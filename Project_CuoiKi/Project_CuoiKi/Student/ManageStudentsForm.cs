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
    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();

        }
        My_DB mydb = new My_DB();
        STUDENT student = new STUDENT();
        ClassSt cs = new ClassSt();
        SCORE score = new SCORE();
        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelIDStudent.Text = "";
            TextBoxFName.Text = "";
            TextBoxLName.Text = "";
            TextBoxAddress.Text = "";
            TextBoxPhone.Text = "";
            DateTimePicker1.Value = DateTime.Now;
            PictureBoxStudentImage.Image = null;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(labelIDStudent.Text);
            try
            {
                
                
                if ((MessageBox.Show("Are You Sure Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    student.deleteAccountStudent(studentId); score.deleteAllScore(studentId);

                    if (student.deleteStudent(studentId) )
                    {
                        
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        labelIDStudent.Text = "";
                        TextBoxFName.Text = "";
                        TextBoxLName.Text = "";
                        TextBoxAddress.Text = "";
                        TextBoxPhone.Text = "";
                        DateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;

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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = TextBoxFName.Text;
            string lname = TextBoxLName.Text;
            DateTime bdate = DateTimePicker1.Value;
            string phone = TextBoxPhone.Text;
            string adrs = TextBoxAddress.Text;

            int num = 0;
            if (Int32.TryParse(TextBoxPhone.Text, out num))
            {
                phone = TextBoxPhone.Text.ToString();
            }
            else
            {
                MessageBox.Show("Phải nhập số điện thoại là số");
                return;
            }
            string gender = "Male";
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            int idclass = Int32.Parse(ComboBoxClassName.SelectedValue.ToString());


            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year ", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(labelIDStudent.Text);
                    if (Int32.TryParse(labelIDStudent.Text, out num))
                    {
                        ///dữ liệu ẩn label
                        id = Int32.Parse(labelIDStudent.Text);
                    }
                    int idold = (int)DataGridView.CurrentRow.Cells[0].Value;
                    SqlCommand check = new SqlCommand("select * from std where ID = @id and @id <> @idold");
                    check.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(labelIDStudent.Text);
                    check.Parameters.Add("@idold", SqlDbType.Int).Value = (int)DataGridView.CurrentRow.Cells[0].Value;
                    check.Connection = mydb.getConnection;
                    SqlDataAdapter adapter = new SqlDataAdapter(check);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    SqlCommand check2 = new SqlCommand("select * from std where @id =" + idold);
                    check2.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(labelIDStudent.Text);
                    check.Connection = mydb.getConnection;
                    SqlDataAdapter adapter2 = new SqlDataAdapter(check2);
                    DataTable table2 = new DataTable();
                    adapter.Fill(table2);
                    if (table.Rows.Count == 0 || table2.Rows.Count == 0)
                    {
                        PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                        if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic, idclass))
                        {
                            MessageBox.Show("Student Infor Update ", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid(new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id where id_class!=1"));

                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập trùng ID",
                                "Trùng ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        labelIDStudent.Focus();
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
                if ((TextBoxFName.Text.Trim() == "") || (TextBoxLName.Text.Trim() == "") || (TextBoxAddress.Text.Trim() == "") || (TextBoxPhone.Text.Trim() == "") || PictureBoxStudentImage.Image == null || ComboBoxClassName.Text.Trim() == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm add = new AddStudentForm(); add.Show();
            /*
            STUDENT student = new STUDENT();
            string fname = TextBoxFName.Text;
            string lname = TextBoxLName.Text;
            DateTime bdate = DateTimePicker1.Value;
            string adrs = TextBoxAddress.Text;
            string gender = "Male";



            int num = 0;
            int id;
            if (Int32.TryParse(txtStudentID.Text, out num))
            {
                id = Convert.ToInt32(txtStudentID.Text);
            }
            else
            {
                MessageBox.Show("Phải nhập student ID là số");
                return;
            }
            SqlCommand check = new SqlCommand("select * from std where ID=@id");
            check.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            check.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(check);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {

                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                MemoryStream pic = new MemoryStream();
                int born_year = DateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                int idclass = Int32.Parse(ComboBoxClassName.SelectedValue.ToString());
                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year ", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    string phone = "";
                    if (Int32.TryParse(TextBoxPhone.Text, out num))
                    {
                        phone = TextBoxPhone.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Phải nhập số điện thoại là số");
                        return;
                    }
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic, idclass))
                    {
                        DialogResult result = MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            txtStudentID.Text = "";
                            TextBoxLName.Text = "";
                            TextBoxFName.Text = "";
                            TextBoxPhone.Text = "";
                            TextBoxAddress.Text = "";
                            txtStudentID.Focus();
                        }
                        fillGrid(new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id where id_class!=1"));

                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fiedls", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if ((TextBoxFName.Text.Trim() == "") || (TextBoxLName.Text.Trim() == "") || (TextBoxAddress.Text.Trim() == "") || (TextBoxPhone.Text.Trim() == "") || PictureBoxStudentImage.Image == null || ComboBoxClassName.Text.Trim() == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }*/

        }


        //load dữ liệu lên datagridview 

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            //data cũ-->
            // fillGrid(new SqlCommand("select * from std"));
            fillGrid(new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id where id_class!=1"));
            ComboBoxClassName.DataSource = cs.getAllClass();
            ComboBoxClassName.DisplayMember = "Name_Class";
            ComboBoxClassName.ValueMember = "Id";

        }
        public void fillGrid(SqlCommand command)
        {
            DataGridView.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView.RowTemplate.Height = 80;
            DataGridView.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView.AllowUserToAddRows = false;

            //demsinhvien

            labelTotalStudent.Text = ("Total Student: " + DataGridView.Rows.Count);


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //data cũ -->
            //SqlCommand command = new SqlCommand("SELECT * from std where CONCAT(fname,lname,address) like '% " + textBoxSearch.Text + "%'");
            SqlCommand command = new SqlCommand("SELECT s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c  on s.id_class = c.Id where id_class!=1 and s.Id='" + textBoxSearch.Text + "'");



            fillGrid(command);
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);

            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + labelIDStudent.Text);
            if ((PictureBoxStudentImage.Image == null))
            {
                MessageBox.Show(" No Image In The PictureBox");

            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }
        bool verif()
        {
            if ((TextBoxFName.Text.Trim() == "") || (TextBoxLName.Text.Trim() == "") || (TextBoxAddress.Text.Trim() == "") || (TextBoxPhone.Text.Trim() == "") || (PictureBoxStudentImage.Image == null))
            {
                return false;

            }
            else
            {
                return true;
            }

        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            labelIDStudent.Text= DataGridView.CurrentRow.Cells[0].Value.ToString();



            labelIDStudent.Text = DataGridView.CurrentRow.Cells[0].Value.ToString();
            TextBoxFName.Text = DataGridView.CurrentRow.Cells[1].Value.ToString();
            TextBoxLName.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();

            if (DataGridView.CurrentRow.Cells[3].Value != DBNull.Value)
            {
                DateTimePicker1.Value = (DateTime)DataGridView.CurrentRow.Cells[3].Value;
            }
            else
            {
                DateTimePicker1.Value = DateTime.Now;
            }

            // gender
            if ((DataGridView.CurrentRow.Cells[4].Value.ToString() == "Female"))
                RadioButtonFemale.Checked = true;
            else
                RadioButtonMale.Checked = true;

            TextBoxPhone.Text = DataGridView.CurrentRow.Cells[5].Value.ToString();
            TextBoxAddress.Text = DataGridView.CurrentRow.Cells[6].Value.ToString();

            // image
            if (DataGridView.CurrentRow.Cells[7].Value != DBNull.Value)
            {
                byte[] pic;
                pic = (byte[])DataGridView.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
            }
            else
            {
                PictureBoxStudentImage.Image = null;
            }
            ComboBoxClassName.Text = DataGridView.CurrentRow.Cells[8].Value.ToString();
            ComboBoxClassName.DisplayMember = DataGridView.CurrentRow.Cells[8].Value.ToString();
            ComboBoxClassName.ValueMember = "Id";
        }

        public void fillCombo(int index)
        {
            ComboBoxClassName.DataSource = cs.getAllClass();
            ComboBoxClassName.DisplayMember = "Name_Class";
            ComboBoxClassName.ValueMember = "Id";
            ComboBoxClassName.SelectedItem = index;

        }



        private void buttonSearchClass_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id where id_class!=1 and c.Name_Class like '%" + ComboBoxClassName.Text + "%'");

            fillGrid(command);
        }

        private void buttonNoClass_Click(object sender, EventArgs e)
        {
            StudentNoClassForm mana = new StudentNoClassForm();
            this.Hide();
            mana.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id where id_class!=1 ");
            DataGridView.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView.RowTemplate.Height = 80;
            DataGridView.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView.AllowUserToAddRows = false;
        }
    }
}
