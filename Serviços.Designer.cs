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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.txtAgendarHorarioCliente = new System.Windows.Forms.TextBox();
            this.txtAgendarDataCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgendamentoCliente = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbServico
            // 
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(29, 302);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(182, 21);
            this.cmbServico.TabIndex = 1;
            this.cmbServico.SelectedIndexChanged += new System.EventHandler(this.cmbServico_SelectedIndexChanged);
            // 
            // lblEscolhaServico
            // 
            this.lblEscolhaServico.AutoSize = true;
            this.lblEscolhaServico.BackColor = System.Drawing.Color.White;
            this.lblEscolhaServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaServico.Location = new System.Drawing.Point(46, 283);
            this.lblEscolhaServico.Name = "lblEscolhaServico";
            this.lblEscolhaServico.Size = new System.Drawing.Size(146, 16);
            this.lblEscolhaServico.TabIndex = 2;
            this.lblEscolhaServico.Text = "Escolha um serviço:";
            // 
            // pictFotoServico
            // 
            this.pictFotoServico.Image = ((System.Drawing.Image)(resources.GetObject("pictFotoServico.Image")));
            this.pictFotoServico.Location = new System.Drawing.Point(248, 41);
            this.pictFotoServico.Name = "pictFotoServico";
            this.pictFotoServico.Size = new System.Drawing.Size(528, 381);
            this.pictFotoServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictFotoServico.TabIndex = 3;
            this.pictFotoServico.TabStop = false;
            // 
            // txtPrecoServico
            // 
            this.txtPrecoServico.Location = new System.Drawing.Point(29, 359);
            this.txtPrecoServico.Name = "txtPrecoServico";
            this.txtPrecoServico.Size = new System.Drawing.Size(182, 20);
            this.txtPrecoServico.TabIndex = 5;
            // 
            // lblPrecoCorte
            // 
            this.lblPrecoCorte.AutoSize = true;
            this.lblPrecoCorte.BackColor = System.Drawing.Color.White;
            this.lblPrecoCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCorte.Location = new System.Drawing.Point(91, 340);
            this.lblPrecoCorte.Name = "lblPrecoCorte";
            this.lblPrecoCorte.Size = new System.Drawing.Size(52, 16);
            this.lblPrecoCorte.TabIndex = 6;
            this.lblPrecoCorte.Text = "Preço:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(29, 83);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(182, 20);
            this.txtNomeCliente.TabIndex = 8;
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(29, 135);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(182, 20);
            this.txtTelefoneCliente.TabIndex = 9;
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.BackColor = System.Drawing.Color.White;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.Location = new System.Drawing.Point(35, 169);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(166, 16);
            this.lblTelefoneCliente.TabIndex = 10;
            this.lblTelefoneCliente.Text = "Data do Agendamento:";
            // 
            // txtAgendarHorarioCliente
            // 
            this.txtAgendarHorarioCliente.Location = new System.Drawing.Point(29, 243);
            this.txtAgendarHorarioCliente.Name = "txtAgendarHorarioCliente";
            this.txtAgendarHorarioCliente.Size = new System.Drawing.Size(182, 20);
            this.txtAgendarHorarioCliente.TabIndex = 11;
            // 
            // txtAgendarDataCliente
            // 
            this.txtAgendarDataCliente.Location = new System.Drawing.Point(29, 188);
            this.txtAgendarDataCliente.Name = "txtAgendarDataCliente";
            this.txtAgendarDataCliente.Size = new System.Drawing.Size(182, 20);
            this.txtAgendarDataCliente.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Horário do Agendamento:";
            // 
            // btnAgendamentoCliente
            // 
            this.btnAgendamentoCliente.Location = new System.Drawing.Point(61, 385);
            this.btnAgendamentoCliente.Name = "btnAgendamentoCliente";
            this.btnAgendamentoCliente.Size = new System.Drawing.Size(109, 37);
            this.btnAgendamentoCliente.TabIndex = 14;
            this.btnAgendamentoCliente.Text = "Agendar";
            this.btnAgendamentoCliente.UseVisualStyleBackColor = true;
            this.btnAgendamentoCliente.Click += new System.EventHandler(this.btnAgendamentoCliente_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAgendamentoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAgendarDataCliente);
            this.Controls.Add(this.txtAgendarHorarioCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.txtTelefoneCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.TextBox txtAgendarHorarioCliente;
        private System.Windows.Forms.TextBox txtAgendarDataCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgendamentoCliente;
        private System.Windows.Forms.Button btnVoltar;
    }
}