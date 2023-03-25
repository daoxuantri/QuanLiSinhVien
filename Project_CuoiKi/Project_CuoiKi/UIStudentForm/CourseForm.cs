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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }
        STUDENT sc = new STUDENT();
        My_DB mydb = new My_DB();
        SCORE score = new SCORE();
        int id = search.idstu;
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                int courseID = Convert.ToInt32(textCourseID.Text);
                if ((MessageBox.Show("Are You sure You want To Delete This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (score.deleteScorebyStudent(id, courseID))
                    {
                        MessageBox.Show("Course deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Completed course", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter Course ID", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("select c.Id, c.label, ct.fname, ct.lname, ct.email from course as c inner join contact as ct on c.id_contact = ct.Id inner join score as s on s.id_course = c.Id inner join std on s.id_student = std.Id where std.Id = " + id));

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select c.Id, c.label, ct.fname, ct.lname, ct.email from course as c inner join contact as ct on c.id_contact = ct.Id inner join score as s on s.id_course = c.Id inner join std on s.id_student = std.Id where std.Id = " + id));


        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCourseID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
        }
        public void fillGrid(SqlCommand command)
        {
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 80;
            dgv.AllowUserToAddRows = false;
            dgv.DataSource = sc.getStudents(command);

            //demkhoahoc
            labelTotalCourse.Text = ("Total Course: " + dgv.Rows.Count);
        }
    }
}
