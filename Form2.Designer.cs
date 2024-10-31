namespace Kasa_za_prodavnicu
{
    partial class UkupanPrometForm
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
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.lbPromet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(84, 415);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(95, 35);
            this.btnIzlaz.TabIndex = 0;
            this.btnIzlaz.Text = "lzlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // lbPromet
            // 
            this.lbPromet.FormattingEnabled = true;
            this.lbPromet.Location = new System.Drawing.Point(43, 56);
            this.lbPromet.Name = "lbPromet";
            this.lbPromet.Size = new System.Drawing.Size(326, 316);
            this.lbPromet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ukupan promet prodavnice";
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(206, 415);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(95, 35);
            this.btnBrisanje.TabIndex = 3;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // UkupanPrometForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(412, 462);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPromet);
            this.Controls.Add(this.btnIzlaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UkupanPrometForm";
            this.Text = "Ukupan promet";
            this.Load += new System.EventHandler(this.UkupanPrometForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.ListBox lbPromet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrisanje;
    }
}