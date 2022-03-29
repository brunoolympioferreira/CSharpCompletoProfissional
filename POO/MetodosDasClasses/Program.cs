using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            #region Metodos Simples
            //m.Cumprimentar();
            #endregion

            #region Metodos com Parametros
            //m.Somar(10, 5);
            //m.Apresentar("Bruno", 35);
            #endregion

            #region Passagem de Parametros por valor e por referencia
            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);
            #endregion

            #region Metodos com Retorno de Valores
            //string nomeCompleto = m.MontaNome("Bruno", "Ferreira");
            //int codigoChar = m.CodigoChar('a');
            //double pi = m.ValorPi();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigoChar);
            //Console.WriteLine(pi);
            #endregion

            #region Sobrecarga de métodos
            //m.Cumprimentar();
            //m.Cumprimentar("Bruno");
            //m.Cumprimentar("Bruno", 18);

            //bool res1 = m.Comparar(100, 50 * 2);
            //bool res2 = m.Comparar("Bruno", "bruno");

            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            #endregion

            Console.ReadKey();
        }
    }
}
