using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            //Carro carro = new Carro();
            //Bicicleta bicicleta = new Bicicleta();

            //carro.Acelerar();
            //bicicleta.Acelerar();

            //carro.Parar();
            //bicicleta.Parar();
            #endregion

            #region Parte 2

            Humano humano = new Humano();
            Pessoa pessoa = new Pessoa();
            Homem homem = new Homem();

            Console.WriteLine("\nHumano");
            humano.Olhos();
            humano.Cabelos();

            Console.WriteLine("\nPessoa");
            pessoa.Olhos();
            pessoa.Cabelos();

            Console.WriteLine("\nHomem");
            homem.Olhos();
            homem.Cabelos();

            #endregion

            Console.ReadKey();
        }
    }
}
