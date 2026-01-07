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
            this.btnjarmutorles = new System.Windows.Forms.Button();
            this.btnuthozzaadas = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncegkezeles
            // 
            this.btncegkezeles.Location = new System.Drawing.Point(66, 38);
            this.btncegkezeles.Name = "btncegkezeles";
            this.btncegkezeles.Size = new System.Drawing.Size(97, 23);
            this.btncegkezeles.TabIndex = 0;
            this.btncegkezeles.Text = "Cégek kezelése";
            this.btncegkezeles.UseCompatibleTextRendering = true;
            this.btncegkezeles.UseVisualStyleBackColor = true;
            this.btncegkezeles.Click += new System.EventHandler(this.btncegkezeles_Click);
            // 
            // btnjarmutorles
            // 
            this.btnjarmutorles.Location = new System.Drawing.Point(66, 82);
            this.btnjarmutorles.Name = "btnjarmutorles";
            this.btnjarmutorles.Size = new System.Drawing.Size(97, 23);
            this.btnjarmutorles.TabIndex = 1;
            this.btnjarmutorles.Text = "Jármű törlés";
            this.btnjarmutorles.UseVisualStyleBackColor = true;
            // 
            // btnuthozzaadas
            // 
            this.btnuthozzaadas.Location = new System.Drawing.Point(66, 126);
            this.btnuthozzaadas.Name = "btnuthozzaadas";
            this.btnuthozzaadas.Size = new System.Drawing.Size(97, 23);
            this.btnuthozzaadas.TabIndex = 2;
            this.btnuthozzaadas.Text = "Út hozzáadás";
            this.btnuthozzaadas.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(12, 226);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(97, 23);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Kijelentkezés";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(81, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(81, 306);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // userinterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnuthozzaadas);
            this.Controls.Add(this.btnjarmutorles);
            this.Controls.Add(this.btncegkezeles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(560, 300);
            this.MinimumSize = new System.Drawing.Size(560, 300);
            this.Name = "userinterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TollÚtdíj";
            this.Load += new System.EventHandler(this.userinterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncegkezeles;
        private System.Windows.Forms.Button btnjarmutorles;
        private System.Windows.Forms.Button btnuthozzaadas;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}