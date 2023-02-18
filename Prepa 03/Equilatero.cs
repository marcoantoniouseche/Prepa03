using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    public class Equilatero : Triangulo
    {
        private float _lado;

        public Equilatero(float lado, string color) : base(color) 
        {
            _lado = lado;
        }

        public Equilatero(float baseTriángulo, float altura, string color) : base(baseTriángulo, altura, color) 
        {
            _lado = baseTriángulo;
        }

        public override double GetArea()
        {
            if (base.Altura != 0 && base.Base != 0)
            {
                return base.GetArea();
            } 
            else {
                return (Math.Pow(_lado, 2) * Math.Sqrt(3)) / 4;
            }
        }

        public override double GetPerimetro()
        {
            return 3 * _lado;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un triángulo equilátero de color {GetColor()}, área {GetArea()} y perímetro {GetPerimetro()}.");
        }
    }
}
