using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LStreetwear
{
    class Conexao
    {
        private static string conn = "server=localhost;Port=3306;Database=db_lstreetwear;uid=admin;pwd=admin";

        private static MySqlConnection con = null;

        public static MySqlConnection conectar()
        {
            con = new MySqlConnection(conn);
            try 
            {
                con.Open();
            }
            catch (Exception)
            {
                con = null;
                
            }
            return con;
        }

        public static void desconectar()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
