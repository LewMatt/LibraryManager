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
            // UserControlBibliotekaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
