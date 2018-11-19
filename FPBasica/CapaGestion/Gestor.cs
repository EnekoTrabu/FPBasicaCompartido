using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BibliotecaClases;

namespace CapaGestion
{
    public class Gestor
    {


        private MySqlConnection conexion;
        private string servidor;
        private string BD;
        private string Usuario;
        private string Contrasena;
        private void IniciarConexion()
        {
            servidor = "localhost";
            BD = "almacenbd";
            Usuario = "root";
            Contrasena = "";
            string stringDeConexion;
            stringDeConexion = "SERVER=" + servidor + ";" + "DATABASE=" +
            BD + ";" + "UID=" + Usuario + ";" + "PASSWORD=" + Contrasena + ";";

            try
            {
                conexion = new MySqlConnection(stringDeConexion);
                conexion.Open();
            }
            catch (Exception elCasque)
            {

                return elCasque.Message;
            }
        }
    }
}
