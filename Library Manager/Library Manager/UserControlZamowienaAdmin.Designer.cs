﻿namespace Library_Manager
{
    partial class UserControlZamowienaAdmin
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
            this.listViewZamowienia = new System.Windows.Forms.ListView();
            this.hIDUzytkownika = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIDKsiazki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajDoBib = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(376, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zamówienia";
            // 
            // listViewZamowienia
            // 
            this.listViewZamowienia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hIDUzytkownika,
            this.hIDKsiazki});
            this.listViewZamowienia.HideSelection = false;
            this.listViewZamowienia.Location = new System.Drawing.Point(347, 183);
            this.listViewZamowienia.Name = "listViewZamowienia";
            this.listViewZamowienia.Size = new System.Drawing.Size(188, 294);
            this.listViewZamowienia.TabIndex = 1;
            this.listViewZamowienia.UseCompatibleStateImageBehavior = false;
            this.listViewZamowienia.View = System.Windows.Forms.View.Details;
            // 
            // hIDUzytkownika
            // 
            this.hIDUzytkownika.Text = "ID Użytkownika";
            this.hIDUzytkownika.Width = 99;
            // 
            // hIDKsiazki
            // 
            this.hIDKsiazki.Text = "ID Książki";
            this.hIDKsiazki.Width = 81;
            // 
            // btnDodajDoBib
            // 
            this.btnDodajDoBib.Location = new System.Drawing.Point(614, 285);
            this.btnDodajDoBib.Name = "btnDodajDoBib";
            this.btnDodajDoBib.Size = new System.Drawing.Size(169, 68);
            this.btnDodajDoBib.TabIndex = 2;
            this.btnDodajDoBib.Text = "Dodaj do biblioteki.";
            this.btnDodajDoBib.UseVisualStyleBackColor = true;
            // 
            // UserControlZamowienaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajDoBib);
            this.Controls.Add(this.listViewZamowienia);
            this.Controls.Add(this.label1);
            this.Name = "UserControlZamowienaAdmin";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader hIDUzytkownika;
        private System.Windows.Forms.ColumnHeader hIDKsiazki;
        private System.Windows.Forms.Button btnDodajDoBib;
        public System.Windows.Forms.ListView listViewZamowienia;
    }
}
