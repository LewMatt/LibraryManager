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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka";
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
            this.listViewBiblioteka.HideSelection = false;
            this.listViewBiblioteka.Location = new System.Drawing.Point(82, 148);
            this.listViewBiblioteka.Name = "listViewBiblioteka";
            this.listViewBiblioteka.Size = new System.Drawing.Size(600, 350);
            this.listViewBiblioteka.TabIndex = 1;
            this.listViewBiblioteka.UseCompatibleStateImageBehavior = false;
            this.listViewBiblioteka.View = System.Windows.Forms.View.Details;
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
            // hIlosc
            // 
            this.hIlosc.Text = "Ilość dostępnych";
            this.hIlosc.Width = 100;
            // 
            // UserControlBiblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewBiblioteka);
            this.Controls.Add(this.label1);
            this.Name = "UserControlBiblioteka";
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
        private System.Windows.Forms.ColumnHeader hIlosc;
        public System.Windows.Forms.ListView listViewBiblioteka;
    }
}
