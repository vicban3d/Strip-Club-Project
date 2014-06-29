namespace ConnectingData
{
    partial class F_EmployeesMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.b_clients = new System.Windows.Forms.Button();
            this.ext_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button1.Location = new System.Drawing.Point(509, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_clients
            // 
            this.b_clients.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_clients.ForeColor = System.Drawing.Color.DarkOrchid;
            this.b_clients.Location = new System.Drawing.Point(509, 12);
            this.b_clients.Name = "b_clients";
            this.b_clients.Size = new System.Drawing.Size(150, 60);
            this.b_clients.TabIndex = 10;
            this.b_clients.Text = "Manage Clients";
            this.b_clients.UseVisualStyleBackColor = false;
            this.b_clients.Click += new System.EventHandler(this.b_clients_Click);
            // 
            // ext_btn
            // 
            this.ext_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ext_btn.ForeColor = System.Drawing.Color.DarkOrchid;
            this.ext_btn.Location = new System.Drawing.Point(509, 81);
            this.ext_btn.Margin = new System.Windows.Forms.Padding(6);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(150, 60);
            this.ext_btn.TabIndex = 5;
            this.ext_btn.Text = "Update Storage";
            this.ext_btn.UseVisualStyleBackColor = false;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Employees";
            // 
            // F_EmployeesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConnectingData.Properties.Resources._1319306707_strip_club_by_phileas100_d4dkszo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_clients);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ext_btn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "F_EmployeesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_clients;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Label label2;

    }
}