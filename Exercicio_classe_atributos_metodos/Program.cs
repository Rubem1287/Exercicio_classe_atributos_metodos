using System;
using System.Globalization;
namespace Exercicio_classe_atributos_metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo : ");
           retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Area = "+retangulo.Area(retangulo.Largura, retangulo.Altura).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = "+retangulo.Perimetro(retangulo.Largura, retangulo.Altura).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = "+retangulo.Diagonal(retangulo.Largura, retangulo.Altura).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
