﻿namespace Library_Manager
{
    partial class FormMenuAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnWyjscie = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUzytkownicy = new System.Windows.Forms.Button();
            this.btnKsiazkiWypozyczone = new System.Windows.Forms.Button();
            this.btnBiblioteka = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.userControlUzytkownicyAdmin1 = new Library_Manager.UserControlUzytkownicyAdmin();
            this.userControlKsiazkiWypAdmin1 = new Library_Manager.UserControlKsiazkiWypAdmin();
            this.userControlBibliotekaAdmin1 = new Library_Manager.UserControlBibliotekaAdmin();
            this.userControlMenuAdmin1 = new Library_Manager.UserControlMenuAdmin();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "menu admin";
            // 
            // btnWyjscie
            // 
            this.btnWyjscie.Location = new System.Drawing.Point(800, 0);
            this.btnWyjscie.Name = "btnWyjscie";
            this.btnWyjscie.Size = new System.Drawing.Size(100, 50);
            this.btnWyjscie.TabIndex = 1;
            this.btnWyjscie.Text = "Wyjście";
            this.btnWyjscie.UseVisualStyleBackColor = true;
            this.btnWyjscie.Click += new System.EventHandler(this.btnWyjscie_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUzytkownicy);
            this.panel1.Controls.Add(this.btnKsiazkiWypozyczone);
            this.panel1.Controls.Add(this.btnBiblioteka);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 2;
            // 
            // btnUzytkownicy
            // 
            this.btnUzytkownicy.Location = new System.Drawing.Point(0, 180);
            this.btnUzytkownicy.Name = "btnUzytkownicy";
            this.btnUzytkownicy.Size = new System.Drawing.Size(200, 50);
            this.btnUzytkownicy.TabIndex = 3;
            this.btnUzytkownicy.Text = "Użytkownicy";
            this.btnUzytkownicy.UseVisualStyleBackColor = true;
            this.btnUzytkownicy.Click += new System.EventHandler(this.btnUzytkownicy_Click);
            // 
            // btnKsiazkiWypozyczone
            // 
            this.btnKsiazkiWypozyczone.Location = new System.Drawing.Point(0, 120);
            this.btnKsiazkiWypozyczone.Name = "btnKsiazkiWypozyczone";
            this.btnKsiazkiWypozyczone.Size = new System.Drawing.Size(200, 50);
            this.btnKsiazkiWypozyczone.TabIndex = 2;
            this.btnKsiazkiWypozyczone.Text = "Książki wypożyczone";
            this.btnKsiazkiWypozyczone.UseVisualStyleBackColor = true;
            this.btnKsiazkiWypozyczone.Click += new System.EventHandler(this.btnKsiazkiWypozyczone_Click);
            // 
            // btnBiblioteka
            // 
            this.btnBiblioteka.Location = new System.Drawing.Point(0, 60);
            this.btnBiblioteka.Name = "btnBiblioteka";
            this.btnBiblioteka.Size = new System.Drawing.Size(200, 50);
            this.btnBiblioteka.TabIndex = 1;
            this.btnBiblioteka.Text = "Biblioteka";
            this.btnBiblioteka.UseVisualStyleBackColor = true;
            this.btnBiblioteka.Click += new System.EventHandler(this.btnBiblioteka_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 50);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnWyjscie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 50);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnWyloguj);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 650);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 50);
            this.panel3.TabIndex = 4;
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.Location = new System.Drawing.Point(800, 0);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(100, 50);
            this.btnWyloguj.TabIndex = 2;
            this.btnWyloguj.Text = "Wyloguj";
            this.btnWyloguj.UseVisualStyleBackColor = true;
            this.btnWyloguj.Click += new System.EventHandler(this.btnWyloguj_Click);
            // 
            // userControlUzytkownicyAdmin1
            // 
            this.userControlUzytkownicyAdmin1.Location = new System.Drawing.Point(200, 50);
            this.userControlUzytkownicyAdmin1.Name = "userControlUzytkownicyAdmin1";
            this.userControlUzytkownicyAdmin1.Size = new System.Drawing.Size(900, 600);
            this.userControlUzytkownicyAdmin1.TabIndex = 8;
            // 
            // userControlKsiazkiWypAdmin1
            // 
            this.userControlKsiazkiWypAdmin1.Location = new System.Drawing.Point(200, 50);
            this.userControlKsiazkiWypAdmin1.Name = "userControlKsiazkiWypAdmin1";
            this.userControlKsiazkiWypAdmin1.Size = new System.Drawing.Size(900, 600);
            this.userControlKsiazkiWypAdmin1.TabIndex = 7;
            // 
            // userControlBibliotekaAdmin1
            // 
            this.userControlBibliotekaAdmin1.Location = new System.Drawing.Point(200, 50);
            this.userControlBibliotekaAdmin1.Name = "userControlBibliotekaAdmin1";
            this.userControlBibliotekaAdmin1.Size = new System.Drawing.Size(900, 600);
            this.userControlBibliotekaAdmin1.TabIndex = 6;
            // 
            // userControlMenuAdmin1
            // 
            this.userControlMenuAdmin1.Location = new System.Drawing.Point(200, 50);
            this.userControlMenuAdmin1.Name = "userControlMenuAdmin1";
            this.userControlMenuAdmin1.Size = new System.Drawing.Size(900, 600);
            this.userControlMenuAdmin1.TabIndex = 5;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.userControlUzytkownicyAdmin1);
            this.Controls.Add(this.userControlKsiazkiWypAdmin1);
            this.Controls.Add(this.userControlBibliotekaAdmin1);
            this.Controls.Add(this.userControlMenuAdmin1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuAdmin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWyjscie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUzytkownicy;
        private System.Windows.Forms.Button btnKsiazkiWypozyczone;
        private System.Windows.Forms.Button btnBiblioteka;
        private UserControlMenuAdmin userControlMenuAdmin1;
        private UserControlBibliotekaAdmin userControlBibliotekaAdmin1;
        private UserControlKsiazkiWypAdmin userControlKsiazkiWypAdmin1;
        private UserControlUzytkownicyAdmin userControlUzytkownicyAdmin1;
        private System.Windows.Forms.Button btnWyloguj;
    }
}