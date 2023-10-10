using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace BarbeariaPatrick
{
    public static class Variaveis
    {
        public static string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=db_Projeto; User ID=sa;Password=123456;";

        public static string CaixaTxtPrecoServico { get; set; }
        public static string CaixaTxtNomeCliente { get; set; }
        public static TimeSpan CaixaTxtHorarioAgendamento { get; set; }
        public static DateTime CaixaTxtDataAgendamento { get; set; }
        public static string CaixaTxtServico { get; set; }
        public static string CaixaTxtFuncionario { get; set; }

        public static string CaixaTxtAgendarNomeCliente { get; set; }
        public static int CaixaTxtIDServico { get; set; }
        public static int CaixaTxtIDCliente { get; set; }

        public static string CaixaTxtTelefoneCliente { get; set; }

        public static DateTime CaixaTxtDataCliente { get; set; }

        public static TimeSpan CaixaTxtHorarioCliente { get; set; }

        public static string CaixaTxtNomeServico { get; set; }

        public static string CaixaTxtClientePrecoServico { get; set; }
    }
}
