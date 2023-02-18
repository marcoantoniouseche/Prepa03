using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    public class Escaleno : Triangulo
    {
        private float _ladoA;
        private float _ladoB;
        private float _ladoC;
        private float _semiperímetro;
        
        public Escaleno(float ladoA, float ladoB, float ladoC, string color) : base(color)
        {
            _ladoA = ladoA;
            _ladoB = ladoB;
            _ladoC = ladoC;
            _semiperímetro = (ladoA + ladoB + ladoC) / 2;
        }

        public override double GetArea()
        {
            return Math.Sqrt(_semiperímetro * (_semiperímetro - _ladoA) *
                (_semiperímetro - _ladoB) * (_semiperímetro - _ladoC));
            
        }

        public override double GetPerimetro()
        {
            return _ladoA + _ladoB + _ladoC;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un triángulo escaleno de color {GetColor()}, área {GetArea()} y perímetro {GetPerimetro()}.");
        }
    }
}
