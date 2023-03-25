using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKi
{
    public partial class StudentNoClassForm : Form
    {
        public StudentNoClassForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB(); STUDENT student = new STUDENT(); ClassSt cs = new ClassSt();
        
        
        private void StudentNoClassForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id where id_class=1");
             
            fillGrid(command);

            dgv.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgv.RowTemplate.Height = 80;
            dgv.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dgv.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgv.AllowUserToAddRows = false;
            ComboBoxClassName.DataSource = cs.getAllNoClass();
            ComboBoxClassName.DisplayMember = "Name_Class";
            ComboBoxClassName.ValueMember = "Id";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool verif()
        {
            if ((TextIDStudent.Text.Trim() == "") || (ComboBoxClassName.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(TextIDStudent.Text);
            int idclass = Int32.Parse(ComboBoxClassName.SelectedValue.ToString());
            if (verif())
            {
                if (student.insertclassforstudent(id, idclass))
                {
                    MessageBox.Show("Add a new class for successful students", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Class for Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fiedls", "Add Class for Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            SqlCommand commmand = new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id where id_class=1");
            fillGrid(commmand);

        }
        public void fillGrid(SqlCommand command)
        {
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 80;
            dgv.AllowUserToAddRows = false;
            dgv.DataSource = student.getStudents(command);
            //demsinhvien
            labelTotalStudent.Text = ("Total Student: " + dgv.Rows.Count);
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand commmand = new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id where id_class=1");
            fillGrid(commmand);
        }

        private void buttonManageStudent_Click(object sender, EventArgs e)
        {
            ManageStudentsForm mana = new ManageStudentsForm();
            mana.Show();
            this.Hide();
        }

       

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id where id_class=1");
             
            fillGrid(command);
            dgv.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgv.RowTemplate.Height = 80;
            dgv.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dgv.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgv.AllowUserToAddRows = false;
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            TextIDStudent.Text = dgv.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
