namespace Library_Manager
{
    partial class UserControlMojeKsiazki
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
            this.listViewMojeKsiazki = new System.Windows.Forms.ListView();
            this.hID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hTytul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hDataZwrotu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moje książki";
            // 
            // listViewMojeKsiazki
            // 
            this.listViewMojeKsiazki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hID,
            this.hTytul,
            this.hAutor,
            this.hDataZwrotu});
            this.listViewMojeKsiazki.HideSelection = false;
            this.listViewMojeKsiazki.Location = new System.Drawing.Point(71, 144);
            this.listViewMojeKsiazki.Name = "listViewMojeKsiazki";
            this.listViewMojeKsiazki.Size = new System.Drawing.Size(600, 350);
            this.listViewMojeKsiazki.TabIndex = 1;
            this.listViewMojeKsiazki.UseCompatibleStateImageBehavior = false;
            this.listViewMojeKsiazki.View = System.Windows.Forms.View.Details;
            // 
            // hID
            // 
            this.hID.Text = "ID";
            // 
            // hTytul
            // 
            this.hTytul.Text = "Tytuł";
            this.hTytul.Width = 200;
            // 
            // hAutor
            // 
            this.hAutor.Text = "Autor";
            this.hAutor.Width = 140;
            // 
            // hDataZwrotu
            // 
            this.hDataZwrotu.Text = "Data zwrotu";
            this.hDataZwrotu.Width = 80;
            // 
            // UserControlMojeKsiazki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewMojeKsiazki);
            this.Controls.Add(this.label1);
            this.Name = "UserControlMojeKsiazki";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader hID;
        private System.Windows.Forms.ColumnHeader hTytul;
        private System.Windows.Forms.ColumnHeader hAutor;
        private System.Windows.Forms.ColumnHeader hDataZwrotu;
        public System.Windows.Forms.ListView listViewMojeKsiazki;
    }
}
