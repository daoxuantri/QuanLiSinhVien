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
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        SCORE score = new SCORE();
        My_DB mydb = new My_DB();
        string data = "score";
        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxStudentID.Text);
                int courseID = Convert.ToInt32(comboBoxCourse.SelectedValue);
                float scoreValue = float.Parse(TextBoxScore.Text);
                string description = TextBoxDescription.Text;
                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataGridView1.DataSource = score.getStudentsScore();
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

        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = (int)DataGridView1.CurrentRow.Cells[0].Value;
                int courseId = (int)DataGridView1.CurrentRow.Cells[3].Value;
                if ((MessageBox.Show("Are You sure You want To Delete This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (score.deleteScore(studentId, courseId))
                    {
                        MessageBox.Show("Score deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxStudentID.Text = "";
                        TextBoxScore.Text = "";
                        TextBoxDescription.Text = "";
                        DataGridView1.DataSource = score.getStudentsScore();
                    }
                    else
                    {
                        MessageBox.Show("Score not deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please choose student id and course id", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAVGScoreByCourse_Click(object sender, EventArgs e)
        {
            AvgScoreForm avgScoreByCourseForm = new AvgScoreForm();
            avgScoreByCourseForm.Show();

        }

        private void buttonShowStudents_Click(object sender, EventArgs e)
        {
            data = "std";
            SqlCommand command = new SqlCommand("select Id,fname, lname,bdate from std");
            DataGridView1.DataSource = student.getStudents(command);


        }

        private void buttonShowScores_Click(object sender, EventArgs e)
        {
            data = "score";
            DataGridView1.DataSource = score.getStudentsScore();

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFormDatagridview();

        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {

            DataGridView1.DataSource = score.getStudentsScore();
            comboBoxCourse.DataSource = course.getAllCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "Id";

        }
        void getDataFormDatagridview()
        {
            if (data == "std")
            {
                textBoxStudentID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
                TextBoxScore.Text = "";
            }
            else if (data == "score")
            {
                textBoxStudentID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBoxCourse.SelectedValue = DataGridView1.CurrentRow.Cells[3].Value;
                TextBoxScore.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
                SqlCommand command = new SqlCommand();
                command.Connection = mydb.getConnection;
                command.CommandText = ("select description from score where id_student=" + Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value) + "and id_course=" + Convert.ToInt32(DataGridView1.CurrentRow.Cells[3].Value));
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        TextBoxDescription.Text = table.Rows[i].ItemArray[j].ToString();
                    }
                }
            }
        }
    }
}
