using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursivo recursivo = new Recursivo();
            recursivo.ExecutarRecursivo("Ola mundo", 5);


            Console.ReadKey();
        }
    }
}
