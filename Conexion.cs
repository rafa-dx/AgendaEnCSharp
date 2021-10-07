using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Agenda
{
    class Conexion
    {
        public static   SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=localhost;DATABASE=AGENDA;integrated security=true;");
            cn.Open();
            return cn;
        }
    }
}
