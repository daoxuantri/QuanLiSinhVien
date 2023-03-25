using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKi
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        SCORE score = new SCORE();
        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(TextBoxStudentID.Text);
                int courseID = Convert.ToInt32(ComboBoxCourse.SelectedValue);
                float scoreValue = float.Parse(TextBoxScore.Text);
                string description = TextBoxDescription.Text;

                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            ComboBoxCourse.DataSource = course.getAllCourses();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "Id";
            // dua no voi student
            SqlCommand command = new SqlCommand("SELECT Id, fname, lname FROM std");
            DataGridViewStudents.DataSource = student.getStudents(command);
        }

        private void DataGridViewStudents_Click(object sender, EventArgs e)
        {
            TextBoxStudentID.Text = DataGridViewStudents.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
