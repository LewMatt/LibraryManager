﻿namespace Library_Manager
{
    partial class Form1
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUtworzKonto = new System.Windows.Forms.Button();
            this.lblLibraryManager = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLogin.Location = new System.Drawing.Point(371, 239);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(358, 45);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "Login";
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(371, 341);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(358, 45);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Hasło";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLogin.BackgroundImage = global::Library_Manager.Properties.Resources.wood_button;
            this.btnLogin.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(425, 480);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Zaloguj";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(256, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło:";
            this.label2.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.BackgroundImage = global::Library_Manager.Properties.Resources.wood_button;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1000, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUtworzKonto
            // 
            this.btnUtworzKonto.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnUtworzKonto.BackgroundImage = global::Library_Manager.Properties.Resources.wood_button;
            this.btnUtworzKonto.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtworzKonto.ForeColor = System.Drawing.Color.White;
            this.btnUtworzKonto.Location = new System.Drawing.Point(0, 0);
            this.btnUtworzKonto.Name = "btnUtworzKonto";
            this.btnUtworzKonto.Size = new System.Drawing.Size(200, 50);
            this.btnUtworzKonto.TabIndex = 6;
            this.btnUtworzKonto.Text = "Utwórz konto";
            this.btnUtworzKonto.UseVisualStyleBackColor = false;
            this.btnUtworzKonto.Click += new System.EventHandler(this.btnUtworzKonto_Click);
            // 
            // lblLibraryManager
            // 
            this.lblLibraryManager.BackColor = System.Drawing.Color.Transparent;
            this.lblLibraryManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLibraryManager.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLibraryManager.ForeColor = System.Drawing.Color.White;
            this.lblLibraryManager.Location = new System.Drawing.Point(0, 0);
            this.lblLibraryManager.Name = "lblLibraryManager";
            this.lblLibraryManager.Size = new System.Drawing.Size(1100, 140);
            this.lblLibraryManager.TabIndex = 7;
            this.lblLibraryManager.Text = "Library Manager ";
            this.lblLibraryManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUtworzKonto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Manager.Properties.Resources.book_photo_1100_700;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLibraryManager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUtworzKonto;
        private System.Windows.Forms.Label lblLibraryManager;
        private System.Windows.Forms.Panel panel1;
    }
}

