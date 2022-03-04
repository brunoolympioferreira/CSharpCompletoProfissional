using System;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Condicao encadeada
            //int valor = 5;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else if (valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("Condição Alternativa 1");
            //}
            //else
            //{
            //    Console.WriteLine("Condição Alternativa 2");
            //}
            #endregion

            #region Operador ternário

            int numero = 3;
            string mensagem = numero > 5 ? "maior que 5" : "menor que 5"; ;

            // condição ? true : false;
            //mensagem = numero > 5 ? "maior que 5" : "menor que 5"; 

            //if (numero > 5)
            //{
            //    mensagem = "maior que 5";
            //}
            //else
            //{
            //    mensagem = "Menor que 5";
            //}

            #endregion

            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}
