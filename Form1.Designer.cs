namespace ABC_Car_Traders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signin_signupBtn = new System.Windows.Forms.Button();
            this.signin_btn = new System.Windows.Forms.Button();
            this.signin_showPass = new System.Windows.Forms.CheckBox();
            this.signin_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signin_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.signin_signupBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 450);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.white_logo;
            this.pictureBox1.Image = global::ABC_Car_Traders.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(98, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(120, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Login your Account";
            // 
            // signin_signupBtn
            // 
            this.signin_signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.signin_signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_signupBtn.FlatAppearance.BorderSize = 0;
            this.signin_signupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(40)))), ((int)(((byte)(91)))));
            this.signin_signupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(40)))), ((int)(((byte)(91)))));
            this.signin_signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_signupBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_signupBtn.ForeColor = System.Drawing.Color.White;
            this.signin_signupBtn.Location = new System.Drawing.Point(64, 391);
            this.signin_signupBtn.Name = "signin_signupBtn";
            this.signin_signupBtn.Size = new System.Drawing.Size(226, 31);
            this.signin_signupBtn.TabIndex = 1;
            this.signin_signupBtn.Text = "SIGN UP";
            this.signin_signupBtn.UseVisualStyleBackColor = false;
            this.signin_signupBtn.Click += new System.EventHandler(this.signup_loginBtn_Click);
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.signin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_btn.FlatAppearance.BorderSize = 0;
            this.signin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(40)))), ((int)(((byte)(91)))));
            this.signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(40)))), ((int)(((byte)(91)))));
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_btn.ForeColor = System.Drawing.Color.White;
            this.signin_btn.Location = new System.Drawing.Point(420, 312);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(93, 34);
            this.signin_btn.TabIndex = 24;
            this.signin_btn.Text = "SIGN IN";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // signin_showPass
            // 
            this.signin_showPass.AutoSize = true;
            this.signin_showPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_showPass.Location = new System.Drawing.Point(569, 263);
            this.signin_showPass.Name = "signin_showPass";
            this.signin_showPass.Size = new System.Drawing.Size(112, 18);
            this.signin_showPass.TabIndex = 23;
            this.signin_showPass.Text = "Show Password";
            this.signin_showPass.UseVisualStyleBackColor = true;
            this.signin_showPass.CheckedChanged += new System.EventHandler(this.signin_showPass_CheckedChanged);
            // 
            // signin_password
            // 
            this.signin_password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_password.Location = new System.Drawing.Point(420, 227);
            this.signin_password.Multiline = true;
            this.signin_password.Name = "signin_password";
            this.signin_password.PasswordChar = '*';
            this.signin_password.Size = new System.Drawing.Size(261, 30);
            this.signin_password.TabIndex = 22;
            this.signin_password.TextChanged += new System.EventHandler(this.signin_password_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password:";
            // 
            // signin_username
            // 
            this.signin_username.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_username.Location = new System.Drawing.Point(420, 165);
            this.signin_username.Multiline = true;
            this.signin_username.Name = "signin_username";
            this.signin_username.Size = new System.Drawing.Size(261, 30);
            this.signin_username.TabIndex = 20;
            this.signin_username.TextChanged += new System.EventHandler(this.signin_username_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Login into Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.signin_showPass);
            this.Controls.Add(this.signin_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signin_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signin_signupBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.CheckBox signin_showPass;
        private System.Windows.Forms.TextBox signin_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signin_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

