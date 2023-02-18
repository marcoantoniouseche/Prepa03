using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2,3, "blanco");

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;

            Figura figura3 = new Circulo(2, "negro");

            figura1.MostrarDatos();
          
            figura2.MostrarDatos();
           
            figura3.MostrarDatos();

            Console.WriteLine($" Area {figura3.GetArea()}, Perimetro {figura3.GetPerimetro()}");

            //Test triángulo equilátero.
            Equilatero equilátero = new Equilatero(4, "Azul");
            Equilatero equilátero2 = new Equilatero(4, (float) Math.Sqrt(Math.Pow(4, 2) - Math.Pow(2, 2)), "Azul");
            equilátero.MostrarDatos();
            equilátero2.MostrarDatos();

            //Test triángulo isósceles.
            Isosceles isósceles = new Isosceles(12, 8, "Rojo");
            isósceles.MostrarDatos();

            //Test triángulo escaleno.
            Escaleno escaleno = new Escaleno(10, 12, 14, "Verde");
            escaleno.MostrarDatos();

            Console.ReadLine();
        }
    }
}
