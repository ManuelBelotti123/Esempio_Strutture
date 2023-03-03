using System;
using System.IO;
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
            per.Visible = false;
            percent.Visible = false;
            invperc.Visible = false;
        }

        //funzioni evento
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salva_Click(object sender, EventArgs e)
        {
            if (dim < 100)
            {
                //riempio la variabile dell'struct
                p[dim].nome = nome.Text;
                p[dim].prezzo = float.Parse(prezzo.Text);
                dim++;
            }
            //visualizzazione
            visualizza(p);
        }

        private void cancella_Click(object sender, EventArgs e)
        {
            int pos = Ricerca(p, nome.Text, dim);
            //se non l'elemento non viene trovato
            if (pos == -1)
            {
                MessageBox.Show("Elemento non trovato");
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
                MessageBox.Show("Elemento non trovato");
                visualizza(p);
            }
            //altrimenti
            else
            {
                Modifica(p, InputMod.Text, float.Parse(PrezzoMod.Text), pos);
                listView1.Items.Clear();
                MessageBox.Show("Elemento modificato correttamente");
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

        private void SommaPrezzi_Click(object sender, EventArgs e)
        {
            //richiama la funzione somma
            float somma = Somma(p, dim);
            //messagebox di conferma
            MessageBox.Show("La somma dei prezzi dei prodotti è " + somma, "Somma dei prezzi");

        }

        private void perc_Click(object sender, EventArgs e)
        {
            float Perc = 0;
            bool f = true;
            //imposta la visibilità true
            per.Visible = true;
            percent.Visible = true;
            invperc.Visible = true;
        }

        private void invperc_Click(object sender, EventArgs e)
        {
            //a seconda della risposta dell'utente, sottrai o aggiungi la percentuale
            bool f = PercentualeRisp();
            Percentuale(p, dim, f, float.Parse(percent.Text));
            visualizza(p);
            //visibilità false
            per.Visible = false;
            percent.Visible = false;
            invperc.Visible = false;
        }



        private void SalvaFile_Click(object sender, EventArgs e)
        {
            // Creating a file
            string percorso = @"Prodotti.csv";
            // Appending the given texts
            using (StreamWriter sw = File.CreateText(percorso))
            {
                sw.WriteLine("Ciao");
            }
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
            //assicura che l'utente voglia cancellare l'elemento
            var risp = MessageBox.Show("Vuoi realemente cancellare questo elemento?", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (risp == DialogResult.Yes)
            {
                //ciclo con cui i valori slittano tutti di uno a sinistra
                for (int i = pos; i < dim; i++)
                {
                    p[pos] = p[pos + 1];
                }
                dim--;
                MessageBox.Show("Elemento cancellato correttamente");
            }
            else
            {
                MessageBox.Show("Elemento non trovato");
            }
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

        public float Somma(Prodotto[] p, int dim)
        {
            float somma = 0;
            //ciclo di somma
            for (int i = 0; i < dim; i++)
            {
                somma = somma + p[i].prezzo;
            }
            return somma;
        }

        public void Percentuale(Prodotto[] p, int dim, bool c, float Perc)
        {
            //ciclo di somma della percentuale al prezzo la percentuale
            for (int i = 0; i < dim; i++)
            {
                //nel caso si voglia aggiungere
                if (c)
                {
                    p[i].prezzo = p[i].prezzo + ((p[i].prezzo * Perc) / 100);
                }
                //nel caso si voglia sottrarre la percentuale
                else
                {
                    p[i].prezzo = p[i].prezzo - ((p[i].prezzo * Perc) / 100);
                }
            }
        }

        public bool PercentualeRisp()
        {
            bool f;
            //scelta tra somma e sottrazione della percentuale
            var risp = MessageBox.Show("Vuoi sommare (yes) o sottrarre (no) una percentuale?", "Percentuale", MessageBoxButtons.YesNo);
            if (risp == DialogResult.Yes)
            {
                f = true;
            }
            else
            {
                f = false;
            }
            return f;
        }

        public void GenerazioneFile(Prodotto[] p, int dim)
        {

        }
    }
}
