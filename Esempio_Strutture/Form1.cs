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
            //se non l'elemento non viene trovato
            if (pos == -1)
            {
                listView1.Items.Clear();
                listView1.Items.Add("Elemento non trovato");
                visualizza(p);
            }
            //altrimenti cancella
            else
            {
                Cancella(p, pos, ref dim);
                visualizza(p);
            }
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            //imposto visibili le etichette e le textbox che servono per la modifica
            LabelMod.Visible = true;
            InputMod.Visible = true;
            PrezzoMod.Visible = true;
            InvioMod.Visible = true;
        }

        private void InvioMod_Click(object sender, EventArgs e)
        {
            int pos = Ricerca(p, nome.Text, dim);
            //se non è stato trovato l'elemento cercato
            if (pos == -1)
            {
                listView1.Items.Clear();
                listView1.Items.Add("Elemento non trovato");
            }
            //altrimenti
            else
            {
                Modifica(p, InputMod.Text, float.Parse(PrezzoMod.Text), pos);
                listView1.Items.Clear();
            }
            //nascondo le etichette e textbox che non servono più
            LabelMod.Visible = false;
            InputMod.Visible = false;
            PrezzoMod.Visible = false;
            InvioMod.Visible = false;
            //visualizza
            visualizza(p);
        }

        private void Ordina_Click(object sender, EventArgs e)
        {
            //ordina
            Sort(p, dim);
            //stampa
            visualizza(p);
        }

        //funzioni di servizio
        public string prodstring(Prodotto p)
        {
            return "Nome: " + p.nome + " Prezzo:" + p.prezzo.ToString();
        }
        public void visualizza(Prodotto[] p)
        {
            //stampa
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
                //se l'elemento ricercato viene trovato
                if (p[i].nome == elemricercato)
                {
                    pos = i;
                }
            }
            return pos;
        }
        public void Cancella(Prodotto[] p, int pos, ref int dim)
        {
            //ciclo con cui i valori slittano tutti di uno a sinistra
            for (int i = pos; i < dim; i++)
            {
                p[pos] = p[pos + 1];
            }
            dim--;
        }
        public void Modifica(Prodotto[] p, string elemricercato, float prezzo, int pos)
        {
            //modifica del primo campo
            p[pos].nome = elemricercato;
            //modifica del secondo campo
            p[pos].prezzo = prezzo;
        }

        public void Sort(Prodotto[] p, int dim)
        {
            //dichiarazioni
            int x, y;
            string sup;
            //bubblesort
            for (x = 0; x < dim - 1; x++)
            {
                //confronta le coppie 
                for (y = 0; y < dim - 1 - x; y++)
                {
                    //nel caso trovo una coppia da scambiare
                    if (string.Compare(p[y].nome, p[y + 1].nome) > 0)
                    {
                        sup = p[y].nome;
                        //avviene lo scambio
                        p[y].nome = p[y + 1].nome;
                        p[y + 1].nome = sup;
                    }
                }
            }
        }
    }
}
