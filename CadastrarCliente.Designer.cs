namespace BarbeariaPatrick
{
    partial class CadastrarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarClienteSenha = new System.Windows.Forms.TextBox();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtClienteLogin = new System.Windows.Forms.TextBox();
            this.txtClienteSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(311, 339);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(145, 67);
            this.btnCadastrarCliente.TabIndex = 23;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cadastrar Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Confirmar SENHA:";
            // 
            // txtConfirmarClienteSenha
            // 
            this.txtConfirmarClienteSenha.BackColor = System.Drawing.Color.Black;
            this.txtConfirmarClienteSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarClienteSenha.ForeColor = System.Drawing.Color.White;
            this.txtConfirmarClienteSenha.Location = new System.Drawing.Point(299, 289);
            this.txtConfirmarClienteSenha.Name = "txtConfirmarClienteSenha";
            this.txtConfirmarClienteSenha.PasswordChar = '*';
            this.txtConfirmarClienteSenha.Size = new System.Drawing.Size(178, 29);
            this.txtConfirmarClienteSenha.TabIndex = 20;
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.BackColor = System.Drawing.Color.Black;
            this.lblSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaLogin.ForeColor = System.Drawing.Color.White;
            this.lblSenhaLogin.Location = new System.Drawing.Point(296, 197);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(55, 16);
            this.lblSenhaLogin.TabIndex = 19;
            this.lblSenhaLogin.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Black;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(296, 118);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(49, 16);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "Login:";
            // 
            // txtClienteLogin
            // 
            this.txtClienteLogin.BackColor = System.Drawing.Color.Black;
            this.txtClienteLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteLogin.ForeColor = System.Drawing.Color.White;
            this.txtClienteLogin.Location = new System.Drawing.Point(299, 137);
            this.txtClienteLogin.Name = "txtClienteLogin";
            this.txtClienteLogin.Size = new System.Drawing.Size(178, 29);
            this.txtClienteLogin.TabIndex = 17;
            // 
            // txtClienteSenha
            // 
            this.txtClienteSenha.BackColor = System.Drawing.Color.Black;
            this.txtClienteSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteSenha.ForeColor = System.Drawing.Color.White;
            this.txtClienteSenha.Location = new System.Drawing.Point(299, 216);
            this.txtClienteSenha.Name = "txtClienteSenha";
            this.txtClienteSenha.PasswordChar = '*';
            this.txtClienteSenha.Size = new System.Drawing.Size(178, 29);
            this.txtClienteSenha.TabIndex = 16;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmarClienteSenha);
            this.Controls.Add(this.lblSenhaLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtClienteLogin);
            this.Controls.Add(this.txtClienteSenha);
            this.Name = "CadastrarCliente";
            this.Text = "CadastrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmarClienteSenha;
        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtClienteLogin;
        private System.Windows.Forms.TextBox txtClienteSenha;
    }
}