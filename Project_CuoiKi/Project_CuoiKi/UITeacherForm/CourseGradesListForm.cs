using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKi
{
    public partial class CourseGradesListForm : Form
    {
        public CourseGradesListForm()
        {
            InitializeComponent();
        }
        int id = search.idstu;
        My_DB mydb = new My_DB();
        STUDENT sc = new STUDENT();

        private void CourseGradesListForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select c.Id as ID_Course, c.label, st.Id as ID_Student, st.fname, st.lname, s.student_score, s.description from course as c inner join score as s on s.id_course = c.Id inner join contact as co on co.Id = c.id_contact inner join std as st on s.id_student = st.Id where co.Id = " + id + "order by ID_Course"));

        }

        public void fillGrid(SqlCommand command)
        {
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 80;
            dgv.AllowUserToAddRows = false;
            dgv.DataSource = sc.getStudents(command);

        }


        private void buttonAllCourse_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select c.Id as ID_Course, c.label, st.Id as ID_Student, st.fname, st.lname, s.student_score, s.description from course as c inner join score as s on s.id_course = c.Id inner join contact as co on co.Id = c.id_contact inner join std as st on s.id_student = st.Id where co.Id = " + id + "order by ID_Course"));
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            MarkCourseForm mc = new MarkCourseForm();
            // thu tu cua cac cot: ID_Course - label - ID_Student - fname - lname - student_score

            mc.labelIdCourse.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            mc.labelLabel.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            mc.labelIdStudent.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            mc.labelFname.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            mc.labelLName.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            mc.textScore.Text = dgv.CurrentRow.Cells[5].Value.ToString();

            mc.Show();
            this.Hide();
        }

        private void textBoxLabel_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select c.Id as ID_Course, c.label, st.Id as ID_Student, st.fname, st.lname, s.student_score, s.description from course as c inner join score as s on s.id_course = c.Id inner join contact as co on co.Id = c.id_contact inner join std as st on s.id_student = st.Id where co.Id = " + id + "and c.label like '%" + textBoxLabel.Text + "%'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
    }
}
