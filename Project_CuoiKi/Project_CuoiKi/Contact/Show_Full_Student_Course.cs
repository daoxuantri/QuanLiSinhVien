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
    public partial class Show_Full_Student_Course : Form
    {
        public Show_Full_Student_Course()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Full_Student_Course_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("select std.Id, CONCAT(std.lname,' ',std.fname) as 'Full Name', Course.label, score.student_score as 'Diem' from contact join Course on contact.id=Course.id_contact join score on score.id_course=Course.Id join std on std.Id=score.id_student where contact.id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ShowFullContact.id_contact;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }
    }
}
