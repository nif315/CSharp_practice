namespace MemoryCards
{
    partial class FormMemCards
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemCards));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGameS1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRules = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpS1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.card16 = new System.Windows.Forms.PictureBox();
            this.card15 = new System.Windows.Forms.PictureBox();
            this.card14 = new System.Windows.Forms.PictureBox();
            this.card13 = new System.Windows.Forms.PictureBox();
            this.card12 = new System.Windows.Forms.PictureBox();
            this.card11 = new System.Windows.Forms.PictureBox();
            this.card10 = new System.Windows.Forms.PictureBox();
            this.card9 = new System.Windows.Forms.PictureBox();
            this.card8 = new System.Windows.Forms.PictureBox();
            this.card7 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.pictureLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGame,
            this.menuHelp});
            this.menu.Location = new System.Drawing.Point(20, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(529, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuGame
            // 
            this.menuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewGame,
            this.menuGameS1,
            this.menuExit});
            this.menuGame.Name = "menuGame";
            this.menuGame.Size = new System.Drawing.Size(50, 20);
            this.menuGame.Text = "Game";
            // 
            // menuNewGame
            // 
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuNewGame.Size = new System.Drawing.Size(150, 22);
            this.menuNewGame.Text = "New game";
            this.menuNewGame.Click += new System.EventHandler(this.menuNewGame_Click);
            // 
            // menuGameS1
            // 
            this.menuGameS1.Name = "menuGameS1";
            this.menuGameS1.Size = new System.Drawing.Size(147, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuExit.Size = new System.Drawing.Size(150, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRules,
            this.menuHelpS1,
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // menuRules
            // 
            this.menuRules.Name = "menuRules";
            this.menuRules.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuRules.Size = new System.Drawing.Size(141, 22);
            this.menuRules.Text = "Rules";
            this.menuRules.Click += new System.EventHandler(this.menuRules_Click);
            // 
            // menuHelpS1
            // 
            this.menuHelpS1.Name = "menuHelpS1";
            this.menuHelpS1.Size = new System.Drawing.Size(138, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuAbout.Size = new System.Drawing.Size(141, 22);
            this.menuAbout.Text = "About us";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // pictureLayoutPanel
            // 
            this.pictureLayoutPanel.BackColor = System.Drawing.Color.White;
            this.pictureLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pictureLayoutPanel.ColumnCount = 4;
            this.pictureLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pictureLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pictureLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pictureLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pictureLayoutPanel.Controls.Add(this.card16, 3, 3);
            this.pictureLayoutPanel.Controls.Add(this.card15, 2, 3);
            this.pictureLayoutPanel.Controls.Add(this.card14, 1, 3);
            this.pictureLayoutPanel.Controls.Add(this.card13, 0, 3);
            this.pictureLayoutPanel.Controls.Add(this.card12, 3, 2);
            this.pictureLayoutPanel.Controls.Add(this.card11, 2, 2);
            this.pictureLayoutPanel.Controls.Add(this.card10, 1, 2);
            this.pictureLayoutPanel.Controls.Add(this.card9, 0, 2);
            this.pictureLayoutPanel.Controls.Add(this.card8, 3, 1);
            this.pictureLayoutPanel.Controls.Add(this.card7, 2, 1);
            this.pictureLayoutPanel.Controls.Add(this.card6, 1, 1);
            this.pictureLayoutPanel.Controls.Add(this.card5, 0, 1);
            this.pictureLayoutPanel.Controls.Add(this.card4, 3, 0);
            this.pictureLayoutPanel.Controls.Add(this.card3, 2, 0);
            this.pictureLayoutPanel.Controls.Add(this.card2, 1, 0);
            this.pictureLayoutPanel.Controls.Add(this.card1, 0, 0);
            this.pictureLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLayoutPanel.Location = new System.Drawing.Point(20, 84);
            this.pictureLayoutPanel.Name = "pictureLayoutPanel";
            this.pictureLayoutPanel.RowCount = 4;
            this.pictureLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pictureLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pictureLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pictureLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pictureLayoutPanel.Size = new System.Drawing.Size(529, 246);
            this.pictureLayoutPanel.TabIndex = 1;
            // 
            // card16
            // 
            this.card16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card16.Image = global::MemoryCards.Properties.Resources._0;
            this.card16.Location = new System.Drawing.Point(402, 189);
            this.card16.Margin = new System.Windows.Forms.Padding(5);
            this.card16.Name = "card16";
            this.card16.Size = new System.Drawing.Size(121, 51);
            this.card16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card16.TabIndex = 15;
            this.card16.TabStop = false;
            this.card16.Tag = "15";
            this.card16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card15
            // 
            this.card15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card15.Image = global::MemoryCards.Properties.Resources._0;
            this.card15.Location = new System.Drawing.Point(270, 189);
            this.card15.Margin = new System.Windows.Forms.Padding(5);
            this.card15.Name = "card15";
            this.card15.Size = new System.Drawing.Size(121, 51);
            this.card15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card15.TabIndex = 14;
            this.card15.TabStop = false;
            this.card15.Tag = "14";
            this.card15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card14
            // 
            this.card14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card14.Image = global::MemoryCards.Properties.Resources._0;
            this.card14.Location = new System.Drawing.Point(138, 189);
            this.card14.Margin = new System.Windows.Forms.Padding(5);
            this.card14.Name = "card14";
            this.card14.Size = new System.Drawing.Size(121, 51);
            this.card14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card14.TabIndex = 13;
            this.card14.TabStop = false;
            this.card14.Tag = "13";
            this.card14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card13
            // 
            this.card13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card13.Image = global::MemoryCards.Properties.Resources._0;
            this.card13.Location = new System.Drawing.Point(6, 189);
            this.card13.Margin = new System.Windows.Forms.Padding(5);
            this.card13.Name = "card13";
            this.card13.Size = new System.Drawing.Size(121, 51);
            this.card13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card13.TabIndex = 12;
            this.card13.TabStop = false;
            this.card13.Tag = "12";
            this.card13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card12
            // 
            this.card12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card12.Image = global::MemoryCards.Properties.Resources._0;
            this.card12.Location = new System.Drawing.Point(402, 128);
            this.card12.Margin = new System.Windows.Forms.Padding(5);
            this.card12.Name = "card12";
            this.card12.Size = new System.Drawing.Size(121, 50);
            this.card12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card12.TabIndex = 11;
            this.card12.TabStop = false;
            this.card12.Tag = "11";
            this.card12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card11
            // 
            this.card11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card11.Image = global::MemoryCards.Properties.Resources._0;
            this.card11.Location = new System.Drawing.Point(270, 128);
            this.card11.Margin = new System.Windows.Forms.Padding(5);
            this.card11.Name = "card11";
            this.card11.Size = new System.Drawing.Size(121, 50);
            this.card11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card11.TabIndex = 10;
            this.card11.TabStop = false;
            this.card11.Tag = "10";
            this.card11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card10
            // 
            this.card10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card10.Image = global::MemoryCards.Properties.Resources._0;
            this.card10.Location = new System.Drawing.Point(138, 128);
            this.card10.Margin = new System.Windows.Forms.Padding(5);
            this.card10.Name = "card10";
            this.card10.Size = new System.Drawing.Size(121, 50);
            this.card10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card10.TabIndex = 9;
            this.card10.TabStop = false;
            this.card10.Tag = "9";
            this.card10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card9
            // 
            this.card9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card9.Image = global::MemoryCards.Properties.Resources._0;
            this.card9.Location = new System.Drawing.Point(6, 128);
            this.card9.Margin = new System.Windows.Forms.Padding(5);
            this.card9.Name = "card9";
            this.card9.Size = new System.Drawing.Size(121, 50);
            this.card9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card9.TabIndex = 8;
            this.card9.TabStop = false;
            this.card9.Tag = "8";
            this.card9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card8
            // 
            this.card8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card8.Image = global::MemoryCards.Properties.Resources._0;
            this.card8.Location = new System.Drawing.Point(402, 67);
            this.card8.Margin = new System.Windows.Forms.Padding(5);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(121, 50);
            this.card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card8.TabIndex = 7;
            this.card8.TabStop = false;
            this.card8.Tag = "7";
            this.card8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card7
            // 
            this.card7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card7.Image = global::MemoryCards.Properties.Resources._0;
            this.card7.Location = new System.Drawing.Point(270, 67);
            this.card7.Margin = new System.Windows.Forms.Padding(5);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(121, 50);
            this.card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card7.TabIndex = 6;
            this.card7.TabStop = false;
            this.card7.Tag = "6";
            this.card7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card6
            // 
            this.card6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card6.Image = global::MemoryCards.Properties.Resources._0;
            this.card6.Location = new System.Drawing.Point(138, 67);
            this.card6.Margin = new System.Windows.Forms.Padding(5);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(121, 50);
            this.card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card6.TabIndex = 5;
            this.card6.TabStop = false;
            this.card6.Tag = "5";
            this.card6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card5
            // 
            this.card5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card5.Image = global::MemoryCards.Properties.Resources._0;
            this.card5.Location = new System.Drawing.Point(6, 67);
            this.card5.Margin = new System.Windows.Forms.Padding(5);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(121, 50);
            this.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card5.TabIndex = 4;
            this.card5.TabStop = false;
            this.card5.Tag = "4";
            this.card5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card4
            // 
            this.card4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card4.Image = global::MemoryCards.Properties.Resources._0;
            this.card4.Location = new System.Drawing.Point(402, 6);
            this.card4.Margin = new System.Windows.Forms.Padding(5);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(121, 50);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card4.TabIndex = 3;
            this.card4.TabStop = false;
            this.card4.Tag = "3";
            this.card4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card3
            // 
            this.card3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card3.Image = global::MemoryCards.Properties.Resources._0;
            this.card3.Location = new System.Drawing.Point(270, 6);
            this.card3.Margin = new System.Windows.Forms.Padding(5);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(121, 50);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card3.TabIndex = 2;
            this.card3.TabStop = false;
            this.card3.Tag = "2";
            this.card3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card2
            // 
            this.card2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card2.Image = global::MemoryCards.Properties.Resources._0;
            this.card2.Location = new System.Drawing.Point(138, 6);
            this.card2.Margin = new System.Windows.Forms.Padding(5);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(121, 50);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card2.TabIndex = 1;
            this.card2.TabStop = false;
            this.card2.Tag = "1";
            this.card2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // card1
            // 
            this.card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card1.Image = global::MemoryCards.Properties.Resources._0;
            this.card1.Location = new System.Drawing.Point(6, 6);
            this.card1.Margin = new System.Windows.Forms.Padding(5);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(121, 50);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card1.TabIndex = 0;
            this.card1.TabStop = false;
            this.card1.Tag = "0";
            this.card1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card11_MouseClick);
            // 
            // FormMemCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 350);
            this.Controls.Add(this.pictureLayoutPanel);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormMemCards";
            this.Text = "Memory Cards";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pictureLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.card16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuGame;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
        private System.Windows.Forms.ToolStripSeparator menuGameS1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuRules;
        private System.Windows.Forms.ToolStripSeparator menuHelpS1;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.TableLayoutPanel pictureLayoutPanel;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card16;
        private System.Windows.Forms.PictureBox card15;
        private System.Windows.Forms.PictureBox card14;
        private System.Windows.Forms.PictureBox card13;
        private System.Windows.Forms.PictureBox card12;
        private System.Windows.Forms.PictureBox card11;
        private System.Windows.Forms.PictureBox card10;
        private System.Windows.Forms.PictureBox card9;
        private System.Windows.Forms.PictureBox card8;
        private System.Windows.Forms.PictureBox card7;
        private System.Windows.Forms.PictureBox card6;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card2;
    }
}

