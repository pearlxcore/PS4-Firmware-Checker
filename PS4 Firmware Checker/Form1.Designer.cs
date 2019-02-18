namespace PS4_Firmware_Checker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFWLabelSYS = new System.Windows.Forms.TextBox();
            this.tbSDKVersionSYS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVersionSYS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLinkSYS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSizeSYS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLinkREC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSizeREC = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFWVersion = new System.Windows.Forms.TextBox();
            this.tbFWLabelREC = new System.Windows.Forms.TextBox();
            this.tbSDKVersionREC = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firmware Label : ";
            // 
            // tbFWLabelSYS
            // 
            this.tbFWLabelSYS.Location = new System.Drawing.Point(144, 28);
            this.tbFWLabelSYS.Name = "tbFWLabelSYS";
            this.tbFWLabelSYS.Size = new System.Drawing.Size(100, 20);
            this.tbFWLabelSYS.TabIndex = 1;
            this.tbFWLabelSYS.TabStop = false;
            this.tbFWLabelSYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSDKVersionSYS
            // 
            this.tbSDKVersionSYS.Location = new System.Drawing.Point(144, 61);
            this.tbSDKVersionSYS.Name = "tbSDKVersionSYS";
            this.tbSDKVersionSYS.Size = new System.Drawing.Size(100, 20);
            this.tbSDKVersionSYS.TabIndex = 3;
            this.tbSDKVersionSYS.TabStop = false;
            this.tbSDKVersionSYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SDK Version :";
            // 
            // tbVersionSYS
            // 
            this.tbVersionSYS.Location = new System.Drawing.Point(144, 94);
            this.tbVersionSYS.Name = "tbVersionSYS";
            this.tbVersionSYS.Size = new System.Drawing.Size(100, 20);
            this.tbVersionSYS.TabIndex = 5;
            this.tbVersionSYS.TabStop = false;
            this.tbVersionSYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Firmware Version :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLinkSYS);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbSizeSYS);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbVersionSYS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFWLabelSYS);
            this.groupBox1.Controls.Add(this.tbSDKVersionSYS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 210);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firmware Info";
            // 
            // tbLinkSYS
            // 
            this.tbLinkSYS.Location = new System.Drawing.Point(144, 160);
            this.tbLinkSYS.Name = "tbLinkSYS";
            this.tbLinkSYS.Size = new System.Drawing.Size(309, 20);
            this.tbLinkSYS.TabIndex = 12;
            this.tbLinkSYS.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Link :";
            // 
            // tbSizeSYS
            // 
            this.tbSizeSYS.Location = new System.Drawing.Point(144, 127);
            this.tbSizeSYS.Name = "tbSizeSYS";
            this.tbSizeSYS.Size = new System.Drawing.Size(100, 20);
            this.tbSizeSYS.TabIndex = 10;
            this.tbSizeSYS.TabStop = false;
            this.tbSizeSYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Firmware Size :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(270, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 119);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Download Firmware";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Australia",
            "Brazil",
            "China",
            "European Union",
            "Japan",
            "Korea",
            "Latin/Central America",
            "North America",
            "Rusia",
            "Southeast Asia",
            "Taiwan",
            "United Kingdom"});
            this.comboBox1.Location = new System.Drawing.Point(27, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.TabStop = false;
            this.comboBox1.Text = "Select Server Region";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Download ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbLinkREC);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbSizeREC);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbFWVersion);
            this.groupBox2.Controls.Add(this.tbFWLabelREC);
            this.groupBox2.Controls.Add(this.tbSDKVersionREC);
            this.groupBox2.Location = new System.Drawing.Point(24, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 210);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firmware Info";
            // 
            // tbLinkREC
            // 
            this.tbLinkREC.Location = new System.Drawing.Point(143, 163);
            this.tbLinkREC.Name = "tbLinkREC";
            this.tbLinkREC.Size = new System.Drawing.Size(309, 20);
            this.tbLinkREC.TabIndex = 15;
            this.tbLinkREC.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Link :";
            // 
            // tbSizeREC
            // 
            this.tbSizeREC.Location = new System.Drawing.Point(143, 129);
            this.tbSizeREC.Name = "tbSizeREC";
            this.tbSizeREC.Size = new System.Drawing.Size(100, 20);
            this.tbSizeREC.TabIndex = 13;
            this.tbSizeREC.TabStop = false;
            this.tbSizeREC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Location = new System.Drawing.Point(269, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 122);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Download Firmware";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Download ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "North America",
            "United Kingdom",
            "Australia",
            "Brazil",
            "China",
            "European Union",
            "Japan",
            "Korea",
            "Latin/Central America",
            "Rusia",
            "Southeast Asia",
            "Taiwan"});
            this.comboBox2.Location = new System.Drawing.Point(28, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Select Server Region";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Firmware Size :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Firmware Label : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Firmware Version :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SDK Version :";
            // 
            // tbFWVersion
            // 
            this.tbFWVersion.Location = new System.Drawing.Point(143, 95);
            this.tbFWVersion.Name = "tbFWVersion";
            this.tbFWVersion.Size = new System.Drawing.Size(100, 20);
            this.tbFWVersion.TabIndex = 5;
            this.tbFWVersion.TabStop = false;
            this.tbFWVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFWLabelREC
            // 
            this.tbFWLabelREC.Location = new System.Drawing.Point(143, 27);
            this.tbFWLabelREC.Name = "tbFWLabelREC";
            this.tbFWLabelREC.Size = new System.Drawing.Size(100, 20);
            this.tbFWLabelREC.TabIndex = 1;
            this.tbFWLabelREC.TabStop = false;
            this.tbFWLabelREC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSDKVersionREC
            // 
            this.tbSDKVersionREC.Location = new System.Drawing.Point(143, 61);
            this.tbSDKVersionREC.Name = "tbSDKVersionREC";
            this.tbSDKVersionREC.Size = new System.Drawing.Size(100, 20);
            this.tbSDKVersionREC.TabIndex = 3;
            this.tbSDKVersionREC.TabStop = false;
            this.tbSDKVersionREC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 281);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "System Firmware";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recovery Firmware";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 315);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS4 Firmware Checker by pearlxcore";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFWLabelSYS;
        private System.Windows.Forms.TextBox tbSDKVersionSYS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVersionSYS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbFWVersion;
        private System.Windows.Forms.TextBox tbFWLabelREC;
        private System.Windows.Forms.TextBox tbSDKVersionREC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbLinkSYS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSizeSYS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSizeREC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbLinkREC;
        private System.Windows.Forms.Label label12;
    }
}

