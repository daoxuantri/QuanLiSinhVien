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
    public partial class MainFormStudent : Form
    {
        public MainFormStudent()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        STUDENT cs = new STUDENT();
        int id = search.idstu;
        private void MainFormStudent_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id WHERE s.Id =" + id);
            DataTable table = cs.getStudents(command);
            if (table.Rows.Count > 0)
            {
                labelIdStudent.Text = table.Rows[0]["Id"].ToString();
                labelFName.Text = table.Rows[0]["fname"].ToString();
                labelLName.Text = table.Rows[0]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    labelGT.Text = "Female";
                }
                else
                {
                    labelGT.Text = "Male";
                }
                labelSDT.Text = table.Rows[0]["phone"].ToString();
                labelAdress.Text = table.Rows[0]["address"].ToString();

                if (table.Rows[0]["picture"] != DBNull.Value)
                {
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox1.Image = Image.FromStream(picture);
                };
                labelClass.Text = table.Rows[0]["Name_Class"].ToString();

            };
        }

        private void đăngKíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisCourseForm add = new RegisCourseForm(); add.Show();
        }

        private void lịchHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseGradesForm add = new CourseGradesForm(); add.Show();
        }

        private void xóaMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseForm add = new CourseForm(); add.Show();
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditInformationStudentForm add = new EditInformationStudentForm();add.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id WHERE s.Id =" + id);
            DataTable table = cs.getStudents(command);
            if (table.Rows.Count > 0)
            {
                labelIdStudent.Text = table.Rows[0]["Id"].ToString();
                labelFName.Text = table.Rows[0]["fname"].ToString();
                labelLName.Text = table.Rows[0]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    labelGT.Text = "Female";
                }
                else
                {
                    labelGT.Text = "Male";
                }
                labelSDT.Text = table.Rows[0]["phone"].ToString();
                labelAdress.Text = table.Rows[0]["address"].ToString();

                if (table.Rows[0]["picture"] != DBNull.Value)
                {
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox1.Image = Image.FromStream(picture);
                };
                labelClass.Text = table.Rows[0]["Name_Class"].ToString();

            };
        }
    }
}
