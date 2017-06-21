namespace MySchool
{
    partial class CourseMsgFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.nudCredit = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudExp = new System.Windows.Forms.NumericUpDown();
            this.nudPrelection = new System.Windows.Forms.NumericUpDown();
            this.lblExpt = new System.Windows.Forms.Label();
            this.lblPrelection = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoElective = new System.Windows.Forms.RadioButton();
            this.rdoRequired = new System.Windows.Forms.RadioButton();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrelection)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 327);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.nudCredit);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblCredit);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(463, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "课程信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(171, 261);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 29);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "下一步(&C)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // nudCredit
            // 
            this.nudCredit.Location = new System.Drawing.Point(92, 141);
            this.nudCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCredit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCredit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCredit.Name = "nudCredit";
            this.nudCredit.Size = new System.Drawing.Size(160, 25);
            this.nudCredit.TabIndex = 3;
            this.nudCredit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 25);
            this.txtName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudExp);
            this.groupBox2.Controls.Add(this.nudPrelection);
            this.groupBox2.Controls.Add(this.lblExpt);
            this.groupBox2.Controls.Add(this.lblPrelection);
            this.groupBox2.Location = new System.Drawing.Point(11, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(432, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学时分配";
            // 
            // nudExp
            // 
            this.nudExp.Location = new System.Drawing.Point(319, 24);
            this.nudExp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudExp.Name = "nudExp";
            this.nudExp.Size = new System.Drawing.Size(75, 25);
            this.nudExp.TabIndex = 4;
            // 
            // nudPrelection
            // 
            this.nudPrelection.Location = new System.Drawing.Point(91, 24);
            this.nudPrelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPrelection.Name = "nudPrelection";
            this.nudPrelection.Size = new System.Drawing.Size(85, 25);
            this.nudPrelection.TabIndex = 4;
            this.nudPrelection.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lblExpt
            // 
            this.lblExpt.AutoSize = true;
            this.lblExpt.Location = new System.Drawing.Point(224, 26);
            this.lblExpt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpt.Name = "lblExpt";
            this.lblExpt.Size = new System.Drawing.Size(82, 15);
            this.lblExpt.TabIndex = 0;
            this.lblExpt.Text = "实验学时：";
            // 
            // lblPrelection
            // 
            this.lblPrelection.AutoSize = true;
            this.lblPrelection.Location = new System.Drawing.Point(13, 26);
            this.lblPrelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrelection.Name = "lblPrelection";
            this.lblPrelection.Size = new System.Drawing.Size(82, 15);
            this.lblPrelection.TabIndex = 0;
            this.lblPrelection.Text = "理论学时：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoElective);
            this.groupBox1.Controls.Add(this.rdoRequired);
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.lblClass);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(435, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类别";
            // 
            // rdoElective
            // 
            this.rdoElective.AutoSize = true;
            this.rdoElective.Location = new System.Drawing.Point(321, 24);
            this.rdoElective.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoElective.Name = "rdoElective";
            this.rdoElective.Size = new System.Drawing.Size(58, 19);
            this.rdoElective.TabIndex = 2;
            this.rdoElective.Text = "选修";
            this.rdoElective.UseVisualStyleBackColor = true;
            // 
            // rdoRequired
            // 
            this.rdoRequired.AutoSize = true;
            this.rdoRequired.Checked = true;
            this.rdoRequired.Location = new System.Drawing.Point(251, 24);
            this.rdoRequired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoRequired.Name = "rdoRequired";
            this.rdoRequired.Size = new System.Drawing.Size(58, 19);
            this.rdoRequired.TabIndex = 2;
            this.rdoRequired.TabStop = true;
            this.rdoRequired.Text = "必修";
            this.rdoRequired.UseVisualStyleBackColor = true;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "公共必修",
            "专业必修",
            "公共选修",
            "专业选修"});
            this.cboClass.Location = new System.Drawing.Point(85, 22);
            this.cboClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(135, 23);
            this.cboClass.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(0, 26);
            this.lblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(82, 15);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "课程类别：";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(25, 148);
            this.lblCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(52, 15);
            this.lblCredit.TabIndex = 0;
            this.lblCredit.Text = "学分：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "课程名称：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnColor);
            this.tabPage2.Controls.Add(this.btnFont);
            this.tabPage2.Controls.Add(this.btnYes);
            this.tabPage2.Controls.Add(this.txtInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(463, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "确定信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(160, 231);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 29);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "颜色(&C)";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(36, 231);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(100, 29);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "字体(&F)";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(287, 231);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 29);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "确认(&Y)";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(8, 9);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(437, 214);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "";
            // 
            // CourseMsgFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 333);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseMsgFrm";
            this.Text = "添加课程信息";
            this.Load += new System.EventHandler(this.CourseMsgFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrelection)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.NumericUpDown nudCredit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudExp;
        private System.Windows.Forms.NumericUpDown nudPrelection;
        private System.Windows.Forms.Label lblExpt;
        private System.Windows.Forms.Label lblPrelection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoElective;
        private System.Windows.Forms.RadioButton rdoRequired;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
    }
}