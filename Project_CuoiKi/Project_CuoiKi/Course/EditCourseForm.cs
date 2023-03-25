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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        COURSE course = new COURSE();
        CONTACT contact = new CONTACT();
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxCourseName.Text;
            int hrs = (int)numericUpDown.Value;
            string descr = textBoxDescription.Text;
            int id = (int)(comboBoxSelectCourse.SelectedValue);
            int id_teacher = Int32.Parse(ComboBoxteacher.SelectedValue.ToString());
            if (hrs > 10)
            {
                if (!course.checkCourseName(name, Convert.ToInt32(comboBoxSelectCourse.SelectedValue)))
                {
                    MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (course.updateCourse(id, name, hrs, descr, id_teacher))
                {
                    MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information); fillCombo(comboBoxSelectCourse.SelectedIndex);
                    fillCombo(comboBoxSelectCourse.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập period > 10", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void fillCombo(int index)
        {
            comboBoxSelectCourse.DataSource = course.getAllCourses();
            comboBoxSelectCourse.DisplayMember = "label";
            comboBoxSelectCourse.ValueMember = "Id";
            comboBoxSelectCourse.SelectedItem = index;
            
        }

        private void comboBoxSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxSelectCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                textBoxCourseName.Text = table.Rows[0][1].ToString();
                numericUpDown.Value = Int32.Parse(table.Rows[0][2].ToString());
                textBoxDescription.Text = table.Rows[0][3].ToString();
                SqlCommand command = new SqlCommand("select CONCAT(contact.lname,' ',contact.fname) as Ten from contact where Id = " + Int32.Parse(table.Rows[0][4].ToString()), mydb.getConnection);
                DataTable dt = contact.SelectContactList(command);
                ComboBoxteacher.Text = dt.Rows[0][0].ToString();
                
            }
            catch { }
        }

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            comboBoxSelectCourse.DataSource = course.getAllCourses();
            comboBoxSelectCourse.DisplayMember = "label";
            comboBoxSelectCourse.ValueMember = "Id";
            comboBoxSelectCourse.SelectedItem = null;
            SqlCommand command = new SqlCommand("select Id, CONCAT(lname,' ',fname) as 'Ten' from contact", mydb.getConnection);
            DataTable dt = contact.SelectContactList(command);
            ComboBoxteacher.DataSource = dt;
            ComboBoxteacher.DisplayMember = "Ten";
            ComboBoxteacher.ValueMember = "Id";
        }
    }
}
