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
            //visibilità
            LabelMod.Visible = false;
            InputMod.Visible = false;
            PrezzoMod.Visible = false;
            InvioMod.Visible = false;
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

        private void cancella_Click(object sender, EventArgs e)
        {
            int pos = Ricerca(p, nome.Text, dim);
            if (pos == -1)
            {
                listView1.Items.Clear();
                listView1.Items.Add("Elemento non trovato");
                visualizza(p);
            }
            else
            {
                Cancella(p, pos, ref dim);
                visualizza(p);
            }
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            LabelMod.Visible = true;
            InputMod.Visible = true;
            PrezzoMod.Visible = true;
            InvioMod.Visible = true;
        }

        private void InvioMod_Click(object sender, EventArgs e)
        {
            int pos = Ricerca(p, nome.Text, dim);
            if (pos == -1)
            {
                listView1.Items.Clear();
                listView1.Items.Add("Elemento non trovato");
            }
            else
            {
                Modifica(p, InputMod.Text, float.Parse(PrezzoMod.Text), pos);
                listView1.Items.Clear();
            }
            LabelMod.Visible = false;
            InputMod.Visible = false;
            PrezzoMod.Visible = false;
            InvioMod.Visible = false;
            //visualizza
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
        public int Ricerca(Prodotto[] p, string elemricercato, int dim)
        {
            int pos = -1;
            //ciclo di ricerca
            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == elemricercato)
                {
                    pos = i;
                }
            }
            return pos;
        }
        public void Cancella(Prodotto[] p, int pos, ref int dim)
        {
            for (int i = pos; i < dim; i++)
            {
                p[pos] = p[pos + 1];
            }
            dim--;
        }
        public void Modifica(Prodotto[] p, string elemricercato, float prezzo, int pos)
        {
            p[pos].nome = elemricercato;
            p[pos].prezzo = prezzo;
        }
    }
}
