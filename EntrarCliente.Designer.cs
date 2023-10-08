namespace BarbeariaPatrick
{
    partial class EntrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntrarCliente));
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtLogonSenha = new System.Windows.Forms.TextBox();
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.btnVoltarADM = new System.Windows.Forms.Button();
            this.pictFotoServico = new System.Windows.Forms.PictureBox();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.BackColor = System.Drawing.Color.Black;
            this.lblSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaLogin.ForeColor = System.Drawing.Color.White;
            this.lblSenhaLogin.Location = new System.Drawing.Point(435, 233);
            this.lblSenhaLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(67, 20);
            this.lblSenhaLogin.TabIndex = 9;
            this.lblSenhaLogin.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Black;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(435, 135);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(61, 20);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Black;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(439, 159);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(192, 34);
            this.txtLogin.TabIndex = 7;
            // 
            // txtLogonSenha
            // 
            this.txtLogonSenha.BackColor = System.Drawing.Color.Black;
            this.txtLogonSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogonSenha.ForeColor = System.Drawing.Color.White;
            this.txtLogonSenha.Location = new System.Drawing.Point(439, 256);
            this.txtLogonSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogonSenha.Name = "txtLogonSenha";
            this.txtLogonSenha.PasswordChar = '*';
            this.txtLogonSenha.Size = new System.Drawing.Size(192, 34);
            this.txtLogonSenha.TabIndex = 6;
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnEntrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarLogin.ForeColor = System.Drawing.Color.White;
            this.btnEntrarLogin.Location = new System.Drawing.Point(439, 337);
            this.btnEntrarLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(193, 82);
            this.btnEntrarLogin.TabIndex = 5;
            this.btnEntrarLogin.Text = "Entrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = false;
            this.btnEntrarLogin.Click += new System.EventHandler(this.btnEntrarLogin_Click);
            // 
            // btnVoltarADM
            // 
            this.btnVoltarADM.BackColor = System.Drawing.Color.White;
            this.btnVoltarADM.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarADM.Location = new System.Drawing.Point(16, 15);
            this.btnVoltarADM.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltarADM.Name = "btnVoltarADM";
            this.btnVoltarADM.Size = new System.Drawing.Size(100, 28);
            this.btnVoltarADM.TabIndex = 17;
            this.btnVoltarADM.Text = "Voltar";
            this.btnVoltarADM.UseVisualStyleBackColor = false;
            this.btnVoltarADM.Click += new System.EventHandler(this.btnVoltarADM_Click);
            // 
            // pictFotoServico
            // 
            this.pictFotoServico.Image = ((System.Drawing.Image)(resources.GetObject("pictFotoServico.Image")));
            this.pictFotoServico.Location = new System.Drawing.Point(44, 135);
            this.pictFotoServico.Margin = new System.Windows.Forms.Padding(4);
            this.pictFotoServico.Name = "pictFotoServico";
            this.pictFotoServico.Size = new System.Drawing.Size(319, 321);
            this.pictFotoServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictFotoServico.TabIndex = 18;
            this.pictFotoServico.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Uighur", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCliente.Location = new System.Drawing.Point(360, 51);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(376, 52);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "ENTRE NA SUA CONTA:";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.pictFotoServico);
            this.Controls.Add(this.btnVoltarADM);
            this.Controls.Add(this.lblSenhaLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtLogonSenha);
            this.Controls.Add(this.btnEntrarLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EntrarCliente";
            this.Text = "EntrarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtLogonSenha;
        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Button btnVoltarADM;
        private System.Windows.Forms.PictureBox pictFotoServico;
        private System.Windows.Forms.Label lblCliente;
    }
}