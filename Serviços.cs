using System;
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
            consulta = "SELECT NomeServico FROM tbl_Servicos1";
            CarregaComboBox carregaServico = new CarregaComboBox();

            List<string> Servicos = new List<string>();

            Servicos.AddRange(carregaServico.carregaComboBox(consulta, "NomeServico"));

            cmbServico.Items.AddRange(Servicos.ToArray());
        }

        private void cmbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta = "SELECT PreçoServico, IdServiço FROM tbl_Servicos1 WHERE NomeServico = '" + cmbServico.SelectedItem.ToString() + "';";

            ConsultarServico consultaServico = new ConsultarServico();
            consultaServico.fazerConsulta(consulta);
            txtPrecoServico.Text = Variaveis.CaixaTxtPrecoServico;
            txtIDdoServico.Text = Variaveis.CaixaTxtIDServico.ToString();

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial Tela = new TelaInicial();
            Tela.Show();
            this.Hide();
        }

        private void btnAgendamentoCliente_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tbl_AgendamentoCliente(IdCliente, IdServiço, DataAgendamento, HorarioAgendamento) " +
                "VALUES ('" + txtIDcliente.Text + "','" + txtIDdoServico.Text + "', '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', '" + txtAgendarHorarioCliente.Text + "');";
            

            ComandosDML inserir = new ComandosDML();
            try
            {
                inserir.iud(sql); 
                MessageBox.Show("Agendamento marcado com sucesso");
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString(), "Erro de banco de dados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source.ToString(), "Erro Genérico");
            }
            finally
            {
                
            }
        }

        private void txtAgendarHorarioCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDservico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIDdoServico_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefoneCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtAgendarDataCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarID_Click(object sender, EventArgs e)
        {
            consulta = "SELECT IdCliente FROM tbl_CadastroCliente1 WHERE NomeCliente = '" + txtConsultarIDcliente.Text + "'; ";

            ConsultarIDcliente Consultarcliente = new ConsultarIDcliente();

            Consultarcliente.fazerConsulta(consulta);
            txtIDcliente.Text = Variaveis.CaixaTxtIDCliente.ToString();
            string id = "SEU ID FOI INSERIDO!";
            lblidcliente.Text = id;
        }

        private void lblPrecoCorte_Click(object sender, EventArgs e)
        {

        }

        private void lblEscolhaServico_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecoServico_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictFotoServico_Click_1(object sender, EventArgs e)
        {

        }
    }
}
