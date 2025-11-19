namespace TollÚtdíj
{
    partial class userinterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userinterface));
            this.btncegkezeles = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnuthozzaadas = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncegkezeles
            // 
            this.btncegkezeles.Location = new System.Drawing.Point(73, 73);
            this.btncegkezeles.Name = "btncegkezeles";
            this.btncegkezeles.Size = new System.Drawing.Size(97, 23);
            this.btncegkezeles.TabIndex = 0;
            this.btncegkezeles.Text = "Cégek kezelése";
            this.btncegkezeles.UseCompatibleTextRendering = true;
            this.btncegkezeles.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Jármű törlés";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnuthozzaadas
            // 
            this.btnuthozzaadas.Location = new System.Drawing.Point(73, 161);
            this.btnuthozzaadas.Name = "btnuthozzaadas";
            this.btnuthozzaadas.Size = new System.Drawing.Size(97, 23);
            this.btnuthozzaadas.TabIndex = 2;
            this.btnuthozzaadas.Text = "Út hozzáadás";
            this.btnuthozzaadas.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(73, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(73, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(73, 293);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // userinterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 430);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnuthozzaadas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncegkezeles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "userinterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TollÚtdíj";
            this.Load += new System.EventHandler(this.userinterface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncegkezeles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnuthozzaadas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}