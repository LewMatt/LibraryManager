namespace Library_Manager
{
    partial class FormNowaKsiazka
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
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.lblNowa = new System.Windows.Forms.Label();
            this.lblTytul = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblGatunek = new System.Windows.Forms.Label();
            this.lblDataWyd = new System.Windows.Forms.Label();
            this.lblIlosc = new System.Windows.Forms.Label();
            this.textBoxTytul = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxGatunek = new System.Windows.Forms.TextBox();
            this.textBoxDataWyd = new System.Windows.Forms.TextBox();
            this.textBoxIlosc = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(988, 638);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 50);
            this.btnAnuluj.TabIndex = 0;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // lblNowa
            // 
            this.lblNowa.AutoSize = true;
            this.lblNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNowa.Location = new System.Drawing.Point(458, 46);
            this.lblNowa.Name = "lblNowa";
            this.lblNowa.Size = new System.Drawing.Size(106, 20);
            this.lblNowa.TabIndex = 1;
            this.lblNowa.Text = "Nowa książka";
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytul.Location = new System.Drawing.Point(244, 154);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(65, 25);
            this.lblTytul.TabIndex = 2;
            this.lblTytul.Text = "Tytuł:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAutor.Location = new System.Drawing.Point(240, 221);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(69, 25);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor:";
            // 
            // lblGatunek
            // 
            this.lblGatunek.AutoSize = true;
            this.lblGatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGatunek.Location = new System.Drawing.Point(210, 278);
            this.lblGatunek.Name = "lblGatunek";
            this.lblGatunek.Size = new System.Drawing.Size(99, 25);
            this.lblGatunek.TabIndex = 4;
            this.lblGatunek.Text = "Gatunek:";
            // 
            // lblDataWyd
            // 
            this.lblDataWyd.AutoSize = true;
            this.lblDataWyd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataWyd.Location = new System.Drawing.Point(161, 336);
            this.lblDataWyd.Name = "lblDataWyd";
            this.lblDataWyd.Size = new System.Drawing.Size(148, 25);
            this.lblDataWyd.TabIndex = 5;
            this.lblDataWyd.Text = "Data wydania:";
            // 
            // lblIlosc
            // 
            this.lblIlosc.AutoSize = true;
            this.lblIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIlosc.Location = new System.Drawing.Point(247, 398);
            this.lblIlosc.Name = "lblIlosc";
            this.lblIlosc.Size = new System.Drawing.Size(62, 25);
            this.lblIlosc.TabIndex = 6;
            this.lblIlosc.Text = "Ilość:";
            // 
            // textBoxTytul
            // 
            this.textBoxTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTytul.Location = new System.Drawing.Point(337, 151);
            this.textBoxTytul.Name = "textBoxTytul";
            this.textBoxTytul.Size = new System.Drawing.Size(400, 31);
            this.textBoxTytul.TabIndex = 7;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAutor.Location = new System.Drawing.Point(337, 218);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(400, 31);
            this.textBoxAutor.TabIndex = 8;
            // 
            // textBoxGatunek
            // 
            this.textBoxGatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGatunek.Location = new System.Drawing.Point(337, 275);
            this.textBoxGatunek.Name = "textBoxGatunek";
            this.textBoxGatunek.Size = new System.Drawing.Size(400, 31);
            this.textBoxGatunek.TabIndex = 9;
            // 
            // textBoxDataWyd
            // 
            this.textBoxDataWyd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDataWyd.Location = new System.Drawing.Point(337, 333);
            this.textBoxDataWyd.Name = "textBoxDataWyd";
            this.textBoxDataWyd.Size = new System.Drawing.Size(400, 31);
            this.textBoxDataWyd.TabIndex = 10;
            // 
            // textBoxIlosc
            // 
            this.textBoxIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIlosc.Location = new System.Drawing.Point(337, 395);
            this.textBoxIlosc.Name = "textBoxIlosc";
            this.textBoxIlosc.Size = new System.Drawing.Size(400, 31);
            this.textBoxIlosc.TabIndex = 11;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(433, 510);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(200, 50);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj książkę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormNowaKsiazka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.textBoxIlosc);
            this.Controls.Add(this.textBoxDataWyd);
            this.Controls.Add(this.textBoxGatunek);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTytul);
            this.Controls.Add(this.lblIlosc);
            this.Controls.Add(this.lblDataWyd);
            this.Controls.Add(this.lblGatunek);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTytul);
            this.Controls.Add(this.lblNowa);
            this.Controls.Add(this.btnAnuluj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNowaKsiazka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNowaKsiazka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label lblNowa;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblGatunek;
        private System.Windows.Forms.Label lblDataWyd;
        private System.Windows.Forms.Label lblIlosc;
        private System.Windows.Forms.TextBox textBoxTytul;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxGatunek;
        private System.Windows.Forms.TextBox textBoxDataWyd;
        private System.Windows.Forms.TextBox textBoxIlosc;
        private System.Windows.Forms.Button btnDodaj;
    }
}