using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbeariaPatrick
{
    class CarregaComboBox
    { 
    public List<string> carregaComboBox(string SQL, string coluna)
    {
        SqlConnection conn = new SqlConnection(Variaveis.strConn);
        List<string> Item = new List<string>();
            try
            {
                conn.Open();
                SqlCommand consulta = new SqlCommand(SQL, conn);
                SqlDataReader drDados = null;        
                drDados = consulta.ExecuteReader();

            if (drDados.HasRows)
            {
                while (drDados.Read())
                {
                    Item.Add(drDados[coluna].ToString());
                }
            }
            else
            {
                MessageBox.Show("Registros não encontrados");
            }
                drDados.Close();
                conn.Close();
                 }
            catch (Exception s)
                {
    MessageBox.Show(s.Source.ToString());
                }
            return Item;


        }
    }
}
