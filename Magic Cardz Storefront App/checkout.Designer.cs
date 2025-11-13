namespace Magic_Cardz_Storefront_App
{
    partial class checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.Minimise = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.ListBox();
            this.items = new System.Windows.Forms.ListBox();
            this.checkoutBtn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.checkoutBtn.SuspendLayout();
            this.back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.items);
            this.panel2.Location = new System.Drawing.Point(299, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 500);
            this.panel2.TabIndex = 2;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.FormattingEnabled = true;
            this.price.ItemHeight = 31;
            this.price.Location = new System.Drawing.Point(579, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(299, 500);
            this.price.TabIndex = 1;
            // 
            // items
            // 
            this.items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.items.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items.FormattingEnabled = true;
            this.items.ItemHeight = 31;
            this.items.Location = new System.Drawing.Point(0, 0);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(573, 500);
            this.items.TabIndex = 0;
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.checkoutBtn.Controls.Add(this.label1);
            this.checkoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutBtn.Location = new System.Drawing.Point(338, 610);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(738, 117);
            this.checkoutBtn.TabIndex = 3;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkout Now!";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.back.Controls.Add(this.backBtn);
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(0, 710);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(139, 60);
            this.back.TabIndex = 4;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.back);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkout";
            this.Load += new System.EventHandler(this.checkout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.checkoutBtn.ResumeLayout(false);
            this.checkoutBtn.PerformLayout();
            this.back.ResumeLayout(false);
            this.back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Minimise;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel checkoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.Label backBtn;
        private System.Windows.Forms.ListBox items;
        private System.Windows.Forms.ListBox price;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}