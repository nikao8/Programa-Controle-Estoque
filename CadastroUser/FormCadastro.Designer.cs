
namespace ProjetoCadastroUser
{
    partial class FormCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuario));
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.txtboxLogin = new System.Windows.Forms.TextBox();
            this.txtboxCpf = new System.Windows.Forms.TextBox();
            this.txtboxSenha = new System.Windows.Forms.TextBox();
            this.chkboxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(15, 191);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(271, 36);
            this.buttonCadastrar.TabIndex = 5;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 23);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(274, 16);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Cadastro de usuário controle de estoque";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(57, 59);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(44, 16);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(55, 99);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(50, 16);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha:";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpf.Location = new System.Drawing.Point(70, 144);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(31, 16);
            this.labelCpf.TabIndex = 4;
            this.labelCpf.Text = "Cpf:";
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.Location = new System.Drawing.Point(107, 59);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.Size = new System.Drawing.Size(100, 20);
            this.txtboxLogin.TabIndex = 1;
            this.txtboxLogin.TextChanged += new System.EventHandler(this.txtboxLogin_TextChanged);
            // 
            // txtboxCpf
            // 
            this.txtboxCpf.Location = new System.Drawing.Point(107, 144);
            this.txtboxCpf.Name = "txtboxCpf";
            this.txtboxCpf.Size = new System.Drawing.Size(100, 20);
            this.txtboxCpf.TabIndex = 4;
            // 
            // txtboxSenha
            // 
            this.txtboxSenha.Location = new System.Drawing.Point(107, 95);
            this.txtboxSenha.Name = "txtboxSenha";
            this.txtboxSenha.Size = new System.Drawing.Size(100, 20);
            this.txtboxSenha.TabIndex = 2;
            this.txtboxSenha.UseSystemPasswordChar = true;
            // 
            // chkboxMostrarSenha
            // 
            this.chkboxMostrarSenha.AutoSize = true;
            this.chkboxMostrarSenha.Location = new System.Drawing.Point(107, 121);
            this.chkboxMostrarSenha.Name = "chkboxMostrarSenha";
            this.chkboxMostrarSenha.Size = new System.Drawing.Size(99, 17);
            this.chkboxMostrarSenha.TabIndex = 3;
            this.chkboxMostrarSenha.Text = "Mostrar senha?";
            this.chkboxMostrarSenha.UseVisualStyleBackColor = true;
            this.chkboxMostrarSenha.CheckedChanged += new System.EventHandler(this.chkboxMostrarSenha_CheckedChanged);
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(293, 239);
            this.Controls.Add(this.chkboxMostrarSenha);
            this.Controls.Add(this.txtboxSenha);
            this.Controls.Add(this.txtboxCpf);
            this.Controls.Add(this.txtboxLogin);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuario ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.TextBox txtboxLogin;
        private System.Windows.Forms.TextBox txtboxCpf;
        private System.Windows.Forms.TextBox txtboxSenha;
        private System.Windows.Forms.CheckBox chkboxMostrarSenha;
    }
}

