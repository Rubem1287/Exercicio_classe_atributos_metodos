using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_classe_atributos_metodos
{
    class Retangulo
    {

        public double Largura;
        public double Altura;


        public double Area(double largura,double altura)
        {
            return (largura*altura);
        }

        public double Perimetro(double largura, double altura)
        {
            return ((largura + altura) * 2);
        }

        public double Diagonal(double largura, double altura)
        {
            return (Math.Sqrt(Math.Pow(largura,2) + Math.Pow(altura,2)));
        }

    }
}
