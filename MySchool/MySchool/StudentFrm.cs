using System;
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
    public partial class StudentFrm : Form
    {
        private int current = 1;
        private string connString = @"Data Source=DESKTOP-162V1H5\ONLY;Initial Catalog=MySchool;Integrated Security=True";
        public StudentFrm()
        {
            InitializeComponent();
            current = 1;
            ShowCurrentStudent();
        }


        private void ShowCurrentStudent()
        {
            string sql = String.Format("SELECT * FROM StudentMsg WHERE StudentNo='{0}'", current);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader.GetString(1);
                    string sex = reader.GetString(2);
                    if (sex == "男")
                        rdoMale.Checked = true;
                    else
                        rdoFemale.Checked = true;
                    dtBirthday.Value = reader.GetDateTime(3);
                    txtDept.Text = reader.GetString(4);
                    txtSpec.Text = reader.GetString(5);
                    string[] hobbies = new string[6];
                    hobbies = reader.GetString(6).Split('、');
                    checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false;
                    checkBox4.Checked = false; checkBox5.Checked = false; checkBox6.Checked = false;
                    foreach (string s in hobbies)
                    {
                        switch (s)
                        {
                            case "阅读": checkBox1.Checked = true; break;
                            case "体育": checkBox2.Checked = true; break;
                            case "音乐": checkBox3.Checked = true; break;
                            case "上网": checkBox4.Checked = true; break;
                            case "旅游": checkBox5.Checked = true; break;
                            default: checkBox6.Checked = true; break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("前面或后面已无数据了", "没有数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
        }

        private void StudentFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current++;
            ShowCurrentStudent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            current--;
            ShowCurrentStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = conn = new SqlConnection(connString);
            string sql = String.Format("DELETE FROM StudentMsg WHERE StudentNo='{0}'", current);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n <= 0)
                {
                    MessageBox.Show("删除失败，请与管理员联系！", "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    current--;
                    ShowCurrentStudent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (rdoMale.Checked)
                sex = "男";
            else
                sex = "女";
            string hobby = "";
            if (checkBox1.Checked) hobby += checkBox1.Text;
            if (checkBox2.Checked) hobby += "、" + checkBox2.Text;
            if (checkBox3.Checked) hobby += "、" + checkBox3.Text;
            if (checkBox4.Checked) hobby += "、" + checkBox4.Text;
            if (checkBox5.Checked) hobby += "、" + checkBox5.Text;
            if (checkBox6.Checked) hobby += "、" + checkBox6.Text;
            SqlConnection conn = conn = new SqlConnection(connString);
            string sql = String.Format("UPDATE StudentMsg SET StudentName='{0}',Sex='{1}',Birthday='{2}',Department='{3}',Speciality='{4}',Hobby='{5}' WHERE StudentNo='{6}'", txtName.Text, sex, dtBirthday.Value, txtDept.Text, txtSpec.Text, hobby, current);//SQL语句
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n <= 0)
                {
                    MessageBox.Show("数据更新操作失败，请检查数据格式！", "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();//关闭数据库连接
            }
        }
    }
}
