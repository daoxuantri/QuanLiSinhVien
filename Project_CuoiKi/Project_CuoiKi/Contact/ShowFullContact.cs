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
    public partial class ShowFullContact : Form
    {
        public ShowFullContact()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            /*string a = comboBoxNameGroup.Text;
            SqlCommand command = new SqlCommand("SELECT contact.id as 'Contact ID' ,fname as 'First Name',lname as 'Last Name', Mygroup.name as 'Group', phone, email, address, pic as 'picture'"
                + " FROM contact JOIN Mygroup on contact.group_id = Mygroup.id WHERE"
                + " Group ='"+a+"'");*/
            int a = Int32.Parse(comboBoxNameGroup.SelectedValue.ToString());
            SqlCommand command = new SqlCommand("SELECT contact.id as 'Contact ID' ,fname as 'First Name',lname as 'Last Name', Mygroup.name as 'Group', phone, email, address, pic as 'picture'"
                + " FROM contact JOIN Mygroup on contact.group_id = mygroup.id WHERE"
                + " mygroup.id ='" + a + "'");

            fillGrid(command);
        }
        GROUP group = new GROUP();
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = group.getGroup(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].HeaderText = "Teacher ID";
            dataGridView1.Columns[1].HeaderText = "First name";
            dataGridView1.Columns[2].HeaderText = "Last name";
            dataGridView1.Columns[3].HeaderText = "Name Group";
            dataGridView1.Columns[4].HeaderText = "Phone";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Address";
            dataGridView1.Columns[7].HeaderText = "Picture";
            
        }
        My_DB mydb = new My_DB();
        private void ShowFullContact_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("Select * from mygroup", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            comboBoxNameGroup.DataSource = table;
            comboBoxNameGroup.DisplayMember = "name";
            comboBoxNameGroup.ValueMember = "Id";

            SqlCommand commmand = new SqlCommand("SELECT contact.id as 'Contact ID' ,fname as 'First Name',lname as 'Last Name', Mygroup.name as 'Group', phone, email, address, pic as 'picture'"
                + " FROM contact JOIN Mygroup on contact.group_id = mygroup.id ");

            fillGrid(commmand);
        }
        public static int id_contact;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id_contact = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Show_Full_Student_Course show_full = new Show_Full_Student_Course();
            show_full.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT contact.id as 'Contact ID' ,fname as 'First Name',lname as 'Last Name', Mygroup.name as 'Group', phone, email, address, pic as 'picture'"
                + " FROM contact JOIN Mygroup on contact.group_id = mygroup.id ");

            fillGrid(command);
        }
    }
}
