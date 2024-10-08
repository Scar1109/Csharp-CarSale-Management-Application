﻿namespace ABC_Car_Traders
{
    partial class AdminDashboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.users_btn = new System.Windows.Forms.Button();
            this.manageCar_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_user = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.orderDetails_btn = new System.Windows.Forms.Button();
            this.partDetails_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new ABC_Car_Traders.Dashboard();
            this.carManagement1 = new ABC_Car_Traders.AdminPanels.CarManagement();
            this.partManagement1 = new ABC_Car_Traders.AdminPanels.PartManagement();
            this.orderManagement1 = new ABC_Car_Traders.AdminPanels.OrderManagement();
            this.userManagement1 = new ABC_Car_Traders.AdminPanels.UserManagement();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 35);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ABC Car Traders";
            // 
            // users_btn
            // 
            this.users_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.users_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.users_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_btn.ForeColor = System.Drawing.Color.White;
            this.users_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.users_btn.Location = new System.Drawing.Point(14, 358);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(200, 40);
            this.users_btn.TabIndex = 4;
            this.users_btn.Text = "USERS";
            this.users_btn.UseVisualStyleBackColor = false;
            this.users_btn.Click += new System.EventHandler(this.users_btn_Click);
            // 
            // manageCar_btn
            // 
            this.manageCar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.manageCar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageCar_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.manageCar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCar_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCar_btn.ForeColor = System.Drawing.Color.White;
            this.manageCar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageCar_btn.Location = new System.Drawing.Point(14, 214);
            this.manageCar_btn.Name = "manageCar_btn";
            this.manageCar_btn.Size = new System.Drawing.Size(200, 40);
            this.manageCar_btn.TabIndex = 3;
            this.manageCar_btn.Text = "CARS";
            this.manageCar_btn.UseVisualStyleBackColor = false;
            this.manageCar_btn.Click += new System.EventHandler(this.manageCar_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(14, 165);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(200, 41);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.ForeColor = System.Drawing.Color.White;
            this.greet_user.Location = new System.Drawing.Point(59, 129);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(115, 19);
            this.greet_user.TabIndex = 1;
            this.greet_user.Text = "Welcome, User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.orderDetails_btn);
            this.panel2.Controls.Add(this.partDetails_btn);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.users_btn);
            this.panel2.Controls.Add(this.manageCar_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 560);
            this.panel2.TabIndex = 2;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.logout_icon_30x30;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(15, 517);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(30, 30);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // orderDetails_btn
            // 
            this.orderDetails_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.orderDetails_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderDetails_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.orderDetails_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderDetails_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetails_btn.ForeColor = System.Drawing.Color.White;
            this.orderDetails_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderDetails_btn.Location = new System.Drawing.Point(14, 310);
            this.orderDetails_btn.Name = "orderDetails_btn";
            this.orderDetails_btn.Size = new System.Drawing.Size(200, 40);
            this.orderDetails_btn.TabIndex = 8;
            this.orderDetails_btn.Text = "ORDERS";
            this.orderDetails_btn.UseVisualStyleBackColor = false;
            this.orderDetails_btn.Click += new System.EventHandler(this.orderDetails_btn_Click);
            // 
            // partDetails_btn
            // 
            this.partDetails_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.partDetails_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.partDetails_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.partDetails_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partDetails_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDetails_btn.ForeColor = System.Drawing.Color.White;
            this.partDetails_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.partDetails_btn.Location = new System.Drawing.Point(14, 262);
            this.partDetails_btn.Name = "partDetails_btn";
            this.partDetails_btn.Size = new System.Drawing.Size(200, 40);
            this.partDetails_btn.TabIndex = 7;
            this.partDetails_btn.Text = "PARTS";
            this.partDetails_btn.UseVisualStyleBackColor = false;
            this.partDetails_btn.Click += new System.EventHandler(this.partDetails_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(15, 517);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(35, 35);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABC_Car_Traders.Properties.Resources.logo_white;
            this.pictureBox1.Location = new System.Drawing.Point(54, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.carManagement1);
            this.panel3.Controls.Add(this.partManagement1);
            this.panel3.Controls.Add(this.orderManagement1);
            this.panel3.Controls.Add(this.userManagement1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 560);
            this.panel3.TabIndex = 3;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(907, 560);
            this.dashboard1.TabIndex = 4;
            // 
            // carManagement1
            // 
            this.carManagement1.Location = new System.Drawing.Point(-3, 0);
            this.carManagement1.Name = "carManagement1";
            this.carManagement1.Size = new System.Drawing.Size(907, 560);
            this.carManagement1.TabIndex = 3;
            // 
            // partManagement1
            // 
            this.partManagement1.Location = new System.Drawing.Point(0, 0);
            this.partManagement1.Name = "partManagement1";
            this.partManagement1.Size = new System.Drawing.Size(907, 560);
            this.partManagement1.TabIndex = 2;
            // 
            // orderManagement1
            // 
            this.orderManagement1.Location = new System.Drawing.Point(0, 0);
            this.orderManagement1.Name = "orderManagement1";
            this.orderManagement1.Size = new System.Drawing.Size(907, 560);
            this.orderManagement1.TabIndex = 1;
            // 
            // userManagement1
            // 
            this.userManagement1.Location = new System.Drawing.Point(0, 0);
            this.userManagement1.Name = "userManagement1";
            this.userManagement1.Size = new System.Drawing.Size(907, 560);
            this.userManagement1.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 595);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button users_btn;
        private System.Windows.Forms.Button manageCar_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button partDetails_btn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button orderDetails_btn;
        private System.Windows.Forms.Panel panel3;
        private AdminPanels.OrderManagement orderManagement1;
        private AdminPanels.UserManagement userManagement1;
        private Dashboard dashboard1;
        private AdminPanels.CarManagement carManagement1;
        private AdminPanels.PartManagement partManagement1;
    }
}