using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //           Primer lote con 10 registros de productos, cada producto tiene:
            //           -Codigo de articulo (3 digitos no consecutivos).
            //           -Precio.
            //           -Codigo  de Marca (1 a 10)
            //           Segundo lote con las ventas de la semana. Cada venta tiene:
            //           -Codigo articulo.
            //           -Cantidad.
            //           -Codigo Cliente. (1 a 100)
            //           Este lote corta con Codigo Cliente == 0.
            //              LOTE DE CARGA Y LOTE DE PROCESO.

            Articulo[] articulos = new Articulo[10];

            //articulos[6].CodMarca = 3; //una manera de cargar el vector.

            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto:");
                Console.WriteLine("Codigo:");
                articulos[i].CodArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1a10)");
                articulos[i].CodMarca = int.Parse(Console.ReadLine());
            }
            //cuando pega la vuelta completa, ya tengo el vector cargado.
            Venta venta = new Venta();
            Console.WriteLine("Ingresar la venta:");
            Console.WriteLine("Codigo Cliente:");
            venta.CodCliente = int.Parse(Console.ReadLine());
            while (venta.CodCliente!=0)
            {
                venta.CodCliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Codigo Articulo:");
                venta.CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Codigo Articulo:");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos...

                //pido cliente nuevamente
                Console.WriteLine("Ingresar la venta:");
                Console.WriteLine("Codigo Cliente:");
                venta.CodCliente = int.Parse(Console.ReadLine());

            }
        }
    }
}
