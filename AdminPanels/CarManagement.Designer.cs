namespace ABC_Car_Traders.AdminPanels
{
    partial class CarManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.carDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addCar_transmission = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addCar_clearBtn = new System.Windows.Forms.Button();
            this.addCar_deleteBtn = new System.Windows.Forms.Button();
            this.addCar_updateBtn = new System.Windows.Forms.Button();
            this.addCar_addBtn = new System.Windows.Forms.Button();
            this.addCar_importBtn = new System.Windows.Forms.Button();
            this.addCar_picture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addCar_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addCar_make = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addCar_model = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addCar_year = new System.Windows.Forms.TextBox();
            this.addCar_Milage = new System.Windows.Forms.TextBox();
            this.addCar_engine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addCar_regNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCar_picture)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // carDataGridView
            // 
            this.carDataGridView.AllowUserToAddRows = false;
            this.carDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGridView.EnableHeadersVisualStyles = false;
            this.carDataGridView.Location = new System.Drawing.Point(22, 61);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.ReadOnly = true;
            this.carDataGridView.RowHeadersVisible = false;
            this.carDataGridView.Size = new System.Drawing.Size(809, 193);
            this.carDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exsisting Cars";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.carDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 279);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 226);
            this.panel2.TabIndex = 1;
            // 
            // addCar_transmission
            // 
            this.addCar_transmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_transmission.FormattingEnabled = true;
            this.addCar_transmission.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.addCar_transmission.Location = new System.Drawing.Point(389, 112);
            this.addCar_transmission.Name = "addCar_transmission";
            this.addCar_transmission.Size = new System.Drawing.Size(156, 23);
            this.addCar_transmission.TabIndex = 19;
            this.addCar_transmission.SelectedIndexChanged += new System.EventHandler(this.addCar_transmission_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Transmission :";
            // 
            // addCar_clearBtn
            // 
            this.addCar_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.addCar_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCar_clearBtn.FlatAppearance.BorderSize = 0;
            this.addCar_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addCar_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCar_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addCar_clearBtn.Location = new System.Drawing.Point(701, 157);
            this.addCar_clearBtn.Name = "addCar_clearBtn";
            this.addCar_clearBtn.Size = new System.Drawing.Size(113, 37);
            this.addCar_clearBtn.TabIndex = 17;
            this.addCar_clearBtn.Text = "Clear";
            this.addCar_clearBtn.UseVisualStyleBackColor = false;
            this.addCar_clearBtn.Click += new System.EventHandler(this.addCar_clearBtn_Click);
            // 
            // addCar_deleteBtn
            // 
            this.addCar_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.addCar_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCar_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addCar_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addCar_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCar_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addCar_deleteBtn.Location = new System.Drawing.Point(701, 108);
            this.addCar_deleteBtn.Name = "addCar_deleteBtn";
            this.addCar_deleteBtn.Size = new System.Drawing.Size(113, 37);
            this.addCar_deleteBtn.TabIndex = 16;
            this.addCar_deleteBtn.Text = "Delete";
            this.addCar_deleteBtn.UseVisualStyleBackColor = false;
            this.addCar_deleteBtn.Click += new System.EventHandler(this.addCar_deleteBtn_Click);
            // 
            // addCar_updateBtn
            // 
            this.addCar_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.addCar_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCar_updateBtn.FlatAppearance.BorderSize = 0;
            this.addCar_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addCar_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCar_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addCar_updateBtn.Location = new System.Drawing.Point(701, 61);
            this.addCar_updateBtn.Name = "addCar_updateBtn";
            this.addCar_updateBtn.Size = new System.Drawing.Size(113, 37);
            this.addCar_updateBtn.TabIndex = 15;
            this.addCar_updateBtn.Text = "Update";
            this.addCar_updateBtn.UseVisualStyleBackColor = false;
            this.addCar_updateBtn.Click += new System.EventHandler(this.addCar_updateBtn_Click);
            // 
            // addCar_addBtn
            // 
            this.addCar_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.addCar_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCar_addBtn.FlatAppearance.BorderSize = 0;
            this.addCar_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addCar_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCar_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_addBtn.ForeColor = System.Drawing.Color.White;
            this.addCar_addBtn.Location = new System.Drawing.Point(701, 13);
            this.addCar_addBtn.Name = "addCar_addBtn";
            this.addCar_addBtn.Size = new System.Drawing.Size(113, 37);
            this.addCar_addBtn.TabIndex = 14;
            this.addCar_addBtn.Text = "Add";
            this.addCar_addBtn.UseVisualStyleBackColor = false;
            this.addCar_addBtn.Click += new System.EventHandler(this.addCar_addBtn_Click);
            // 
            // addCar_importBtn
            // 
            this.addCar_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.addCar_importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCar_importBtn.FlatAppearance.BorderSize = 0;
            this.addCar_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCar_importBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_importBtn.ForeColor = System.Drawing.Color.White;
            this.addCar_importBtn.Location = new System.Drawing.Point(582, 132);
            this.addCar_importBtn.Name = "addCar_importBtn";
            this.addCar_importBtn.Size = new System.Drawing.Size(82, 23);
            this.addCar_importBtn.TabIndex = 13;
            this.addCar_importBtn.Text = "Upload";
            this.addCar_importBtn.UseVisualStyleBackColor = false;
            this.addCar_importBtn.Click += new System.EventHandler(this.addCar_importBtn_Click);
            // 
            // addCar_picture
            // 
            this.addCar_picture.BackColor = System.Drawing.SystemColors.Window;
            this.addCar_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCar_picture.Location = new System.Drawing.Point(582, 43);
            this.addCar_picture.Name = "addCar_picture";
            this.addCar_picture.Size = new System.Drawing.Size(82, 92);
            this.addCar_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addCar_picture.TabIndex = 12;
            this.addCar_picture.TabStop = false;
            this.addCar_picture.Click += new System.EventHandler(this.addCar_picture_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mileage :";
            // 
            // addCar_Price
            // 
            this.addCar_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_Price.Location = new System.Drawing.Point(389, 34);
            this.addCar_Price.Name = "addCar_Price";
            this.addCar_Price.Size = new System.Drawing.Size(156, 21);
            this.addCar_Price.TabIndex = 9;
            this.addCar_Price.TextChanged += new System.EventHandler(this.addCar_Price_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year :";
            // 
            // addCar_make
            // 
            this.addCar_make.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_make.Location = new System.Drawing.Point(115, 74);
            this.addCar_make.Name = "addCar_make";
            this.addCar_make.Size = new System.Drawing.Size(156, 21);
            this.addCar_make.TabIndex = 5;
            this.addCar_make.TextChanged += new System.EventHandler(this.addCar_make_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Make :";
            // 
            // addCar_model
            // 
            this.addCar_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_model.Location = new System.Drawing.Point(115, 34);
            this.addCar_model.Name = "addCar_model";
            this.addCar_model.Size = new System.Drawing.Size(156, 21);
            this.addCar_model.TabIndex = 3;
            this.addCar_model.TextChanged += new System.EventHandler(this.addCar_model_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addCar_regNo);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.addCar_engine);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.addCar_Milage);
            this.panel3.Controls.Add(this.addCar_year);
            this.panel3.Controls.Add(this.addCar_transmission);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.addCar_clearBtn);
            this.panel3.Controls.Add(this.addCar_deleteBtn);
            this.panel3.Controls.Add(this.addCar_updateBtn);
            this.panel3.Controls.Add(this.addCar_addBtn);
            this.panel3.Controls.Add(this.addCar_importBtn);
            this.panel3.Controls.Add(this.addCar_picture);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.addCar_Price);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.addCar_make);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addCar_model);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(24, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 215);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(0, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(839, 226);
            this.panel4.TabIndex = 1;
            // 
            // addCar_year
            // 
            this.addCar_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_year.Location = new System.Drawing.Point(115, 114);
            this.addCar_year.Name = "addCar_year";
            this.addCar_year.Size = new System.Drawing.Size(156, 21);
            this.addCar_year.TabIndex = 20;
            this.addCar_year.TextChanged += new System.EventHandler(this.addCar_year_TextChanged);
            // 
            // addCar_Milage
            // 
            this.addCar_Milage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_Milage.Location = new System.Drawing.Point(389, 74);
            this.addCar_Milage.Name = "addCar_Milage";
            this.addCar_Milage.Size = new System.Drawing.Size(156, 21);
            this.addCar_Milage.TabIndex = 21;
            this.addCar_Milage.TextChanged += new System.EventHandler(this.addCar_Milage_TextChanged);
            // 
            // addCar_engine
            // 
            this.addCar_engine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_engine.Location = new System.Drawing.Point(115, 155);
            this.addCar_engine.Name = "addCar_engine";
            this.addCar_engine.Size = new System.Drawing.Size(156, 21);
            this.addCar_engine.TabIndex = 23;
            this.addCar_engine.TextChanged += new System.EventHandler(this.addCar_engine_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Engine :";
            // 
            // addCar_regNo
            // 
            this.addCar_regNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCar_regNo.Location = new System.Drawing.Point(389, 155);
            this.addCar_regNo.Name = "addCar_regNo";
            this.addCar_regNo.Size = new System.Drawing.Size(156, 21);
            this.addCar_regNo.TabIndex = 25;
            this.addCar_regNo.TextChanged += new System.EventHandler(this.addCar_regNo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(293, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Reg. No. :";
            // 
            // CarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "CarManagement";
            this.Size = new System.Drawing.Size(907, 560);
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCar_picture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView carDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox addCar_transmission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addCar_clearBtn;
        private System.Windows.Forms.Button addCar_deleteBtn;
        private System.Windows.Forms.Button addCar_updateBtn;
        private System.Windows.Forms.Button addCar_addBtn;
        private System.Windows.Forms.Button addCar_importBtn;
        private System.Windows.Forms.PictureBox addCar_picture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addCar_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addCar_make;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addCar_model;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox addCar_year;
        private System.Windows.Forms.TextBox addCar_regNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addCar_engine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addCar_Milage;
    }
}
