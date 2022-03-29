using System;

namespace Estaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classe Estática
            //Matematica.taxa = 10;

            //int valor1 = Matematica.Adicionar(200);
            //int valor2 = Matematica.Diminuir(200);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);
            #endregion

            #region Membros Estáticos
            Pessoa.maiorIdade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Bruno";
            p1.idade = Pessoa.CalcularIdade(1986);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maiorIdade);
            #endregion

            Console.ReadKey();
        }
    }
}
