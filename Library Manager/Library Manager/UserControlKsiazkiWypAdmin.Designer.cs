namespace Library_Manager
{
    partial class UserControlKsiazkiWypAdmin
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
            this.listViewKsiazkiWyp = new System.Windows.Forms.ListView();
            this.hIDKsiazka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIDUzytkownik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hTytuł = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hDataZwrotu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ksiązki wypożyczone";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewKsiazkiWyp
            // 
            this.listViewKsiazkiWyp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hIDKsiazka,
            this.hIDUzytkownik,
            this.hTytuł,
            this.hDataZwrotu});
            this.listViewKsiazkiWyp.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewKsiazkiWyp.HideSelection = false;
            this.listViewKsiazkiWyp.Location = new System.Drawing.Point(60, 180);
            this.listViewKsiazkiWyp.Name = "listViewKsiazkiWyp";
            this.listViewKsiazkiWyp.Size = new System.Drawing.Size(634, 350);
            this.listViewKsiazkiWyp.TabIndex = 1;
            this.listViewKsiazkiWyp.UseCompatibleStateImageBehavior = false;
            this.listViewKsiazkiWyp.View = System.Windows.Forms.View.Details;
            // 
            // hIDKsiazka
            // 
            this.hIDKsiazka.Text = "ID Książki";
            this.hIDKsiazka.Width = 100;
            // 
            // hIDUzytkownik
            // 
            this.hIDUzytkownik.Text = "ID Użytkownika";
            this.hIDUzytkownik.Width = 100;
            // 
            // hTytuł
            // 
            this.hTytuł.Text = "Tytuł";
            this.hTytuł.Width = 100;
            // 
            // hDataZwrotu
            // 
            this.hDataZwrotu.Text = "Data zwrotu";
            this.hDataZwrotu.Width = 100;
            // 
            // UserControlKsiazkiWypAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewKsiazkiWyp);
            this.Controls.Add(this.label1);
            this.Name = "UserControlKsiazkiWypAdmin";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader hIDKsiazka;
        private System.Windows.Forms.ColumnHeader hIDUzytkownik;
        private System.Windows.Forms.ColumnHeader hTytuł;
        private System.Windows.Forms.ColumnHeader hDataZwrotu;
        public System.Windows.Forms.ListView listViewKsiazkiWyp;
    }
}
