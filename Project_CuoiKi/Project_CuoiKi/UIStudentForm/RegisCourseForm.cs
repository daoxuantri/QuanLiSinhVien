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
    public partial class RegisCourseForm : Form
    {
        public RegisCourseForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        STUDENT st = new STUDENT();
        CONTACT contact = new CONTACT();
        SCORE sc = new SCORE();
        int studentID = search.idstu;
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select c.Id, c.label, c.period, c.description, ct.fname, ct.lname from course as c inner join contact as ct on c.id_contact = ct.Id where (c.label = '" + textBoxLabel.Text + "') ORDER BY c.Id"));
        }

        private void ButtonCourseRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 0;
                int courseID;
                if (Int32.TryParse(labelIdCourse.Text, out num))
                {
                    courseID = Convert.ToInt32(labelIdCourse.Text);
                }
                else
                {
                    MessageBox.Show("Phải nhập Course ID là số");
                    return;
                }
                if (!sc.studentScoreExist(studentID, courseID))
                {
                    if (sc.insertScorebyStudent(studentID, courseID))
                    {
                        MessageBox.Show("Course Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            labelIdCourse.Text = dgv.Rows[i].Cells[0].Value.ToString();
            labelLabel.Text = dgv.Rows[i].Cells[1].Value.ToString();
            labelPeriod.Text = dgv.Rows[i].Cells[2].Value.ToString();
            labelDescription.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void RegisCourseForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select c.Id, c.label, c.period, c.description, ct.fname, ct.lname from course as c inner join contact as ct on c.id_contact = ct.Id ORDER BY c.Id"));
        }

        public void fillGrid(SqlCommand command)
        {
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 20;
            dgv.AllowUserToAddRows = false;
            dgv.DataSource = st.getStudents(command);
            //demlop
            labelTotalCourse.Text = ("Total Course: " + dgv.Rows.Count);
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select c.Id, c.label, c.period, c.description, ct.fname, ct.lname from course as c inner join contact as ct on c.id_contact = ct.Id ORDER BY c.Id"));
        }

        private void textBoxLabel_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select c.Id, c.label, c.period, c.description, ct.fname, ct.lname from course as c inner join contact as ct on c.id_contact = ct.Id where c.label like '%" + textBoxLabel.Text + "%'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
    }
}
