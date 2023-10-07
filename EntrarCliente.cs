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
    public partial class EntrarCliente : Form
    {
        public EntrarCliente()
        {
            InitializeComponent();
        }
        public string sql;
        string senhaUser = String.Empty;

        private void btnVoltarADM_Click(object sender, EventArgs e)
        {
            TelaInicial Tela = new TelaInicial();
            Tela.Show();
            this.Hide();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            Criptografar cripto = new Criptografar();


            string SQLsenha = "SELECT senhaCliente FROM tbl_CadastroCliente1 WHERE loginCliente = '" + txtLogin.Text + "'";
            consultaSenha(SQLsenha);


            string senha = cripto.HashSHA256(txtLogonSenha.Text);


            StringComparer comparar = StringComparer.OrdinalIgnoreCase;


            if (comparar.Compare(senha, senhaUser) == 0)
            {
                this.Hide();
                Serviços TelaInicial = new Serviços();
                TelaInicial.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos! Tente Novamente", "Logon Inválido");
            }
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

                    senhaUser = (string)drDados["senhaCliente"];
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
