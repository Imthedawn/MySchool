using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MySchool
{
    public partial class ScoreMsgFrm : Form
    {
        private List<StudentMsg> StudentList;
        private List<CourseMsg> CourseList;
        private List<ScoreMsg> ScoreList;
        private int current;
        private MyScloolDBContext db;
        public ScoreMsgFrm()
        {
            InitializeComponent();
            StudentList = new List<StudentMsg>();
            CourseList = new List<CourseMsg>();
            ScoreList = new List<ScoreMsg>();
            current = 1;
            string sqlConn = @"Data Source=DESKTOP-162V1H5\ONLY;Initial Catalog=MySchool;Integrated Security=True";
            db = new MyScloolDBContext(sqlConn);
        }

        private void showScore()
        {
            if (current >= 1 && current <= ScoreList.Count)
            {
                txtCourseId.Text = ScoreList[current - 1].CourseId.ToString();
                txtStudentId.Text = ScoreList[current - 1].StudentNo.ToString();
                txtScore.Text = ScoreList[current - 1].Score.ToString();
            }
        }

        private void ScoreMsgFrm_Load(object sender, EventArgs e)
        {
            var queryScore = from score in db.scores select score;
            foreach (var score in queryScore)
            {
                ScoreList.Add(score);
            }
            showScore();
        }

        private void txtCourseId_TextChanged(object sender, EventArgs e)
        {
            var queryCourse = from course in db.courses where course.CourseId == int.Parse(txtCourseId.Text) select course;
            foreach (var course in queryCourse)
            {
                txtCourseName.Text = course.CourseName;
            }

        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            var queryStudent = from student in db.students where student.StudentNo == int.Parse(txtStudentId.Text) select student;
            foreach (var student in queryStudent)
            {
                txtStudentName.Text = student.StudentName;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (current == 1)
                MessageBox.Show("已经到第一条了", "注意", MessageBoxButtons.OK);
            else
            {
                current--;
                showScore();
            };
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current == ScoreList.Count)
                MessageBox.Show("已经到最后一条了", "注意", MessageBoxButtons.OK);
            else
            {
                current++;
                showScore();
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ScoreMsg score = new ScoreMsg(int.Parse(txtCourseId.Text), int.Parse(txtStudentId.Text), int.Parse(txtScore.Text));
            db.scores.InsertOnSubmit(score);
            try
            {
                db.SubmitChanges();
                ScoreList.Add(score);
                current = ScoreList.Count;
                showScore();
                MessageBox.Show("已经到成功添加新记录", "注意", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注意", MessageBoxButtons.OK);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (current >= 1 && current <= ScoreList.Count)
            {
                var updateScores = from score in db.scores where (score.CourseId == ScoreList[current - 1].CourseId && score.StudentNo == ScoreList[current - 1].StudentNo) select score;
                foreach (ScoreMsg score in updateScores)
                {
                    score.Score = int.Parse(txtScore.Text);
                }
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("已经到成功更新记录", "注意", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "注意", MessageBoxButtons.OK);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (current >= 1 && current <= ScoreList.Count)
            {
                var delScore = from score in db.scores where (score.CourseId == ScoreList[current - 1].CourseId && score.StudentNo == ScoreList[current - 1].StudentNo) select score;
                foreach (ScoreMsg score in delScore)
                {
                    db.scores.DeleteOnSubmit(score);
                }
                try
                {
                    db.SubmitChanges();
                    ScoreList.RemoveAt(current - 1);
                    if (current > 0) current--;
                    showScore();
                    MessageBox.Show("已经到成功删除记录", "注意", MessageBoxButtons.OK); ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "注意", MessageBoxButtons.OK);
                }
            }
        }
    }
}
