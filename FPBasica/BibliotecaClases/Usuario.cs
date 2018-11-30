using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BibliotecaClases
{
    public class Usuario : IEquatable<Usuario>
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string permiso { get; set; }
        public Image foto { get; set; }

        public Usuario(int id, string usuario, string contrasena, string permiso, Image foto)
        {
            this.id = id;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.permiso = permiso;
            this.foto = foto;
        }

        public Usuario()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Usuario);
        }

        public bool Equals(Usuario other)
        {
            return other != null &&
                   id == other.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + id.GetHashCode();
        }
    }
}
