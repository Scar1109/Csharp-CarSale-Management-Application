namespace ABC_Car_Traders.AdminPanels
{
    partial class OrderManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.Label();
            this.order_status = new System.Windows.Forms.Label();
            this.conformDilivary_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carOrdersDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partOrdersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.carOrdersDataGrid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(21, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 406);
            this.panel2.TabIndex = 2;
            // 
            // carOrdersDataGrid
            // 
            this.carOrdersDataGrid.AllowUserToAddRows = false;
            this.carOrdersDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carOrdersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.carOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carOrdersDataGrid.EnableHeadersVisualStyles = false;
            this.carOrdersDataGrid.Location = new System.Drawing.Point(20, 64);
            this.carOrdersDataGrid.Name = "carOrdersDataGrid";
            this.carOrdersDataGrid.ReadOnly = true;
            this.carOrdersDataGrid.RowHeadersVisible = false;
            this.carOrdersDataGrid.Size = new System.Drawing.Size(379, 315);
            this.carOrdersDataGrid.TabIndex = 4;
            this.carOrdersDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carOrdersDataGrid_CellClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.partOrdersDataGrid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(461, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 406);
            this.panel1.TabIndex = 5;
            // 
            // partOrdersDataGrid
            // 
            this.partOrdersDataGrid.AllowUserToAddRows = false;
            this.partOrdersDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partOrdersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.partOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partOrdersDataGrid.EnableHeadersVisualStyles = false;
            this.partOrdersDataGrid.Location = new System.Drawing.Point(20, 64);
            this.partOrdersDataGrid.Name = "partOrdersDataGrid";
            this.partOrdersDataGrid.ReadOnly = true;
            this.partOrdersDataGrid.RowHeadersVisible = false;
            this.partOrdersDataGrid.Size = new System.Drawing.Size(379, 315);
            this.partOrdersDataGrid.TabIndex = 4;
            this.partOrdersDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partOrdersDataGrid_CellClick);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status     :";
            // 
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_id.Location = new System.Drawing.Point(360, 455);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(72, 19);
            this.order_id.TabIndex = 8;
            this.order_id.Text = "--select--";
            // 
            // order_status
            // 
            this.order_status.AutoSize = true;
            this.order_status.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_status.Location = new System.Drawing.Point(360, 495);
            this.order_status.Name = "order_status";
            this.order_status.Size = new System.Drawing.Size(72, 19);
            this.order_status.TabIndex = 9;
            this.order_status.Text = "--select--";
            // 
            // conformDilivary_btn
            // 
            this.conformDilivary_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(63)))), ((int)(((byte)(142)))));
            this.conformDilivary_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conformDilivary_btn.FlatAppearance.BorderSize = 0;
            this.conformDilivary_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.conformDilivary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conformDilivary_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conformDilivary_btn.ForeColor = System.Drawing.Color.White;
            this.conformDilivary_btn.Location = new System.Drawing.Point(599, 463);
            this.conformDilivary_btn.Name = "conformDilivary_btn";
            this.conformDilivary_btn.Size = new System.Drawing.Size(214, 47);
            this.conformDilivary_btn.TabIndex = 16;
            this.conformDilivary_btn.Text = "Conform Dilivary";
            this.conformDilivary_btn.UseVisualStyleBackColor = false;
            this.conformDilivary_btn.Click += new System.EventHandler(this.conformDilivary_btn_Click);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.conformDilivary_btn);
            this.Controls.Add(this.order_status);
            this.Controls.Add(this.order_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "OrderManagement";
            this.Size = new System.Drawing.Size(907, 560);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carOrdersDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partOrdersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView carOrdersDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView partOrdersDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label order_id;
        private System.Windows.Forms.Label order_status;
        private System.Windows.Forms.Button conformDilivary_btn;
    }
}
