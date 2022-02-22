using System;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implícita
            //byte num1 = 100; // 8 bits, de 0 a 255
            //ushort num2; // 16 bits, 0 a 65535

            //float num3 = 1250.45f;
            //double num4 = num3;

            //num3 = num1;
            //num2 = num1;
            #endregion

            #region Conversão Explicita
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500.52f;
            //int num4 = (int)num3;

            //char letra = (char)97;
            #endregion

            #region Metodo Parse

            //string txtNumero = "1985";

            //int numero = int.Parse(txtNumero);

            //byte num1 = byte.Parse("16");

            //double num2 = double.Parse("125623,57");

            //float num3 = float.Parse("457,75");

            #endregion

            #region Classe Convert

            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');

            #endregion

            Console.WriteLine(num1);
            Console.ReadKey();
        }
    }
}
