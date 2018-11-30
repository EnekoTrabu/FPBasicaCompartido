using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Familia : IEquatable<Familia>
    {
        public string Idfamilia { get; set; }
        public string IdString { get; set; }
        public string Descripcion { get; set; }

        public Familia(string idfamilia, string idString, string descripcion)
        {
            Idfamilia = idfamilia;
            IdString = idString;
            Descripcion = descripcion;
        }

        public Familia(string idfamilia, string idString)
        {
            Idfamilia = idfamilia;
            IdString = idString;
        }

        public Familia()
        {
        }

        public Familia(string idfamilia)
        {
            Idfamilia = idfamilia;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Familia);
        }

        public bool Equals(Familia other)
        {
            return other != null &&
                   Idfamilia == other.Idfamilia;
        }

        public override int GetHashCode()
        {
            return -514772085 + EqualityComparer<string>.Default.GetHashCode(Idfamilia);
        }
    }
}
