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
    public partial class UpdateClassForm : Form
    {
        public UpdateClassForm()
        {
            InitializeComponent();
        }
        ClassSt classSt = new ClassSt();
        SqlConnection connection;
        SqlCommand commmand;
        string str = @"Data Source=MINHHIEU\SQLEXPRESS;Initial Catalog=DoanCNTT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        My_DB mydb = new My_DB();






        public void fillGrid(SqlCommand command)
        {
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 20;
            dgv.AllowUserToAddRows = false;
            dgv.DataSource = classSt.getClass(command);
            //demlop
            labelTotalClass.Text = ("Total Class: " + dgv.Rows.Count);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * from class where Id !=1");

            fillGrid(command);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ManageStudentsForm mana = new ManageStudentsForm();
            this.Hide();
            mana.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string name = txtClass.Text;
            if (verif())
            {
                try
                {
                    id = Convert.ToInt32(txtID.Text);
                    if (classSt.updateClass(id, name))
                    {
                        MessageBox.Show("Class Infor Update ", "Edit Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Class", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fiedls", "Edit Class", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bool verif()
            {
                if ((txtClass.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);

                SqlCommand command = new SqlCommand("select Id from std where  id_class= " + id + "", mydb.getConnection);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    classSt.resetidClass(id);
                }
                if (classSt.deleteClass(id))
                {
                    MessageBox.Show("Class Deleted", "Delete Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    txtClass.Text = "";
                }
                else
                {
                    MessageBox.Show("Class Not Deleted", "Delete Class", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {

            }
        } 

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtClass.Text;
            SqlCommand check = new SqlCommand("select * from class where Id=@id");
            check.Parameters.Add("@id", SqlDbType.Int).Value = id;
            check.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(check);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                if (verif())
                {
                    if (classSt.insertClass(id, name))
                    {
                        MessageBox.Show("New Class Added", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fiedls", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                bool verif()
                {
                    if (txtClass.Text.Trim() == "")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
            }
            else
            {
                MessageBox.Show("Nhập trùng ID",
                       "Trùng ID",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                txtID.Focus();
            }
        }

        

        private void UpdateClassForm_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT * from class where Id !=1");

            fillGrid(command);
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtID.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtClass.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }
    }
}

