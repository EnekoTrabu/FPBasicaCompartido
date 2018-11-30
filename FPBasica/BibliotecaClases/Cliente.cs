using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cliente : IEquatable<Cliente>
    {
        public string Nif { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }
        public string LugarEntrega { get; set; }    

        public Cliente(){

        }

        public Cliente(string nif, string nombre, string apellido1, string apellido2, string direccion, string lugarEntrega){
            this.Nif = nif;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = Apellido2;
            this.Direccion = direccion;
            this.LugarEntrega = lugarEntrega;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Cliente);
        }

        public bool Equals(Cliente other)
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
