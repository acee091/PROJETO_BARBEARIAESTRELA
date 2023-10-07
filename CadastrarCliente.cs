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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (txtClienteSenha.Text.Equals(txtConfirmarClienteSenha.Text))
            {

                Criptografar cripto = new Criptografar();
                string senha = cripto.HashSHA256(txtClienteSenha.Text);



                // Criar string SQL:
                string sql = "INSERT INTO tbl_CadastroCliente(NomeCliente, Telefone, loginCliente, senhaCliente) VALUES ('" + txtNomeCliente.Text+ "', '" + txtTelefoneCliente.Text + "','" + txtClienteLogin.Text + "','" + senha + "')";

                ComandosDML inserir = new ComandosDML();

                try
                {
                    inserir.iud(sql);
                }
                finally
                {
                    MessageBox.Show("Usuário Cadastrado");
                }
            }
            else
            {
                MessageBox.Show("As senhas digitadas não correspondem", "Senha inválida");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial Tela = new TelaInicial();
            Tela.Show();
            this.Hide();
        }
    }
}
