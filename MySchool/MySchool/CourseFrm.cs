﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool
{
    public partial class CourseFrm : Form
    {
        public CourseFrm()
        {
            InitializeComponent();
        }

        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet("MyScool");
        private void ShowCourses()
        {
            string connString = @"Data Source=DESKTOP-162V1H5\ONLY;Initial Catalog=MySchool;Integrated Security=True";
            string sql = "select CourseId as 课程ID, CourseName as 课程名称, CourseClass as 课程类别, Required 是否必修,Credit as 学分, PrelectionCredit as 理论学时, ExperimentCredit as 实验学时 from CourseMsg";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            da.SelectCommand = comm;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(ds, "CourseMsg");
            dgvCourse.DataSource = ds.Tables["CourseMsg"];
            conn.Close();
        }
        private void CourseFrm_Load(object sender, EventArgs e)
        {
            ShowCourses();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            da.Update(ds, "CourseMsg");
            MessageBox.Show("数据更新已经成功保存！", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您是否真的要取消目前添加、修改或删除操作？", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ds.Clear();
                ShowCourses();
                dgvCourse.Refresh();
            }
        }
    }
}
