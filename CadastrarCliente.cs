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
                string sql = "INSERT INTO tbl_ClienteLogon(cliente_user, clientesenha) VALUES ('" + txtClienteLogin.Text + "','" + senha + "')";

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
    }
}
