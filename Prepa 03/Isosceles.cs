using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    public class Isosceles : Triangulo
    {
        private float _lado;

        public Isosceles(float baseTriángulo, float altura, string color) : base(baseTriángulo, altura, color) 
        { 
            _lado = (float) Math.Sqrt(Math.Pow(altura, 2) + (Math.Pow(baseTriángulo, 2) / 4));
        }

        public override double GetArea()
        {
            return base.GetArea();
        }

        public override double GetPerimetro()
        {
            return base.Base + (2 * _lado);
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un triángulo isósceles de color {GetColor()}, área {GetArea()} y perímetro {GetPerimetro()}.");
        }
    }
}
