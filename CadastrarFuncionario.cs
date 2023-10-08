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
    public partial class CadastrarFuncionario : Form
    {
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }
        

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (txtCadastraSenha.Text.Equals(txtConfirmarSenha.Text))
            {
                
                Criptografar cripto = new Criptografar();
                string senha = cripto.HashSHA256(txtCadastraSenha.Text);



                // Criar string SQL:
                string sql = "INSERT INTO tbl_logon(Nome_user, Senha) VALUES ('" + txtCadastraNome.Text + "','" + senha + "')";
                
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

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 Tela = new Form1();
            Tela.Show();
            this.Hide();
        }
    }
}
