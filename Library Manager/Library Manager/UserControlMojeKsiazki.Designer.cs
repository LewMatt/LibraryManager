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
            this.btnOddajKsiazke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moje książki";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewMojeKsiazki
            // 
            this.listViewMojeKsiazki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hID,
            this.hTytul,
            this.hAutor,
            this.hDataZwrotu});
            this.listViewMojeKsiazki.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewMojeKsiazki.FullRowSelect = true;
            this.listViewMojeKsiazki.HideSelection = false;
            this.listViewMojeKsiazki.Location = new System.Drawing.Point(60, 180);
            this.listViewMojeKsiazki.Name = "listViewMojeKsiazki";
            this.listViewMojeKsiazki.Size = new System.Drawing.Size(634, 350);
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
            // btnOddajKsiazke
            // 
            this.btnOddajKsiazke.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOddajKsiazke.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOddajKsiazke.ForeColor = System.Drawing.Color.White;
            this.btnOddajKsiazke.Location = new System.Drawing.Point(737, 267);
            this.btnOddajKsiazke.Name = "btnOddajKsiazke";
            this.btnOddajKsiazke.Size = new System.Drawing.Size(120, 70);
            this.btnOddajKsiazke.TabIndex = 2;
            this.btnOddajKsiazke.Text = "Oddaj książkę";
            this.btnOddajKsiazke.UseVisualStyleBackColor = false;
            this.btnOddajKsiazke.Click += new System.EventHandler(this.btnOddajKsiazke_Click);
            // 
            // UserControlMojeKsiazki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnOddajKsiazke);
            this.Controls.Add(this.listViewMojeKsiazki);
            this.Controls.Add(this.label1);
            this.Name = "UserControlMojeKsiazki";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader hID;
        private System.Windows.Forms.ColumnHeader hTytul;
        private System.Windows.Forms.ColumnHeader hAutor;
        private System.Windows.Forms.ColumnHeader hDataZwrotu;
        public System.Windows.Forms.ListView listViewMojeKsiazki;
        private System.Windows.Forms.Button btnOddajKsiazke;
    }
}
