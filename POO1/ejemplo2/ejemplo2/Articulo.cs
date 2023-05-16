using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Articulo
    {
        //           -Codigo de articulo (3 digitos no consecutivos).
        //           -Precio.
        //           -Codigo  de Marca (1 a 10)

        //private int CodArticulo;
        public int CodArt { get; set; }
        //private float Precio;
        public float Precio { get; set; }
        
        private int codMarca;
        public int CodMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
    }
}
