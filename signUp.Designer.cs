namespace PBO20des
{
    partial class signUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.signup_x = new System.Windows.Forms.Label();
            this.signup_here = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_show = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.signup_password);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.signup_x);
            this.panel1.Controls.Add(this.signup_here);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signup_show);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.signup_username);
            this.panel1.Controls.Add(this.signup_email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 440);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // signup_password
            // 
            this.signup_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.Location = new System.Drawing.Point(380, 259);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(353, 36);
            this.signup_password.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password";
            // 
            // signup_x
            // 
            this.signup_x.AutoSize = true;
            this.signup_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_x.Location = new System.Drawing.Point(718, 9);
            this.signup_x.Name = "signup_x";
            this.signup_x.Size = new System.Drawing.Size(25, 29);
            this.signup_x.TabIndex = 10;
            this.signup_x.Text = "x";
            this.signup_x.Click += new System.EventHandler(this.signup_x_Click);
            // 
            // signup_here
            // 
            this.signup_here.AutoSize = true;
            this.signup_here.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_here.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signup_here.Location = new System.Drawing.Point(598, 391);
            this.signup_here.Name = "signup_here";
            this.signup_here.Size = new System.Drawing.Size(94, 20);
            this.signup_here.TabIndex = 9;
            this.signup_here.Text = "Login here";
            this.signup_here.Click += new System.EventHandler(this.signup_here_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(394, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Already have an account?";
            // 
            // signup_show
            // 
            this.signup_show.AutoSize = true;
            this.signup_show.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signup_show.Location = new System.Drawing.Point(584, 301);
            this.signup_show.Name = "signup_show";
            this.signup_show.Size = new System.Drawing.Size(148, 24);
            this.signup_show.TabIndex = 7;
            this.signup_show.Text = "Show Password";
            this.signup_show.UseVisualStyleBackColor = true;
            this.signup_show.CheckedChanged += new System.EventHandler(this.signup_show_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.LightGray;
            this.signup_btn.Location = new System.Drawing.Point(379, 314);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(97, 50);
            this.signup_btn.TabIndex = 6;
            this.signup_btn.Text = "SIGN UP";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_username
            // 
            this.signup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.Location = new System.Drawing.Point(379, 188);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(353, 36);
            this.signup_username.TabIndex = 5;
            // 
            // signup_email
            // 
            this.signup_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_email.Location = new System.Drawing.Point(379, 119);
            this.signup_email.Multiline = true;
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(353, 36);
            this.signup_email.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get Started";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(0, -6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 452);
            this.panel3.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Papyrus", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 44);
            this.label10.TabIndex = 26;
            this.label10.Text = "SKINTECTOR";
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
            // signUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(771, 440);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signUp";
            this.Load += new System.EventHandler(this.signUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signup_x;
        private System.Windows.Forms.Label signup_here;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox signup_show;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}