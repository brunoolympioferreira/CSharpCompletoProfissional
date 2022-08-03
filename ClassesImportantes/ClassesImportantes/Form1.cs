using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ola meus amigos");
            //MessageBox.Show("Mensagem a ser impressa", "Titulo da Mensagem");
            // MessageBox.Show("Texto da mensagem","Titulo",MessageBoxButtons.YesNo);
            //MessageBox.Show("Texto da mensagem","Titulo",MessageBoxButtons.YesNoCancel);
            //MessageBox.Show("Texto da mensagem","Titulo",MessageBoxButtons.OKCancel);


            //DialogResult res = MessageBox.Show("Texto da mensagem","Titulo",MessageBoxButtons.OKCancel);
            //if (res == DialogResult.OK)
            //{
            //    lblResultado.Text = "Clicou em Ok";
            //}
            //else if (res == DialogResult.Cancel)
            //{
            //    lblResultado.Text = "Clicou em cancelar";
            //}

            //MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            //MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo,MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            //Random random = new Random(696855); //Semente fixa
            Random random = new Random(DateTime.Now.Millisecond); //semente variavel


            //int valor = random.Next();
            //int valor = random.Next(10);
            //int valor = random.Next(20,50);
            int valor = random.Next(100);
            //double valor2 = random.NextDouble();
            double valor2 = random.NextDouble() * 100;


            //lblResultado.Text = "Numero: " + valor1;
            lblResultado.Text = "Numero: " + valor2;
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //TimeSpan retorna horarios formatados de veriados tipos

            //lblResultado.Text = TimeSpan.FromMinutes(90.5).ToString();
            //lblResultado.Text = TimeSpan.FromDays(7.25).ToString();
            //lblResultado.Text = TimeSpan.FromTicks(1000000000).ToString();
            //lblResultado.Text = TimeSpan.TicksPerMinute.ToString();

            TimeSpan inicio = new TimeSpan(1,0,0);
            TimeSpan fim = new TimeSpan(3,30,0);

            //TimeSpan intervalo = fim - inicio;
            TimeSpan intervalo = fim + inicio;

            //TimeSpan add = inicio.Add(fim);
            TimeSpan sub = fim.Subtract(inicio);

            //lblResultado.Text = inicio.ToString();
            //lblResultado.Text = intervalo.ToString();
            //lblResultado.Text = intervalo.Hours.ToString();
            //lblResultado.Text = intervalo.ToString();
            //lblResultado.Text = add.ToString();
            lblResultado.Text = sub.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = DateTime.Now.ToString();
            //lblResultado.Text = DateTime.Today.ToString();
            //lblResultado.Text = DateTime.DaysInMonth(2022,5).ToString();
            //lblResultado.Text = DateTime.IsLeapYear(2024).ToString();
            //lblResultado.Text = DateTime.Now.ToLongDateString();
            //lblResultado.Text = DateTime.Now.ToShortDateString();
            //lblResultado.Text = DateTime.Now.ToLongTimeString();
            //lblResultado.Text = DateTime.Now.ToShortTimeString();
            //lblResultado.Text = DateTime.Now.ToUniversalTime().ToString();
            //lblResultado.Text = DateTime.Now.ToString("yyyy-MM-dd H:mm:s");
            //lblResultado.Text = DateTime.Now.ToString("dd-MM-yyyy H:mm");

            DateTime data = new DateTime(1985,1,10,14,35,30);

            //lblResultado.Text = data.AddYears(2).ToString();
            //TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            //lblResultado.Text = data.Add(tempo).ToString();

            //lblResultado.Text = data.DayOfWeek.ToString();
            //lblResultado.Text = data.DayOfYear.ToString();


        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color vermelho = Color.Red;
            Color amarelo = Color.Yellow;

            //Color cor1 = Color.FromArgb(100,Color.DarkGreen);
            //Color cor1 = Color.FromArgb(255,100,50,135);
            Color cor1 = Color.FromArgb(100,50,135);
            Color cor2 = Color.FromKnownColor(KnownColor.Control);
            Color cor3 = Color.FromName("DarkRed");

            lblResultado.BackColor = cor3;
            lblResultado.ForeColor = cor2;

            Color cor4 = lblResultado.BackColor;

            btnColor.BackColor = lblResultado.BackColor;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Comic Sans MS", 26, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel);

            Font letra2 = new Font(FontFamily.GenericMonospace, 36, FontStyle.Regular, GraphicsUnit.Pixel);

            lblResultado.Text = "Bem vindo ao C#, trabalho com fontes";
            lblResultado.Font = letra2;
        }

        private void btnEnviroment_Click(object sender, EventArgs e)
        {
            string meusDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string meusDocs = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            //string meusDocs = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //Environment.CurrentDirectory = "C:\\";
            //string dirAtual = Environment.CurrentDirectory;
            //Environment.NewLine;
            //string varAmb = Environment.GetEnvironmentVariable("Path");
            //string[] discos = Environment.GetLogicalDrives();

            //foreach (var item in discos)
            //{
            //    lblResultado.Text += "\n" + item;
            //}

            //lblResultado.Text = dirAtual + "\n" + meusDocs;
            //string user = Environment.UserName;
            //string dominio = Environment.UserDomainName;
            //lblResultado.Text = dominio;
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            string exec = Application.ExecutablePath;
            string pasta = Application.StartupPath;

            lblResultado.Text = pasta;
        }
    }
}
