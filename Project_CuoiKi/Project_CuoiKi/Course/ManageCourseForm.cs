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
  
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        My_DB mydb = new My_DB();
        int pos;
        CONTACT contact = new CONTACT();
        void reloadListBoxData()
        {
            ListBoxCourses.DataSource = course.getAllCourses();
            ListBoxCourses.ValueMember = "Id"; ListBoxCourses.DisplayMember = "label";// 5V có thể chuyển thành course name hay name
            ListBoxCourses.SelectedItem = null;
            labelTotalCourses.Text = ("Total Courses: " + course.totalCourses());
        }
        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];
            ListBoxCourses.SelectedIndex = index;
            textBoxID.Text = dr.ItemArray[0].ToString();
            textBoxCourseName.Text = dr.ItemArray[1].ToString();
            numericUpDown.Value = int.Parse(dr.ItemArray[2].ToString());
            textBoxDescription.Text = dr.ItemArray[3].ToString();
            if (int.Parse(dr.ItemArray[4].ToString()) != null)
            {
                SqlCommand command = new SqlCommand("select CONCAT(contact.lname,' ',contact.fname) as Ten from contact where Id = " + int.Parse(dr.ItemArray[4].ToString()), mydb.getConnection);
                DataTable dt = contact.SelectContactList(command);
                comboBoxTeacher.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("Môn Học Chưa có giảng viên nào Phụ trách", "Vui lòng chọn môn khác", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void ManageCourseForm_Load(object sender, EventArgs e)
        {

            reloadListBoxData();
            SqlCommand command = new SqlCommand("select Id, CONCAT(lname,' ',fname) as 'Ten' from contact", mydb.getConnection);
            DataTable dt = contact.SelectContactList(command);
            comboBoxTeacher.DataSource = dt;
            comboBoxTeacher.DisplayMember = "Ten";
            comboBoxTeacher.ValueMember = "Id";
        }

        private void ListBoxCourses_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)ListBoxCourses.SelectedItem;
            pos = ListBoxCourses.SelectedIndex;
            showData(pos);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                int Cid = 0;
                int num = 0;
                if (Int32.TryParse(textBoxID.Text, out num))
                {
                    Cid = Int32.Parse(textBoxID.Text);
                }
                else
                {
                    MessageBox.Show("Phải nhập Course ID là số");
                    return;
                }
                
                SqlCommand check = new SqlCommand("select * from course where Id=@id");
                check.Parameters.Add("@id", SqlDbType.VarChar).Value = textBoxID.Text;
                check.Connection = mydb.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(check);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {

                    
                    string name = textBoxCourseName.Text;
                    int hrs = (int)numericUpDown.Value;
                    string descr = textBoxDescription.Text;
                    int id_teacher = Int32.Parse(comboBoxTeacher.SelectedValue.ToString());
                    if (hrs > 10)
                    {
                        if (name.Trim() == "")
                        {
                            MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (course.checkCourseName(name))
                        {
                            if (course.insertCourse(Cid, name, hrs, descr, id_teacher))
                            {
                                MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reloadListBoxData();
                            }
                            else
                            {
                                MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập period > 10", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID đã tồn tại", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ các trường", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool check_input()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxCourseName.Text.Trim() == "") || (textBoxDescription.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxCourseName.Text;
            int hrs = (int)numericUpDown.Value;
            string descr = textBoxDescription.Text;
            int id = int.Parse(textBoxID.Text);
            int id_teacher = Int32.Parse(comboBoxTeacher.SelectedValue.ToString());
            if (hrs > 10)
            {
                if (!course.checkCourseName(name, Convert.ToInt32(textBoxID.Text)))
                {
                    MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (course.updateCourse(id, name, hrs, descr, id_teacher))
                {
                    MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
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
            pos = 0;
        }
        SCORE score = new SCORE();
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int coursetId = Convert.ToInt32(textBoxID.Text);
                if ((MessageBox.Show("Are You sure You want To Delete This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                { 
                    score.deleteTableScoreINcourse(coursetId);
                    
                        if (course.removeCourse(coursetId) )
                        {
                            MessageBox.Show("Course deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxID.Text = "";
                            textBoxCourseName.Text = "";
                            textBoxDescription.Text = "";
                            numericUpDown.Value = 10;
                            reloadListBoxData();

                        }
                        else
                        {
                            MessageBox.Show("Course not deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                    
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid Numberic ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pos = 0;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourses().Rows.Count) - 1)
            {
                pos += 1;
                showData(pos);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos -= 1;
                showData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }
    }
}
