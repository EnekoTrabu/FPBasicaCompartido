using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Producto : IEquatable<Producto>
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public string IdFamilia { get; set; }
        public string IdSubfamilia { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public string PesoBruto { get; set; }
        public string PesoNeto { get; set; }
        public string Estanteria { get; set; }
        public int Altura { get; set; }
        public string Estante { get; set; }

        public Producto(string codigo, string descripcion, int idMarca, string idFamilia, string idSubfamilia, float precio, int stock, string pesoBruto, string pesoNeto, string estanteria, int altura, string estante)
        {
            Codigo = codigo;
        
            Descripcion = descripcion;
            IdMarca = idMarca;
             IdFamilia = idFamilia;
             IdSubfamilia = idSubfamilia;
            Precio = precio;
            Stock = stock;
            PesoBruto = pesoBruto;
            PesoNeto = pesoNeto;
            Estanteria = estanteria;
            Altura = altura;
            Estante = estante;
        }

        public Producto()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Producto);
        }

        public bool Equals(Producto other)
        {
            return other != null &&
                   Codigo == other.Codigo;
        }

        public override int GetHashCode()
        {
            return 1745598366 + EqualityComparer<string>.Default.GetHashCode(Codigo);
        }
    }
}
