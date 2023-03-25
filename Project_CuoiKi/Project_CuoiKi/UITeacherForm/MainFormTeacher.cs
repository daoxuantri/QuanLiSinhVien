using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKi
{
    public partial class MainFormTeacher : Form
    {
        public MainFormTeacher()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        STUDENT cs = new STUDENT();
        CONTACT ct = new CONTACT();
        int id = search.idstu;
        private void nhữngMônGiảngViênDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseGradeList add = new CourseGradeList(); add.Show();
        }

        private void chỉnhSữaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationTeacherForm add = new InformationTeacherForm(); add.Show();
        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseGradesListForm add = new CourseGradesListForm();
            add.Show();
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

        private void MainFormTeacher_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT c.id, c.fname, c.lname, p.name, c.phone, c.email, c.address, c.pic from contact as c inner join mygroup as p on c.group_id = p.Id WHERE c.Id =" + id);
            DataTable table = cs.getStudents(command);
            if (table.Rows.Count > 0)
            {
                labelIdTeacher.Text = table.Rows[0]["Id"].ToString();
                labelFName.Text = table.Rows[0]["fname"].ToString();
                labelLName.Text = table.Rows[0]["lname"].ToString();
                labelSDT.Text = table.Rows[0]["phone"].ToString();
                labelGmail.Text = table.Rows[0]["email"].ToString();
                labelAdress.Text = table.Rows[0]["address"].ToString();
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
