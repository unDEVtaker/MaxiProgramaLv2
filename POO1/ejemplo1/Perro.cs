using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Perro         //Perro: Nombre, Color, Origen.
    {
        private string Nombre;
        private string Color;
        private string Origen;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string color
        {
            get { return Color; }
            set { Color = value; }
        }
        public string origen
        {
            get { return Origen; }
            set { Origen = value; }
        }
    }
}
