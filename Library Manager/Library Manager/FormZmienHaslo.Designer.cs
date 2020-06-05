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
            this.SuspendLayout();
            // 
            // lblZmianaHas
            // 
            this.lblZmianaHas.AutoSize = true;
            this.lblZmianaHas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZmianaHas.Location = new System.Drawing.Point(466, 75);
            this.lblZmianaHas.Name = "lblZmianaHas";
            this.lblZmianaHas.Size = new System.Drawing.Size(126, 24);
            this.lblZmianaHas.TabIndex = 0;
            this.lblZmianaHas.Text = "Zmiana hasła";
            // 
            // lblHasloAkt
            // 
            this.lblHasloAkt.AutoSize = true;
            this.lblHasloAkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHasloAkt.Location = new System.Drawing.Point(189, 199);
            this.lblHasloAkt.Name = "lblHasloAkt";
            this.lblHasloAkt.Size = new System.Drawing.Size(178, 29);
            this.lblHasloAkt.TabIndex = 1;
            this.lblHasloAkt.Text = "Aktualne hasło:";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.Location = new System.Drawing.Point(217, 301);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(150, 29);
            this.lblHaslo.TabIndex = 2;
            this.lblHaslo.Text = "Nowe hasło:";
            // 
            // lblPowHaslo
            // 
            this.lblPowHaslo.AutoSize = true;
            this.lblPowHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPowHaslo.Location = new System.Drawing.Point(129, 404);
            this.lblPowHaslo.Name = "lblPowHaslo";
            this.lblPowHaslo.Size = new System.Drawing.Size(238, 29);
            this.lblPowHaslo.TabIndex = 3;
            this.lblPowHaslo.Text = "Powtórz nowe hasło:";
            // 
            // textBoxAktHaslo
            // 
            this.textBoxAktHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAktHaslo.Location = new System.Drawing.Point(406, 196);
            this.textBoxAktHaslo.Name = "textBoxAktHaslo";
            this.textBoxAktHaslo.Size = new System.Drawing.Size(300, 35);
            this.textBoxAktHaslo.TabIndex = 4;
            // 
            // textBoxNoweHaslo
            // 
            this.textBoxNoweHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNoweHaslo.Location = new System.Drawing.Point(406, 298);
            this.textBoxNoweHaslo.Name = "textBoxNoweHaslo";
            this.textBoxNoweHaslo.Size = new System.Drawing.Size(300, 35);
            this.textBoxNoweHaslo.TabIndex = 5;
            // 
            // textBoxNoweHasloPow
            // 
            this.textBoxNoweHasloPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNoweHasloPow.Location = new System.Drawing.Point(406, 401);
            this.textBoxNoweHasloPow.Name = "textBoxNoweHasloPow";
            this.textBoxNoweHasloPow.Size = new System.Drawing.Size(300, 35);
            this.textBoxNoweHasloPow.TabIndex = 6;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(988, 638);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 50);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZmienHaslo
            // 
            this.btnZmienHaslo.Location = new System.Drawing.Point(445, 521);
            this.btnZmienHaslo.Name = "btnZmienHaslo";
            this.btnZmienHaslo.Size = new System.Drawing.Size(200, 50);
            this.btnZmienHaslo.TabIndex = 8;
            this.btnZmienHaslo.Text = "Zmień hasło";
            this.btnZmienHaslo.UseVisualStyleBackColor = true;
            // 
            // FormZmienHaslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnZmienHaslo);
            this.Controls.Add(this.btnAnuluj);
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
    }
}