using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esempio_Strutture
{
    public partial class Form1 : Form
    {
        //dichiarazioni
        public struct Prodotto
        {
            public string nome;
            public float prezzo;
        }
        public Prodotto[] p;
        public int dim;

        //costruttore della classe
        public Form1()
        {
            InitializeComponent();
            //inizializzazioni
            p = new Prodotto[100];
            dim = 0;
        }

        //funzioni evento
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salva_Click(object sender, EventArgs e)
        {
            //riempio la variabile dell'struct
            p[dim].nome = nome.Text;
            p[dim].prezzo = float.Parse(prezzo.Text);
            dim++;
            //visualizzazione
            visualizza(p);
        }

        //funzioni di servizio
        public string prodstring(Prodotto p)
        {
            return "Nome: " + p.nome + " Prezzo:" + p.prezzo.ToString();
        }

        public void visualizza(Prodotto[] p)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodstring(p[i]));
            }
        }
    }
}
