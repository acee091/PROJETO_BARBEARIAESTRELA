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
            consulta = "SELECT CC.DataAgendamento, CC.HorarioAgendamento, SC.NomeServico, SC.PreçoServico, " +
                "FUNC.NomeFuncionario FROM tbl_CadastroCliente1 CC INNER JOIN tbl_Cliente_Servicos1 CS ON CC.IdCliente = CS.IdCliente " +
                "INNER JOIN tbl_Servicos1 SC ON CS.IdServiço = SC.IdServiço INNER JOIN tbl_funcionario_servico FSC ON FSC.IdServiço = SC.IdServiço " +
                "INNER JOIN tbl_Funcionarios1 FUNC ON FUNC.IdFuncionario = FSC.IdFuncionario WHERE NomeCliente = '" + cmbNomeCliente.SelectedItem.ToString() + "';";

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
            consulta = "SELECT NomeCliente FROM tbl_CadastroCliente1";
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
