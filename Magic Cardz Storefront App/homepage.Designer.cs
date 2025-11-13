namespace Magic_Cardz_Storefront_App
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.Minimise = new System.Windows.Forms.Label();
            this.pokemon = new System.Windows.Forms.Panel();
            this.pokemonPic = new System.Windows.Forms.PictureBox();
            this.mtg = new System.Windows.Forms.Panel();
            this.mtgPic = new System.Windows.Forms.PictureBox();
            this.yugiohPic = new System.Windows.Forms.PictureBox();
            this.yugioh = new System.Windows.Forms.Panel();
            this.lorcana = new System.Windows.Forms.Panel();
            this.lorcanaPic = new System.Windows.Forms.PictureBox();
            this.Account = new System.Windows.Forms.Panel();
            this.Basket = new System.Windows.Forms.Panel();
            this.accountName = new System.Windows.Forms.Label();
            this.BasketAmount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pokemon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPic)).BeginInit();
            this.mtg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtgPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yugiohPic)).BeginInit();
            this.yugioh.SuspendLayout();
            this.lorcana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lorcanaPic)).BeginInit();
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
            // pokemon
            // 
            this.pokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.pokemon.Controls.Add(this.pokemonPic);
            this.pokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pokemon.Location = new System.Drawing.Point(12, 194);
            this.pokemon.Name = "pokemon";
            this.pokemon.Size = new System.Drawing.Size(311, 499);
            this.pokemon.TabIndex = 2;
            this.pokemon.Click += new System.EventHandler(this.pokemon_Click);
            // 
            // pokemonPic
            // 
            this.pokemonPic.Image = ((System.Drawing.Image)(resources.GetObject("pokemonPic.Image")));
            this.pokemonPic.Location = new System.Drawing.Point(0, 149);
            this.pokemonPic.Name = "pokemonPic";
            this.pokemonPic.Size = new System.Drawing.Size(311, 176);
            this.pokemonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pokemonPic.TabIndex = 0;
            this.pokemonPic.TabStop = false;
            this.pokemonPic.Click += new System.EventHandler(this.pokemonPic_Click);
            // 
            // mtg
            // 
            this.mtg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.mtg.Controls.Add(this.mtgPic);
            this.mtg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtg.Location = new System.Drawing.Point(359, 194);
            this.mtg.Name = "mtg";
            this.mtg.Size = new System.Drawing.Size(311, 499);
            this.mtg.TabIndex = 3;
            this.mtg.Click += new System.EventHandler(this.mtg_Click);
            // 
            // mtgPic
            // 
            this.mtgPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtgPic.Image = ((System.Drawing.Image)(resources.GetObject("mtgPic.Image")));
            this.mtgPic.Location = new System.Drawing.Point(0, 149);
            this.mtgPic.Name = "mtgPic";
            this.mtgPic.Size = new System.Drawing.Size(311, 191);
            this.mtgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mtgPic.TabIndex = 0;
            this.mtgPic.TabStop = false;
            this.mtgPic.Click += new System.EventHandler(this.mtgPic_Click);
            // 
            // yugiohPic
            // 
            this.yugiohPic.Image = ((System.Drawing.Image)(resources.GetObject("yugiohPic.Image")));
            this.yugiohPic.Location = new System.Drawing.Point(0, 149);
            this.yugiohPic.Name = "yugiohPic";
            this.yugiohPic.Size = new System.Drawing.Size(311, 176);
            this.yugiohPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yugiohPic.TabIndex = 0;
            this.yugiohPic.TabStop = false;
            this.yugiohPic.Click += new System.EventHandler(this.yugiohPic_Click);
            // 
            // yugioh
            // 
            this.yugioh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.yugioh.Controls.Add(this.yugiohPic);
            this.yugioh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yugioh.Location = new System.Drawing.Point(701, 194);
            this.yugioh.Name = "yugioh";
            this.yugioh.Size = new System.Drawing.Size(311, 499);
            this.yugioh.TabIndex = 3;
            this.yugioh.Click += new System.EventHandler(this.yugioh_Click);
            // 
            // lorcana
            // 
            this.lorcana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.lorcana.Controls.Add(this.lorcanaPic);
            this.lorcana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lorcana.Location = new System.Drawing.Point(1043, 194);
            this.lorcana.Name = "lorcana";
            this.lorcana.Size = new System.Drawing.Size(311, 499);
            this.lorcana.TabIndex = 3;
            this.lorcana.Click += new System.EventHandler(this.lorcana_Click);
            // 
            // lorcanaPic
            // 
            this.lorcanaPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lorcanaPic.Image = ((System.Drawing.Image)(resources.GetObject("lorcanaPic.Image")));
            this.lorcanaPic.Location = new System.Drawing.Point(0, 149);
            this.lorcanaPic.Name = "lorcanaPic";
            this.lorcanaPic.Size = new System.Drawing.Size(311, 191);
            this.lorcanaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lorcanaPic.TabIndex = 0;
            this.lorcanaPic.TabStop = false;
            this.lorcanaPic.Click += new System.EventHandler(this.lorcanaPic_Click);
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.Account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Account.Location = new System.Drawing.Point(933, 73);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(79, 73);
            this.Account.TabIndex = 4;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // Basket
            // 
            this.Basket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.Basket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Basket.Location = new System.Drawing.Point(1183, 73);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(79, 73);
            this.Basket.TabIndex = 5;
            this.Basket.Click += new System.EventHandler(this.Basket_Click);
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName.Location = new System.Drawing.Point(1018, 87);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(86, 31);
            this.accountName.TabIndex = 6;
            this.accountName.Text = "label1";
            this.accountName.Click += new System.EventHandler(this.accountName_Click);
            // 
            // BasketAmount
            // 
            this.BasketAmount.AutoSize = true;
            this.BasketAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketAmount.Location = new System.Drawing.Point(1268, 87);
            this.BasketAmount.Name = "BasketAmount";
            this.BasketAmount.Size = new System.Drawing.Size(98, 31);
            this.BasketAmount.TabIndex = 7;
            this.BasketAmount.Text = "Basket";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BasketAmount);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.mtg);
            this.Controls.Add(this.yugioh);
            this.Controls.Add(this.lorcana);
            this.Controls.Add(this.pokemon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pokemon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPic)).EndInit();
            this.mtg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtgPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yugiohPic)).EndInit();
            this.yugioh.ResumeLayout(false);
            this.lorcana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lorcanaPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Minimise;
        private System.Windows.Forms.Panel pokemon;
        private System.Windows.Forms.Panel mtg;
        private System.Windows.Forms.Panel yugioh;
        private System.Windows.Forms.Panel lorcana;
        private System.Windows.Forms.Panel Account;
        private System.Windows.Forms.Panel Basket;
        private System.Windows.Forms.PictureBox pokemonPic;
        private System.Windows.Forms.PictureBox yugiohPic;
        private System.Windows.Forms.PictureBox mtgPic;
        private System.Windows.Forms.PictureBox lorcanaPic;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.Label BasketAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}