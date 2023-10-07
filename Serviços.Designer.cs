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
            this.txtAgendarDataCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgendamentoCliente = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbServico
            // 
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(39, 109);
            this.cmbServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(241, 24);
            this.cmbServico.TabIndex = 1;
            this.cmbServico.SelectedIndexChanged += new System.EventHandler(this.cmbServico_SelectedIndexChanged);
            // 
            // lblEscolhaServico
            // 
            this.lblEscolhaServico.AutoSize = true;
            this.lblEscolhaServico.BackColor = System.Drawing.Color.White;
            this.lblEscolhaServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaServico.Location = new System.Drawing.Point(67, 85);
            this.lblEscolhaServico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscolhaServico.Name = "lblEscolhaServico";
            this.lblEscolhaServico.Size = new System.Drawing.Size(180, 20);
            this.lblEscolhaServico.TabIndex = 2;
            this.lblEscolhaServico.Text = "Escolha um serviço:";
            // 
            // pictFotoServico
            // 
            this.pictFotoServico.Image = ((System.Drawing.Image)(resources.GetObject("pictFotoServico.Image")));
            this.pictFotoServico.Location = new System.Drawing.Point(331, 50);
            this.pictFotoServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictFotoServico.Name = "pictFotoServico";
            this.pictFotoServico.Size = new System.Drawing.Size(704, 469);
            this.pictFotoServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictFotoServico.TabIndex = 3;
            this.pictFotoServico.TabStop = false;
            // 
            // txtPrecoServico
            // 
            this.txtPrecoServico.Location = new System.Drawing.Point(39, 185);
            this.txtPrecoServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecoServico.Name = "txtPrecoServico";
            this.txtPrecoServico.Size = new System.Drawing.Size(241, 22);
            this.txtPrecoServico.TabIndex = 5;
            // 
            // lblPrecoCorte
            // 
            this.lblPrecoCorte.AutoSize = true;
            this.lblPrecoCorte.BackColor = System.Drawing.Color.White;
            this.lblPrecoCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCorte.Location = new System.Drawing.Point(115, 161);
            this.lblPrecoCorte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoCorte.Name = "lblPrecoCorte";
            this.lblPrecoCorte.Size = new System.Drawing.Size(64, 20);
            this.lblPrecoCorte.TabIndex = 6;
            this.lblPrecoCorte.Text = "Preço:";
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
            this.lblTelefoneCliente.Location = new System.Drawing.Point(58, 234);
            this.lblTelefoneCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(200, 20);
            this.lblTelefoneCliente.TabIndex = 10;
            this.lblTelefoneCliente.Text = "Data do Agendamento:";
            // 
            // txtAgendarHorarioCliente
            // 
            this.txtAgendarHorarioCliente.Location = new System.Drawing.Point(39, 362);
            this.txtAgendarHorarioCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAgendarHorarioCliente.Name = "txtAgendarHorarioCliente";
            this.txtAgendarHorarioCliente.Size = new System.Drawing.Size(241, 22);
            this.txtAgendarHorarioCliente.TabIndex = 11;
            this.txtAgendarHorarioCliente.TextChanged += new System.EventHandler(this.txtAgendarHorarioCliente_TextChanged);
            // 
            // txtAgendarDataCliente
            // 
            this.txtAgendarDataCliente.Location = new System.Drawing.Point(39, 267);
            this.txtAgendarDataCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAgendarDataCliente.Name = "txtAgendarDataCliente";
            this.txtAgendarDataCliente.Size = new System.Drawing.Size(241, 22);
            this.txtAgendarDataCliente.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Horário do Agendamento:";
            // 
            // btnAgendamentoCliente
            // 
            this.btnAgendamentoCliente.BackColor = System.Drawing.Color.White;
            this.btnAgendamentoCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamentoCliente.Location = new System.Drawing.Point(84, 416);
            this.btnAgendamentoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgendamentoCliente.Name = "btnAgendamentoCliente";
            this.btnAgendamentoCliente.Size = new System.Drawing.Size(145, 65);
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
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 28);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAgendamentoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAgendarDataCliente);
            this.Controls.Add(this.txtAgendarHorarioCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.lblPrecoCorte);
            this.Controls.Add(this.txtPrecoServico);
            this.Controls.Add(this.pictFotoServico);
            this.Controls.Add(this.lblEscolhaServico);
            this.Controls.Add(this.cmbServico);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtAgendarDataCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgendamentoCliente;
        private System.Windows.Forms.Button btnVoltar;
    }
}