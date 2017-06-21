namespace MySchool
{
    partial class StudentMsgFrm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblHobby = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.lstSpec = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.timeGo = new System.Windows.Forms.Timer(this.components);
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(20, 66);
            this.lblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(52, 15);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "性别：";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(20, 152);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(52, 15);
            this.lblDept.TabIndex = 2;
            this.lblDept.Text = "院系：";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(336, 19);
            this.lblSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(52, 15);
            this.lblSpec.TabIndex = 3;
            this.lblSpec.Text = "专业：";
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(336, 134);
            this.lblHobby.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(52, 15);
            this.lblHobby.TabIndex = 4;
            this.lblHobby.Text = "爱好：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 25);
            this.txtName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Location = new System.Drawing.Point(91, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(195, 46);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(124, 19);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(43, 19);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(9, 18);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(43, 19);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // cboDept
            // 
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Items.AddRange(new object[] {
            "计算机系",
            "微电子技术系",
            "电子信息工程系",
            "经济与管理工程系",
            "图形艺术系"});
            this.cboDept.Location = new System.Drawing.Point(91, 151);
            this.cboDept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(193, 23);
            this.cboDept.TabIndex = 7;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // lstSpec
            // 
            this.lstSpec.FormattingEnabled = true;
            this.lstSpec.ItemHeight = 15;
            this.lstSpec.Location = new System.Drawing.Point(399, 8);
            this.lstSpec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSpec.Name = "lstSpec";
            this.lstSpec.Size = new System.Drawing.Size(215, 79);
            this.lstSpec.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(399, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(227, 69);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(152, 46);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(59, 19);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "其它";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(80, 46);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(59, 19);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "旅游";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(8, 46);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(59, 19);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "上网";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(153, 19);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 19);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "音乐";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(81, 19);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 19);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "体育";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 19);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "阅读";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(131, 184);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 29);
            this.btnYes.TabIndex = 9;
            this.btnYes.Text = "确定(&Y)";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(408, 184);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.Black;
            this.lblTip.Location = new System.Drawing.Point(71, 231);
            this.lblTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(187, 15);
            this.lblTip.TabIndex = 11;
            this.lblTip.Text = "天行健，君子以自强不息！";
            // 
            // timeGo
            // 
            this.timeGo.Tick += new System.EventHandler(this.timeGo_Tick);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(16, 111);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(82, 15);
            this.lblBirthday.TabIndex = 2;
            this.lblBirthday.Text = "出生年月：";
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(100, 105);
            this.dtBirthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtBirthday.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(184, 25);
            this.dtBirthday.TabIndex = 12;
            // 
            // StudentMsgFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 255);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lstSpec);
            this.Controls.Add(this.cboDept);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "StudentMsgFrm";
            this.Text = "添加学生信息";
            this.Load += new System.EventHandler(this.StudentInfoFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.ListBox lstSpec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Timer timeGo;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dtBirthday;
    }
}