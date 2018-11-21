using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string CodBarras { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public string PesoBruto { get; set; }
        public string PesoNeto { get; set; }
        public string Estanteria { get; set; }
        public int Altura { get; set; }
        public string Estante { get; set; }

    }
}
