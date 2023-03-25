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
    public partial class SelectContact : Form
    {
        public SelectContact()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        private void SelectContact_Load(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT  id ,  fname  as'first name',  lname  as 'last name',  group_id  as'group id' FROM  contact  ");
             
            dataGridView1.DataSource = contact.SelectContactList(command);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
