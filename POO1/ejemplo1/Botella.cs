using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Botella //Botella: Capacidad, Color, Material.
    {
        //capacidad maxima:100
        //cantidadActual: inicio en cero.
        //metodo recarga: carga el 100 y devuelve el costo de recargar $50 cada 100 lts.
        public Botella(string color, string material)
        {
           this.color = color;
           this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        //sobrecarga constructor
        public Botella() { }

        //desctructor
        ~Botella()
        {

        }

        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return CantidadActual; }
        }
        //PROPIEDAD
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}
        public string Material
        {
            get { return material; }
        }
        //metodo
        public float recargar()
        {
            if (cantidadActual>0)
            {
                int dif = 100 - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }
    }
}
 