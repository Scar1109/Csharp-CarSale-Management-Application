namespace ABC_Car_Traders.HomePanels
{
    partial class CarView
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
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.carViewPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(699, 15);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(153, 20);
            this.searchInput.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(858, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // carViewPanel
            // 
            this.carViewPanel.AutoScroll = true;
            this.carViewPanel.Location = new System.Drawing.Point(1, 46);
            this.carViewPanel.Name = "carViewPanel";
            this.carViewPanel.Size = new System.Drawing.Size(949, 557);
            this.carViewPanel.TabIndex = 8;
            // 
            // CarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.carViewPanel);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searchBtn);
            this.Name = "CarView";
            this.Size = new System.Drawing.Size(952, 608);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel carViewPanel;
    }
}
