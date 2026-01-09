namespace TollÚtdíj
{
    partial class cegkezeles
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
            this.lblhibas = new System.Windows.Forms.Label();
            this.lsbceglista = new System.Windows.Forms.ListBox();
            this.btnmentes = new System.Windows.Forms.Button();
            this.btnvissza = new System.Windows.Forms.Button();
            this.txbcegnev = new System.Windows.Forms.TextBox();
            this.txbcegszam = new System.Windows.Forms.TextBox();
            this.txbcegcim = new System.Windows.Forms.TextBox();
            this.lbladatok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblhibas
            // 
            this.lblhibas.AutoSize = true;
            this.lblhibas.Location = new System.Drawing.Point(12, 9);
            this.lblhibas.Name = "lblhibas";
            this.lblhibas.Size = new System.Drawing.Size(0, 13);
            this.lblhibas.TabIndex = 0;
            // 
            // lsbceglista
            // 
            this.lsbceglista.FormattingEnabled = true;
            this.lsbceglista.Location = new System.Drawing.Point(12, 67);
            this.lsbceglista.Name = "lsbceglista";
            this.lsbceglista.Size = new System.Drawing.Size(120, 277);
            this.lsbceglista.TabIndex = 1;
            this.lsbceglista.SelectedIndexChanged += new System.EventHandler(this.lsbceglista_SelectedIndexChanged_1);
            // 
            // btnmentes
            // 
            this.btnmentes.Location = new System.Drawing.Point(153, 210);
            this.btnmentes.Name = "btnmentes";
            this.btnmentes.Size = new System.Drawing.Size(101, 38);
            this.btnmentes.TabIndex = 2;
            this.btnmentes.Text = "Változtatások mentése";
            this.btnmentes.UseVisualStyleBackColor = true;
            this.btnmentes.Click += new System.EventHandler(this.btnmentes_Click);
            // 
            // btnvissza
            // 
            this.btnvissza.Location = new System.Drawing.Point(12, 9);
            this.btnvissza.Name = "btnvissza";
            this.btnvissza.Size = new System.Drawing.Size(75, 23);
            this.btnvissza.TabIndex = 3;
            this.btnvissza.Text = "Vissza";
            this.btnvissza.UseVisualStyleBackColor = true;
            this.btnvissza.Click += new System.EventHandler(this.btnvissza_Click);
            // 
            // txbcegnev
            // 
            this.txbcegnev.Location = new System.Drawing.Point(139, 88);
            this.txbcegnev.Name = "txbcegnev";
            this.txbcegnev.Size = new System.Drawing.Size(134, 20);
            this.txbcegnev.TabIndex = 4;
            // 
            // txbcegszam
            // 
            this.txbcegszam.Location = new System.Drawing.Point(139, 129);
            this.txbcegszam.Name = "txbcegszam";
            this.txbcegszam.Size = new System.Drawing.Size(134, 20);
            this.txbcegszam.TabIndex = 5;
            // 
            // txbcegcim
            // 
            this.txbcegcim.Location = new System.Drawing.Point(139, 170);
            this.txbcegcim.Name = "txbcegcim";
            this.txbcegcim.Size = new System.Drawing.Size(134, 20);
            this.txbcegcim.TabIndex = 6;
            // 
            // lbladatok
            // 
            this.lbladatok.AutoSize = true;
            this.lbladatok.Location = new System.Drawing.Point(181, 67);
            this.lbladatok.Name = "lbladatok";
            this.lbladatok.Size = new System.Drawing.Size(44, 13);
            this.lbladatok.TabIndex = 7;
            this.lbladatok.Text = "Adatok:";
            // 
            // cegkezeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbladatok);
            this.Controls.Add(this.txbcegcim);
            this.Controls.Add(this.txbcegszam);
            this.Controls.Add(this.txbcegnev);
            this.Controls.Add(this.btnvissza);
            this.Controls.Add(this.btnmentes);
            this.Controls.Add(this.lsbceglista);
            this.Controls.Add(this.lblhibas);
            this.Name = "cegkezeles";
            this.Text = "Cégek kezelése";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhibas;
        private System.Windows.Forms.ListBox lsbceglista;
        private System.Windows.Forms.Button btnmentes;
        private System.Windows.Forms.Button btnvissza;
        private System.Windows.Forms.TextBox txbcegnev;
        private System.Windows.Forms.TextBox txbcegszam;
        private System.Windows.Forms.TextBox txbcegcim;
        private System.Windows.Forms.Label lbladatok;
    }
}