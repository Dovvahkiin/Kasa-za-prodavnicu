using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kasa_za_prodavnicu
{
    public partial class UkupanPrometForm : Form
    {
        public UkupanPrometForm()
        {
            InitializeComponent();

        }
        string tekst = "";
        private void UkupanPrometForm_Load(object sender, EventArgs e)
        {

            if (File.Exists("Promet.dat")) // Ukoliko fajl postoji uradi sledeće
            {
                MessageBox.Show("Uspešna konekcija sa fajlom.", "Konekcija");

                StreamReader sr = new StreamReader("Promet.dat");
                while (tekst != null)
                {
                    tekst = sr.ReadLine(); // tekst dobija vrednost iščitanoj liniji
                    if (tekst != null)
                    {
                        lbPromet.Items.Add(tekst); // tekst iz fajla se upisuje u listBox
                    }
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("Fajl se kreira jer ne postoji.", "Kreiranje fajla");
                File.Create("Promet.dat");
            }


        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            File.Delete("Promet.dat"); // Brisanje fajla sa ukupnim prometom
            string putanjaDoFoldera = @"C:\\Kasa\\Kasa za prodavnicu\\bin\\Debug";
            string fajloviZaBrisanje = @"*Kupac*.txt";
            string[] fileList = System.IO.Directory.GetFiles(putanjaDoFoldera, fajloviZaBrisanje); //inicijalizacija putanje do foldera sa računima
            foreach(string file in fileList) // Za svaki string koji sadrži Kupac u filelisti odnosno u debug folderu 
            {
                System.IO.File.Delete(file); // briše postojeći fajl
            }
            Close();
        }
    }
}
