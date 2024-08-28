namespace ABC_Car_Traders.HomePanels
{
    partial class PartsView
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
            this.partViewPanel = new System.Windows.Forms.Panel();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // partViewPanel
            // 
            this.partViewPanel.AutoScroll = true;
            this.partViewPanel.Location = new System.Drawing.Point(1, 46);
            this.partViewPanel.Name = "partViewPanel";
            this.partViewPanel.Size = new System.Drawing.Size(949, 557);
            this.partViewPanel.TabIndex = 11;
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(699, 15);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(153, 20);
            this.searchInput.TabIndex = 10;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(858, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // PartsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.partViewPanel);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searchBtn);
            this.Name = "PartsView";
            this.Size = new System.Drawing.Size(950, 606);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel partViewPanel;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchBtn;
    }
}
