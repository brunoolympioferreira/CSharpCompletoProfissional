﻿using System;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();

            if (a.Login("abc123"))
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
                Console.WriteLine("Acesso negado!");

            Console.ReadKey();
        }
    }
}
