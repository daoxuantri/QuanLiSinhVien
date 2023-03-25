using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Project_CuoiKi
{
    public partial class InformationTeacherForm : Form
    {
        public InformationTeacherForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        STUDENT cs = new STUDENT();
        CONTACT ct = new CONTACT();
        int id = search.idstu;
        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);

            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + labelIdTeacher.Text);
            if ((pictureBox1.Image == null))
            {
                MessageBox.Show(" No Image In The PictureBox");

            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Convert.ToInt32(labelIdTeacher.Text);
                int num = 0;
                string sdt;
                if (Int32.TryParse(textPhone.Text, out num))
                {
                    sdt = textPhone.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Phải nhập số điện thoại là số");
                    return;
                }
                string gmail = textEmail.Text;
                string adrs = textAddress.Text;
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                try
                {
                    if (ct.editContact(id, sdt, adrs, gmail, pic))
                    {
                        MessageBox.Show("Information Update", "Edit Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Information Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Information Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fiedls", "Information Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bool verif()
            {
                if ((textPhone.Text.Trim() == "") || (textAddress.Text.Trim() == "") || (textAddress.Text.Trim() == "") || pictureBox1.Image == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private void InformationTeacherForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT c.id, c.fname, c.lname, p.name, c.phone, c.email, c.address, c.pic from contact as c inner join mygroup as p on c.group_id = p.Id WHERE c.Id =" + id);
            DataTable table = cs.getStudents(command);
            if (table.Rows.Count > 0)
            {
                labelIdTeacher.Text = table.Rows[0]["Id"].ToString();
                labelFName.Text = table.Rows[0]["fname"].ToString();
                labelLName.Text = table.Rows[0]["lname"].ToString();
                textPhone.Text = table.Rows[0]["phone"].ToString();
                textEmail.Text = table.Rows[0]["email"].ToString();
                textAddress.Text = table.Rows[0]["address"].ToString();
                labelGName.Text = table.Rows[0]["name"].ToString();
                if (table.Rows[0]["pic"] != DBNull.Value)
                {
                    byte[] pic = (byte[])table.Rows[0]["pic"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox1.Image = Image.FromStream(picture);
                };

            };
        }
    }
}
