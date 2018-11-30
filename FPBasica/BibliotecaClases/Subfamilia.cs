using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class Subfamilia : IEquatable<Subfamilia>
    {
        public string IdSubFamilia { get; set; }
        public string IdString { get; set; }
        public string Descripcion { get; set; }
        public string IdFamilia { get; set; }

        public Subfamilia(string idSubFamilia, string idFamilia , string idString, string descripcion)
        {
            IdSubFamilia = idSubFamilia;
            IdFamilia = idFamilia;
            IdString = idString;
            Descripcion = descripcion;
            
        }

        public Subfamilia()
        {
        }

        public Subfamilia(string idSubFamilia, string idString)
        {
            IdSubFamilia = idSubFamilia;
            IdString = idString;
        }

        public Subfamilia(string idSubFamilia, string idString, string idFamilia) : this(idSubFamilia, idString)
        {
            IdFamilia = idFamilia;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Subfamilia);
        }

        public bool Equals(Subfamilia other)
        {
            return other != null &&
                   IdSubFamilia == other.IdSubFamilia;
        }

        public override int GetHashCode()
        {
            return -1482311027 + EqualityComparer<string>.Default.GetHashCode(IdSubFamilia);
        }
    }
}
