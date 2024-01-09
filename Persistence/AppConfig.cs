using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public static class DbCommunicator
    {
        public static string Usuario { get; set; }
        public static string Senha { get; set; }
        public static string Database { get; set; }
        public static string Servidor { get; set; }

        public static string GetConnectionString()
        {
            return $"Server={Servidor};Database={Database};User={Usuario};Password={Senha}";
        }
    }
}


