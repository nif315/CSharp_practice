namespace amazonAwsBot
{
    partial class controlPanel
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
            this.startEC2 = new MetroFramework.Controls.MetroTile();
            this.shutdownEC2 = new MetroFramework.Controls.MetroTile();
            this.checkboxSweden = new MetroFramework.Controls.MetroCheckBox();
            this.checkboxParis = new MetroFramework.Controls.MetroCheckBox();
            this.checkboxLondon = new MetroFramework.Controls.MetroCheckBox();
            this.checkboxIreland = new MetroFramework.Controls.MetroCheckBox();
            this.checkboxFrankfurt = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // startEC2
            // 
            this.startEC2.ActiveControl = null;
            this.startEC2.Location = new System.Drawing.Point(131, 126);
            this.startEC2.Name = "startEC2";
            this.startEC2.Size = new System.Drawing.Size(141, 40);
            this.startEC2.TabIndex = 2;
            this.startEC2.Text = "on";
            this.startEC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startEC2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startEC2.UseSelectable = true;
            this.startEC2.Click += new System.EventHandler(this.startEC2_Click);
            // 
            // shutdownEC2
            // 
            this.shutdownEC2.ActiveControl = null;
            this.shutdownEC2.Location = new System.Drawing.Point(131, 64);
            this.shutdownEC2.Name = "shutdownEC2";
            this.shutdownEC2.Size = new System.Drawing.Size(141, 40);
            this.shutdownEC2.TabIndex = 3;
            this.shutdownEC2.Text = "off";
            this.shutdownEC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shutdownEC2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shutdownEC2.UseSelectable = true;
            this.shutdownEC2.Click += new System.EventHandler(this.shutdownEC2_Click);
            // 
            // checkboxSweden
            // 
            this.checkboxSweden.AutoSize = true;
            this.checkboxSweden.Location = new System.Drawing.Point(24, 64);
            this.checkboxSweden.Name = "checkboxSweden";
            this.checkboxSweden.Size = new System.Drawing.Size(64, 15);
            this.checkboxSweden.TabIndex = 4;
            this.checkboxSweden.Text = "Sweden";
            this.checkboxSweden.UseSelectable = true;
            // 
            // checkboxParis
            // 
            this.checkboxParis.AutoSize = true;
            this.checkboxParis.Location = new System.Drawing.Point(24, 86);
            this.checkboxParis.Name = "checkboxParis";
            this.checkboxParis.Size = new System.Drawing.Size(48, 15);
            this.checkboxParis.TabIndex = 5;
            this.checkboxParis.Text = "Paris";
            this.checkboxParis.UseSelectable = true;
            // 
            // checkboxLondon
            // 
            this.checkboxLondon.AutoSize = true;
            this.checkboxLondon.Location = new System.Drawing.Point(24, 107);
            this.checkboxLondon.Name = "checkboxLondon";
            this.checkboxLondon.Size = new System.Drawing.Size(64, 15);
            this.checkboxLondon.TabIndex = 6;
            this.checkboxLondon.Text = "London";
            this.checkboxLondon.UseSelectable = true;
            // 
            // checkboxIreland
            // 
            this.checkboxIreland.AutoSize = true;
            this.checkboxIreland.Location = new System.Drawing.Point(24, 129);
            this.checkboxIreland.Name = "checkboxIreland";
            this.checkboxIreland.Size = new System.Drawing.Size(59, 15);
            this.checkboxIreland.TabIndex = 7;
            this.checkboxIreland.Text = "Ireland";
            this.checkboxIreland.UseSelectable = true;
            // 
            // checkboxFrankfurt
            // 
            this.checkboxFrankfurt.AutoSize = true;
            this.checkboxFrankfurt.Location = new System.Drawing.Point(24, 151);
            this.checkboxFrankfurt.Name = "checkboxFrankfurt";
            this.checkboxFrankfurt.Size = new System.Drawing.Size(71, 15);
            this.checkboxFrankfurt.TabIndex = 8;
            this.checkboxFrankfurt.Text = "Frankfurt";
            this.checkboxFrankfurt.UseSelectable = true;
            // 
            // controlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 185);
            this.Controls.Add(this.checkboxFrankfurt);
            this.Controls.Add(this.checkboxIreland);
            this.Controls.Add(this.checkboxLondon);
            this.Controls.Add(this.checkboxParis);
            this.Controls.Add(this.checkboxSweden);
            this.Controls.Add(this.shutdownEC2);
            this.Controls.Add(this.startEC2);
            this.Name = "controlPanel";
            this.Text = "Control panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile startEC2;
        private MetroFramework.Controls.MetroTile shutdownEC2;
        private MetroFramework.Controls.MetroCheckBox checkboxSweden;
        private MetroFramework.Controls.MetroCheckBox checkboxParis;
        private MetroFramework.Controls.MetroCheckBox checkboxLondon;
        private MetroFramework.Controls.MetroCheckBox checkboxIreland;
        private MetroFramework.Controls.MetroCheckBox checkboxFrankfurt;
    }
}

