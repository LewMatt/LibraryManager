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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAnuluj.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.ForeColor = System.Drawing.Color.White;
            this.btnAnuluj.Location = new System.Drawing.Point(1000, 0);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 50);
            this.btnAnuluj.TabIndex = 0;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = false;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // lblNowa
            // 
            this.lblNowa.BackColor = System.Drawing.Color.Transparent;
            this.lblNowa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNowa.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNowa.ForeColor = System.Drawing.Color.White;
            this.lblNowa.Location = new System.Drawing.Point(0, 0);
            this.lblNowa.Name = "lblNowa";
            this.lblNowa.Size = new System.Drawing.Size(1100, 120);
            this.lblNowa.TabIndex = 1;
            this.lblNowa.Text = "Nowa książka";
            this.lblNowa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.BackColor = System.Drawing.Color.Transparent;
            this.lblTytul.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytul.ForeColor = System.Drawing.Color.White;
            this.lblTytul.Location = new System.Drawing.Point(266, 151);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(80, 37);
            this.lblTytul.TabIndex = 2;
            this.lblTytul.Text = "Tytuł:";
            this.lblTytul.Visible = false;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAutor.ForeColor = System.Drawing.Color.White;
            this.lblAutor.Location = new System.Drawing.Point(261, 220);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(85, 37);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor:";
            this.lblAutor.Visible = false;
            // 
            // lblGatunek
            // 
            this.lblGatunek.AutoSize = true;
            this.lblGatunek.BackColor = System.Drawing.Color.Transparent;
            this.lblGatunek.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblGatunek.ForeColor = System.Drawing.Color.White;
            this.lblGatunek.Location = new System.Drawing.Point(235, 290);
            this.lblGatunek.Name = "lblGatunek";
            this.lblGatunek.Size = new System.Drawing.Size(111, 37);
            this.lblGatunek.TabIndex = 4;
            this.lblGatunek.Text = "Gatunek:";
            this.lblGatunek.Visible = false;
            // 
            // lblDataWyd
            // 
            this.lblDataWyd.AutoSize = true;
            this.lblDataWyd.BackColor = System.Drawing.Color.Transparent;
            this.lblDataWyd.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDataWyd.ForeColor = System.Drawing.Color.White;
            this.lblDataWyd.Location = new System.Drawing.Point(175, 360);
            this.lblDataWyd.Name = "lblDataWyd";
            this.lblDataWyd.Size = new System.Drawing.Size(170, 37);
            this.lblDataWyd.TabIndex = 5;
            this.lblDataWyd.Text = "Data wydania:";
            this.lblDataWyd.Visible = false;
            // 
            // lblIlosc
            // 
            this.lblIlosc.AutoSize = true;
            this.lblIlosc.BackColor = System.Drawing.Color.Transparent;
            this.lblIlosc.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblIlosc.ForeColor = System.Drawing.Color.White;
            this.lblIlosc.Location = new System.Drawing.Point(278, 430);
            this.lblIlosc.Name = "lblIlosc";
            this.lblIlosc.Size = new System.Drawing.Size(68, 37);
            this.lblIlosc.TabIndex = 6;
            this.lblIlosc.Text = "Ilość:";
            this.lblIlosc.Visible = false;
            // 
            // textBoxTytul
            // 
            this.textBoxTytul.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTytul.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTytul.Location = new System.Drawing.Point(350, 150);
            this.textBoxTytul.Name = "textBoxTytul";
            this.textBoxTytul.Size = new System.Drawing.Size(400, 36);
            this.textBoxTytul.TabIndex = 7;
            this.textBoxTytul.Text = "Tytuł";
            this.textBoxTytul.Enter += new System.EventHandler(this.textBoxTytul_Enter);
            this.textBoxTytul.Leave += new System.EventHandler(this.textBoxTytul_Leave);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAutor.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAutor.Location = new System.Drawing.Point(350, 220);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(400, 36);
            this.textBoxAutor.TabIndex = 8;
            this.textBoxAutor.Text = "Autor";
            this.textBoxAutor.Enter += new System.EventHandler(this.textBoxAutor_Enter);
            this.textBoxAutor.Leave += new System.EventHandler(this.textBoxAutor_Leave);
            // 
            // textBoxGatunek
            // 
            this.textBoxGatunek.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGatunek.ForeColor = System.Drawing.Color.Gray;
            this.textBoxGatunek.Location = new System.Drawing.Point(350, 290);
            this.textBoxGatunek.Name = "textBoxGatunek";
            this.textBoxGatunek.Size = new System.Drawing.Size(400, 36);
            this.textBoxGatunek.TabIndex = 9;
            this.textBoxGatunek.Text = "Gatunek";
            this.textBoxGatunek.Enter += new System.EventHandler(this.textBoxGatunek_Enter);
            this.textBoxGatunek.Leave += new System.EventHandler(this.textBoxGatunek_Leave);
            // 
            // textBoxDataWyd
            // 
            this.textBoxDataWyd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDataWyd.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDataWyd.Location = new System.Drawing.Point(350, 360);
            this.textBoxDataWyd.Name = "textBoxDataWyd";
            this.textBoxDataWyd.Size = new System.Drawing.Size(400, 36);
            this.textBoxDataWyd.TabIndex = 10;
            this.textBoxDataWyd.Text = "Data wydania";
            this.textBoxDataWyd.Enter += new System.EventHandler(this.textBoxDataWyd_Enter);
            this.textBoxDataWyd.Leave += new System.EventHandler(this.textBoxDataWyd_Leave);
            // 
            // textBoxIlosc
            // 
            this.textBoxIlosc.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIlosc.ForeColor = System.Drawing.Color.Gray;
            this.textBoxIlosc.Location = new System.Drawing.Point(350, 430);
            this.textBoxIlosc.Name = "textBoxIlosc";
            this.textBoxIlosc.Size = new System.Drawing.Size(400, 36);
            this.textBoxIlosc.TabIndex = 11;
            this.textBoxIlosc.Text = "Ilość";
            this.textBoxIlosc.Enter += new System.EventHandler(this.textBoxIlosc_Enter);
            this.textBoxIlosc.Leave += new System.EventHandler(this.textBoxIlosc_Leave);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDodaj.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(425, 530);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(250, 50);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj książkę";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAnuluj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 13;
            // 
            // FormNowaKsiazka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Manager.Properties.Resources.book_photo_1100_700;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panel1);
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
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNowaKsiazka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNowaKsiazka";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
    }
}