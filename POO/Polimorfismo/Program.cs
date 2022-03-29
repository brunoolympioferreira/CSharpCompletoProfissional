using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forma b = new Triangulo();
            Forma c = new Circulo();
            Forma d = new Retangulo();

            Console.WriteLine("Triangulo");
            b.Desenhar();
            b.Area();

            Console.WriteLine("Circulo");
            c.Desenhar();
            c.Area();

            Console.WriteLine("Retangulo");
            d.Desenhar();
            d.Area();


            Console.ReadKey();

        }
    }
}
