namespace TollÚtdíj
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.txbpass = new System.Windows.Forms.TextBox();
            this.txbusername = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(57, 136);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(39, 13);
            this.lblpass.TabIndex = 12;
            this.lblpass.Text = "Jelszó:";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(37, 85);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(59, 13);
            this.lbluser.TabIndex = 11;
            this.lbluser.Text = "E-mail cím:";
            // 
            // txbpass
            // 
            this.txbpass.Location = new System.Drawing.Point(102, 133);
            this.txbpass.MaxLength = 25;
            this.txbpass.Name = "txbpass";
            this.txbpass.PasswordChar = '*';
            this.txbpass.Size = new System.Drawing.Size(114, 20);
            this.txbpass.TabIndex = 10;
            // 
            // txbusername
            // 
            this.txbusername.Location = new System.Drawing.Point(103, 82);
            this.txbusername.MaxLength = 25;
            this.txbusername.Name = "txbusername";
            this.txbusername.Size = new System.Drawing.Size(113, 20);
            this.txbusername.TabIndex = 9;
            this.txbusername.TextChanged += new System.EventHandler(this.txbusername_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(99, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(117, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Kérjük jelentkezzen be!";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(102, 181);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(114, 23);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Bejelentkezés";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // Login
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txbpass);
            this.Controls.Add(this.txbusername);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnlogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 300);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txbpass;
        private System.Windows.Forms.TextBox txbusername;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnlogin;
    }
}

