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
    public partial class CourseGradesForm : Form
    {
        public CourseGradesForm()
        {
            InitializeComponent();
        }

        int id = search.idstu;
        int i;
        My_DB mydb = new My_DB();
        STUDENT sc = new STUDENT();

        private void CourseGradesForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select c.label, s.student_score, s.description, co.fname,co.lname, co.email from course as c inner join score as s on s.id_course = c.Id inner join contact as co on co.Id = c.id_contact inner join std as st on s.id_student = st.Id where st.Id = " + id));
        }

        
       
        public void fillGrid(SqlCommand command)
        {
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 80;
            dgv.AllowUserToAddRows = false;
            dgv.DataSource = sc.getStudents(command);


        }
    }
}
