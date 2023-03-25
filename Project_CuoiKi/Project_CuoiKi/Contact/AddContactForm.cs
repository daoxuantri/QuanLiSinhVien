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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxContactImage.Image = Image.FromFile(opf.FileName);
                pictureBoxContactImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            if (!checkinput())
            {
                int num = 0;
                int id = 0;
                if (Int32.TryParse(txtContactId.Text, out num))
                {
                    id = Int32.Parse(txtContactId.Text);
                }
                else
                {
                    MessageBox.Show("Phải nhập ID là số", "'Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //int id = Convert.ToInt32(txtContactId.Text);
                string fname = textBoxFName.Text;
                string lname = textBoxLName.Text;
                string phone = textBoxPhone.Text;
                int phn = 0;
                if (Int32.TryParse(textBoxPhone.Text, out phn))
                {
                    phone = textBoxPhone.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Phải nhập so dien thoai là số", "'Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string address = textBoxAddress.Text;
                string email = textBoxEmail.Text;
                
                int groupid = (int)comboBoxGroup.SelectedValue;
                string username = textBoxusername.Text;
                string password = textBoxpassword.Text;
                MemoryStream pic = new MemoryStream();
                pictureBoxContactImage.Image.Save(pic, pictureBoxContactImage.Image.RawFormat);
                if (!contact.checkID(Convert.ToInt32(txtContactId.Text)))
                {
                    if (contact.insertContact(id, fname, lname, phone, address, email, groupid, pic))
                    {
                        contact.insertAccountTeacher(id, username, password);
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hay dien du cac truong", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool checkinput()
        {
            if (textBoxAddress.Text.Trim() == "" || textBoxEmail.Text.Trim() == "" || textBoxFName.Text.Trim() == "" || textBoxLName.Text.Trim() == "" || textBoxPhone.Text.Trim() == "" || pictureBoxContactImage.Image == null || txtContactId.Text.Trim() == "")
            {
                return true;
            }
            return false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();
            comboBoxGroup.DataSource = group.AllGroup();
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "Id";
        }
    }
}
