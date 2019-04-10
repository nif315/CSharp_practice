namespace WindowsFormsApp1
{
    partial class Form1
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
            this.JsonInput = new MetroFramework.Controls.MetroTextBox();
            this.xmlOutput = new MetroFramework.Controls.MetroTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.save_xml = new MetroFramework.Controls.MetroTile();
            this.open_json = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.parse_to_xml = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.xmlInput = new MetroFramework.Controls.MetroTextBox();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.jsonOutput = new MetroFramework.Controls.MetroTextBox();
            this.open_xml = new MetroFramework.Controls.MetroTile();
            this.save_json = new MetroFramework.Controls.MetroTile();
            this.metroTile11 = new MetroFramework.Controls.MetroTile();
            this.parse_to_json = new MetroFramework.Controls.MetroTile();
            this.parse_to_xml.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // JsonInput
            // 
            // 
            // 
            // 
            this.JsonInput.CustomButton.Image = null;
            this.JsonInput.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.JsonInput.CustomButton.Name = "";
            this.JsonInput.CustomButton.Size = new System.Drawing.Size(131, 131);
            this.JsonInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.JsonInput.CustomButton.TabIndex = 1;
            this.JsonInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.JsonInput.CustomButton.UseSelectable = true;
            this.JsonInput.CustomButton.Visible = false;
            this.JsonInput.Lines = new string[0];
            this.JsonInput.Location = new System.Drawing.Point(6, 29);
            this.JsonInput.MaxLength = 32767;
            this.JsonInput.Multiline = true;
            this.JsonInput.Name = "JsonInput";
            this.JsonInput.PasswordChar = '\0';
            this.JsonInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.JsonInput.SelectedText = "";
            this.JsonInput.SelectionLength = 0;
            this.JsonInput.SelectionStart = 0;
            this.JsonInput.ShortcutsEnabled = true;
            this.JsonInput.Size = new System.Drawing.Size(419, 133);
            this.JsonInput.TabIndex = 1;
            this.JsonInput.UseSelectable = true;
            this.JsonInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.JsonInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // xmlOutput
            // 
            // 
            // 
            // 
            this.xmlOutput.CustomButton.Image = null;
            this.xmlOutput.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.xmlOutput.CustomButton.Name = "";
            this.xmlOutput.CustomButton.Size = new System.Drawing.Size(131, 131);
            this.xmlOutput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.xmlOutput.CustomButton.TabIndex = 1;
            this.xmlOutput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.xmlOutput.CustomButton.UseSelectable = true;
            this.xmlOutput.CustomButton.Visible = false;
            this.xmlOutput.Lines = new string[0];
            this.xmlOutput.Location = new System.Drawing.Point(6, 209);
            this.xmlOutput.MaxLength = 32767;
            this.xmlOutput.Multiline = true;
            this.xmlOutput.Name = "xmlOutput";
            this.xmlOutput.PasswordChar = '\0';
            this.xmlOutput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.xmlOutput.SelectedText = "";
            this.xmlOutput.SelectionLength = 0;
            this.xmlOutput.SelectionStart = 0;
            this.xmlOutput.ShortcutsEnabled = true;
            this.xmlOutput.Size = new System.Drawing.Size(419, 133);
            this.xmlOutput.TabIndex = 2;
            this.xmlOutput.UseSelectable = true;
            this.xmlOutput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.xmlOutput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "JSON";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 187);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "XML";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(328, 168);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(97, 35);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "CLEAR ALL";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(344, 360);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(81, 35);
            this.metroTile2.TabIndex = 8;
            this.metroTile2.Text = "PARSE";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // save_xml
            // 
            this.save_xml.ActiveControl = null;
            this.save_xml.Location = new System.Drawing.Point(10, 360);
            this.save_xml.Name = "save_xml";
            this.save_xml.Size = new System.Drawing.Size(81, 35);
            this.save_xml.TabIndex = 9;
            this.save_xml.Text = "SAVE";
            this.save_xml.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_xml.UseSelectable = true;
            this.save_xml.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // open_json
            // 
            this.open_json.ActiveControl = null;
            this.open_json.Location = new System.Drawing.Point(97, 360);
            this.open_json.Name = "open_json";
            this.open_json.Size = new System.Drawing.Size(81, 35);
            this.open_json.TabIndex = 10;
            this.open_json.Text = "OPEN";
            this.open_json.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.open_json.UseSelectable = true;
            this.open_json.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(225, 168);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(97, 35);
            this.metroTile5.TabIndex = 11;
            this.metroTile5.Text = "CLEAR XML";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(122, 168);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(97, 35);
            this.metroTile6.TabIndex = 12;
            this.metroTile6.Text = "CLEAR JSON";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // parse_to_xml
            // 
            this.parse_to_xml.Controls.Add(this.tabPage1);
            this.parse_to_xml.Controls.Add(this.tabPage2);
            this.parse_to_xml.Location = new System.Drawing.Point(23, 63);
            this.parse_to_xml.Name = "parse_to_xml";
            this.parse_to_xml.SelectedIndex = 0;
            this.parse_to_xml.Size = new System.Drawing.Size(443, 429);
            this.parse_to_xml.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.metroTile6);
            this.tabPage1.Controls.Add(this.JsonInput);
            this.tabPage1.Controls.Add(this.metroTile5);
            this.tabPage1.Controls.Add(this.xmlOutput);
            this.tabPage1.Controls.Add(this.open_json);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.save_xml);
            this.tabPage1.Controls.Add(this.metroTile1);
            this.tabPage1.Controls.Add(this.metroTile2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(435, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "JSON to XML";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.metroTile7);
            this.tabPage2.Controls.Add(this.xmlInput);
            this.tabPage2.Controls.Add(this.metroTile8);
            this.tabPage2.Controls.Add(this.jsonOutput);
            this.tabPage2.Controls.Add(this.open_xml);
            this.tabPage2.Controls.Add(this.save_json);
            this.tabPage2.Controls.Add(this.metroTile11);
            this.tabPage2.Controls.Add(this.parse_to_json);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(435, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XML to JSON";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 7);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(39, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "XML";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 187);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "JSON";
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(122, 168);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(97, 35);
            this.metroTile7.TabIndex = 21;
            this.metroTile7.Text = "CLEAR JSON";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // xmlInput
            // 
            // 
            // 
            // 
            this.xmlInput.CustomButton.Image = null;
            this.xmlInput.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.xmlInput.CustomButton.Name = "";
            this.xmlInput.CustomButton.Size = new System.Drawing.Size(131, 131);
            this.xmlInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.xmlInput.CustomButton.TabIndex = 1;
            this.xmlInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.xmlInput.CustomButton.UseSelectable = true;
            this.xmlInput.CustomButton.Visible = false;
            this.xmlInput.Lines = new string[0];
            this.xmlInput.Location = new System.Drawing.Point(6, 29);
            this.xmlInput.MaxLength = 32767;
            this.xmlInput.Multiline = true;
            this.xmlInput.Name = "xmlInput";
            this.xmlInput.PasswordChar = '\0';
            this.xmlInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.xmlInput.SelectedText = "";
            this.xmlInput.SelectionLength = 0;
            this.xmlInput.SelectionStart = 0;
            this.xmlInput.ShortcutsEnabled = true;
            this.xmlInput.Size = new System.Drawing.Size(419, 133);
            this.xmlInput.TabIndex = 13;
            this.xmlInput.UseSelectable = true;
            this.xmlInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.xmlInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(225, 168);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(97, 35);
            this.metroTile8.TabIndex = 20;
            this.metroTile8.Text = "CLEAR XML";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.UseSelectable = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // jsonOutput
            // 
            // 
            // 
            // 
            this.jsonOutput.CustomButton.Image = null;
            this.jsonOutput.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.jsonOutput.CustomButton.Name = "";
            this.jsonOutput.CustomButton.Size = new System.Drawing.Size(131, 131);
            this.jsonOutput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jsonOutput.CustomButton.TabIndex = 1;
            this.jsonOutput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jsonOutput.CustomButton.UseSelectable = true;
            this.jsonOutput.CustomButton.Visible = false;
            this.jsonOutput.Lines = new string[0];
            this.jsonOutput.Location = new System.Drawing.Point(6, 209);
            this.jsonOutput.MaxLength = 32767;
            this.jsonOutput.Multiline = true;
            this.jsonOutput.Name = "jsonOutput";
            this.jsonOutput.PasswordChar = '\0';
            this.jsonOutput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jsonOutput.SelectedText = "";
            this.jsonOutput.SelectionLength = 0;
            this.jsonOutput.SelectionStart = 0;
            this.jsonOutput.ShortcutsEnabled = true;
            this.jsonOutput.Size = new System.Drawing.Size(419, 133);
            this.jsonOutput.TabIndex = 14;
            this.jsonOutput.UseSelectable = true;
            this.jsonOutput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jsonOutput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // open_xml
            // 
            this.open_xml.ActiveControl = null;
            this.open_xml.Location = new System.Drawing.Point(97, 360);
            this.open_xml.Name = "open_xml";
            this.open_xml.Size = new System.Drawing.Size(81, 35);
            this.open_xml.TabIndex = 19;
            this.open_xml.Text = "OPEN";
            this.open_xml.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.open_xml.UseSelectable = true;
            this.open_xml.Click += new System.EventHandler(this.metroTile9_Click);
            // 
            // save_json
            // 
            this.save_json.ActiveControl = null;
            this.save_json.Location = new System.Drawing.Point(10, 360);
            this.save_json.Name = "save_json";
            this.save_json.Size = new System.Drawing.Size(81, 35);
            this.save_json.TabIndex = 18;
            this.save_json.Text = "SAVE";
            this.save_json.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_json.UseSelectable = true;
            this.save_json.Click += new System.EventHandler(this.metroTile10_Click);
            // 
            // metroTile11
            // 
            this.metroTile11.ActiveControl = null;
            this.metroTile11.Location = new System.Drawing.Point(328, 168);
            this.metroTile11.Name = "metroTile11";
            this.metroTile11.Size = new System.Drawing.Size(97, 35);
            this.metroTile11.TabIndex = 16;
            this.metroTile11.Text = "CLEAR ALL";
            this.metroTile11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile11.UseSelectable = true;
            this.metroTile11.Click += new System.EventHandler(this.metroTile11_Click);
            // 
            // parse_to_json
            // 
            this.parse_to_json.ActiveControl = null;
            this.parse_to_json.Location = new System.Drawing.Point(344, 360);
            this.parse_to_json.Name = "parse_to_json";
            this.parse_to_json.Size = new System.Drawing.Size(81, 35);
            this.parse_to_json.TabIndex = 17;
            this.parse_to_json.Text = "PARSE";
            this.parse_to_json.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.parse_to_json.UseSelectable = true;
            this.parse_to_json.Click += new System.EventHandler(this.metroTile12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 522);
            this.Controls.Add(this.parse_to_xml);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.parse_to_xml.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox JsonInput;
        private MetroFramework.Controls.MetroTextBox xmlOutput;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile save_xml;
        private MetroFramework.Controls.MetroTile open_json;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private System.Windows.Forms.TabControl parse_to_xml;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTextBox xmlInput;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTextBox jsonOutput;
        private MetroFramework.Controls.MetroTile open_xml;
        private MetroFramework.Controls.MetroTile save_json;
        private MetroFramework.Controls.MetroTile metroTile11;
        private MetroFramework.Controls.MetroTile parse_to_json;
    }
}

