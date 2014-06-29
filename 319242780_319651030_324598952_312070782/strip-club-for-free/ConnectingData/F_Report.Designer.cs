namespace ConnectingData
{
    partial class F_Report
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.Course_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course_Name});
            this.DG.Location = new System.Drawing.Point(24, 23);
            this.DG.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(511, 466);
            this.DG.TabIndex = 0;
            // 
            // Course_Name
            // 
            this.Course_Name.HeaderText = "Course Name";
            this.Course_Name.Name = "Course_Name";
            // 
            // F_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(568, 504);
            this.Controls.Add(this.DG);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "F_Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Name;
    }
}