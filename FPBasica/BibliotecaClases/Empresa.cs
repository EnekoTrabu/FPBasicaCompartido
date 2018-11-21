using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class Empresa : IEquatable<Empresa>
    {
        public string Nif { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Image Logo { get; set; }


        public Empresa(string nif, string nombre, string direccion, Image logo)
        {
            this.Nif = nif;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Logo = logo;
        }

        public Empresa()
        {
        }

        public Empresa(string nif)
        {
            this.Nif = nif;
        }

        public Empresa(string nombre, string direccion) : this(nombre)
        {
            Direccion = direccion;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Empresa);
        }

        public bool Equals(Empresa other)
        {
            return other != null &&
                   Nif == other.Nif;
        }

        public override int GetHashCode()
        {
            return -146653734 + EqualityComparer<string>.Default.GetHashCode(Nif);
        }
    }
}
