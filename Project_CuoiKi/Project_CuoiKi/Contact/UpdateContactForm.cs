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
    public partial class UpdateContactForm : Form
    {
        public UpdateContactForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB(); CONTACT contact = new CONTACT();
        private void btn_selectContact_Click(object sender, EventArgs e)
        {
            SelectContact SelectContactF = new SelectContact();
            SelectContactF.ShowDialog();
            try
            {
                int contactId = Convert.ToInt32(SelectContactF.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DataTable table = contact.GetContactById(contactId);
                labelIdContact.Text = table.Rows[0][0].ToString();
                textBoxFName.Text = table.Rows[0][1].ToString();
                textBoxLName.Text = table.Rows[0][2].ToString();
                comboBoxGroup.SelectedValue = table.Rows[0][3];
                textBoxPhone.Text = table.Rows[0][4].ToString();
                textBoxEmail.Text = table.Rows[0][5].ToString();
                textBoxAddress.Text = table.Rows[0][6].ToString();
                byte[] pic = (byte[])table.Rows[0][7];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxContactImage.Image = Image.FromStream(picture);

                /*textBoxContactId.Text = table.Rows[0]["id"].ToString();
                textBoxFName.Text = table.Rows[0]["fname"].ToString();
                textBoxLName.Text = table.Rows[0]["lname"].ToString();
                comboBoxGroup.SelectedValue = table.Rows[0]["group_id"];
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxEmail.Text = table.Rows[0]["email"].ToString();
                textBoxAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxContactImage.Image = Image.FromStream(picture);*/
            }
            catch (Exception)
            {
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxContactImage.Image = Image.FromFile(opf.FileName);
                pictureBoxContactImage.Text = opf.FileName.Split('\\').Last();
                pictureBoxContactImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!checkinput())
            {
                string fname = textBoxFName.Text;
                string lname = textBoxLName.Text;
                string phone = "";
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
                try
                {
                    int id = Convert.ToInt32(labelIdContact.Text);
                    int groupid = (int)comboBoxGroup.SelectedValue;
                    MemoryStream pic = new MemoryStream();
                    pictureBoxContactImage.Image.Save(pic, pictureBoxContactImage.Image.RawFormat);
                    if (contact.updateContact(id, fname, lname, phone, address, email, groupid, pic))
                    {
                        MessageBox.Show("Contact Inormation UpDated", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay dien du cac truong", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool checkinput()
        {
            if (textBoxAddress.Text.Trim() == "" || textBoxEmail.Text.Trim() == "" || textBoxFName.Text.Trim() == "" || textBoxLName.Text.Trim() == "" || textBoxPhone.Text.Trim() == "" || pictureBoxContactImage.Image == null)
            {
                return true;
            }
            return false;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateContactForm_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();
            comboBoxGroup.DataSource = group.AllGroup();
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "Id";
        }
    }
}
