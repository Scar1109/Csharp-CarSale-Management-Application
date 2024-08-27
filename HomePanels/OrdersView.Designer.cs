namespace ABC_Car_Traders.HomePanels
{
    partial class OrdersView
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
            this.panal01 = new System.Windows.Forms.Panel();
            this.partOrders_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carOrders_Panel = new System.Windows.Forms.Panel();
            this.panal01.SuspendLayout();
            this.partOrders_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panal01
            // 
            this.panal01.BackColor = System.Drawing.Color.White;
            this.panal01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panal01.Controls.Add(this.carOrders_Panel);
            this.panal01.Controls.Add(this.label1);
            this.panal01.Location = new System.Drawing.Point(14, 11);
            this.panal01.Name = "panal01";
            this.panal01.Size = new System.Drawing.Size(924, 288);
            this.panal01.TabIndex = 0;
            // 
            // partOrders_Panel
            // 
            this.partOrders_Panel.BackColor = System.Drawing.Color.White;
            this.partOrders_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partOrders_Panel.Controls.Add(this.label2);
            this.partOrders_Panel.Location = new System.Drawing.Point(14, 309);
            this.partOrders_Panel.Name = "partOrders_Panel";
            this.partOrders_Panel.Size = new System.Drawing.Size(924, 288);
            this.partOrders_Panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Part Orders";
            // 
            // carOrders_Panel
            // 
            this.carOrders_Panel.AutoScroll = true;
            this.carOrders_Panel.Location = new System.Drawing.Point(19, 35);
            this.carOrders_Panel.Name = "carOrders_Panel";
            this.carOrders_Panel.Size = new System.Drawing.Size(887, 232);
            this.carOrders_Panel.TabIndex = 2;
            // 
            // OrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.partOrders_Panel);
            this.Controls.Add(this.panal01);
            this.Name = "OrdersView";
            this.Size = new System.Drawing.Size(952, 608);
            this.panal01.ResumeLayout(false);
            this.panal01.PerformLayout();
            this.partOrders_Panel.ResumeLayout(false);
            this.partOrders_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panal01;
        private System.Windows.Forms.Panel carOrders_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel partOrders_Panel;
        private System.Windows.Forms.Label label2;
    }
}
