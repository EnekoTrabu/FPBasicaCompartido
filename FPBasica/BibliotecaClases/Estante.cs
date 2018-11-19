using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    class Estante
    {
        public char idEstanteria { get; set; }
        public int altura {get; set;}
        public string estante {get; set;}

        public Estante()
        {
        }

         public Estante(char idEstanteria, int altura, string estante)
        {
            this.idEstanteria = idEstanteria;
            this.altura= altura;
            this.estante = estante;
        }





    }
}
