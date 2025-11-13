namespace Magic_Cardz_Storefront_App
{
    partial class account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.Minimise = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.back.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Minimise);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 52);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1311, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(43, 42);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "X";
            this.Exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseClick);
            // 
            // Minimise
            // 
            this.Minimise.AutoSize = true;
            this.Minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimise.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Minimise.Location = new System.Drawing.Point(1274, 9);
            this.Minimise.Name = "Minimise";
            this.Minimise.Size = new System.Drawing.Size(31, 42);
            this.Minimise.TabIndex = 4;
            this.Minimise.Text = "-";
            this.Minimise.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimise_MouseClick);
            // 
            // accountName
            // 
            this.accountName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountName.AutoSize = true;
            this.accountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName.Location = new System.Drawing.Point(549, 208);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(204, 73);
            this.accountName.TabIndex = 2;
            this.accountName.Text = "label1";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.back.Controls.Add(this.backBtn);
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(0, 710);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(139, 60);
            this.back.TabIndex = 3;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(30, 18);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 31);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.back);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account";
            this.Load += new System.EventHandler(this.account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.back.ResumeLayout(false);
            this.back.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Minimise;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.Label backBtn;
    }
}