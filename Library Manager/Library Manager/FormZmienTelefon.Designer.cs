namespace Library_Manager
{
    partial class FormZmienTelefon
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
            this.lblZmienTel = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZmien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblZmienTel
            // 
            this.lblZmienTel.AutoSize = true;
            this.lblZmienTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZmienTel.Location = new System.Drawing.Point(414, 73);
            this.lblZmienTel.Name = "lblZmienTel";
            this.lblZmienTel.Size = new System.Drawing.Size(216, 24);
            this.lblZmienTel.TabIndex = 0;
            this.lblZmienTel.Text = "Zmiana numeru telefonu";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTelefon.Location = new System.Drawing.Point(232, 221);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(137, 25);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "Nowy numer:";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.Location = new System.Drawing.Point(296, 307);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(73, 25);
            this.lblHaslo.TabIndex = 2;
            this.lblHaslo.Text = "Hasło:";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTelefon.Location = new System.Drawing.Point(418, 218);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(300, 31);
            this.textBoxTelefon.TabIndex = 3;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.Location = new System.Drawing.Point(418, 304);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(300, 31);
            this.textBoxHaslo.TabIndex = 4;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(988, 638);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 50);
            this.btnAnuluj.TabIndex = 5;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZmien
            // 
            this.btnZmien.Location = new System.Drawing.Point(454, 472);
            this.btnZmien.Name = "btnZmien";
            this.btnZmien.Size = new System.Drawing.Size(200, 50);
            this.btnZmien.TabIndex = 6;
            this.btnZmien.Text = "Zmień";
            this.btnZmien.UseVisualStyleBackColor = true;
            this.btnZmien.Click += new System.EventHandler(this.btnZmien_Click);
            // 
            // FormZmienTelefon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnZmien);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblZmienTel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZmienTelefon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZmienTelefon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZmienTel;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZmien;
    }
}