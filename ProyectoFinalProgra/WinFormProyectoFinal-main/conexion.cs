using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProyectoFinal
{

    class conexion
    {
        public static MySqlConnection conex()
        {
            string servidor = "server=localhost;port=3306;uid=root;pwd='';database=kingsman;";
            MySqlConnection conexionBD = new MySqlConnection(servidor);
            try
            {
                return conexionBD;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }

    } 
}
    
