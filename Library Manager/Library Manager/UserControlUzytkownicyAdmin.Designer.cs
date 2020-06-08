namespace Library_Manager
{
    partial class UserControlUzytkownicyAdmin
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
            this.listViewUzytkownicy = new System.Windows.Forms.ListView();
            this.hID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hImie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hNazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label1.Text = "Użytkownicy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewUzytkownicy
            // 
            this.listViewUzytkownicy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hID,
            this.hImie,
            this.hNazwisko,
            this.hEmail,
            this.hTelefon});
            this.listViewUzytkownicy.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewUzytkownicy.HideSelection = false;
            this.listViewUzytkownicy.Location = new System.Drawing.Point(60, 180);
            this.listViewUzytkownicy.Name = "listViewUzytkownicy";
            this.listViewUzytkownicy.Size = new System.Drawing.Size(634, 350);
            this.listViewUzytkownicy.TabIndex = 1;
            this.listViewUzytkownicy.UseCompatibleStateImageBehavior = false;
            this.listViewUzytkownicy.View = System.Windows.Forms.View.Details;
            // 
            // hID
            // 
            this.hID.Text = "ID";
            this.hID.Width = 40;
            // 
            // hImie
            // 
            this.hImie.Text = "Imię";
            this.hImie.Width = 110;
            // 
            // hNazwisko
            // 
            this.hNazwisko.Text = "Nazwisko";
            this.hNazwisko.Width = 80;
            // 
            // hEmail
            // 
            this.hEmail.Text = "Email";
            this.hEmail.Width = 140;
            // 
            // hTelefon
            // 
            this.hTelefon.Text = "Telefon";
            this.hTelefon.Width = 100;
            // 
            // UserControlUzytkownicyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.listViewUzytkownicy);
            this.Controls.Add(this.label1);
            this.Name = "UserControlUzytkownicyAdmin";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listViewUzytkownicy;
        private System.Windows.Forms.ColumnHeader hID;
        private System.Windows.Forms.ColumnHeader hImie;
        private System.Windows.Forms.ColumnHeader hNazwisko;
        private System.Windows.Forms.ColumnHeader hEmail;
        private System.Windows.Forms.ColumnHeader hTelefon;
    }
}
