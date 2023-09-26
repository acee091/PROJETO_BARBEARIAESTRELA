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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.lblEscolhaServico = new System.Windows.Forms.Label();
            this.pictFotoServico = new System.Windows.Forms.PictureBox();
            this.txtPrecoServico = new System.Windows.Forms.TextBox();
            this.lblPrecoCorte = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.agendarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Agendamentos";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // agendarToolStripMenuItem
            // 
            this.agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            this.agendarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.agendarToolStripMenuItem.Text = "Agendar";
            // 
            // cmbServico
            // 
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(29, 71);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(182, 21);
            this.cmbServico.TabIndex = 1;
            this.cmbServico.SelectedIndexChanged += new System.EventHandler(this.cmbServico_SelectedIndexChanged);
            // 
            // lblEscolhaServico
            // 
            this.lblEscolhaServico.AutoSize = true;
            this.lblEscolhaServico.Location = new System.Drawing.Point(26, 55);
            this.lblEscolhaServico.Name = "lblEscolhaServico";
            this.lblEscolhaServico.Size = new System.Drawing.Size(102, 13);
            this.lblEscolhaServico.TabIndex = 2;
            this.lblEscolhaServico.Text = "Escolha um serviço:";
            // 
            // pictFotoServico
            // 
            this.pictFotoServico.Location = new System.Drawing.Point(248, 41);
            this.pictFotoServico.Name = "pictFotoServico";
            this.pictFotoServico.Size = new System.Drawing.Size(528, 381);
            this.pictFotoServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictFotoServico.TabIndex = 3;
            this.pictFotoServico.TabStop = false;
            // 
            // txtPrecoServico
            // 
            this.txtPrecoServico.Location = new System.Drawing.Point(29, 150);
            this.txtPrecoServico.Name = "txtPrecoServico";
            this.txtPrecoServico.Size = new System.Drawing.Size(182, 20);
            this.txtPrecoServico.TabIndex = 5;
            // 
            // lblPrecoCorte
            // 
            this.lblPrecoCorte.AutoSize = true;
            this.lblPrecoCorte.Location = new System.Drawing.Point(26, 134);
            this.lblPrecoCorte.Name = "lblPrecoCorte";
            this.lblPrecoCorte.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoCorte.TabIndex = 6;
            this.lblPrecoCorte.Text = "Preço:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrecoCorte);
            this.Controls.Add(this.txtPrecoServico);
            this.Controls.Add(this.pictFotoServico);
            this.Controls.Add(this.lblEscolhaServico);
            this.Controls.Add(this.cmbServico);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Serviços";
            this.Text = "Serviços";
            this.Load += new System.EventHandler(this.Serviços_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictFotoServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.Label lblEscolhaServico;
        private System.Windows.Forms.PictureBox pictFotoServico;
        private System.Windows.Forms.TextBox txtPrecoServico;
        private System.Windows.Forms.Label lblPrecoCorte;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}