using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProjetoLoginControleEstoque
{
    public partial class FormLoginControleEstoque : Form
    {
        public FormLoginControleEstoque()
        {
            InitializeComponent();
        }

        // Conexão com o banco de dados local:
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=123321; Database=controle_estoque");
        }

        NpgsqlDataReader dr; // Armazena o resultado do select

        private bool ValidateUser()
        {
            using (NpgsqlConnection con = GetConnection())
            {

                con.Open();
                string query = @"select login,senha from users where login = @user and senha = md5(@password) ";
                
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.Add(new NpgsqlParameter("@user", DbType.String) { Value = txtboxLogin.Text });
                cmd.Parameters.Add(new NpgsqlParameter("@password", DbType.String) { Value = txtboxSenha.Text });

                dr = cmd.ExecuteReader(); // ExecuteReader pois precisa do retorno da query por ser um select

                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (ValidateUser()) // Chamo a função que valida o user e retorna um bool
            {
                MessageBox.Show("Sucesso!, entrando com o usuário '" + txtboxLogin.Text + "'\nClique em OK para iniciar o programa de controle de estoque.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado ou campos preenchidos incorretamente", "Usuario não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DialogResult = DialogResult.Abort;
            }
            
            Close();
        }
        private void chkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtboxSenha.UseSystemPasswordChar = !chkboxShowPass.Checked;
        }
    }
}
