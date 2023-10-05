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
                // Criptografar senha fornecida com algoritmo MD5 (arquivo criptografar.cs):
                Criptografar cripto = new Criptografar();
                string senha = cripto.HashSHA256(txtCadastraSenha.Text);



                // Criar string SQL:
                string sql = "INSERT INTO tbl_logon(Nome_user, Senha) VALUES ('" + txtCadastraNome.Text + "','" + senha + "')";
                // Instanciar objeto comandosDML (classe em arquivo à parte):
                ComandosDML inserir = new ComandosDML();
                // Executar a consulta:
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
