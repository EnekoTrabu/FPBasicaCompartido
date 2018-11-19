using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
   class Estante : IEquatable<Estante>
    {
        public char idEstanteria { get; set; }
        public int altura { get; set; }
        public string estante { get; set; }

        public Estante()
        {
        }

        public Estante(char idEstanteria, int altura, string estante)
        {
            this.idEstanteria = idEstanteria;
            this.altura = altura;
            this.estante = estante;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Estante);
        }

        public bool Equals(Estante other)
        {
            return other != null &&
                   idEstanteria == other.idEstanteria &&
                   altura == other.altura &&
                   estante == other.estante;
        }

        public override int GetHashCode()
        {
            var hashCode = 2107790685;
            hashCode = hashCode * -1521134295 + idEstanteria.GetHashCode();
            hashCode = hashCode * -1521134295 + altura.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(estante);
            return hashCode;
        }
    }
}
