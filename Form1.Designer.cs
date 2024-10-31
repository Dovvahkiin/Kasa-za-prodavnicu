namespace Kasa_za_prodavnicu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.lbRacun = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzdavanje = new System.Windows.Forms.Button();
            this.btnNoviKupac = new System.Windows.Forms.Button();
            this.btnPromet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCena);
            this.groupBox1.Controls.Add(this.tbKolicina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNaziv);
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KUPOVINA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(80, 125);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(153, 20);
            this.tbCena.TabIndex = 4;
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(80, 80);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(153, 20);
            this.tbKolicina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Količina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(80, 31);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(153, 20);
            this.tbNaziv.TabIndex = 0;
            // 
            // lbRacun
            // 
            this.lbRacun.BackColor = System.Drawing.Color.White;
            this.lbRacun.ForeColor = System.Drawing.Color.Black;
            this.lbRacun.FormattingEnabled = true;
            this.lbRacun.Location = new System.Drawing.Point(28, 202);
            this.lbRacun.Name = "lbRacun";
            this.lbRacun.Size = new System.Drawing.Size(249, 316);
            this.lbRacun.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Transparent;
            this.btnDodaj.ForeColor = System.Drawing.Color.Black;
            this.btnDodaj.Location = new System.Drawing.Point(30, 29);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 59);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzdavanje
            // 
            this.btnIzdavanje.BackColor = System.Drawing.Color.Transparent;
            this.btnIzdavanje.ForeColor = System.Drawing.Color.Black;
            this.btnIzdavanje.Location = new System.Drawing.Point(30, 125);
            this.btnIzdavanje.Name = "btnIzdavanje";
            this.btnIzdavanje.Size = new System.Drawing.Size(137, 59);
            this.btnIzdavanje.TabIndex = 3;
            this.btnIzdavanje.Text = "Izdavanje računa";
            this.btnIzdavanje.UseVisualStyleBackColor = false;
            this.btnIzdavanje.Click += new System.EventHandler(this.btnIzdavanje_Click);
            // 
            // btnNoviKupac
            // 
            this.btnNoviKupac.BackColor = System.Drawing.Color.Transparent;
            this.btnNoviKupac.ForeColor = System.Drawing.Color.Black;
            this.btnNoviKupac.Location = new System.Drawing.Point(30, 221);
            this.btnNoviKupac.Name = "btnNoviKupac";
            this.btnNoviKupac.Size = new System.Drawing.Size(137, 59);
            this.btnNoviKupac.TabIndex = 4;
            this.btnNoviKupac.Text = "Novi kupac";
            this.btnNoviKupac.UseVisualStyleBackColor = false;
            this.btnNoviKupac.Click += new System.EventHandler(this.btnNoviKupac_Click);
            // 
            // btnPromet
            // 
            this.btnPromet.BackColor = System.Drawing.Color.Transparent;
            this.btnPromet.ForeColor = System.Drawing.Color.Black;
            this.btnPromet.Location = new System.Drawing.Point(30, 430);
            this.btnPromet.Name = "btnPromet";
            this.btnPromet.Size = new System.Drawing.Size(137, 59);
            this.btnPromet.TabIndex = 5;
            this.btnPromet.Text = "Ukupan promet";
            this.btnPromet.UseVisualStyleBackColor = false;
            this.btnPromet.Click += new System.EventHandler(this.btnPromet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnPromet);
            this.groupBox2.Controls.Add(this.btnNoviKupac);
            this.groupBox2.Controls.Add(this.btnIzdavanje);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.ForeColor = System.Drawing.Color.Orange;
            this.groupBox2.Location = new System.Drawing.Point(301, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 506);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcije";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(30, 326);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 59);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Štampanje računa";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Kasa_za_prodavnicu.Properties.Resources._123;
            this.ClientSize = new System.Drawing.Size(547, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbRacun);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbRacun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzdavanje;
        private System.Windows.Forms.Button btnNoviKupac;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPromet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}

