namespace BarbeariaPatrick
{
    partial class Serviços
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serviços));
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.lblEscolhaServico = new System.Windows.Forms.Label();
            this.pictFotoServico = new System.Windows.Forms.PictureBox();
            this.txtPrecoServico = new System.Windows.Forms.TextBox();
            this.lblPrecoCorte = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.txtAgendarHorarioCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgendamentoCliente = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtIDdoServico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.txtConsultarIDcliente = new System.Windows.Forms.TextBox();
            this.btnConsultarID = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbServico
            // 
            this.cmbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(26, 276);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(182, 24);
            this.cmbServico.TabIndex = 1;
            this.cmbServico.SelectedIndexChanged += new System.EventHandler(this.cmbServico_SelectedIndexChanged);
            // 
            // lblEscolhaServico
            // 
            this.lblEscolhaServico.AutoSize = true;
            this.lblEscolhaServico.BackColor = System.Drawing.Color.White;
            this.lblEscolhaServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaServico.ForeColor = System.Drawing.Color.Tan;
            this.lblEscolhaServico.Location = new System.Drawing.Point(12, 257);
            this.lblEscolhaServico.Name = "lblEscolhaServico";
            this.lblEscolhaServico.Size = new System.Drawing.Size(205, 16);
            this.lblEscolhaServico.TabIndex = 2;
            this.lblEscolhaServico.Text = "Escolha o serviço desejado:";
            this.lblEscolhaServico.Click += new System.EventHandler(this.lblEscolhaServico_Click);
            // 
            // pictFotoServico
            // 
            this.pictFotoServico.Image = ((System.Drawing.Image)(resources.GetObject("pictFotoServico.Image")));
            this.pictFotoServico.Location = new System.Drawing.Point(231, 12);
            this.pictFotoServico.Name = "pictFotoServico";
            this.pictFotoServico.Size = new System.Drawing.Size(316, 408);
            this.pictFotoServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictFotoServico.TabIndex = 3;
            this.pictFotoServico.TabStop = false;
            this.pictFotoServico.Click += new System.EventHandler(this.pictFotoServico_Click_1);
            // 
            // txtPrecoServico
            // 
            this.txtPrecoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoServico.Location = new System.Drawing.Point(26, 330);
            this.txtPrecoServico.Name = "txtPrecoServico";
            this.txtPrecoServico.Size = new System.Drawing.Size(182, 22);
            this.txtPrecoServico.TabIndex = 5;
            this.txtPrecoServico.TextChanged += new System.EventHandler(this.txtPrecoServico_TextChanged);
            // 
            // lblPrecoCorte
            // 
            this.lblPrecoCorte.AutoSize = true;
            this.lblPrecoCorte.BackColor = System.Drawing.Color.White;
            this.lblPrecoCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCorte.ForeColor = System.Drawing.Color.Tan;
            this.lblPrecoCorte.Location = new System.Drawing.Point(86, 311);
            this.lblPrecoCorte.Name = "lblPrecoCorte";
            this.lblPrecoCorte.Size = new System.Drawing.Size(52, 16);
            this.lblPrecoCorte.TabIndex = 6;
            this.lblPrecoCorte.Text = "Preço:";
            this.lblPrecoCorte.Click += new System.EventHandler(this.lblPrecoCorte_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.BackColor = System.Drawing.Color.White;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.Location = new System.Drawing.Point(586, 143);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(166, 16);
            this.lblTelefoneCliente.TabIndex = 10;
            this.lblTelefoneCliente.Text = "Data do Agendamento:";
            this.lblTelefoneCliente.Click += new System.EventHandler(this.lblTelefoneCliente_Click);
            // 
            // txtAgendarHorarioCliente
            // 
            this.txtAgendarHorarioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgendarHorarioCliente.Location = new System.Drawing.Point(630, 225);
            this.txtAgendarHorarioCliente.Name = "txtAgendarHorarioCliente";
            this.txtAgendarHorarioCliente.Size = new System.Drawing.Size(77, 22);
            this.txtAgendarHorarioCliente.TabIndex = 11;
            this.txtAgendarHorarioCliente.TextChanged += new System.EventHandler(this.txtAgendarHorarioCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Horário do Agendamento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAgendamentoCliente
            // 
            this.btnAgendamentoCliente.BackColor = System.Drawing.Color.White;
            this.btnAgendamentoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendamentoCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamentoCliente.Location = new System.Drawing.Point(605, 315);
            this.btnAgendamentoCliente.Name = "btnAgendamentoCliente";
            this.btnAgendamentoCliente.Size = new System.Drawing.Size(121, 53);
            this.btnAgendamentoCliente.TabIndex = 14;
            this.btnAgendamentoCliente.Text = "Agendar";
            this.btnAgendamentoCliente.UseVisualStyleBackColor = false;
            this.btnAgendamentoCliente.Click += new System.EventHandler(this.btnAgendamentoCliente_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtIDdoServico
            // 
            this.txtIDdoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDdoServico.Location = new System.Drawing.Point(650, 286);
            this.txtIDdoServico.Name = "txtIDdoServico";
            this.txtIDdoServico.Size = new System.Drawing.Size(28, 22);
            this.txtIDdoServico.TabIndex = 19;
            this.txtIDdoServico.TextChanged += new System.EventHandler(this.txtIDdoServico_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID do serviço:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDcliente.Location = new System.Drawing.Point(650, 102);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.Size = new System.Drawing.Size(28, 22);
            this.txtIDcliente.TabIndex = 21;
            this.txtIDcliente.TextChanged += new System.EventHandler(this.txtIDcliente_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(636, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "SEU ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.BackColor = System.Drawing.Color.White;
            this.lblidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidcliente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblidcliente.Location = new System.Drawing.Point(12, 92);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(144, 20);
            this.lblidcliente.TabIndex = 23;
            this.lblidcliente.Text = "Digite seu nome:";
            this.lblidcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConsultarIDcliente
            // 
            this.txtConsultarIDcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarIDcliente.Location = new System.Drawing.Point(15, 115);
            this.txtConsultarIDcliente.Name = "txtConsultarIDcliente";
            this.txtConsultarIDcliente.Size = new System.Drawing.Size(165, 22);
            this.txtConsultarIDcliente.TabIndex = 22;
            // 
            // btnConsultarID
            // 
            this.btnConsultarID.BackColor = System.Drawing.Color.White;
            this.btnConsultarID.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultarID.Location = new System.Drawing.Point(50, 143);
            this.btnConsultarID.Name = "btnConsultarID";
            this.btnConsultarID.Size = new System.Drawing.Size(88, 22);
            this.btnConsultarID.TabIndex = 24;
            this.btnConsultarID.Text = "Consultar";
            this.btnConsultarID.UseVisualStyleBackColor = false;
            this.btnConsultarID.Click += new System.EventHandler(this.btnConsultarID_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Uighur", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCliente.Location = new System.Drawing.Point(553, 35);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(253, 48);
            this.lblCliente.TabIndex = 25;
            this.lblCliente.Text = "AGENDAMENTO";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(7, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 38);
            this.label7.TabIndex = 27;
            this.label7.Text = "Conferir os IDS:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(561, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 22);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "Serviços:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnConsultarID);
            this.Controls.Add(this.lblidcliente);
            this.Controls.Add(this.txtConsultarIDcliente);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDdoServico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAgendamentoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAgendarHorarioCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.lblPrecoCorte);
            this.Controls.Add(this.txtPrecoServico);
            this.Controls.Add(this.pictFotoServico);
            this.Controls.Add(this.lblEscolhaServico);
            this.Controls.Add(this.cmbServico);
            this.Name = "Serviços";
            this.Text = "Serviços";
            this.Load += new System.EventHandler(this.Serviços_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.Label lblEscolhaServico;
        private System.Windows.Forms.PictureBox pictFotoServico;
        private System.Windows.Forms.TextBox txtPrecoServico;
        private System.Windows.Forms.Label lblPrecoCorte;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.TextBox txtAgendarHorarioCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgendamentoCliente;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtIDdoServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.TextBox txtConsultarIDcliente;
        private System.Windows.Forms.Button btnConsultarID;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}