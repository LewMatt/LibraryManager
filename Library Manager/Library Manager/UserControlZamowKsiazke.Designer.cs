namespace Library_Manager
{
    partial class UserControlZamowKsiazke
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
            this.labelZamowKsiazke = new System.Windows.Forms.Label();
            this.listViewKsiazkiZamow = new System.Windows.Forms.ListView();
            this.hID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hTytul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hGatunek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hDataWyd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIleDos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnZamow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelZamowKsiazke
            // 
            this.labelZamowKsiazke.AutoSize = true;
            this.labelZamowKsiazke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZamowKsiazke.Location = new System.Drawing.Point(298, 66);
            this.labelZamowKsiazke.Name = "labelZamowKsiazke";
            this.labelZamowKsiazke.Size = new System.Drawing.Size(139, 24);
            this.labelZamowKsiazke.TabIndex = 0;
            this.labelZamowKsiazke.Text = "Zamów książkę";
            // 
            // listViewKsiazkiZamow
            // 
            this.listViewKsiazkiZamow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hID,
            this.hTytul,
            this.hAutor,
            this.hGatunek,
            this.hDataWyd,
            this.hIleDos});
            this.listViewKsiazkiZamow.FullRowSelect = true;
            this.listViewKsiazkiZamow.HideSelection = false;
            this.listViewKsiazkiZamow.Location = new System.Drawing.Point(59, 172);
            this.listViewKsiazkiZamow.Name = "listViewKsiazkiZamow";
            this.listViewKsiazkiZamow.Size = new System.Drawing.Size(570, 313);
            this.listViewKsiazkiZamow.TabIndex = 1;
            this.listViewKsiazkiZamow.UseCompatibleStateImageBehavior = false;
            this.listViewKsiazkiZamow.View = System.Windows.Forms.View.Details;
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
            // hIleDos
            // 
            this.hIleDos.Text = "Ilość dost.";
            this.hIleDos.Width = 64;
            // 
            // btnZamow
            // 
            this.btnZamow.Location = new System.Drawing.Point(667, 295);
            this.btnZamow.Name = "btnZamow";
            this.btnZamow.Size = new System.Drawing.Size(200, 50);
            this.btnZamow.TabIndex = 2;
            this.btnZamow.Text = "Zamów książkę.";
            this.btnZamow.UseVisualStyleBackColor = true;
            this.btnZamow.Click += new System.EventHandler(this.btnZamow_Click);
            // 
            // UserControlZamowKsiazke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZamow);
            this.Controls.Add(this.listViewKsiazkiZamow);
            this.Controls.Add(this.labelZamowKsiazke);
            this.Name = "UserControlZamowKsiazke";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader hID;
        private System.Windows.Forms.ColumnHeader hTytul;
        private System.Windows.Forms.ColumnHeader hAutor;
        private System.Windows.Forms.ColumnHeader hGatunek;
        private System.Windows.Forms.ColumnHeader hDataWyd;
        private System.Windows.Forms.ColumnHeader hIleDos;
        public System.Windows.Forms.ListView listViewKsiazkiZamow;
        public System.Windows.Forms.Label labelZamowKsiazke;
        private System.Windows.Forms.Button btnZamow;
    }
}
