namespace ABC_Car_Traders
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partOrder_export = new System.Windows.Forms.Button();
            this.partOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carOrder_export = new System.Windows.Forms.Button();
            this.carOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dashboard_partOrderCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dashboard_carOrderCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dashboard_userCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partOrdersDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carOrdersDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.partOrder_export);
            this.panel1.Controls.Add(this.partOrdersDataGrid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(460, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 332);
            this.panel1.TabIndex = 7;
            // 
            // partOrder_export
            // 
            this.partOrder_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.partOrder_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partOrder_export.ForeColor = System.Drawing.Color.White;
            this.partOrder_export.Location = new System.Drawing.Point(324, 25);
            this.partOrder_export.Name = "partOrder_export";
            this.partOrder_export.Size = new System.Drawing.Size(75, 23);
            this.partOrder_export.TabIndex = 6;
            this.partOrder_export.Text = "Export";
            this.partOrder_export.UseVisualStyleBackColor = false;
            this.partOrder_export.Click += new System.EventHandler(this.partOrder_export_Click);
            // 
            // partOrdersDataGrid
            // 
            this.partOrdersDataGrid.AllowUserToAddRows = false;
            this.partOrdersDataGrid.AllowUserToDeleteRows = false;
            this.partOrdersDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partOrdersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.partOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partOrdersDataGrid.EnableHeadersVisualStyles = false;
            this.partOrdersDataGrid.Location = new System.Drawing.Point(20, 64);
            this.partOrdersDataGrid.Name = "partOrdersDataGrid";
            this.partOrdersDataGrid.ReadOnly = true;
            this.partOrdersDataGrid.RowHeadersVisible = false;
            this.partOrdersDataGrid.Size = new System.Drawing.Size(379, 247);
            this.partOrdersDataGrid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Part Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.carOrder_export);
            this.panel2.Controls.Add(this.carOrdersDataGrid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 332);
            this.panel2.TabIndex = 6;
            // 
            // carOrder_export
            // 
            this.carOrder_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.carOrder_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carOrder_export.ForeColor = System.Drawing.Color.White;
            this.carOrder_export.Location = new System.Drawing.Point(324, 25);
            this.carOrder_export.Name = "carOrder_export";
            this.carOrder_export.Size = new System.Drawing.Size(75, 23);
            this.carOrder_export.TabIndex = 5;
            this.carOrder_export.Text = "Export";
            this.carOrder_export.UseVisualStyleBackColor = false;
            this.carOrder_export.Click += new System.EventHandler(this.carOrder_export_Click);
            // 
            // carOrdersDataGrid
            // 
            this.carOrdersDataGrid.AllowUserToAddRows = false;
            this.carOrdersDataGrid.AllowUserToDeleteRows = false;
            this.carOrdersDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carOrdersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.carOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carOrdersDataGrid.EnableHeadersVisualStyles = false;
            this.carOrdersDataGrid.Location = new System.Drawing.Point(20, 64);
            this.carOrdersDataGrid.Name = "carOrdersDataGrid";
            this.carOrdersDataGrid.ReadOnly = true;
            this.carOrdersDataGrid.RowHeadersVisible = false;
            this.carOrdersDataGrid.Size = new System.Drawing.Size(379, 247);
            this.carOrdersDataGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Orders";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(20, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(862, 161);
            this.panel3.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.panel5.Controls.Add(this.dashboard_partOrderCount);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(590, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 123);
            this.panel5.TabIndex = 2;
            // 
            // dashboard_partOrderCount
            // 
            this.dashboard_partOrderCount.AutoSize = true;
            this.dashboard_partOrderCount.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_partOrderCount.ForeColor = System.Drawing.Color.White;
            this.dashboard_partOrderCount.Location = new System.Drawing.Point(187, 27);
            this.dashboard_partOrderCount.Name = "dashboard_partOrderCount";
            this.dashboard_partOrderCount.Size = new System.Drawing.Size(26, 29);
            this.dashboard_partOrderCount.TabIndex = 6;
            this.dashboard_partOrderCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(136, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Part Orders";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.panel4.Controls.Add(this.dashboard_carOrderCount);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(313, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 123);
            this.panel4.TabIndex = 1;
            // 
            // dashboard_carOrderCount
            // 
            this.dashboard_carOrderCount.AutoSize = true;
            this.dashboard_carOrderCount.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_carOrderCount.ForeColor = System.Drawing.Color.White;
            this.dashboard_carOrderCount.Location = new System.Drawing.Point(183, 27);
            this.dashboard_carOrderCount.Name = "dashboard_carOrderCount";
            this.dashboard_carOrderCount.Size = new System.Drawing.Size(26, 29);
            this.dashboard_carOrderCount.TabIndex = 4;
            this.dashboard_carOrderCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(131, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car Orders";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.panel6.Controls.Add(this.dashboard_userCount);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(32, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 123);
            this.panel6.TabIndex = 0;
            // 
            // dashboard_userCount
            // 
            this.dashboard_userCount.AutoSize = true;
            this.dashboard_userCount.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_userCount.ForeColor = System.Drawing.Color.White;
            this.dashboard_userCount.Location = new System.Drawing.Point(187, 27);
            this.dashboard_userCount.Name = "dashboard_userCount";
            this.dashboard_userCount.Size = new System.Drawing.Size(26, 29);
            this.dashboard_userCount.TabIndex = 2;
            this.dashboard_userCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(125, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Count";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ABC_Car_Traders.Properties.Resources._2;
            this.pictureBox3.Location = new System.Drawing.Point(20, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ABC_Car_Traders.Properties.Resources.Car;
            this.pictureBox2.Location = new System.Drawing.Point(20, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABC_Car_Traders.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(18, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(907, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partOrdersDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carOrdersDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button partOrder_export;
        private System.Windows.Forms.DataGridView partOrdersDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button carOrder_export;
        private System.Windows.Forms.DataGridView carOrdersDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label dashboard_partOrderCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label dashboard_carOrderCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label dashboard_userCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
