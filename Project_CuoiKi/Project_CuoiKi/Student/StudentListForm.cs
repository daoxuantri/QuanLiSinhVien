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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doanCNTTDataSet.std' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'doanCNTTDataSet2.std' table. You can move, or remove it, as needed.

            SqlCommand command = new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id ");
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;

            


        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id ");
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            

            

            UDStudentForm updateDeletStdF = new UDStudentForm(); 
            // thu tu cua cac cot: id - fname - Inane - bd - gar - phn - adrs - pic
            updateDeletStdF.labelIDStudent.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeletStdF.textBoxFirstName.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeletStdF.textBoxLastName.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeletStdF.DateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;
            //gender
            if (DataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
            {
                updateDeletStdF.radioButtonFemale.Checked = true;
            }
            else
            {
                updateDeletStdF.radioButtonMale.Checked = true;
            }
            updateDeletStdF.textBoxPhone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeletStdF.textBoxAddress.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
             
           
            if (DataGridView1.CurrentRow.Cells[7].Value != DBNull.Value)
            {
                byte[] pic;
                pic = (byte[])DataGridView1.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);
                updateDeletStdF.pictureBox1.Image = Image.FromStream(picture);
            }
            else
            {
                updateDeletStdF.pictureBox1.Image = null;
            }
            
            updateDeletStdF.comboBox1.Text = DataGridView1.CurrentRow.Cells[8].Value.ToString();
            updateDeletStdF.Show();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=TRIDANGIU\SQLEXPRESS;Initial Catalog=DoAnCNTT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id  where s.Id like '%" + textBoxId.Text + "%'",conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        public void fillGrid(SqlCommand command)
        {
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;

          


        }
    }
}
