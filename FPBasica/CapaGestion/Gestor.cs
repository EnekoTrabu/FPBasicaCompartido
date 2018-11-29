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
                return "Conexión exitosa";
            }
            catch (Exception elCasque)
            {

                return elCasque.Message ;
            }
        }
        private bool InsertarProducto(Producto producto)
        {
           try 
	       {	        
		       string InsertProducto = "INSERT INTO producto (codigo, descripcion, idmarca, idfamilia, idsubfamilia,  precio, stock, pesobruto, pesoneto, estanteria, altura, estante) VALUES(@codigo, @codbarras, @descripcion, @idmarca, @precio, @stock, @pesobruto, @pesoneto, @estanteria, @altura, @estante);";
               MySqlCommand cmdIContacto = new MySqlCommand(InsertProducto, conexion);
               cmdIContacto.Parameters.AddWithValue("@codigo", producto.Codigo);
               cmdIContacto.Parameters.AddWithValue("@descripcion", producto.Descripcion);
               cmdIContacto.Parameters.AddWithValue("@idmarca", producto.IdMarca);
               cmdIContacto.Parameters.AddWithValue("@idfamilia", producto.IdFamilia);
               cmdIContacto.Parameters.AddWithValue("@idsubfamilia", producto.IdSubfamilia);
               cmdIContacto.Parameters.AddWithValue("@precio", producto.Precio);
               cmdIContacto.Parameters.AddWithValue("@stock", producto.Stock);
               cmdIContacto.Parameters.AddWithValue("@pesobruto", producto.PesoBruto);
               cmdIContacto.Parameters.AddWithValue("@pesoneto", producto.PesoNeto);
               cmdIContacto.Parameters.AddWithValue("@estanteria", producto.Estanteria);
               cmdIContacto.Parameters.AddWithValue("@altura", producto.Altura);
               cmdIContacto.Parameters.AddWithValue("@estante", producto.Estante);
               cmdIContacto.ExecuteNonQuery();
               return true;
	       }
	       catch (Exception)
           {
                return false;
           }
        }
        public List<Producto> SelectPorAtributo(string atributo, string valor){
           try 
	       {	        
		        string SelectDatos = "SELECT * FROM producto WHERE @atributo=@valor;";
                MySqlCommand cmdS = new MySqlCommand(SelectDatos, conexion);
                cmdS.Parameters.AddWithValue("@atributo", atributo);
                cmdS.Parameters.AddWithValue("@valor", valor);
                MySqlDataReader Lector = cmdS.ExecuteReader();
                List<Producto> listado = new List<Producto>();
                while (Lector.Read())
                {
                        listado.Add(new Producto());
 
                }
                Lector.Close();
                conexion.Close();
                
                return listado;
	       }
	       catch (Exception elCasque)
	       {

		        return elCasque.Message;
	       }
        }
        public List<Producto> SelectPorDescripccion(string trozoDescripcion){
            if(trozoDescripcion==""){
                string SelectDatos = "SELECT * FROM producto;";
                MySqlCommand cmdS = new MySqlCommand(SelectDatos, conexion);

            }else{

                string SelectDatos = "SELECT * FROM producto WHERE producto.descripcion LIKE @valor;";
                MySqlCommand cmdS = new MySqlCommand(SelectDatos, conexion);
                cmdS.Parameters.AddWithValue("@valor", ("%"+ trozoDescripcion+ "%"));
            }
            
            MySqlDataReader Lector = cmdS.ExecuteReader();
            List<Producto> listado = new List<Producto>();
            while (Lector.Read())
            {
                listado.Add(new Producto());
 
            }
                Lector.Close();
                conexion.Close();
                
                return listado;
        }
        public string DarAltaProducto(Producto nuevoProducto){

            IniciarConexion();
            if(InsertarProducto(nuevoProducto)){
                return "Producto añadido con éxito";

            }else{
                return "Hubo un problema al añadir el producto";
            }
            
        }
    }
}
