namespace Library_Manager
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
            this.hIDKsiaz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIDUz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajDoBib = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zamówienia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewZamowienia
            // 
            this.listViewZamowienia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hIDKsiaz,
            this.hIDUz});
            this.listViewZamowienia.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewZamowienia.FullRowSelect = true;
            this.listViewZamowienia.HideSelection = false;
            this.listViewZamowienia.Location = new System.Drawing.Point(300, 155);
            this.listViewZamowienia.Name = "listViewZamowienia";
            this.listViewZamowienia.Size = new System.Drawing.Size(300, 400);
            this.listViewZamowienia.TabIndex = 1;
            this.listViewZamowienia.UseCompatibleStateImageBehavior = false;
            this.listViewZamowienia.View = System.Windows.Forms.View.Details;
            // 
            // hIDKsiaz
            // 
            this.hIDKsiaz.Text = "ID Książki";
            this.hIDKsiaz.Width = 145;
            // 
            // hIDUz
            // 
            this.hIDUz.Text = "ID Użytkownika";
            this.hIDUz.Width = 150;
            // 
            // btnDodajDoBib
            // 
            this.btnDodajDoBib.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajDoBib.Location = new System.Drawing.Point(670, 267);
            this.btnDodajDoBib.Name = "btnDodajDoBib";
            this.btnDodajDoBib.Size = new System.Drawing.Size(160, 80);
            this.btnDodajDoBib.TabIndex = 2;
            this.btnDodajDoBib.Text = "Dodaj do biblioteki";
            this.btnDodajDoBib.UseVisualStyleBackColor = true;
            this.btnDodajDoBib.Click += new System.EventHandler(this.btnDodajDoBib_Click);
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

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader hIDKsiaz;
        private System.Windows.Forms.ColumnHeader hIDUz;
        private System.Windows.Forms.Button btnDodajDoBib;
        public System.Windows.Forms.ListView listViewZamowienia;
    }
}
