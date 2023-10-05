using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaPatrick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            ConsultarCliente Tela = new ConsultarCliente();
            Tela.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial Tela = new TelaInicial();
            Tela.Show();
            this.Hide();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblSenhaLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario Tela = new CadastrarFuncionario();
            Tela.Show();
        }
    }
}
