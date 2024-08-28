namespace ABC_Car_Traders.AdminPanels
{
    partial class PartManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addPart_manufacture = new System.Windows.Forms.TextBox();
            this.addPart_qunatity = new System.Windows.Forms.TextBox();
            this.addPart_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addPart_clearBtn = new System.Windows.Forms.Button();
            this.addPart_deleteBtn = new System.Windows.Forms.Button();
            this.addPart_updateBtn = new System.Windows.Forms.Button();
            this.addPart_addBtn = new System.Windows.Forms.Button();
            this.addPart_importBtn = new System.Windows.Forms.Button();
            this.addPart_picture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addPart_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addPart_make = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPart_model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPart_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.partDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(21, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 279);
            this.panel1.TabIndex = 2;
            // 
            // partDataGridView
            // 
            this.partDataGridView.AllowUserToAddRows = false;
            this.partDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.partDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGridView.EnableHeadersVisualStyles = false;
            this.partDataGridView.Location = new System.Drawing.Point(22, 61);
            this.partDataGridView.Name = "partDataGridView";
            this.partDataGridView.ReadOnly = true;
            this.partDataGridView.RowHeadersVisible = false;
            this.partDataGridView.Size = new System.Drawing.Size(809, 193);
            this.partDataGridView.TabIndex = 3;
            this.partDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exsisting Parts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 226);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addPart_manufacture);
            this.panel3.Controls.Add(this.addPart_qunatity);
            this.panel3.Controls.Add(this.addPart_name);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.addPart_clearBtn);
            this.panel3.Controls.Add(this.addPart_deleteBtn);
            this.panel3.Controls.Add(this.addPart_updateBtn);
            this.panel3.Controls.Add(this.addPart_addBtn);
            this.panel3.Controls.Add(this.addPart_importBtn);
            this.panel3.Controls.Add(this.addPart_picture);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.addPart_price);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.addPart_make);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addPart_model);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(21, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 215);
            this.panel3.TabIndex = 4;
            // 
            // addPart_manufacture
            // 
            this.addPart_manufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_manufacture.Location = new System.Drawing.Point(480, 107);
            this.addPart_manufacture.Name = "addPart_manufacture";
            this.addPart_manufacture.Size = new System.Drawing.Size(156, 21);
            this.addPart_manufacture.TabIndex = 22;
            // 
            // addPart_qunatity
            // 
            this.addPart_qunatity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_qunatity.Location = new System.Drawing.Point(480, 67);
            this.addPart_qunatity.Name = "addPart_qunatity";
            this.addPart_qunatity.Size = new System.Drawing.Size(156, 21);
            this.addPart_qunatity.TabIndex = 21;
            // 
            // addPart_name
            // 
            this.addPart_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_name.Location = new System.Drawing.Point(176, 107);
            this.addPart_name.Name = "addPart_name";
            this.addPart_name.Size = new System.Drawing.Size(156, 21);
            this.addPart_name.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Manufacturer :";
            // 
            // addPart_clearBtn
            // 
            this.addPart_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.addPart_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPart_clearBtn.FlatAppearance.BorderSize = 0;
            this.addPart_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addPart_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPart_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addPart_clearBtn.Location = new System.Drawing.Point(575, 157);
            this.addPart_clearBtn.Name = "addPart_clearBtn";
            this.addPart_clearBtn.Size = new System.Drawing.Size(113, 37);
            this.addPart_clearBtn.TabIndex = 17;
            this.addPart_clearBtn.Text = "Clear";
            this.addPart_clearBtn.UseVisualStyleBackColor = false;
            this.addPart_clearBtn.Click += new System.EventHandler(this.addPart_clearBtn_Click);
            // 
            // addPart_deleteBtn
            // 
            this.addPart_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.addPart_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPart_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addPart_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addPart_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPart_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addPart_deleteBtn.Location = new System.Drawing.Point(437, 157);
            this.addPart_deleteBtn.Name = "addPart_deleteBtn";
            this.addPart_deleteBtn.Size = new System.Drawing.Size(113, 37);
            this.addPart_deleteBtn.TabIndex = 16;
            this.addPart_deleteBtn.Text = "Delete";
            this.addPart_deleteBtn.UseVisualStyleBackColor = false;
            this.addPart_deleteBtn.Click += new System.EventHandler(this.addPart_deleteBtn_Click);
            // 
            // addPart_updateBtn
            // 
            this.addPart_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.addPart_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPart_updateBtn.FlatAppearance.BorderSize = 0;
            this.addPart_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addPart_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPart_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addPart_updateBtn.Location = new System.Drawing.Point(301, 157);
            this.addPart_updateBtn.Name = "addPart_updateBtn";
            this.addPart_updateBtn.Size = new System.Drawing.Size(113, 37);
            this.addPart_updateBtn.TabIndex = 15;
            this.addPart_updateBtn.Text = "Update";
            this.addPart_updateBtn.UseVisualStyleBackColor = false;
            this.addPart_updateBtn.Click += new System.EventHandler(this.addPart_updateBtn_Click);
            // 
            // addPart_addBtn
            // 
            this.addPart_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.addPart_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPart_addBtn.FlatAppearance.BorderSize = 0;
            this.addPart_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addPart_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPart_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_addBtn.ForeColor = System.Drawing.Color.White;
            this.addPart_addBtn.Location = new System.Drawing.Point(163, 157);
            this.addPart_addBtn.Name = "addPart_addBtn";
            this.addPart_addBtn.Size = new System.Drawing.Size(113, 37);
            this.addPart_addBtn.TabIndex = 14;
            this.addPart_addBtn.Text = "Add";
            this.addPart_addBtn.UseVisualStyleBackColor = false;
            this.addPart_addBtn.Click += new System.EventHandler(this.addPart_addBtn_Click);
            // 
            // addPart_importBtn
            // 
            this.addPart_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.addPart_importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPart_importBtn.FlatAppearance.BorderSize = 0;
            this.addPart_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPart_importBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_importBtn.ForeColor = System.Drawing.Color.White;
            this.addPart_importBtn.Location = new System.Drawing.Point(717, 119);
            this.addPart_importBtn.Name = "addPart_importBtn";
            this.addPart_importBtn.Size = new System.Drawing.Size(82, 23);
            this.addPart_importBtn.TabIndex = 13;
            this.addPart_importBtn.Text = "Upload";
            this.addPart_importBtn.UseVisualStyleBackColor = false;
            this.addPart_importBtn.Click += new System.EventHandler(this.addPart_importBtn_Click);
            // 
            // addPart_picture
            // 
            this.addPart_picture.BackColor = System.Drawing.SystemColors.Window;
            this.addPart_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPart_picture.Location = new System.Drawing.Point(717, 30);
            this.addPart_picture.Name = "addPart_picture";
            this.addPart_picture.Size = new System.Drawing.Size(82, 92);
            this.addPart_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPart_picture.TabIndex = 12;
            this.addPart_picture.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity :";
            // 
            // addPart_price
            // 
            this.addPart_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_price.Location = new System.Drawing.Point(480, 27);
            this.addPart_price.Name = "addPart_price";
            this.addPart_price.Size = new System.Drawing.Size(156, 21);
            this.addPart_price.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name :";
            // 
            // addPart_make
            // 
            this.addPart_make.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_make.Location = new System.Drawing.Point(176, 67);
            this.addPart_make.Name = "addPart_make";
            this.addPart_make.Size = new System.Drawing.Size(156, 21);
            this.addPart_make.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Make :";
            // 
            // addPart_model
            // 
            this.addPart_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart_model.Location = new System.Drawing.Point(176, 27);
            this.addPart_model.Name = "addPart_model";
            this.addPart_model.Size = new System.Drawing.Size(156, 21);
            this.addPart_model.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 30);
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
            // PartManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "PartManagement";
            this.Size = new System.Drawing.Size(907, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPart_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView partDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox addPart_qunatity;
        private System.Windows.Forms.TextBox addPart_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addPart_clearBtn;
        private System.Windows.Forms.Button addPart_deleteBtn;
        private System.Windows.Forms.Button addPart_updateBtn;
        private System.Windows.Forms.Button addPart_addBtn;
        private System.Windows.Forms.Button addPart_importBtn;
        private System.Windows.Forms.PictureBox addPart_picture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addPart_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addPart_make;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addPart_model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox addPart_manufacture;
    }
}
