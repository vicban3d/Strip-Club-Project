namespace ConnectingData
{
    partial class F_ManageData
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
            this.rst_btn = new System.Windows.Forms.Button();
            this.bck_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rst_btn
            // 
            this.rst_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rst_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.rst_btn.ForeColor = System.Drawing.Color.DarkOrchid;
            this.rst_btn.Location = new System.Drawing.Point(509, 87);
            this.rst_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rst_btn.Name = "rst_btn";
            this.rst_btn.Size = new System.Drawing.Size(150, 60);
            this.rst_btn.TabIndex = 3;
            this.rst_btn.Text = "Restore";
            this.rst_btn.UseVisualStyleBackColor = false;
            this.rst_btn.Click += new System.EventHandler(this.rst_btn_Click);
            // 
            // bck_btn
            // 
            this.bck_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bck_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.bck_btn.ForeColor = System.Drawing.Color.DarkOrchid;
            this.bck_btn.Location = new System.Drawing.Point(509, 15);
            this.bck_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(150, 60);
            this.bck_btn.TabIndex = 2;
            this.bck_btn.Text = "Backup";
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button1.Location = new System.Drawing.Point(511, 356);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Manage Data";
            // 
            // F_ManageData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConnectingData.Properties.Resources.ISRAELIDomaine_du_Castel__CELLAR;
            this.ClientSize = new System.Drawing.Size(674, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rst_btn);
            this.Controls.Add(this.bck_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_ManageData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rst_btn;
        private System.Windows.Forms.Button bck_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}