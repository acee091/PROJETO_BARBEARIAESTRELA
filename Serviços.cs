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
            MessageBox.Show(consulta);

            ConsultarServico consultaServico = new ConsultarServico();
            consultaServico.fazerConsulta(consulta);
            txtPrecoServico.Text = Variaveis.CaixaTxtPrecoServico;

            string servico = cmbServico.SelectedItem.ToString();
            string imagem = String.Empty;

            int i;
            for(i=0; i < servico.Length; i++)
            {
                if(servico == servicos[i])
                {
                    imagem = "C:\\servicos\\" + servico + ".jfjf"
                }

        }

        private void pictFotoServico_Click(object sender, EventArgs e)
        {

        }
    }
}
