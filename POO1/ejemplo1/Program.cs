using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        //Clases, Objetos y Propiedades. Encapsulamiento.
        //Persona: Edad, Sueldo, Nombre.
        //Botella: Capacidad, Color, Material.
        //Perro: Nombre, Color, Origen.

        //Articulo: Codigo, Precio.
        //Venta: Codigo Articulo, Cantidad, Codigo Cliente.
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.setEdad(20);

            Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            Botella b1 = new Botella();
            b1.Capacidad = 200;

            Console.WriteLine(b1.Capacidad);

            Perro perro1 = new Perro();
            perro1.nombre = "Benja";
            perro1.color = "Blanco";
            perro1.origen = "Espana";

            Console.WriteLine(perro1.nombre + " " + perro1.color + " " + perro1.origen);
            
            Console.ReadKey();
        }
    }
}
