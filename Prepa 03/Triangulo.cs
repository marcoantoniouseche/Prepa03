using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    public class Triangulo : Figura
    {
        private float _base;
        private float _altura;

        public Triangulo(string color) : base(color) 
        { }

        public Triangulo(float baseTriángulo, float altura, string color) : base(color)
        {
            _base = baseTriángulo;
            _altura = altura;
        }

        public float Base { get { return _base; } set { _base = value; } }
        public float Altura { get { return _altura; } set { _altura = value; } }

        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }

        public override double GetPerimetro()
        {
            //Al existir tres tipos de triángulos(Escaleno, isósceles y equilátero), cada uno
            //va a calcular el perímetro de diferente manera.
            return 0;
        }
    }
}
