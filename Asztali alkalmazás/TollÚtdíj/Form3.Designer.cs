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
            this.button1 = new System.Windows.Forms.Button();
            this.btnvissza = new System.Windows.Forms.Button();
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // cegkezeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvissza);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnvissza;
    }
}