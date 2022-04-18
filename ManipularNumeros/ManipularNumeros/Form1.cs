using System;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region TryParse

            //int num;
            //bool res = int.TryParse("1985ano",out num);

            //if (int.TryParse("1985", out num))
            //{
            //    lblResultado.Text = num.ToString();
            //}
            //else
            //{
            //    lblResultado.Text = "Erro na conversão";
            //}

            #endregion

            #region ToString | Convert.ToString

            //var num = 120.5524;

            //lblResultado.Text = num.ToString("#.00");

            int num = 254;
            //lblResultado.Text = num.ToString("X"); // Formato Hexadecimal
            //lblResultado.Text = num.ToString("X2"); // Formato Hexadecimal com "X" dígitos
            //lblResultado.Text = num.ToString("D"); // Decimal
            //lblResultado.Text = num.ToString("D4"); // Decimal com "X" digitos
            //lblResultado.Text = num.ToString("C"); // Monetário

            //lblResultado.Text = Convert.ToString(num, 8);
            #endregion

            #region Classe Math

            double pi = Math.PI;
            double constE = Math.E;
            double seno = Math.Sin(3);
            double cos = Math.Cos(3);
            double potencia = Math.Pow(2, 2);
            double raizQuadrada = Math.Sqrt(49);
            double arredonda = Math.Round(158.51); // arredonda
            double inteiro = Math.Truncate(32.57); // retorna somente o inteiro
            double floor = Math.Floor(25.99); // arredonda para baixo
            double ceil = Math.Ceiling(25.20); // arredonda para cima

            lblResultado.Text = ceil.ToString();

            #endregion

        }
    }
}
