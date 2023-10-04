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
    public partial class ConsultarAgendamento : Form
    {
        public string consulta;
        public ConsultarAgendamento()
        {
            InitializeComponent();
        }

        private void ConsultarAgendamento_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            consulta = "SELECT NomeCliente, DataAgendamento, HorarioAgendamento, NomeServico, PrecoServico, Telefone FROM tbl_AgendamentoCliente  WHERE " +
                " NomeCliente = '" + txtMostrarNomeCliente + "';";

          
            ConsultarClientes consultarClientes = new ConsultarClientes();

          
            consultarClientes.fazerConsulta(consulta);
            txtPrecoServico.Text = Variaveis.CaixaTxtPrecoServico;
            txtDataAgendamento.Text = Variaveis.CaixaTxtDataAgendamento.ToString("dd/MM/yyyy");
            txtHorarioAgendamento.Text = Variaveis.CaixaTxtHorarioAgendamento.ToString();
            txtServico.Text = Variaveis.CaixaTxtServico;
            txtMostrarNomeCliente.Text = Variaveis.CaixaTxtNomeCliente;
            txtTelefoneCliente.Text = Variaveis.CaixaTxtTelefoneCliente;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial Tela = new TelaInicial();
            Tela.Show();
            this.Hide();
        }
    }
}
