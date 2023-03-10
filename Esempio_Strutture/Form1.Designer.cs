namespace Esempio_Strutture
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.nome = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salva = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.cancella = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.InvioMod = new System.Windows.Forms.Button();
            this.LabelMod = new System.Windows.Forms.Label();
            this.InputMod = new System.Windows.Forms.TextBox();
            this.PrezzoMod = new System.Windows.Forms.TextBox();
            this.Ordina = new System.Windows.Forms.Button();
            this.SommaPrezzi = new System.Windows.Forms.Button();
            this.perc = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.TextBox();
            this.per = new System.Windows.Forms.Label();
            this.invperc = new System.Windows.Forms.Button();
            this.SalvaFile = new System.Windows.Forms.Button();
            this.LeggiFile = new System.Windows.Forms.Button();
            this.Minimo = new System.Windows.Forms.Button();
            this.Massimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(41, 76);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 0;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(41, 116);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(100, 20);
            this.prezzo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezzo";
            // 
            // salva
            // 
            this.salva.Location = new System.Drawing.Point(41, 142);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(100, 23);
            this.salva.TabIndex = 4;
            this.salva.Text = "Aggiungi";
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.salva_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(463, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(308, 385);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Database Prodotti";
            // 
            // cancella
            // 
            this.cancella.Location = new System.Drawing.Point(41, 171);
            this.cancella.Name = "cancella";
            this.cancella.Size = new System.Drawing.Size(100, 23);
            this.cancella.TabIndex = 7;
            this.cancella.Text = "Cancella";
            this.cancella.UseVisualStyleBackColor = true;
            this.cancella.Click += new System.EventHandler(this.cancella_Click);
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(41, 200);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(100, 23);
            this.modifica.TabIndex = 8;
            this.modifica.Text = "Modifica";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // InvioMod
            // 
            this.InvioMod.Location = new System.Drawing.Point(226, 150);
            this.InvioMod.Name = "InvioMod";
            this.InvioMod.Size = new System.Drawing.Size(100, 23);
            this.InvioMod.TabIndex = 11;
            this.InvioMod.Text = "Invio";
            this.InvioMod.UseVisualStyleBackColor = true;
            this.InvioMod.Click += new System.EventHandler(this.InvioMod_Click);
            // 
            // LabelMod
            // 
            this.LabelMod.AutoSize = true;
            this.LabelMod.Location = new System.Drawing.Point(223, 79);
            this.LabelMod.Name = "LabelMod";
            this.LabelMod.Size = new System.Drawing.Size(47, 13);
            this.LabelMod.TabIndex = 10;
            this.LabelMod.Text = "Modifica";
            // 
            // InputMod
            // 
            this.InputMod.Location = new System.Drawing.Point(226, 98);
            this.InputMod.Name = "InputMod";
            this.InputMod.Size = new System.Drawing.Size(100, 20);
            this.InputMod.TabIndex = 9;
            // 
            // PrezzoMod
            // 
            this.PrezzoMod.Location = new System.Drawing.Point(226, 124);
            this.PrezzoMod.Name = "PrezzoMod";
            this.PrezzoMod.Size = new System.Drawing.Size(100, 20);
            this.PrezzoMod.TabIndex = 12;
            // 
            // Ordina
            // 
            this.Ordina.Location = new System.Drawing.Point(41, 229);
            this.Ordina.Name = "Ordina";
            this.Ordina.Size = new System.Drawing.Size(100, 23);
            this.Ordina.TabIndex = 13;
            this.Ordina.Text = "Ordina";
            this.Ordina.UseVisualStyleBackColor = true;
            this.Ordina.Click += new System.EventHandler(this.Ordina_Click);
            // 
            // SommaPrezzi
            // 
            this.SommaPrezzi.Location = new System.Drawing.Point(41, 258);
            this.SommaPrezzi.Name = "SommaPrezzi";
            this.SommaPrezzi.Size = new System.Drawing.Size(100, 23);
            this.SommaPrezzi.TabIndex = 14;
            this.SommaPrezzi.Text = "Somma dei prezzi";
            this.SommaPrezzi.UseVisualStyleBackColor = true;
            this.SommaPrezzi.Click += new System.EventHandler(this.SommaPrezzi_Click);
            // 
            // perc
            // 
            this.perc.Location = new System.Drawing.Point(41, 287);
            this.perc.Name = "perc";
            this.perc.Size = new System.Drawing.Size(100, 23);
            this.perc.TabIndex = 15;
            this.perc.Text = "Percentuale";
            this.perc.UseVisualStyleBackColor = true;
            this.perc.Click += new System.EventHandler(this.perc_Click);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(226, 223);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(100, 20);
            this.percent.TabIndex = 16;
            // 
            // per
            // 
            this.per.AutoSize = true;
            this.per.Location = new System.Drawing.Point(223, 207);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(64, 13);
            this.per.TabIndex = 17;
            this.per.Text = "Percentuale";
            // 
            // invperc
            // 
            this.invperc.Location = new System.Drawing.Point(226, 250);
            this.invperc.Name = "invperc";
            this.invperc.Size = new System.Drawing.Size(100, 23);
            this.invperc.TabIndex = 18;
            this.invperc.Text = "Invio";
            this.invperc.UseVisualStyleBackColor = true;
            this.invperc.Click += new System.EventHandler(this.invperc_Click);
            // 
            // SalvaFile
            // 
            this.SalvaFile.Location = new System.Drawing.Point(41, 316);
            this.SalvaFile.Name = "SalvaFile";
            this.SalvaFile.Size = new System.Drawing.Size(100, 23);
            this.SalvaFile.TabIndex = 19;
            this.SalvaFile.Text = "Salva su file";
            this.SalvaFile.UseVisualStyleBackColor = true;
            this.SalvaFile.Click += new System.EventHandler(this.SalvaFile_Click);
            // 
            // LeggiFile
            // 
            this.LeggiFile.Location = new System.Drawing.Point(41, 345);
            this.LeggiFile.Name = "LeggiFile";
            this.LeggiFile.Size = new System.Drawing.Size(100, 23);
            this.LeggiFile.TabIndex = 20;
            this.LeggiFile.Text = "Leggi da file";
            this.LeggiFile.UseVisualStyleBackColor = true;
            this.LeggiFile.Click += new System.EventHandler(this.LeggiFile_Click);
            // 
            // Minimo
            // 
            this.Minimo.Location = new System.Drawing.Point(41, 374);
            this.Minimo.Name = "Minimo";
            this.Minimo.Size = new System.Drawing.Size(100, 23);
            this.Minimo.TabIndex = 21;
            this.Minimo.Text = "Minimo";
            this.Minimo.UseVisualStyleBackColor = true;
            this.Minimo.Click += new System.EventHandler(this.Minimo_Click);
            // 
            // Massimo
            // 
            this.Massimo.Location = new System.Drawing.Point(41, 403);
            this.Massimo.Name = "Massimo";
            this.Massimo.Size = new System.Drawing.Size(100, 23);
            this.Massimo.TabIndex = 22;
            this.Massimo.Text = "Massimo";
            this.Massimo.UseVisualStyleBackColor = true;
            this.Massimo.Click += new System.EventHandler(this.Massimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Massimo);
            this.Controls.Add(this.Minimo);
            this.Controls.Add(this.LeggiFile);
            this.Controls.Add(this.SalvaFile);
            this.Controls.Add(this.invperc);
            this.Controls.Add(this.per);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.perc);
            this.Controls.Add(this.SommaPrezzi);
            this.Controls.Add(this.Ordina);
            this.Controls.Add(this.PrezzoMod);
            this.Controls.Add(this.InvioMod);
            this.Controls.Add(this.LabelMod);
            this.Controls.Add(this.InputMod);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.cancella);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.salva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancella;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.Button InvioMod;
        private System.Windows.Forms.Label LabelMod;
        private System.Windows.Forms.TextBox InputMod;
        private System.Windows.Forms.TextBox PrezzoMod;
        private System.Windows.Forms.Button Ordina;
        private System.Windows.Forms.Button SommaPrezzi;
        private System.Windows.Forms.Button perc;
        private System.Windows.Forms.TextBox percent;
        private System.Windows.Forms.Label per;
        private System.Windows.Forms.Button invperc;
        private System.Windows.Forms.Button SalvaFile;
        private System.Windows.Forms.Button LeggiFile;
        private System.Windows.Forms.Button Minimo;
        private System.Windows.Forms.Button Massimo;
    }
}

