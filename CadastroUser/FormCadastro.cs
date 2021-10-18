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

namespace ProjetoCadastroUser
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=123321; Database=controle_estoque");
        }

        private void InsertUser()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                string query = @"insert into public.users(login,senha,cpf)values(@user, md5(@password),@cpf)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);

                cmd.Parameters.Add(new NpgsqlParameter("@user", DbType.String) { Value = txtboxLogin.Text });
                cmd.Parameters.Add(new NpgsqlParameter("@password", DbType.String) { Value = txtboxSenha.Text });
                cmd.Parameters.Add(new NpgsqlParameter("@cpf", DbType.String) { Value = txtboxCpf.Text });
                cmd.ExecuteNonQuery();

                txtboxLogin.Text = "";
                txtboxCpf.Text = "";
                txtboxSenha.Text = "";
                chkboxMostrarSenha.Checked = false;
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                txtboxCpf.Text = txtboxCpf.Text.Replace(" ", "");

                if (txtboxLogin.Text == "")
                {
                    MessageBox.Show("Campo de login vazio, preencha-o e tente novamente.", "Login vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtboxLogin.Text.Length > 45)
                {
                    MessageBox.Show("Campo de login maior que 45 caracteres, preencha-o com um tamanho menor e tente novamente.", "Campo login excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtboxSenha.Text == "")
                {
                    MessageBox.Show("Campo de senha vazio, preencha-o e tente novamente.", "Senha vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtboxSenha.Text.Length > 45)
                {
                    MessageBox.Show("Campo de senha maior que 45 caracteres, preencha-o com um tamanho menor e tente novamente.", "Campo senha excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtboxCpf.Text == "")
                {
                    MessageBox.Show("Campo de cpf vazio, preencha-o e tente novamente.", "Cpf vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtboxCpf.Text.Length > 11 || txtboxCpf.Text.Length < 11)
                {
                    MessageBox.Show("Campo de cpf maior ou menor que 11 dígitos, preencha-o sem caracteres especiais e tente novamente.", "Cpf inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!long.TryParse(txtboxCpf.Text, out _))
                {
                    MessageBox.Show("Campo de cpf com dígitos inválidos, preencha-o sem caracteres especiais e tente novamente.", "Cpf inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    InsertUser();
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString() == "-2147467259")
                {
                    MessageBox.Show("Usuário já cadastrado no banco", "Usuário já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkboxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtboxSenha.UseSystemPasswordChar = !chkboxMostrarSenha.Checked;
        }

        private void txtboxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
