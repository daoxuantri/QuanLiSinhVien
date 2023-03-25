using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKi
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }
        USER user = new USER(); My_DB mydb = new My_DB();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbPicture_Click(object sender, EventArgs e)
        {

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
        public bool check_input()
        {
            if (textBoxFirstname.Text == "" || textBoxLastname.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxRepassword.Text == "" || ptbPicture.Image == null)
            {
                return true;
            }
            return false;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
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
                if (!user.usernameExist(username, "edit", hid))
                {
                    if (user.updateUser(id, fname, lname, username, pass, pic, gmail))
                    {
                        MessageBox.Show("Edit Completed Success", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Globals.setGlobalUserid(id);
                        Globals.SetGlobalUser(username);
                        Globals.SetGlobalName(lname.Trim() + fname.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("this username đã tồn tại", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            DataTable dt = user.getUserById(Globals.GlobalUserid);
            textBoxIDuser.Text = dt.Rows[0][0].ToString();
            textBoxLastname.Text = dt.Rows[0][2].ToString();
            textBoxFirstname.Text = dt.Rows[0][1].ToString();
            textBoxUsername.Text = dt.Rows[0][3].ToString();
            textBoxPassword.Text = dt.Rows[0][4].ToString();
            textBoxRepassword.Text = dt.Rows[0][4].ToString();
            textBoxGmail.Text = dt.Rows[0][6].ToString();
            byte[] pic = (byte[])dt.Rows[0][5];

            MemoryStream picture = new MemoryStream(pic);
            ptbPicture.Image = Image.FromStream(picture);
        }
    }
}
