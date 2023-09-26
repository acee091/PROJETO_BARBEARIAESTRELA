using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BarbeariaPatrick
{
    public static class Variaveis
    {
        public static string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=db_BarbeariaEstrela; User ID=sa;Password=123456;";

        public static string CaixaTxtPrecoServico { get; set; }

    }
}
