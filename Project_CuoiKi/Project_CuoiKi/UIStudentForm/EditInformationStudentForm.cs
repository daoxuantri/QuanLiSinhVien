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
    public partial class EditInformationStudentForm : Form
    {
        public EditInformationStudentForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        STUDENT cs = new STUDENT();
        int id = search.idstu;
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(labelIdStudent.Text);
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            DateTime bdate = DateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAddress.Text;

            int num = 0;
            if (Int32.TryParse(textBoxPhone.Text, out num))
            {
                phone = textBoxPhone.Text.ToString();
            }
            else
            {
                MessageBox.Show("Phải nhập số điện thoại là số");
                return;
            }
            string gender = "Male";
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;


            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year ", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    if (cs.editStudent(id, fname, lname, bdate, gender, phone, adrs))
                    {
                        MessageBox.Show("Student Infor Update ", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fiedls", "Edit Student ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bool verif()
            {
                if ((textBoxFName.Text.Trim() == "") || (textBoxLName.Text.Trim() == "") || (textBoxAddress.Text.Trim() == "") || (textBoxPhone.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private void EditInformationStudentForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id WHERE s.Id =" + id);
            DataTable table = cs.getStudents(command);
            if (table.Rows.Count > 0)
            {
                labelIdStudent.Text = table.Rows[0]["Id"].ToString();
                textBoxFName.Text = table.Rows[0]["fname"].ToString();
                textBoxLName.Text = table.Rows[0]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    RadioButtonFemale.Checked = true;
                }
                else
                {
                    RadioButtonMale.Checked = true;
                }
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxAddress.Text = table.Rows[0]["address"].ToString();

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
