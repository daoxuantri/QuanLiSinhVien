using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKi
{
    public partial class MarkCourseForm : Form
    {
        public MarkCourseForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        STUDENT st = new STUDENT();
        SCORE score = new SCORE();
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Are You sure You want To Update score for Student", "Update score for Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {

                    int studentID = Convert.ToInt32(labelIdStudent.Text);
                    int courseID = Convert.ToInt32(labelIdCourse.Text);
                    //float diem = Convert.ToInt32(textScore.Text);
                    float diem = float.Parse(textScore.Text);
                    string description="";
                    if ((diem > 0) && (diem <= 10))
                    {
                        if (0 <= diem && diem < 5)
                        {
                            description = "Trung Binh";
                            if (score.updateScore(studentID, courseID, diem) && score.updateDescription(studentID, courseID,description))
                            {
                                MessageBox.Show("Update score for Student", "Update score for Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Update score for Student", "Update score for Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (diem >= 5 && diem < 8)
                        {
                            description = "Kha";
                            if (score.updateScore(studentID, courseID, diem) && score.updateDescription(studentID, courseID, description))
                            {
                                MessageBox.Show("Update score for Student", "Update score for Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Update score for Student", "Update score for Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            description = "Gioi";
                            if (score.updateScore(studentID, courseID, diem) && score.updateDescription(studentID, courseID, description))
                            {
                                MessageBox.Show("Update score for Student", "Update score for Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Update score for Student", "Update score for Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Phải nhập điểm từ 0 đến 10");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter score", "Update score for Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Are You sure You want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {

                    int studentID = Convert.ToInt32(labelIdStudent.Text);
                    int courseID = Convert.ToInt32(labelIdCourse.Text);
                    if (score.deleteScorebyTeacher(studentID, courseID))
                    {
                        MessageBox.Show("Student deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Completed Student", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter Course ID and Student ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CourseGradesListForm cg = new CourseGradesListForm();
            cg.Show();
            this.Hide();
        }

        private void MarkCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
