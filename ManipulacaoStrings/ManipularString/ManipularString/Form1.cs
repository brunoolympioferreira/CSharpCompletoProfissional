using System;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region Metodo Contains
            //string texto = "Este tipo de variável é alfanumérica.";

            //if (texto.Contains("tipo de v"))
            //{
            //    label1.Text = "Contém";
            //}
            //else
            //{
            //    label1.Text = "Não contém";
            //}
            #endregion

            #region ToString()
            //int num = 5400;
            //bool res = true;

            //label1.Text = res.ToString();
            #endregion

            #region ToUpper | ToLower 
            //string nome = "bruno";
            //string nomeMaiusculo = nome.ToUpper();

            //string nome2 = "Bruno";
            //string nomeMinusculo = nome2.ToLower();

            //label1.Text = nomeMaiusculo;
            //label1.Text = nomeMinusculo;
            #endregion

            #region IndexOf | LastIndexOf
            //string nome = "Bruno Ferreira";

            //var indice = nome.IndexOf('r',5,4);
            //var indice = nome.LastIndexOf('a');

            //label1.Text = "Indice " + indice;
            #endregion

            #region Insert | Replace

            //string nome = "Bruno Ferreira";

            //string nomeFinal = nome.Insert(5, " Roberto Olympio");
            //string nomeFinal = nome.Replace("Ferreira", "Olympio");

            //label1.Text = nomeFinal;

            #endregion

            #region Lenght | SubString

            //string nome = "Bruno Olympio";

            //int tam = nome.Length;
            //label1.Text = "O nome " + nome + " contém " + tam + " letras";

            //for (int i = 0; i < nome.Length; i++)
            //{
            //    label1.Text += nome[i] + "\n";
            //}

            //string parte = nome.Substring(nome.IndexOf("O"));

            //label1.Text = parte;

            #endregion

            #region Split

            //string nomes = "Bruno Vivian Vinicius Celia Roberto Jerusa";

            //char[] separador = { ' ' };

            //string[] resultado = nomes.Split(separador);

            //foreach (string nome in resultado)
            //{
            //    label1.Text += nome + "\n";
            //}

            #endregion

            #region StartsWith | EndsWith

            //string nome = "Bruno";

            //bool res = nome.StartsWith("BRU", StringComparison.OrdinalIgnoreCase);
            //bool res = nome.EndsWith("NO", StringComparison.OrdinalIgnoreCase);

            //if (res)
            //{
            //    label1.Text = "Positivo";
            //}
            //else
            //{
            //    label1.Text = "Negativo";
            //}

            #endregion

            #region Trim | TrimStart | TrimEnd

            //string mensagem = "-_5    Ola Bruno -- 55 ";

            //char[] c = {' ', '-','_','5' };

            //string nova = mensagem.Trim(c);
            //string nova = mensagem.TrimStart(c);
            //string nova = mensagem.TrimEnd(c);

            //label1.Text = ">" + nova + "<";

            #endregion

            #region CompareTo | Equals

            //string nome = "Bruno";
            //string nome2 = "Vini";

            //if (nome.Equals(nome2, StringComparison.OrdinalIgnoreCase))
            //{
            //    label1.Text = "Positivo";
            //}
            //else
            //{
            //    label1.Text = "Negativo";
            //}

            //label1.Text = nome.CompareTo(nome2).ToString();


            #endregion

            #region Format

            //decimal valor = 19.95m;
            //int temp = 32;

            //string s = String.Format("O valor do produto é {0:C2} e a temperatura é {1}",valor, temp);

            //string s = String.Format("Hoje é {0:d} e são {0:t}", DateTime.Now);
            //string s = String.Format("Hoje é {0:D} e são {0:T}", DateTime.Now);

            //string s = $"O valor do produto é {valor:C4} e a temperatura é {temp}";

            //string s = $"Data: {DateTime.Now:D} e hora {DateTime.Now:T}";

            //label1.Text = s;

            #endregion
        }
    }
}
