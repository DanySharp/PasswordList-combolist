namespace PasswordList
{
    partial class PaawordFrm
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
            this.components = new System.ComponentModel.Container();
            this.txtAfterText = new System.Windows.Forms.TextBox();
            this.txtinclude = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBeforeBox = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtexclude = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkAfterBox = new System.Windows.Forms.CheckBox();
            this.checkLowerBox = new System.Windows.Forms.CheckBox();
            this.checkUpperBox = new System.Windows.Forms.CheckBox();
            this.checkCahrBox = new System.Windows.Forms.CheckBox();
            this.checkNumBox = new System.Windows.Forms.CheckBox();
            this.lblmsgnumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtBeforeText = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblcountpasswords = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMobileNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeComboListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAfterText
            // 
            this.txtAfterText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAfterText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfterText.Location = new System.Drawing.Point(111, 188);
            this.txtAfterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAfterText.MaxLength = 15;
            this.txtAfterText.Name = "txtAfterText";
            this.txtAfterText.ReadOnly = true;
            this.txtAfterText.Size = new System.Drawing.Size(175, 27);
            this.txtAfterText.TabIndex = 60;
            this.txtAfterText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAfterText.TextChanged += new System.EventHandler(this.txtAfterText_TextChanged);
            // 
            // txtinclude
            // 
            this.txtinclude.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtinclude.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinclude.Location = new System.Drawing.Point(111, 47);
            this.txtinclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtinclude.MaxLength = 15;
            this.txtinclude.Name = "txtinclude";
            this.txtinclude.Size = new System.Drawing.Size(175, 27);
            this.txtinclude.TabIndex = 46;
            this.txtinclude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(13, 573);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 43);
            this.button1.TabIndex = 52;
            this.button1.Text = "Save Passwords";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Exclude Text :";
            // 
            // checkBeforeBox
            // 
            this.checkBeforeBox.AutoSize = true;
            this.checkBeforeBox.Location = new System.Drawing.Point(32, 226);
            this.checkBeforeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBeforeBox.Name = "checkBeforeBox";
            this.checkBeforeBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBeforeBox.Size = new System.Drawing.Size(132, 21);
            this.checkBeforeBox.TabIndex = 4;
            this.checkBeforeBox.Text = "Add Before Text";
            this.checkBeforeBox.UseVisualStyleBackColor = true;
            this.checkBeforeBox.CheckedChanged += new System.EventHandler(this.checkBeforeBox_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Blue;
            this.btnGenerate.Location = new System.Drawing.Point(316, 488);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(245, 43);
            this.btnGenerate.TabIndex = 51;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Include Text :";
            // 
            // txtexclude
            // 
            this.txtexclude.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtexclude.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexclude.Location = new System.Drawing.Point(111, 90);
            this.txtexclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtexclude.MaxLength = 15;
            this.txtexclude.Name = "txtexclude";
            this.txtexclude.Size = new System.Drawing.Size(175, 27);
            this.txtexclude.TabIndex = 45;
            this.txtexclude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBeforeBox);
            this.groupBox1.Controls.Add(this.checkAfterBox);
            this.groupBox1.Controls.Add(this.checkLowerBox);
            this.groupBox1.Controls.Add(this.checkUpperBox);
            this.groupBox1.Controls.Add(this.checkCahrBox);
            this.groupBox1.Controls.Add(this.checkNumBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(227, 304);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // checkAfterBox
            // 
            this.checkAfterBox.AutoSize = true;
            this.checkAfterBox.Location = new System.Drawing.Point(44, 267);
            this.checkAfterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkAfterBox.Name = "checkAfterBox";
            this.checkAfterBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkAfterBox.Size = new System.Drawing.Size(120, 21);
            this.checkAfterBox.TabIndex = 3;
            this.checkAfterBox.Text = "Add After Text";
            this.checkAfterBox.UseVisualStyleBackColor = true;
            this.checkAfterBox.CheckedChanged += new System.EventHandler(this.checkAfterBox_CheckedChanged);
            // 
            // checkLowerBox
            // 
            this.checkLowerBox.AutoSize = true;
            this.checkLowerBox.Checked = true;
            this.checkLowerBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLowerBox.Location = new System.Drawing.Point(96, 21);
            this.checkLowerBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkLowerBox.Name = "checkLowerBox";
            this.checkLowerBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkLowerBox.Size = new System.Drawing.Size(68, 21);
            this.checkLowerBox.TabIndex = 0;
            this.checkLowerBox.Text = "Lower";
            this.checkLowerBox.UseVisualStyleBackColor = true;
            // 
            // checkUpperBox
            // 
            this.checkUpperBox.AutoSize = true;
            this.checkUpperBox.Location = new System.Drawing.Point(96, 71);
            this.checkUpperBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkUpperBox.Name = "checkUpperBox";
            this.checkUpperBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkUpperBox.Size = new System.Drawing.Size(69, 21);
            this.checkUpperBox.TabIndex = 0;
            this.checkUpperBox.Text = "Upper";
            this.checkUpperBox.UseVisualStyleBackColor = true;
            // 
            // checkCahrBox
            // 
            this.checkCahrBox.AutoSize = true;
            this.checkCahrBox.Location = new System.Drawing.Point(73, 175);
            this.checkCahrBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkCahrBox.Name = "checkCahrBox";
            this.checkCahrBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkCahrBox.Size = new System.Drawing.Size(92, 21);
            this.checkCahrBox.TabIndex = 0;
            this.checkCahrBox.Text = "Character";
            this.checkCahrBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkCahrBox.UseVisualStyleBackColor = true;
            // 
            // checkNumBox
            // 
            this.checkNumBox.AutoSize = true;
            this.checkNumBox.Location = new System.Drawing.Point(85, 124);
            this.checkNumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkNumBox.Name = "checkNumBox";
            this.checkNumBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkNumBox.Size = new System.Drawing.Size(80, 21);
            this.checkNumBox.TabIndex = 0;
            this.checkNumBox.Text = "Number";
            this.checkNumBox.UseVisualStyleBackColor = true;
            // 
            // lblmsgnumber
            // 
            this.lblmsgnumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsgnumber.ForeColor = System.Drawing.Color.Red;
            this.lblmsgnumber.Name = "lblmsgnumber";
            this.lblmsgnumber.Size = new System.Drawing.Size(196, 21);
            this.lblmsgnumber.Text = "Invalid Number in TextBox";
            this.lblmsgnumber.Visible = false;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(100, 20);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(15, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "After Text :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 21);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // txtBeforeText
            // 
            this.txtBeforeText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBeforeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeforeText.Location = new System.Drawing.Point(111, 138);
            this.txtBeforeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBeforeText.MaxLength = 15;
            this.txtBeforeText.Name = "txtBeforeText";
            this.txtBeforeText.ReadOnly = true;
            this.txtBeforeText.Size = new System.Drawing.Size(175, 27);
            this.txtBeforeText.TabIndex = 57;
            this.txtBeforeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.ProgressBar1,
            this.lblmsgnumber,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.lblcountpasswords});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(583, 26);
            this.statusStrip1.TabIndex = 53;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 21);
            this.toolStripStatusLabel1.Text = "Status :";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(13, 21);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(193, 21);
            this.toolStripStatusLabel4.Text = "ListBox Count Passwords :";
            // 
            // lblcountpasswords
            // 
            this.lblcountpasswords.Name = "lblcountpasswords";
            this.lblcountpasswords.Size = new System.Drawing.Size(0, 21);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Before Text :";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(316, 573);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 39);
            this.button2.TabIndex = 56;
            this.button2.Text = "Stop Working";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(143, 234);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(143, 27);
            this.numericUpDown1.TabIndex = 54;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(292, 20);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 464);
            this.listBox1.TabIndex = 48;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 28);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMobileNumberToolStripMenuItem,
            this.makeComboListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // createMobileNumberToolStripMenuItem
            // 
            this.createMobileNumberToolStripMenuItem.Name = "createMobileNumberToolStripMenuItem";
            this.createMobileNumberToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.createMobileNumberToolStripMenuItem.Text = "Create Number List";
            this.createMobileNumberToolStripMenuItem.Click += new System.EventHandler(this.createMobileNumberToolStripMenuItem_Click);
            // 
            // makeComboListToolStripMenuItem
            // 
            this.makeComboListToolStripMenuItem.Name = "makeComboListToolStripMenuItem";
            this.makeComboListToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.makeComboListToolStripMenuItem.Text = "Make ComboList";
            this.makeComboListToolStripMenuItem.Click += new System.EventHandler(this.makeComboListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(0, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 594);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(11, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Password Lenght :";
            // 
            // PaawordFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(583, 654);
            this.Controls.Add(this.txtAfterText);
            this.Controls.Add(this.txtinclude);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtexclude);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBeforeText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PaawordFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PaawordFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAfterText;
        private System.Windows.Forms.TextBox txtinclude;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBeforeBox;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtexclude;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkAfterBox;
        private System.Windows.Forms.CheckBox checkLowerBox;
        private System.Windows.Forms.CheckBox checkUpperBox;
        private System.Windows.Forms.CheckBox checkCahrBox;
        private System.Windows.Forms.CheckBox checkNumBox;
        private System.Windows.Forms.ToolStripStatusLabel lblmsgnumber;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TextBox txtBeforeText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblcountpasswords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMobileNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeComboListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}

