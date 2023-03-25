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
    public partial class RegisterHR : Form
    {
        public RegisterHR()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "SELECT Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                ptbPicture.Image = Image.FromFile(opf.FileName);
            }
        }
        USER user = new USER(); My_DB mydb = new My_DB();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                MessageBox.Show("Hãy nhập đầu đủ các trường", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int num = 0;
                int hid = 0;
                if (Int32.TryParse(textBoxIDuser.Text, out num))
                {
                    hid = Int32.Parse(textBoxIDuser.Text);
                }
                else
                {
                    MessageBox.Show("Phải nhập ID user là số", "'Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MemoryStream pic = new MemoryStream();
                ptbPicture.Image.Save(pic, ptbPicture.Image.RawFormat);
                //int hid = Int32.Parse(textBoxIDuser.Text);
                string fname = textBoxFirstname.Text;
                string lname = textBoxLastname.Text;
                string username = textBoxUsername.Text;
                string pass = textBoxPassword.Text;
                string repass = textBoxRepassword.Text;
                int id = Int32.Parse(textBoxIDuser.Text);
                string gmail = textBoxGmail.Text;
                SqlCommand check = new SqlCommand("select * from hr where Id=@id");
                check.Parameters.Add("@id", SqlDbType.Int).Value = textBoxIDuser.Text;
                check.Connection = mydb.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(check);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    if (!user.usernameExist(username, "register", hid))
                    {
                        if (user.insertUser(id, fname, lname, username, pass, pic, gmail))
                        {
                            MessageBox.Show("Registration Completed Success", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Something Wrong", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("this username đã tồn tại", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Khong duoc trung id user", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool check_input()
            {
                if (textBoxFirstname.Text == "" || textBoxLastname.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxRepassword.Text == "" || ptbPicture.Image == null)
                {
                    return true;
                }
                return false;
            }
            private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
