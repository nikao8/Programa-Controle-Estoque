
namespace ProjetoControleEstoque
{
    partial class formControleEstoque
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formControleEstoque));
            this.labeNomeItem = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.Marcar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtbxNomeItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtbxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.txtbxFiltrar = new System.Windows.Forms.TextBox();
            this.chkbxSelectAll = new System.Windows.Forms.CheckBox();
            this.buttonFilterItem = new System.Windows.Forms.Button();
            this.buttonExcluirSelecionados = new System.Windows.Forms.Button();
            this.button_toExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkbxEdit = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelContador = new System.Windows.Forms.Label();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeNomeItem
            // 
            this.labeNomeItem.AutoSize = true;
            this.labeNomeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeNomeItem.Location = new System.Drawing.Point(13, 78);
            this.labeNomeItem.Name = "labeNomeItem";
            this.labeNomeItem.Size = new System.Drawing.Size(76, 16);
            this.labeNomeItem.TabIndex = 1;
            this.labeNomeItem.Text = "Nome Item:";
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marcar});
            this.datagrid.Location = new System.Drawing.Point(6, 23);
            this.datagrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(660, 407);
            this.datagrid.TabIndex = 17;
            this.datagrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellValueChanged);
            // 
            // Marcar
            // 
            this.Marcar.FalseValue = "0";
            this.Marcar.HeaderText = "Marcar";
            this.Marcar.IndeterminateValue = "2";
            this.Marcar.Name = "Marcar";
            this.Marcar.TrueValue = "1";
            this.Marcar.Width = 60;
            // 
            // txtbxNomeItem
            // 
            this.txtbxNomeItem.Location = new System.Drawing.Point(95, 78);
            this.txtbxNomeItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxNomeItem.MaxLength = 45;
            this.txtbxNomeItem.Name = "txtbxNomeItem";
            this.txtbxNomeItem.Size = new System.Drawing.Size(163, 22);
            this.txtbxNomeItem.TabIndex = 2;
            this.txtbxNomeItem.TextChanged += new System.EventHandler(this.txtbxNomeItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantidade do item:";
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Location = new System.Drawing.Point(147, 120);
            this.numericQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericQuantidade.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(58, 22);
            this.numericQuantidade.TabIndex = 3;
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.Location = new System.Drawing.Point(16, 187);
            this.txtbxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxDescription.MaxLength = 100;
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.Size = new System.Drawing.Size(414, 48);
            this.txtbxDescription.TabIndex = 4;
            this.txtbxDescription.Text = "";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(13, 163);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(136, 16);
            this.labelDescricao.TabIndex = 7;
            this.labelDescricao.Text = "Descrição (opcional):";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.Location = new System.Drawing.Point(223, 242);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(207, 55);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "    Adicionar item";
            this.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpar.Image")));
            this.buttonLimpar.Location = new System.Drawing.Point(16, 242);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(201, 55);
            this.buttonLimpar.TabIndex = 5;
            this.buttonLimpar.Text = "     Limpar Campos";
            this.buttonLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(194, 24);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Preencha os campos:";
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrar.Location = new System.Drawing.Point(8, 32);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(87, 16);
            this.labelFiltrar.TabIndex = 13;
            this.labelFiltrar.Text = "Filtrar item(s):";
            // 
            // txtbxFiltrar
            // 
            this.txtbxFiltrar.Location = new System.Drawing.Point(11, 60);
            this.txtbxFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxFiltrar.MaxLength = 45;
            this.txtbxFiltrar.Name = "txtbxFiltrar";
            this.txtbxFiltrar.Size = new System.Drawing.Size(143, 22);
            this.txtbxFiltrar.TabIndex = 8;
            // 
            // chkbxSelectAll
            // 
            this.chkbxSelectAll.AutoSize = true;
            this.chkbxSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxSelectAll.Location = new System.Drawing.Point(537, 438);
            this.chkbxSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbxSelectAll.Name = "chkbxSelectAll";
            this.chkbxSelectAll.Size = new System.Drawing.Size(129, 20);
            this.chkbxSelectAll.TabIndex = 15;
            this.chkbxSelectAll.Text = "Selecionar todos";
            this.chkbxSelectAll.UseVisualStyleBackColor = true;
            this.chkbxSelectAll.CheckedChanged += new System.EventHandler(this.chkbxSelectAll_CheckedChanged);
            // 
            // buttonFilterItem
            // 
            this.buttonFilterItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonFilterItem.Image")));
            this.buttonFilterItem.Location = new System.Drawing.Point(160, 44);
            this.buttonFilterItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFilterItem.Name = "buttonFilterItem";
            this.buttonFilterItem.Size = new System.Drawing.Size(48, 38);
            this.buttonFilterItem.TabIndex = 9;
            this.buttonFilterItem.UseVisualStyleBackColor = true;
            this.buttonFilterItem.Click += new System.EventHandler(this.buttonFilterItem_Click);
            // 
            // buttonExcluirSelecionados
            // 
            this.buttonExcluirSelecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirSelecionados.Location = new System.Drawing.Point(505, 466);
            this.buttonExcluirSelecionados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExcluirSelecionados.Name = "buttonExcluirSelecionados";
            this.buttonExcluirSelecionados.Size = new System.Drawing.Size(161, 27);
            this.buttonExcluirSelecionados.TabIndex = 16;
            this.buttonExcluirSelecionados.Text = "Excluir selecionados";
            this.buttonExcluirSelecionados.UseVisualStyleBackColor = true;
            this.buttonExcluirSelecionados.Click += new System.EventHandler(this.buttonExcluirSelecionados_Click);
            // 
            // button_toExcel
            // 
            this.button_toExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_toExcel.Location = new System.Drawing.Point(11, 22);
            this.button_toExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_toExcel.Name = "button_toExcel";
            this.button_toExcel.Size = new System.Drawing.Size(419, 68);
            this.button_toExcel.TabIndex = 12;
            this.button_toExcel.Text = "Gerar planilha do Excel completa (todos os itens)";
            this.button_toExcel.UseVisualStyleBackColor = true;
            this.button_toExcel.Click += new System.EventHandler(this.button_toExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_toExcel);
            this.groupBox1.Location = new System.Drawing.Point(12, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkbxEdit);
            this.groupBox2.Controls.Add(this.txtbxFiltrar);
            this.groupBox2.Controls.Add(this.labelFiltrar);
            this.groupBox2.Controls.Add(this.buttonFilterItem);
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manipular lista";
            // 
            // chkbxEdit
            // 
            this.chkbxEdit.AutoSize = true;
            this.chkbxEdit.Location = new System.Drawing.Point(217, 44);
            this.chkbxEdit.Name = "chkbxEdit";
            this.chkbxEdit.Size = new System.Drawing.Size(218, 20);
            this.chkbxEdit.TabIndex = 10;
            this.chkbxEdit.Text = "Habilitar edição de itens da lista";
            this.chkbxEdit.UseVisualStyleBackColor = true;
            this.chkbxEdit.CheckedChanged += new System.EventHandler(this.chkbxEdit_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbxNomeItem);
            this.groupBox3.Controls.Add(this.buttonLimpar);
            this.groupBox3.Controls.Add(this.labeNomeItem);
            this.groupBox3.Controls.Add(this.btnAddItem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numericQuantidade);
            this.groupBox3.Controls.Add(this.txtbxDescription);
            this.groupBox3.Controls.Add(this.labelTitle);
            this.groupBox3.Controls.Add(this.labelDescricao);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 310);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inserção de dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantidade de itens:";
            // 
            // labelContador
            // 
            this.labelContador.AutoSize = true;
            this.labelContador.Location = new System.Drawing.Point(134, 439);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(15, 16);
            this.labelContador.TabIndex = 28;
            this.labelContador.Text = "0";
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(382, 466);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(117, 27);
            this.buttonAtualizar.TabIndex = 14;
            this.buttonAtualizar.Text = "Atualizar Lista";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "github.com/nikao8";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.datagrid);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.buttonAtualizar);
            this.groupBox4.Controls.Add(this.labelContador);
            this.groupBox4.Controls.Add(this.chkbxSelectAll);
            this.groupBox4.Controls.Add(this.buttonExcluirSelecionados);
            this.groupBox4.Location = new System.Drawing.Point(459, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(672, 510);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista dos itens cadastratos";
            // 
            // formControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 537);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formControleEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.formControleEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labeNomeItem;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.TextBox txtbxNomeItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericQuantidade;
        private System.Windows.Forms.RichTextBox txtbxDescription;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.TextBox txtbxFiltrar;
        private System.Windows.Forms.CheckBox chkbxSelectAll;
        private System.Windows.Forms.Button buttonFilterItem;
        private System.Windows.Forms.Button buttonExcluirSelecionados;
        private System.Windows.Forms.Button button_toExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkbxEdit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Marcar;
    }
}

