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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                int Cid = 0;
                int num = 0;
                if (Int32.TryParse(textBoxCourseID.Text, out num))
                {
                    Cid = Int32.Parse(textBoxCourseID.Text);
                }
                else
                {
                    MessageBox.Show("Phải nhập Course ID là số");
                    return;
                }
                My_DB mydb = new My_DB();
                COURSE course = new COURSE();
                SqlCommand check = new SqlCommand("select * from course where Id=@id");
                check.Parameters.Add("@id", SqlDbType.VarChar).Value = textBoxCourseID.Text;
                check.Connection = mydb.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(check);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    string name = textBoxLabel.Text;
                    int hrs;
                    if (Int32.TryParse(textBoxPeriod.Text, out num))
                    {
                        hrs = Int32.Parse(textBoxPeriod.Text);
                    }
                    else
                    {
                        MessageBox.Show("Phải nhập Period là số");
                        return;
                    }
                    string descr = textBoxDescription.Text;
                    int id_teacher = Int32.Parse(ComboBoxteacher.SelectedValue.ToString());
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
            if ((textBoxCourseID.Text.Trim() == "") || (textBoxDescription.Text.Trim() == "") || (textBoxLabel.Text.Trim() == "") || (textBoxPeriod.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        CONTACT contact = new CONTACT();
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select id, CONCAT(fname,' ',lname) as 'Ten' from contact", mydb.getConnection);
            
            DataTable dt = contact.SelectContactList(command);
            ComboBoxteacher.DataSource = dt;
            ComboBoxteacher.DisplayMember = "Ten";
            ComboBoxteacher.ValueMember = "id";

        }
        
    }
}
