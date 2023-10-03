using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BarbeariaPatrick
{
    class ComandosDML
    {
        public void iud(string sql)
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
