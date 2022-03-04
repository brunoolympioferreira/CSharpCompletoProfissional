using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
     class Program
    {
        enum Notas
        {
            Minimo = 10,
            Media = 20,
            Maxima = 30
        }

        struct Pessoa 
        {
            public string nome;
            public int idade;
            public double altura;
        }
        static void Main(string[] args)
        {
            #region Numericas Integrais
            sbyte numero;
            numero = 100;
            #endregion

            #region Números Reais

            float real1 = 100.75f; // 32 bits
            double real2 = 500.258; // 64 bits
            decimal real3 = 752538.457m; // 128 bits

            #endregion

            #region Caractere

            char letra = '\u0041';
            char escape = '\\';

            #endregion

            #region Boolean

            bool verificar = false;
            verificar = true;

            #endregion

            #region String (Cadeia de Caracteres)

            string texto = "Bruno Roberto\nOlympio Ferreira";
            string mensagem = null;
            mensagem = texto;

            #endregion

            #region Tipo Implícito Var

            var valor = 100;
            valor = 20;

            #endregion

            #region Object (base para todos os tipos)

            object obj = false;
            obj = "bruno";
            obj = 200;

            #endregion

            #region Constantes

            const double pi = 3.1415;
            const string nome = "Bruno";

            #endregion

            #region Enumeração

            Notas notasAlunos = Notas.Media;

            #endregion

            #region Struct

            Pessoa p1 = new Pessoa();
            p1.altura = 1.65;
            p1.idade = 35;
            p1.nome = "Bruno";

            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                idade = 20,
                altura = 1.75
            };

            p1.nome = "Logan";
            #endregion


            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);

            Console.ReadKey();

        }
    }
}
