using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        //Persona: Edad, Sueldo, Nombre.
        //ATRIBUTOS o MIEMBROS de la clase

        private int Edad { get; set; }
        private float Sueldo { get; set; }
        private string Nombre { get; set; }

        public void setEdad(int e)
        {
            Edad = e;
        }
        public int getEdad()
        {
            return Edad;
        }

        //public y private

    }
}
