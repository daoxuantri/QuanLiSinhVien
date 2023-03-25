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
    public partial class UDStudentForm : Form
    {
        public UDStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
         

        private void buttonUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "SELECT Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
        SCORE score = new SCORE();
        private void buttonEdit_Click(object sender, EventArgs e)
        {
             
            int id;
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            DateTime bdate = DateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAddress.Text;
            string gender = "Male";

            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

           
            int idclass = Int32.Parse(comboBox1.SelectedValue.ToString());

            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year ", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(labelIDStudent.Text);
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic,idclass))
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
                if ((textBoxFirstName.Text.Trim() == "") || (textBoxLastName.Text.Trim() == "") || (textBoxAddress.Text.Trim() == "") || (textBoxPhone.Text.Trim() == "") || pictureBox1.Image == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(labelIDStudent.Text);
            try
            {
                
                if ((MessageBox.Show("Are You Sure Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    student.deleteAccountStudent(studentId); score.deleteAllScore(studentId);
                    
                        
                        if (student.deleteStudent(studentId))
                        {
                            
                            MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            labelIDStudent.Text = "";
                            textBoxFirstName.Text = "";
                            textBoxLastName.Text = "";
                            textBoxAddress.Text = "";
                            textBoxPhone.Text = "";
                            DateTimePicker1.Value = DateTime.Now;
                            pictureBox1.Image = null;

                        }
                        else
                        {
                            MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                      
                   
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UDStudentForm_Load(object sender, EventArgs e)
        {
            ClassSt cl = new ClassSt();
            comboBox1.DataSource = cl.getAllClass();
            comboBox1.DisplayMember = "Name_Class";
            comboBox1.ValueMember = "Id";
        }
    }
}
