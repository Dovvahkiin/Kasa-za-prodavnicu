// By Spartanac

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Drawing.Printing;


namespace Kasa_za_prodavnicu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PrintDocument printDocument1 = new PrintDocument();
        private string stringToPrint;

        double cena = 0;
        int uplacenNovac = 0;
        double kusur = 0;
        double popust = 0;
        double popustt = 0;
        double scena = 0;
        string doc;
        double promet = 0;
        double ukupanPromet = 0;
        int i = 0;
        string konacnoImeFajla1;
        string imeFajla2;

        private void Form1_Load(object sender, EventArgs e)
        {
            tbNaziv.Enabled = true;
            tbKolicina.Enabled = true;
            tbCena.Enabled = true;
            btnDodaj.Enabled = true;
            btnIzdavanje.Enabled = false;
            btnNoviKupac.Enabled = false;
            btnPrint.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            tbNaziv.Enabled = true;
            tbKolicina.Enabled = true;
            tbCena.Enabled = true;
            btnDodaj.Enabled = true;
            btnIzdavanje.Enabled = true;
            btnNoviKupac.Enabled = true;
            btnPromet.Enabled = false;
            string naziv = tbNaziv.Text;
            int kolicina = Convert.ToInt32(tbKolicina.Text);
            double ccena = Convert.ToDouble(tbCena.Text);
            cena = cena + (ccena * kolicina);
            lbRacun.Items.Add(naziv + "     " + kolicina + " komada" + "     " + kolicina * ccena + " RSD" + "     " + "(" + ccena + " RSD" + ")");
            tbNaziv.Text = "";
            tbCena.Text = "";
            tbKolicina.Text = "";
        }

        private void btnIzdavanje_Click(object sender, EventArgs e)
        {
            uplacenNovac = Convert.ToInt32(Interaction.InputBox("Unesite sumu novca kojom plaćate:\n Račun iznosi: " + cena + " RSD.", "Uplata", "0", -1)); // inputBox iz visualBasic-a
            lbRacun.Items.Add("-------------------------------------------------");
            if (cena >= 2000 && cena < 4000)
                popust = 0.05;
            else if (cena >= 4000 && cena < 8000)
                popust = 0.10;
            else if (cena >= 8000 && cena < 12000)
                popust = 0.15;
            else if (cena >= 12000)
                popust = 0.20;
            else popust = 0;
            popustt = cena * popust;
            scena = cena - popustt;
            lbRacun.Items.Add("Račun iznosi:  " + cena + " RSD");
            lbRacun.Items.Add(" ");
            lbRacun.Items.Add(String.Format("Bonus popust: {0:P2}.", popust)); // {0:P2} - procenat , P1 određuje decimalu
            lbRacun.Items.Add("Ukupno:  " + scena + " RSD");
            lbRacun.Items.Add("------------------------");
            lbRacun.Items.Add("Uplaceno: " + uplacenNovac + " RSD");
            kusur = uplacenNovac - scena;
            lbRacun.Items.Add("------------------------");
            lbRacun.Items.Add("Kusur: " + kusur + " RSD");
            promet = uplacenNovac - kusur;
            doc = "Isplata kupca: " + promet + " RSD";
            using (StreamWriter up = new StreamWriter("Promet.dat", true))
                up.WriteLine(doc);
            ukupanPromet = ukupanPromet + promet;
            StreamWriter sw = new StreamWriter("Promet.dat", true);
            sw.WriteLine("--------------\nUkupan promet je: " + ukupanPromet + ".");

            //   Dodavanje posebnog fajla za svaki račun   //
            string ekstenzija = ".txt"; // određivanje ekstenzije fajla koji će se ponavljati
            string imeFajla = "Kupac "; // određivanje glavnog imena fajla koji će se ponavljati
            string tempIme = imeFajla; // privremeno ime dobija glavno ime fajla dok se vrši konverzija
            while (System.IO.File.Exists(tempIme + ekstenzija)) 
            {
                i++;
                tempIme = imeFajla + i;
            } // za svako i++ odnosno za svaki broj prethodnog fajla dodavaće se +1. Npr. Kupac, pa Kupac1, pa Kupac2...
            string konacnoImeFajla = tempIme + ekstenzija; // konačno ime fajla u formatu (ime sa bor


            // ------------------------------------------- //
            konacnoImeFajla1 = konacnoImeFajla;
            imeFajla2 = imeFajla;

            StreamWriter racun = new StreamWriter(konacnoImeFajla);
            foreach (var item in lbRacun.Items)
            {
                racun.WriteLine(item);
            }
            racun.Close();

            tbNaziv.Enabled = false;
            tbKolicina.Enabled = false;
            tbCena.Enabled = false;
            btnDodaj.Enabled = false;
            btnIzdavanje.Enabled = false;
            btnNoviKupac.Enabled = true;
            btnPromet.Enabled = true;
            btnPrint.Enabled = true;


        }

        private void btnNoviKupac_Click(object sender, EventArgs e)
        {
            lbRacun.Items.Clear();
            cena = 0;
            uplacenNovac = 0;
            kusur = 0;
            popust = 0;
            popustt = 0;
            scena = 0;
            tbNaziv.Text = "";
            tbKolicina.Text = "";
            tbCena.Text = "";
            tbNaziv.Enabled = true;
            tbKolicina.Enabled = true;
            tbCena.Enabled = true;
            btnDodaj.Enabled = true;
            btnIzdavanje.Enabled = false;
            btnPrint.Enabled = false;
            btnNoviKupac.Enabled = false;
            btnPromet.Enabled = true;

        }

        private void btnPromet_Click(object sender, EventArgs e)
        {

            UkupanPrometForm form2 = new UkupanPrometForm();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void DocumentInfo()
        {
            printDocument1.DocumentName = imeFajla2;
            using (FileStream stream = new FileStream(konacnoImeFajla1, FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                stringToPrint = reader.ReadToEnd();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DocumentInfo();
            printDocument1.Print();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;
            e.Graphics.MeasureString(stringToPrint, this.Font,
              e.MarginBounds.Size, StringFormat.GenericTypographic,
              out charactersOnPage, out linesPerPage);

            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
              e.MarginBounds, StringFormat.GenericTypographic);

            stringToPrint = stringToPrint.Substring(charactersOnPage);
            e.HasMorePages = (stringToPrint.Length > 0);

        }


        /*******************************************************************/
        /*********** Božidar Tovarnicki |2020| BogaTrade D.O.O. ************/
        /*******************************************************************/
    }
    }

