using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    abstract public class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; private set; } = 10;
        public int Largura { get; private set; } = 10;
        public int Raio { get; private set; } = 5;

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public virtual void Area() 
        {
            int area = Largura * Altura;
            Console.WriteLine("Area Retângulo: " + area);
        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um círculo");
        }

        public override void Area() 
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Area Circulo: " + area);
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um retângulo");
        }

        public override void Area()
        {
            base.Area();
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um triângulo");
        }

        public override void Area()
        {
            double area = (Largura * Altura) / 2;
            Console.WriteLine("Area Triângulo: " + area);
        }
    }


}
