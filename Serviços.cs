﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BarbeariaPatrick
{
    public partial class Serviços : Form
    {
        public Serviços()
        {
            InitializeComponent();
        }

        public string consulta;
        public string sql;

        string[] Servicos = new string[9] { "Corte Estrela", "Corte Degrade", "Barba Estrela", "Combo Estrela",
            "Barba Pigmentada", "Luzes e Luzes Invertida", "Coloração", "Platinado", "Alisamento" };

        private void Serviços_Load(object sender, EventArgs e)
        {
            consulta = "SELECT NomeServico FROM tbl_Servicos";
            CarregaComboBox carregaServico = new CarregaComboBox();

            List<string> Servicos = new List<string>();

            Servicos.AddRange(carregaServico.carregaComboBox(consulta, "NomeServico"));

            cmbServico.Items.AddRange(Servicos.ToArray());
        }

        private void cmbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta = "SELECT PreçoServico FROM tbl_Servicos WHERE NomeServico = '"  + cmbServico.SelectedItem.ToString() + "';";


            ConsultarServico consultaServico = new ConsultarServico();
            consultaServico.fazerConsulta(consulta);
            txtPrecoServico.Text = Variaveis.CaixaTxtPrecoServico;

            string servico = cmbServico.SelectedItem.ToString();
            string imagem = String.Empty;

            int i;
            for (i = 0; i < Servicos.Length; i++)
            {
                if (servico == Servicos[i])
                {
                    imagem = "C:\\servicos\\" + servico + ".jpg";

                    pictFotoServico.ImageLocation= imagem;
                    break;
                }
            }

        }

        private void pictFotoServico_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCliente Tela = new ConsultarCliente();
            Tela.Show();
        }
    }
}
