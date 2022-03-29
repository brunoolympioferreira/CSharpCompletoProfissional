using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    class Teste
    {
        // Definição de um campo
        private string _nome;
        public string Sobrenome { get; } = "Ferreira";

        private int _idade;

        // Definição de propriedade
        public string Nome 
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade não permitida");
                }
                else
                {
                    _idade = value;
                }
            }
        }



        public void Apresentar()
        {
            if (_nome != "")
                Console.WriteLine("Bem Vindo " + _nome);
        }
    }
}
