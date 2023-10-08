using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaPatrick
{
    class ConsultarIDcliente
    {
        public void fazerConsulta(string consulta)
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);

            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand(consulta, conn);
                SqlDataReader drDados = null;
                drDados = comando.ExecuteReader();

                if (drDados.HasRows)
                {
                    while (drDados.Read())
                    {
                        Variaveis.CaixaTxtIDCliente = (short)drDados["IdCliente"];
                    }
                }
                else
                {
                    MessageBox.Show("Registros não encontrados");
                }
                drDados.Close();
                conn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
        }
    }
}
