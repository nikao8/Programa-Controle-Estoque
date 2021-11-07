using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace ProjetoControleEstoqueCelula
{
    public partial class formControleEstoque : Form
    {
        public formControleEstoque()
        {
            InitializeComponent();
        }

        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=123321; Database=controle_estoque");
        }

        private bool error = false;
        private bool isEqual = false;

        private void InsertItem()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                error = false;
                string query = @"insert into itens (nome, quantidade, descricao)
                values (
                @nome,@quantidade,@descricao
                );";
                                
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);

                cmd.Parameters.Add(new NpgsqlParameter("@nome", DbType.String) { Value = txtbxNomeItem.Text });
                cmd.Parameters.Add(new NpgsqlParameter("@quantidade", DbType.Int32) { Value = numericQuantidade.Value });
                cmd.Parameters.Add(new NpgsqlParameter("@descricao", DbType.String) { Value = txtbxDescription.Text });
                                
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();                                                                               
                }
                catch(SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    error = true;
                    MessageBox.Show(errorMessages.ToString());
                }
                catch(Exception ex)
                {
                    error = true;
                    
                    if(ex.HResult.ToString() == "-2147467259")
                    {
                        isEqual = true;
                        error = false;
                        //MessageBox.Show("Erro item já existente:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // Showbox alterada para o evento add_item
                    }
                    else
                    {
                        MessageBox.Show("Erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }  
            }
            UpdateCount();
            UpdateView();
        }

        private void UpdateCount()
        {
            using (NpgsqlConnection con = GetConnection())
            {                            
                string queryCountRows = @"select count(item_id) from itens;";
                NpgsqlCommand cmdCountRows = new NpgsqlCommand(queryCountRows, con);
                
                NpgsqlDataReader dr;

                try
                {
                    con.Open();
                    dr = cmdCountRows.ExecuteReader(); // ExecuteReader pois precisa do retorno da query por ser um select
                    dr.Read();
                    labelContador.Text = dr[0].ToString();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    
                    MessageBox.Show(errorMessages.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
            }
        }

        private void UpdateView()
        {
            DataTable dtItens = new DataTable();

            using (NpgsqlConnection con = GetConnection())
            {
                try
                {
                    con.Open();
                    string querySelect = @"select item_id,nome,quantidade,descricao from itens;";

                    NpgsqlCommand cmdSelect = new NpgsqlCommand(querySelect, con);
                    NpgsqlDataReader dr = cmdSelect.ExecuteReader();

                    dtItens.Load(dr);

                    datagrid.DataSource = dtItens;
                    dtItens.Columns["item_id"].ColumnName = "Id";
                    dtItens.Columns["nome"].ColumnName = "Nome Item";
                    dtItens.Columns["quantidade"].ColumnName = "Qtd";
                    dtItens.Columns["descricao"].ColumnName = "Descrição";
                    
                    datagrid.Columns[4].Width = 297; // descrição
                    datagrid.Columns[3].Width = 50; // qtd
                    datagrid.Columns[2].Width = 150; // nome
                    datagrid.Columns[1].Width = 60; // id

                    con.Close();
                }
                catch(SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }

                    MessageBox.Show(errorMessages.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }             
        }

        private void FilterItem()
        {
            DataTable dtItens = new DataTable();
            using (NpgsqlConnection con = GetConnection())
            {
                string queryFilter = @"select item_id,nome,quantidade,descricao from itens where upper(nome) like upper(@filtro_item)";
                                
                NpgsqlCommand cmdFilter = new NpgsqlCommand(queryFilter, con);
                cmdFilter.Parameters.Add(new NpgsqlParameter("@filtro_item", DbType.String) { Value = '%' + txtbxFiltrar.Text + '%'});
                NpgsqlDataReader dr; 
                
                try
                {
                    con.Open();
                    dr = cmdFilter.ExecuteReader();
                    if (!dr.HasRows)
                    {
                        UpdateView();
                        UpdateCount();

                        DialogResult resultNotFound = MessageBox.Show("Nenhum item com este nome foi econtrado, tente novamente", "Nenhum item encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                        if(resultNotFound == DialogResult.OK)
                        {
                            return;
                        }
                    }

                    dtItens.Load(dr);
                    
                    datagrid.DataSource = dtItens;
                    dtItens.Columns["item_id"].ColumnName = "Id";
                    dtItens.Columns["nome"].ColumnName = "Nome Item";
                    dtItens.Columns["quantidade"].ColumnName = "Qtd";
                    dtItens.Columns["descricao"].ColumnName = "Descrição";

                    datagrid.Columns[4].Width = 297; // descrição
                    datagrid.Columns[3].Width = 50; // qtd
                    datagrid.Columns[2].Width = 150; // nome
                    datagrid.Columns[1].Width = 60; // id

                    con.Close();

                    labelContador.Text = datagrid.RowCount.ToString();
                }
                catch (SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }

                    MessageBox.Show(errorMessages.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                                           
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtbxNomeItem.Text = "";
            txtbxFiltrar.Text = "";
            chkbxSelectAll.Checked = false;
            txtbxDescription.Text = "";
            numericQuantidade.Value = 0;
        }

        private void formControleEstoque_Load(object sender, EventArgs e)
        {
            UpdateCount();
            UpdateView();
            chkbxEdit.Checked = true;
            datagrid.Columns[1].ReadOnly = true;

            for (int i = 0; i < datagrid.RowCount; i++)
            {
                datagrid[Marcar.Index, i].Value = 0;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtbxNomeItem.Text == "")
            {
                DialogResult resultNomeVazio = MessageBox.Show("Voce deseja inserir um item com nome vazio ?", "Nome vazio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultNomeVazio == DialogResult.Yes)
                {
                    if (!error)
                    {
                        InsertItem();                     
                    }
                    if (isEqual)
                    {
                        MessageBox.Show("Item já existente, cadastre com outro nome.", "Item existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        isEqual = false;
                    }
                    buttonLimpar_Click(sender, e);
                }
                else
                {
                    buttonLimpar_Click(sender, e);
                }
            }
            else
            {
                if (!error)
                {
                    InsertItem();
                }
                if (isEqual)
                {
                    MessageBox.Show("Item já existente, cadastre com outro nome.", "Item existente", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    isEqual = false;
                }
                buttonLimpar_Click(sender, e);
            }
        }

        private void chkbxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxSelectAll.Checked)
            {
                for (int i = 0; i < datagrid.RowCount; i++)
                {
                    datagrid[Marcar.Index, i].Value = 1;
                }
            }
            else
            {
                for (int i = 0; i < datagrid.RowCount; i++)
                {
                    datagrid[Marcar.Index, i].Value = 0;
                }
            }
        }
        private void buttonExcluirSelecionados_Click(object sender, EventArgs e) 
        {
            DialogResult resultExcluir = MessageBox.Show("Voce deseja realmente excluir os itens selecionados ?", "Excluir item(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            int contadorItensExcluidos = 0;
            if (resultExcluir == DialogResult.Yes)
            {
                using(NpgsqlConnection con = GetConnection())
                {
                    for (int i = 0; i < datagrid.RowCount; i++)
                    {
                        if (datagrid[Marcar.Index, i].Value?.ToString() == "1")
                        {
                            string queryDelete = @"delete from itens where item_id = " + datagrid[1, i].Value + "";
                            NpgsqlCommand cmdDelete = new NpgsqlCommand(queryDelete, con);

                            try
                            {
                                con.Open();
                                cmdDelete.ExecuteNonQuery();
                                con.Close();
                                contadorItensExcluidos++;                                
                            }
                            catch (SqlException ex)
                            {
                                StringBuilder errorMessages = new StringBuilder();
                                for (int i1 = 0; i1 < ex.Errors.Count; i1++)
                                {
                                    errorMessages.Append("Index #" + i1 + "\n" +
                                        "Message: " + ex.Errors[i1].Message + "\n" +
                                        "LineNumber: " + ex.Errors[i1].LineNumber + "\n" +
                                        "Source: " + ex.Errors[i1].Source + "\n" +
                                        "Procedure: " + ex.Errors[i1].Procedure + "\n");
                                }

                                MessageBox.Show(errorMessages.ToString());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }                            
                        }
                        else
                        {
                            continue;
                        }
                    }                
                }
                UpdateView();
                UpdateCount();
                MessageBox.Show(contadorItensExcluidos + " item(s) excluídos com sucesso", "Sucesso");
            }
            else
            {
                return;
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            UpdateCount();
            UpdateView();
            datagrid.Columns[1].ReadOnly = true;
        }

        private void buttonFilterItem_Click(object sender, EventArgs e)
        {
            if (txtbxFiltrar.Text == "")
            {
                MessageBox.Show("Campo de busca vazio, preencha-o e tente novamente!.", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UpdateView();
                UpdateCount();
                return;
            }            
            FilterItem();
        }

        private void chkbxEdit_CheckedChanged(object sender, EventArgs e)
        {
            datagrid.Columns[2].ReadOnly = !chkbxEdit.Checked;
            datagrid.Columns[3].ReadOnly = !chkbxEdit.Checked;
            datagrid.Columns[4].ReadOnly = !chkbxEdit.Checked;
        }

        private void datagrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            AlterCell(sender, e);
        }

        private void AlterCell(object sender, DataGridViewCellEventArgs e)
        {
            using (NpgsqlConnection con = GetConnection())
            {
                try
                {
                    if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
                    {
                        return;
                    }

                    con.Open();
                    string queryAlter = @"update itens set nome = @nome, quantidade = @quantidade, descricao = @descricao where item_id = @id;";
                    NpgsqlCommand cmdAlter = new NpgsqlCommand(queryAlter, con);

                    cmdAlter.Parameters.Add(new NpgsqlParameter("@nome", DbType.String) { Value = datagrid[2, e.RowIndex].Value });
                    cmdAlter.Parameters.Add(new NpgsqlParameter("@quantidade", DbType.Int32) { Value = datagrid[3, e.RowIndex].Value });
                    cmdAlter.Parameters.Add(new NpgsqlParameter("@descricao", DbType.String) { Value = datagrid[4, e.RowIndex].Value });
                    cmdAlter.Parameters.Add(new NpgsqlParameter("@id", DbType.Int32) { Value = datagrid[1, e.RowIndex].Value });
                    cmdAlter.ExecuteNonQuery();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }

                    MessageBox.Show(errorMessages.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_toExcel_Click(object sender, EventArgs e)
        {
            if(datagrid.RowCount == 0)
            {
                MessageBox.Show("Não é possível exportar um estoque que não possui nenhum item cadastrado!.", "Erro ao exportar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            
            app.Visible = true;
            worksheet = workbook.Sheets["Planilha1"];
            worksheet = workbook.ActiveSheet;
            
            for (int i = 2; i < datagrid.Columns.Count + 1; i++)
            {
                Excel.Range formatRange;
                formatRange = worksheet.get_Range("a1");
                worksheet.Cells[1, i] = datagrid.Columns[i - 1].HeaderText;
                formatRange.EntireRow.Font.Bold = true;
                formatRange.Font.Size = 16;
                formatRange.EntireColumn.ColumnWidth = 0;
                
                worksheet.Cells[2,i] = worksheet.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                formatRange = worksheet.get_Range("b1");
                formatRange.BorderAround2(Excel.XlLineStyle.xlContinuous,
                Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic,
                Excel.XlColorIndex.xlColorIndexAutomatic);
                formatRange.EntireColumn.ColumnWidth = 10;

                formatRange = worksheet.get_Range("c1");
                formatRange.BorderAround2(Excel.XlLineStyle.xlContinuous,
                Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic,
                Excel.XlColorIndex.xlColorIndexAutomatic);
                formatRange.EntireColumn.ColumnWidth = 27;

                formatRange = worksheet.get_Range("d1");
                formatRange.BorderAround2(Excel.XlLineStyle.xlContinuous,
                Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic,
                Excel.XlColorIndex.xlColorIndexAutomatic);
                formatRange.EntireColumn.ColumnWidth = 10;

                formatRange = worksheet.get_Range("e1");
                formatRange.BorderAround2(Excel.XlLineStyle.xlContinuous,
                Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic,
                Excel.XlColorIndex.xlColorIndexAutomatic);
                formatRange.EntireColumn.ColumnWidth = 50;
                                
                formatRange = worksheet.get_Range("b1", "e1");
                formatRange.Interior.Color = System.Drawing.
                ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
                
            }
            for (int i = 0; i < datagrid.Rows.Count; i++)
            {
                for (int j = 1; j < datagrid.Columns.Count; j++)
                {
                    if (datagrid.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = datagrid.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void txtbxNomeItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
