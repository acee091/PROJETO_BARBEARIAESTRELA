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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string sql;
        string senhaUser = String.Empty;

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            Criptografar cripto = new Criptografar();


            string SQLsenha = "SELECT Senha FROM tbl_Logon WHERE Nome_user = '" + txtLogin.Text + "'";
            consultaSenha(SQLsenha);           


            string senha = cripto.HashSHA256(txtLogonSenha.Text);


            StringComparer comparar = StringComparer.OrdinalIgnoreCase;


            if (comparar.Compare(senha, senhaUser) == 0)
            {
                this.Hide();
                ConsultarCliente TelaInicial = new ConsultarCliente();
                TelaInicial.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos! Tente Novamente", "Logon Inválido");
            }
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
        public void consultaSenha(string sql)
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            try
            {
                conn.Open();
                
                SqlCommand consulta = new SqlCommand(sql, conn);



                
                SqlDataReader drDados = null;



               
                drDados = consulta.ExecuteReader();
                while (drDados.Read())
                {

                    senhaUser = (string)drDados["Senha"];
                }
                drDados.Close();
                conn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
            finally
            {

            }
        }
    }
}
