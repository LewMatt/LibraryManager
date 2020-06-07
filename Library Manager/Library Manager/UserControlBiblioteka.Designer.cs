namespace Library_Manager
{
    partial class UserControlBiblioteka
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
            this.listViewBiblioteka = new System.Windows.Forms.ListView();
            this.hID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hTytul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hGatunek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hDataWyd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnWypozyczKsiazke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 150);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewBiblioteka
            // 
            this.listViewBiblioteka.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hID,
            this.hTytul,
            this.hAutor,
            this.hGatunek,
            this.hDataWyd,
            this.hIlosc});
            this.listViewBiblioteka.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewBiblioteka.FullRowSelect = true;
            this.listViewBiblioteka.HideSelection = false;
            this.listViewBiblioteka.Location = new System.Drawing.Point(60, 180);
            this.listViewBiblioteka.Name = "listViewBiblioteka";
            this.listViewBiblioteka.Size = new System.Drawing.Size(634, 350);
            this.listViewBiblioteka.TabIndex = 1;
            this.listViewBiblioteka.UseCompatibleStateImageBehavior = false;
            this.listViewBiblioteka.View = System.Windows.Forms.View.Details;
            // 
            // hID
            // 
            this.hID.Text = "ID";
            this.hID.Width = 34;
            // 
            // hTytul
            // 
            this.hTytul.Text = "Tytuł";
            this.hTytul.Width = 183;
            // 
            // hAutor
            // 
            this.hAutor.Text = "Autor";
            this.hAutor.Width = 129;
            // 
            // hGatunek
            // 
            this.hGatunek.Text = "Gatunek";
            this.hGatunek.Width = 95;
            // 
            // hDataWyd
            // 
            this.hDataWyd.Text = "Data wydania";
            this.hDataWyd.Width = 89;
            // 
            // hIlosc
            // 
            this.hIlosc.Text = "Ilość dostępnych";
            this.hIlosc.Width = 109;
            // 
            // btnWypozyczKsiazke
            // 
            this.btnWypozyczKsiazke.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWypozyczKsiazke.Location = new System.Drawing.Point(738, 277);
            this.btnWypozyczKsiazke.Name = "btnWypozyczKsiazke";
            this.btnWypozyczKsiazke.Size = new System.Drawing.Size(120, 70);
            this.btnWypozyczKsiazke.TabIndex = 2;
            this.btnWypozyczKsiazke.Text = "Wypożycz książkę";
            this.btnWypozyczKsiazke.UseVisualStyleBackColor = true;
            this.btnWypozyczKsiazke.Click += new System.EventHandler(this.btnWypozyczKsiazke_Click);
            // 
            // UserControlBiblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnWypozyczKsiazke);
            this.Controls.Add(this.listViewBiblioteka);
            this.Controls.Add(this.label1);
            this.Name = "UserControlBiblioteka";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader hID;
        private System.Windows.Forms.ColumnHeader hTytul;
        private System.Windows.Forms.ColumnHeader hAutor;
        private System.Windows.Forms.ColumnHeader hGatunek;
        private System.Windows.Forms.ColumnHeader hDataWyd;
        private System.Windows.Forms.ColumnHeader hIlosc;
        public System.Windows.Forms.ListView listViewBiblioteka;
        private System.Windows.Forms.Button btnWypozyczKsiazke;
    }
}
