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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        STUDENT student = new STUDENT();
        ClassSt cs = new ClassSt();
        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            int Cid = 0;
            int num = 0;
            if (Int32.TryParse(txtStudentID.Text, out num))
            {
                Cid = Int32.Parse(txtStudentID.Text);
            }
            else
            {
                MessageBox.Show("Phải nhập student ID là số");
                return;
            }
            SqlCommand check = new SqlCommand("select * from std where Id=@id");
            check.Parameters.Add("@id", SqlDbType.Int).Value = Cid;
            check.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(check);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                STUDENT student = new STUDENT();
                int id = Convert.ToInt32(txtStudentID.Text);
                string fname = TextBoxFName.Text;
                string lname = TextBoxLName.Text;
                DateTime bdate = DateTimePicker1.Value;
                string phone = TextBoxPhone.Text;
                string adrs = TextBoxAddress.Text;
                string gender = "Male";

                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                int born_year = DateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                int idclass = Int32.Parse(comboBox1.SelectedValue.ToString());
                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    //Độ tuổi của sinh viên phải từ 18 đến 100 tuổi                      Ngày sinh không hợp lệ 

                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year ", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (Int32.TryParse(TextBoxPhone.Text, out num))
                    {
                        phone = TextBoxPhone.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Phải nhập số điện thoại là số");
                        return;
                    }
                    string users = textBoxUserName.Text;
                    string pass = textBoxPassWord.Text;
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic, idclass) && student.insertUser(id, users, pass))
                    {
                        DialogResult result = MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {

                            TextBoxFName.Text = "";
                            TextBoxLName.Text = "";
                            TextBoxPhone.Text = "";
                            TextBoxAddress.Text = "";
                            //textidclass--> chinh sua 

                            comboBox1.Text = "";
                            textBoxUserName.Text = "";
                            textBoxPassWord.Text = "";
                            txtStudentID.Text = "";
                            txtStudentID.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Empty Fiedls", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStudentID.Focus();

                }
            }
            else
            {
                MessageBox.Show("Nhập trùng ID",
                       "Trùng ID",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                txtStudentID.Focus();
            }
            bool verif()
            {
                if ((TextBoxFName.Text.Trim() == "") || (TextBoxLName.Text.Trim() == "") || (TextBoxAddress.Text.Trim() == "") || (TextBoxPhone.Text.Trim() == "") || PictureBoxStudentImage.Image == null || (textBoxUserName.Text.Trim() == "") || (textBoxPassWord.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        

        public void fillCombo(int index)
        {
            comboBox1.DataSource = cs.getAllClass();
            comboBox1.DisplayMember = "Name_Class";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedItem = index;

        }
        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = cs.getAllClass();
            comboBox1.DisplayMember = "Name_Class";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedItem = null;
        }


    }
}
