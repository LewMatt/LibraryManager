namespace Library_Manager
{
    partial class FormMenu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnZamowKsiazke = new System.Windows.Forms.Button();
            this.btnMojeDane = new System.Windows.Forms.Button();
            this.btnMojeKsiazki = new System.Windows.Forms.Button();
            this.btnBiblioteka = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControlMojeDane1 = new Library_Manager.UserControlMojeDane();
            this.userControlMojeKsiazki1 = new Library_Manager.UserControlMojeKsiazki();
            this.userControlBiblioteka1 = new Library_Manager.UserControlBiblioteka();
            this.userControlMenu1 = new Library_Manager.UserControlMenu();
            this.userControlZamowKsiazke1 = new Library_Manager.UserControlZamowKsiazke();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(580, 75);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(74, 25);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "MENU";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(800, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnZamowKsiazke);
            this.panel1.Controls.Add(this.btnMojeDane);
            this.panel1.Controls.Add(this.btnMojeKsiazki);
            this.panel1.Controls.Add(this.btnBiblioteka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 50);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnZamowKsiazke
            // 
            this.btnZamowKsiazke.Location = new System.Drawing.Point(0, 240);
            this.btnZamowKsiazke.Name = "btnZamowKsiazke";
            this.btnZamowKsiazke.Size = new System.Drawing.Size(200, 50);
            this.btnZamowKsiazke.TabIndex = 3;
            this.btnZamowKsiazke.Text = "Zamów książkę";
            this.btnZamowKsiazke.UseVisualStyleBackColor = true;
            this.btnZamowKsiazke.Click += new System.EventHandler(this.btnZamowKsiazke_Click);
            // 
            // btnMojeDane
            // 
            this.btnMojeDane.Location = new System.Drawing.Point(0, 180);
            this.btnMojeDane.Name = "btnMojeDane";
            this.btnMojeDane.Size = new System.Drawing.Size(200, 50);
            this.btnMojeDane.TabIndex = 2;
            this.btnMojeDane.Text = "Moje dane";
            this.btnMojeDane.UseVisualStyleBackColor = true;
            this.btnMojeDane.Click += new System.EventHandler(this.btnMojeDane_Click);
            // 
            // btnMojeKsiazki
            // 
            this.btnMojeKsiazki.Location = new System.Drawing.Point(0, 120);
            this.btnMojeKsiazki.Name = "btnMojeKsiazki";
            this.btnMojeKsiazki.Size = new System.Drawing.Size(200, 50);
            this.btnMojeKsiazki.TabIndex = 1;
            this.btnMojeKsiazki.Text = "Moje książki";
            this.btnMojeKsiazki.UseVisualStyleBackColor = true;
            this.btnMojeKsiazki.Click += new System.EventHandler(this.btnMojeKsiazki_Click);
            // 
            // btnBiblioteka
            // 
            this.btnBiblioteka.Location = new System.Drawing.Point(0, 60);
            this.btnBiblioteka.Name = "btnBiblioteka";
            this.btnBiblioteka.Size = new System.Drawing.Size(200, 50);
            this.btnBiblioteka.TabIndex = 0;
            this.btnBiblioteka.Text = "Biblioteka";
            this.btnBiblioteka.UseVisualStyleBackColor = true;
            this.btnBiblioteka.Click += new System.EventHandler(this.btnBiblioteka_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 50);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 650);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 50);
            this.panel3.TabIndex = 4;
            // 
            // userControlMojeDane1
            // 
            this.userControlMojeDane1.Location = new System.Drawing.Point(200, 50);
            this.userControlMojeDane1.Name = "userControlMojeDane1";
            this.userControlMojeDane1.Size = new System.Drawing.Size(900, 600);
            this.userControlMojeDane1.TabIndex = 8;
            // 
            // userControlMojeKsiazki1
            // 
            this.userControlMojeKsiazki1.Location = new System.Drawing.Point(200, 50);
            this.userControlMojeKsiazki1.Name = "userControlMojeKsiazki1";
            this.userControlMojeKsiazki1.Size = new System.Drawing.Size(900, 600);
            this.userControlMojeKsiazki1.TabIndex = 7;
            // 
            // userControlBiblioteka1
            // 
            this.userControlBiblioteka1.Location = new System.Drawing.Point(200, 50);
            this.userControlBiblioteka1.Name = "userControlBiblioteka1";
            this.userControlBiblioteka1.Size = new System.Drawing.Size(900, 600);
            this.userControlBiblioteka1.TabIndex = 6;
            // 
            // userControlMenu1
            // 
            this.userControlMenu1.Location = new System.Drawing.Point(200, 50);
            this.userControlMenu1.Name = "userControlMenu1";
            this.userControlMenu1.Size = new System.Drawing.Size(900, 600);
            this.userControlMenu1.TabIndex = 5;
            // 
            // userControlZamowKsiazke1
            // 
            this.userControlZamowKsiazke1.Location = new System.Drawing.Point(200, 50);
            this.userControlZamowKsiazke1.Name = "userControlZamowKsiazke1";
            this.userControlZamowKsiazke1.Size = new System.Drawing.Size(900, 600);
            this.userControlZamowKsiazke1.TabIndex = 9;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.userControlZamowKsiazke1);
            this.Controls.Add(this.userControlMojeDane1);
            this.Controls.Add(this.userControlMojeKsiazki1);
            this.Controls.Add(this.userControlBiblioteka1);
            this.Controls.Add(this.userControlMenu1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZamowKsiazke;
        private System.Windows.Forms.Button btnMojeDane;
        private System.Windows.Forms.Button btnMojeKsiazki;
        private System.Windows.Forms.Button btnBiblioteka;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private UserControlMenu userControlMenu1;
        private UserControlBiblioteka userControlBiblioteka1;
        private System.Windows.Forms.Button btnMenu;
        private UserControlMojeKsiazki userControlMojeKsiazki1;
        private UserControlMojeDane userControlMojeDane1;
        private UserControlZamowKsiazke userControlZamowKsiazke1;
    }
}