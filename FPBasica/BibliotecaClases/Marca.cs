using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
   public  class Marca : IEquatable<Marca>
    {
        public int idMarca { get; set; }
        public string nombre { get; set; }

        public Marca()
        {
        }

        public Marca(int idMarca, string nombre)
        {
            this.idMarca = idMarca;
            this.nombre = nombre;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Marca);
        }

        public bool Equals(Marca other)
        {
            return other != null &&
                   idMarca == other.idMarca;
        }

        public override int GetHashCode()
        {
            return 1306757816 + idMarca.GetHashCode();
        }
    }
}
