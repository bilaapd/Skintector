namespace PBO20des
{
    partial class Form1
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
            this.login_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.login_x = new System.Windows.Forms.Label();
            this.login_here = new System.Windows.Forms.Label();
            this.login_show = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_username = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(370, 225);
            this.login_password.Multiline = true;
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(353, 36);
            this.login_password.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(366, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Password";
            // 
            // login_x
            // 
            this.login_x.AutoSize = true;
            this.login_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_x.Location = new System.Drawing.Point(728, 15);
            this.login_x.Name = "login_x";
            this.login_x.Size = new System.Drawing.Size(25, 29);
            this.login_x.TabIndex = 18;
            this.login_x.Text = "x";
            this.login_x.Click += new System.EventHandler(this.login_x_Click);
            // 
            // login_here
            // 
            this.login_here.AutoSize = true;
            this.login_here.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_here.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login_here.Location = new System.Drawing.Point(590, 397);
            this.login_here.Name = "login_here";
            this.login_here.Size = new System.Drawing.Size(118, 20);
            this.login_here.TabIndex = 17;
            this.login_here.Text = "Register here";
            this.login_here.Click += new System.EventHandler(this.signup_loginHere_Click);
            // 
            // login_show
            // 
            this.login_show.AutoSize = true;
            this.login_show.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login_show.Location = new System.Drawing.Point(574, 288);
            this.login_show.Name = "login_show";
            this.login_show.Size = new System.Drawing.Size(148, 24);
            this.login_show.TabIndex = 16;
            this.login_show.Text = "Show Password";
            this.login_show.UseVisualStyleBackColor = true;
            this.login_show.CheckedChanged += new System.EventHandler(this.login_show_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.LightGray;
            this.login_btn.Location = new System.Drawing.Point(367, 294);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(97, 50);
            this.login_btn.TabIndex = 15;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(369, 154);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(353, 36);
            this.login_username.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(0, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 452);
            this.panel3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Hi, Beauties!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(399, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Don\'t have an account?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Welcome to";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Papyrus", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 44);
            this.label10.TabIndex = 26;
            this.label10.Text = "SKINTECTOR";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 440);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.login_x);
            this.Controls.Add(this.login_here);
            this.Controls.Add(this.login_show);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox login_showpw;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox login_pw;
        private System.Windows.Forms.TextBox login_usn;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.Label login_registerhere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label login_x;
        private System.Windows.Forms.Label login_here;
        private System.Windows.Forms.CheckBox login_show;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

