using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            //Array
            string[] nomes = new string[3];
            nomes[0] = "Gabriel";
            nomes[1] = "Arthur";
            nomes[2] = "Danny";

            // Lista Genérica
            List<string> nomes2 = new List<string>();
            nomes2.Add("Bruno");
            nomes2.Add("Vivian");
            nomes2.AddRange(nomes);

            //if (nomes2.Remove("Danny"))
            //{
            //    MessageBox.Show("Danny removida");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possível remover");
            //}

            //if (nomes2.Contains("Danny"))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não contém");
            //}

            //MessageBox.Show("Número de elementos:" + nomes2.Count);

            //nomes2.Sort();

            //MessageBox.Show("Vivian está no índice: " + nomes2.IndexOf("Vivian"));

            //nomes2.Insert(2, "João");

            //nomes2.RemoveAt(1);

            //nomes2.Clear();

            //nomes2.Add("Vivian");


            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro","Moto","Avião","Heliciptero","Barco"
            };

            //MessageBox.Show(veiculos.ElementAt(2));

            //if (veiculos.Add("Moto"))
            //{
            //    MessageBox.Show("Item adicionado");
            //}
            //else
            //{
            //    MessageBox.Show("Item não adicionado");
            //}

            //if (veiculos.Contains("Carro"))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não Contém");

            //}

            //veiculos.Remove("Moto");
            //int num = veiculos.Count;

            //MessageBox.Show(veiculos.First());

            foreach (string item in veiculos)
            {
                lista.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e) // btnDictonary
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                {150,"Vivian" },
                {200, "Vinicius" },
                {80, "Bruno" }
            };

            alunos.Add(100, "Bruno");

            //alunos.Clear();

            //alunos.Remove(80);

            //KeyValuePair<int, string> primeiro = alunos.First();

            //MessageBox.Show("Primeiro " + primeiro.Key + " " + primeiro.Value);
            //MessageBox.Show("Ultimo " + alunos.Last().Value);

            //if (alunos.ContainsKey(100))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não Contém");

            //}

            if (alunos.ContainsValue("Vivian"))
            {
                MessageBox.Show("Contém");
            }
            else
            {
                MessageBox.Show("Não Contém");

            }

            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " = " + item.Value);
            }

            //MessageBox.Show("Quantidade de alunos: " + alunos.Count);
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 27, "Bruno" },
                { 10, "Vinicius" },
                { 17, "Arthur" }
            };

            alunos.Add(14, "Gloria");
            //alunos.Reverse();
            //alunos.Remove(10);
            //alunos.RemoveAt(0);
            //alunos.Count;
            //alunos.ContainsKey(50);
            //alunos.ContainsValue("Bruno");

            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }
        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                {50,"Gulherme" },
                {12,"Bruno" },
                {86,"Vivian" }
            };

            alunos.Add(6, "Vitor");

            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //brnSortedSet
        {
            lista.Items.Clear();
            SortedSet<string> nomes = new SortedSet<string>()
           {
               "Bruno","Vivian","Vinicius","Eduardo","Monica"
           };

            foreach (string nome in nomes)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Bruno");
            fila.Enqueue("Vivian");
            fila.Enqueue("Vinicius");

            MessageBox.Show(fila.Count.ToString());

            foreach (string item in fila)
            {
                lista.Items.Add(item);
            }

            //MessageBox.Show("Primeiro da fila " + fila.Peek());
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Primeiro da fila " + fila.Dequeue());
            //MessageBox.Show(fila.Count.ToString());


            //MessageBox.Show("Primeiro da fila " + fila.First());
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Ultimo da fila " + fila.Last());
            //MessageBox.Show(fila.Count.ToString());

            //fila.Clear();
            while (fila.Count > 0)
            {
                MessageBox.Show("Primeiro da fila " + fila.Dequeue());
                MessageBox.Show(fila.Count.ToString());
                lista.Items.Clear();
                foreach (string item in fila)
                {
                    lista.Items.Add(item);
                }
            }
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Stack<string> pilha = new Stack<string>();

            pilha.Push("Bruno");
            pilha.Push("Vivian");
            pilha.Push("Vinícius");

            MessageBox.Show(pilha.Count.ToString());

            foreach (string item in pilha)
            {
                lista.Items.Add(item);
            }

            //MessageBox.Show("Elemento no topo: " + pilha.Peek());
            //MessageBox.Show(pilha.Count.ToString());


            while (pilha.Count > 0)
            {
                MessageBox.Show("Elemento no topo " + pilha.Pop());
                MessageBox.Show(pilha.Count.ToString());
                lista.Items.Clear();
                foreach (string item in pilha)
                {
                    lista.Items.Add(item);
                }
            }

        }
    }
}
