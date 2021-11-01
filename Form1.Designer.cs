
namespace projectPractice2
{
    partial class frmHomepage
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCurrency = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnect = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUserScoring = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(201, 93);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCurrency
            // 
            this.btnCurrency.Location = new System.Drawing.Point(282, 93);
            this.btnCurrency.Name = "btnCurrency";
            this.btnCurrency.Size = new System.Drawing.Size(75, 23);
            this.btnCurrency.TabIndex = 1;
            this.btnCurrency.Text = "Currency Converter";
            this.btnCurrency.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 25);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Location = new System.Drawing.Point(9, 9);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(108, 13);
            this.lblConnect.TabIndex = 3;
            this.lblConnect.Text = "Connect to Database";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(198, 196);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(63, 13);
            this.lblFname.TabIndex = 4;
            this.lblFname.Text = "First Name: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(198, 257);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(198, 226);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(64, 13);
            this.lblLname.TabIndex = 6;
            this.lblLname.Text = "Last Name: ";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(198, 285);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(61, 13);
            this.lblTimestamp.TabIndex = 7;
            this.lblTimestamp.Text = "Timestamp:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUserScoring
            // 
            this.btnUserScoring.Location = new System.Drawing.Point(444, 93);
            this.btnUserScoring.Name = "btnUserScoring";
            this.btnUserScoring.Size = new System.Drawing.Size(75, 23);
            this.btnUserScoring.TabIndex = 9;
            this.btnUserScoring.Text = "User Scoring";
            this.btnUserScoring.UseVisualStyleBackColor = true;
            this.btnUserScoring.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserScoring);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCurrency);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmHomepage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHomepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCurrency;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUserScoring;
    }
}

