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
        private string IniciarConexion()
        {
            servidor = "localhost";
            BD = "agenda";
            Usuario = "root";
            Contrasena = "";
            string stringDeConexion;
            stringDeConexion = "SERVER=" + servidor + ";" + "DATABASE=" +
            BD + ";" + "UID=" + Usuario + ";" + "PASSWORD=" + Contrasena + ";";
            try
            {
                conexion = new MySqlConnection(stringDeConexion);
                conexion.Open();
                return "Conexión exitosa";
            }
            catch (Exception elCasque)
            {

                return elCasque.Message ;
            }
        }
        private void InsertarProducto(Producto producto)
        {
            string InsertContacto = "INSERT INTO producto (codigo, codbarras, descripcion, idmarca, precio, stock, pesobruto, pesoneto, estanteria, altura, estante) VALUES(@codigo, @codbarras, @descripcion, @idmarca, @precio, @stock, @pesobruto, @pesoneto, @estanteria, @altura, @estante);";
            MySqlCommand cmdIContacto = new MySqlCommand(InsertContacto, conexion);
            cmdIContacto.Parameters.AddWithValue("@codigo", nombre);
            cmdIContacto.Parameters.AddWithValue("@codbarras", email);
            cmdIContacto.Parameters.AddWithValue("@descripcion", nombre);
            cmdIContacto.Parameters.AddWithValue("@idmarca", email);
            cmdIContacto.Parameters.AddWithValue("@precio", nombre);
            cmdIContacto.Parameters.AddWithValue("@stock", email);
            cmdIContacto.Parameters.AddWithValue("@pesobruto", nombre);
            cmdIContacto.Parameters.AddWithValue("@pesoneto", email);
            cmdIContacto.Parameters.AddWithValue("@estanteria", nombre);
            cmdIContacto.Parameters.AddWithValue("@altura", email);
            cmdIContacto.Parameters.AddWithValue("@estante", nombre);
      
            cmdIContacto.ExecuteNonQuery();
        }

    }
}
