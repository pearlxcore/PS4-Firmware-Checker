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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMD5SYS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSizeSYS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbVersionSYS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFWLabelSYS = new System.Windows.Forms.TextBox();
            this.tbSDKVersionSYS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMD5REC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbFWVersionBETA = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSDKBETA = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbmandatory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbmandatory);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbMD5SYS);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 256);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Firmware Info";
            // 
            // tbMD5SYS
            // 
            this.tbMD5SYS.Location = new System.Drawing.Point(206, 206);
            this.tbMD5SYS.Name = "tbMD5SYS";
            this.tbMD5SYS.ReadOnly = true;
            this.tbMD5SYS.Size = new System.Drawing.Size(411, 22);
            this.tbMD5SYS.TabIndex = 12;
            this.tbMD5SYS.TabStop = false;
            this.tbMD5SYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "MD5 :";
            // 
            // tbSizeSYS
            // 
            this.tbSizeSYS.Location = new System.Drawing.Point(206, 138);
            this.tbSizeSYS.Name = "tbSizeSYS";
            this.tbSizeSYS.ReadOnly = true;
            this.tbSizeSYS.Size = new System.Drawing.Size(132, 22);
            this.tbSizeSYS.TabIndex = 10;
            this.tbSizeSYS.TabStop = false;
            this.tbSizeSYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Firmware Size :";
            // 
            // tbVersionSYS
            // 
            this.tbVersionSYS.Location = new System.Drawing.Point(206, 102);
            this.tbVersionSYS.Name = "tbVersionSYS";
            this.tbVersionSYS.ReadOnly = true;
            this.tbVersionSYS.Size = new System.Drawing.Size(132, 22);
            this.tbVersionSYS.TabIndex = 5;
            this.tbVersionSYS.TabStop = false;
            this.tbVersionSYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firmware Label : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Firmware Version :";
            // 
            // tbFWLabelSYS
            // 
            this.tbFWLabelSYS.Location = new System.Drawing.Point(206, 32);
            this.tbFWLabelSYS.Name = "tbFWLabelSYS";
            this.tbFWLabelSYS.ReadOnly = true;
            this.tbFWLabelSYS.Size = new System.Drawing.Size(132, 22);
            this.tbFWLabelSYS.TabIndex = 1;
            this.tbFWLabelSYS.TabStop = false;
            this.tbFWLabelSYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSDKVersionSYS
            // 
            this.tbSDKVersionSYS.Location = new System.Drawing.Point(206, 67);
            this.tbSDKVersionSYS.Name = "tbSDKVersionSYS";
            this.tbSDKVersionSYS.ReadOnly = true;
            this.tbSDKVersionSYS.Size = new System.Drawing.Size(132, 22);
            this.tbSDKVersionSYS.TabIndex = 3;
            this.tbSDKVersionSYS.TabStop = false;
            this.tbSDKVersionSYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "SDK Version :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(374, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 126);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Download Firmware";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Australia",
            "Brazil",
            "China",
            "European Union",
            "Japan",
            "Korea",
            "Latin/Central America",
            "United States",
            "Rusia",
            "Southeast Asia",
            "Taiwan",
            "United Kingdom"});
            this.comboBox1.Location = new System.Drawing.Point(35, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 22);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Download ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMD5REC);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbSizeREC);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbFWVersion);
            this.groupBox2.Controls.Add(this.tbFWLabelREC);
            this.groupBox2.Controls.Add(this.tbSDKVersionREC);
            this.groupBox2.Location = new System.Drawing.Point(14, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 226);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recovery Firmware Info";
            // 
            // tbMD5REC
            // 
            this.tbMD5REC.Location = new System.Drawing.Point(206, 173);
            this.tbMD5REC.Name = "tbMD5REC";
            this.tbMD5REC.ReadOnly = true;
            this.tbMD5REC.Size = new System.Drawing.Size(411, 22);
            this.tbMD5REC.TabIndex = 15;
            this.tbMD5REC.TabStop = false;
            this.tbMD5REC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "MD5 :";
            // 
            // tbSizeREC
            // 
            this.tbSizeREC.Location = new System.Drawing.Point(206, 139);
            this.tbSizeREC.Name = "tbSizeREC";
            this.tbSizeREC.ReadOnly = true;
            this.tbSizeREC.Size = new System.Drawing.Size(132, 22);
            this.tbSizeREC.TabIndex = 13;
            this.tbSizeREC.TabStop = false;
            this.tbSizeREC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Location = new System.Drawing.Point(374, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 131);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Download Firmware";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Download ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "United States",
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
            this.comboBox2.Location = new System.Drawing.Point(38, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 22);
            this.comboBox2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Firmware Size :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Firmware Label : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Firmware Version :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "SDK Version :";
            // 
            // tbFWVersion
            // 
            this.tbFWVersion.Location = new System.Drawing.Point(206, 102);
            this.tbFWVersion.Name = "tbFWVersion";
            this.tbFWVersion.ReadOnly = true;
            this.tbFWVersion.Size = new System.Drawing.Size(132, 22);
            this.tbFWVersion.TabIndex = 5;
            this.tbFWVersion.TabStop = false;
            this.tbFWVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFWLabelREC
            // 
            this.tbFWLabelREC.Location = new System.Drawing.Point(206, 29);
            this.tbFWLabelREC.Name = "tbFWLabelREC";
            this.tbFWLabelREC.ReadOnly = true;
            this.tbFWLabelREC.Size = new System.Drawing.Size(132, 22);
            this.tbFWLabelREC.TabIndex = 1;
            this.tbFWLabelREC.TabStop = false;
            this.tbFWLabelREC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSDKVersionREC
            // 
            this.tbSDKVersionREC.Location = new System.Drawing.Point(206, 66);
            this.tbSDKVersionREC.Name = "tbSDKVersionREC";
            this.tbSDKVersionREC.ReadOnly = true;
            this.tbSDKVersionREC.Size = new System.Drawing.Size(132, 22);
            this.tbSDKVersionREC.TabIndex = 3;
            this.tbSDKVersionREC.TabStop = false;
            this.tbSDKVersionREC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbFWVersionBETA);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.tbSDKBETA);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(13, 508);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(662, 80);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Latest Beta Firmware";
            // 
            // tbFWVersionBETA
            // 
            this.tbFWVersionBETA.Location = new System.Drawing.Point(509, 32);
            this.tbFWVersionBETA.Name = "tbFWVersionBETA";
            this.tbFWVersionBETA.ReadOnly = true;
            this.tbFWVersionBETA.Size = new System.Drawing.Size(132, 22);
            this.tbFWVersionBETA.TabIndex = 5;
            this.tbFWVersionBETA.TabStop = false;
            this.tbFWVersionBETA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(349, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 14);
            this.label14.TabIndex = 4;
            this.label14.Text = "Roll Back Firmware :";
            // 
            // tbSDKBETA
            // 
            this.tbSDKBETA.Location = new System.Drawing.Point(174, 32);
            this.tbSDKBETA.Name = "tbSDKBETA";
            this.tbSDKBETA.ReadOnly = true;
            this.tbSDKBETA.Size = new System.Drawing.Size(132, 22);
            this.tbSDKBETA.TabIndex = 3;
            this.tbSDKBETA.TabStop = false;
            this.tbSDKBETA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 14);
            this.label15.TabIndex = 2;
            this.label15.Text = "Firmware Version :";
            // 
            // tbmandatory
            // 
            this.tbmandatory.Location = new System.Drawing.Point(207, 172);
            this.tbmandatory.Name = "tbmandatory";
            this.tbmandatory.ReadOnly = true;
            this.tbmandatory.Size = new System.Drawing.Size(132, 22);
            this.tbmandatory.TabIndex = 14;
            this.tbmandatory.TabStop = false;
            this.tbmandatory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mandatory :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 603);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMD5SYS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSizeSYS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbVersionSYS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFWLabelSYS;
        private System.Windows.Forms.TextBox tbSDKVersionSYS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMD5REC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSizeREC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFWVersion;
        private System.Windows.Forms.TextBox tbFWLabelREC;
        private System.Windows.Forms.TextBox tbSDKVersionREC;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbFWVersionBETA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSDKBETA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbmandatory;
        private System.Windows.Forms.Label label8;
    }
}

