namespace Library_Manager
{
    partial class FormZmienHaslo
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
            this.lblZmianaHas = new System.Windows.Forms.Label();
            this.lblHasloAkt = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblPowHaslo = new System.Windows.Forms.Label();
            this.textBoxAktHaslo = new System.Windows.Forms.TextBox();
            this.textBoxNoweHaslo = new System.Windows.Forms.TextBox();
            this.textBoxNoweHasloPow = new System.Windows.Forms.TextBox();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZmienHaslo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZmianaHas
            // 
            this.lblZmianaHas.BackColor = System.Drawing.Color.Transparent;
            this.lblZmianaHas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblZmianaHas.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZmianaHas.ForeColor = System.Drawing.Color.White;
            this.lblZmianaHas.Location = new System.Drawing.Point(0, 0);
            this.lblZmianaHas.Name = "lblZmianaHas";
            this.lblZmianaHas.Size = new System.Drawing.Size(1100, 150);
            this.lblZmianaHas.TabIndex = 0;
            this.lblZmianaHas.Text = "Zmiana hasła";
            this.lblZmianaHas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHasloAkt
            // 
            this.lblHasloAkt.AutoSize = true;
            this.lblHasloAkt.BackColor = System.Drawing.Color.Transparent;
            this.lblHasloAkt.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHasloAkt.ForeColor = System.Drawing.Color.White;
            this.lblHasloAkt.Location = new System.Drawing.Point(142, 200);
            this.lblHasloAkt.Name = "lblHasloAkt";
            this.lblHasloAkt.Size = new System.Drawing.Size(179, 37);
            this.lblHasloAkt.TabIndex = 1;
            this.lblHasloAkt.Text = "Aktualne hasło:";
            this.lblHasloAkt.Visible = false;
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.BackColor = System.Drawing.Color.Transparent;
            this.lblHaslo.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHaslo.ForeColor = System.Drawing.Color.White;
            this.lblHaslo.Location = new System.Drawing.Point(177, 290);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(143, 37);
            this.lblHaslo.TabIndex = 2;
            this.lblHaslo.Text = "Nowe hasło:";
            this.lblHaslo.Visible = false;
            // 
            // lblPowHaslo
            // 
            this.lblPowHaslo.AutoSize = true;
            this.lblPowHaslo.BackColor = System.Drawing.Color.Transparent;
            this.lblPowHaslo.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPowHaslo.ForeColor = System.Drawing.Color.White;
            this.lblPowHaslo.Location = new System.Drawing.Point(82, 380);
            this.lblPowHaslo.Name = "lblPowHaslo";
            this.lblPowHaslo.Size = new System.Drawing.Size(237, 37);
            this.lblPowHaslo.TabIndex = 3;
            this.lblPowHaslo.Text = "Powtórz nowe hasło:";
            this.lblPowHaslo.Visible = false;
            // 
            // textBoxAktHaslo
            // 
            this.textBoxAktHaslo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAktHaslo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAktHaslo.Location = new System.Drawing.Point(325, 200);
            this.textBoxAktHaslo.Name = "textBoxAktHaslo";
            this.textBoxAktHaslo.Size = new System.Drawing.Size(450, 36);
            this.textBoxAktHaslo.TabIndex = 4;
            this.textBoxAktHaslo.Text = "Aktualne hasło";
            this.textBoxAktHaslo.Enter += new System.EventHandler(this.textBoxAktHaslo_Enter);
            this.textBoxAktHaslo.Leave += new System.EventHandler(this.textBoxAktHaslo_Leave);
            // 
            // textBoxNoweHaslo
            // 
            this.textBoxNoweHaslo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNoweHaslo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNoweHaslo.Location = new System.Drawing.Point(325, 290);
            this.textBoxNoweHaslo.Name = "textBoxNoweHaslo";
            this.textBoxNoweHaslo.Size = new System.Drawing.Size(450, 36);
            this.textBoxNoweHaslo.TabIndex = 5;
            this.textBoxNoweHaslo.Text = "Nowe hasło";
            this.textBoxNoweHaslo.Enter += new System.EventHandler(this.textBoxNoweHaslo_Enter);
            this.textBoxNoweHaslo.Leave += new System.EventHandler(this.textBoxNoweHaslo_Leave);
            // 
            // textBoxNoweHasloPow
            // 
            this.textBoxNoweHasloPow.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNoweHasloPow.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNoweHasloPow.Location = new System.Drawing.Point(325, 380);
            this.textBoxNoweHasloPow.Name = "textBoxNoweHasloPow";
            this.textBoxNoweHasloPow.Size = new System.Drawing.Size(450, 36);
            this.textBoxNoweHasloPow.TabIndex = 6;
            this.textBoxNoweHasloPow.Text = "Powtórz nowe hasło";
            this.textBoxNoweHasloPow.Enter += new System.EventHandler(this.textBoxNoweHasloPow_Enter);
            this.textBoxNoweHasloPow.Leave += new System.EventHandler(this.textBoxNoweHasloPow_Leave);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAnuluj.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.ForeColor = System.Drawing.Color.White;
            this.btnAnuluj.Location = new System.Drawing.Point(1000, 0);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 50);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = false;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZmienHaslo
            // 
            this.btnZmienHaslo.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnZmienHaslo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZmienHaslo.ForeColor = System.Drawing.Color.White;
            this.btnZmienHaslo.Location = new System.Drawing.Point(425, 500);
            this.btnZmienHaslo.Name = "btnZmienHaslo";
            this.btnZmienHaslo.Size = new System.Drawing.Size(250, 60);
            this.btnZmienHaslo.TabIndex = 8;
            this.btnZmienHaslo.Text = "Zmień hasło";
            this.btnZmienHaslo.UseVisualStyleBackColor = false;
            this.btnZmienHaslo.Click += new System.EventHandler(this.btnZmienHaslo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAnuluj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 9;
            // 
            // FormZmienHaslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Manager.Properties.Resources.book_photo_1100_700;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnZmienHaslo);
            this.Controls.Add(this.textBoxNoweHasloPow);
            this.Controls.Add(this.textBoxNoweHaslo);
            this.Controls.Add(this.textBoxAktHaslo);
            this.Controls.Add(this.lblPowHaslo);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblHasloAkt);
            this.Controls.Add(this.lblZmianaHas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZmienHaslo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZmienHaslo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZmianaHas;
        private System.Windows.Forms.Label lblHasloAkt;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label lblPowHaslo;
        private System.Windows.Forms.TextBox textBoxAktHaslo;
        private System.Windows.Forms.TextBox textBoxNoweHaslo;
        private System.Windows.Forms.TextBox textBoxNoweHasloPow;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZmienHaslo;
        private System.Windows.Forms.Panel panel1;
    }
}