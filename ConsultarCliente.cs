using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BarbeariaPatrick
{
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }
        public string consulta;
        public string sql;

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            consulta = "SELECT DataAgendamento, HorarioAgendamento, NomeServico, PrecoServico, IdFuncionario FROM tbl_AgendamentoCliente1 WHERE " +
                " NomeCliente = '" + cmbNomeCliente.SelectedItem.ToString() + "';";

            ConsultarClientes consultarCliente = new ConsultarClientes();
            consultarCliente.fazerConsulta(consulta);
            txtPrecoServico.Text = Variaveis.CaixaTxtPrecoServico;
            txtFuncionario.Text = Variaveis.CaixaTxtFuncionario;
            txtDataAgendamento.Text = Variaveis.CaixaTxtDataAgendamento.ToString("dd/MM/yyyy");
            txtHorarioAgendamento.Text = Variaveis.CaixaTxtHorarioAgendamento.ToString();
            txtServico.Text = Variaveis.CaixaTxtServico;


            string cliente = cmbNomeCliente.SelectedItem.ToString();
            

            

        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            consulta = "SELECT NomeCliente FROM tbl_AgendamentoCliente";
            CarregaComboBox carregaCliente = new CarregaComboBox();
            List<string> Cliente = new List<string>();
            Cliente.AddRange(carregaCliente.carregaComboBox(consulta, "NomeCliente"));
            cmbNomeCliente.Items.AddRange(Cliente.ToArray());
            


        }

        private void cmbNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
