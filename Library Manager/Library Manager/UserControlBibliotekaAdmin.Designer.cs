namespace Library_Manager
{
    partial class UserControlBibliotekaAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listViewBibliotekaAdmin = new System.Windows.Forms.ListView();
            this.hID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hTytul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hGatunek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hDataWyd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajIloscKsiazek = new System.Windows.Forms.Button();
            this.textBoxIloscKsiazek = new System.Windows.Forms.TextBox();
            this.btnNowaKsiazka = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka admin";
            // 
            // listViewBibliotekaAdmin
            // 
            this.listViewBibliotekaAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hID,
            this.hTytul,
            this.hAutor,
            this.hGatunek,
            this.hDataWyd,
            this.hIle});
            this.listViewBibliotekaAdmin.FullRowSelect = true;
            this.listViewBibliotekaAdmin.HideSelection = false;
            this.listViewBibliotekaAdmin.Location = new System.Drawing.Point(79, 155);
            this.listViewBibliotekaAdmin.Name = "listViewBibliotekaAdmin";
            this.listViewBibliotekaAdmin.Size = new System.Drawing.Size(600, 350);
            this.listViewBibliotekaAdmin.TabIndex = 1;
            this.listViewBibliotekaAdmin.UseCompatibleStateImageBehavior = false;
            this.listViewBibliotekaAdmin.View = System.Windows.Forms.View.Details;
            // 
            // hID
            // 
            this.hID.Text = "ID";
            this.hID.Width = 30;
            // 
            // hTytul
            // 
            this.hTytul.Text = "Tytuł";
            this.hTytul.Width = 180;
            // 
            // hAutor
            // 
            this.hAutor.Text = "Autor";
            this.hAutor.Width = 130;
            // 
            // hGatunek
            // 
            this.hGatunek.Text = "Gatunek";
            this.hGatunek.Width = 80;
            // 
            // hDataWyd
            // 
            this.hDataWyd.Text = "Data wydania";
            this.hDataWyd.Width = 80;
            // 
            // hIle
            // 
            this.hIle.Text = "Ilość dostępnych";
            this.hIle.Width = 100;
            // 
            // btnDodajIloscKsiazek
            // 
            this.btnDodajIloscKsiazek.Location = new System.Drawing.Point(774, 219);
            this.btnDodajIloscKsiazek.Name = "btnDodajIloscKsiazek";
            this.btnDodajIloscKsiazek.Size = new System.Drawing.Size(100, 40);
            this.btnDodajIloscKsiazek.TabIndex = 2;
            this.btnDodajIloscKsiazek.Text = "Dodaj książki";
            this.btnDodajIloscKsiazek.UseVisualStyleBackColor = true;
            this.btnDodajIloscKsiazek.Click += new System.EventHandler(this.btnDodajIloscKsiazek_Click);
            // 
            // textBoxIloscKsiazek
            // 
            this.textBoxIloscKsiazek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIloscKsiazek.Location = new System.Drawing.Point(718, 219);
            this.textBoxIloscKsiazek.Name = "textBoxIloscKsiazek";
            this.textBoxIloscKsiazek.Size = new System.Drawing.Size(50, 38);
            this.textBoxIloscKsiazek.TabIndex = 3;
            // 
            // btnNowaKsiazka
            // 
            this.btnNowaKsiazka.Location = new System.Drawing.Point(718, 330);
            this.btnNowaKsiazka.Name = "btnNowaKsiazka";
            this.btnNowaKsiazka.Size = new System.Drawing.Size(150, 50);
            this.btnNowaKsiazka.TabIndex = 4;
            this.btnNowaKsiazka.Text = "Dodaj nową książkę";
            this.btnNowaKsiazka.UseVisualStyleBackColor = true;
            this.btnNowaKsiazka.Click += new System.EventHandler(this.btnNowaKsiazka_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(749, 455);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(100, 50);
            this.btnOdswiez.TabIndex = 5;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // UserControlBibliotekaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnNowaKsiazka);
            this.Controls.Add(this.textBoxIloscKsiazek);
            this.Controls.Add(this.btnDodajIloscKsiazek);
            this.Controls.Add(this.listViewBibliotekaAdmin);
            this.Controls.Add(this.label1);
            this.Name = "UserControlBibliotekaAdmin";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader hID;
        private System.Windows.Forms.ColumnHeader hTytul;
        private System.Windows.Forms.ColumnHeader hAutor;
        private System.Windows.Forms.ColumnHeader hGatunek;
        private System.Windows.Forms.ColumnHeader hDataWyd;
        private System.Windows.Forms.ColumnHeader hIle;
        public System.Windows.Forms.ListView listViewBibliotekaAdmin;
        private System.Windows.Forms.Button btnDodajIloscKsiazek;
        private System.Windows.Forms.TextBox textBoxIloscKsiazek;
        private System.Windows.Forms.Button btnNowaKsiazka;
        private System.Windows.Forms.Button btnOdswiez;
    }
}
