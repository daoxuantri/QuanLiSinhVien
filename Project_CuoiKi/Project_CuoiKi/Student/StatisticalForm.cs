using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKi
{
    public partial class StatisticalForm : Form
    {
        public StatisticalForm()
        {
            InitializeComponent();
            
            


        }

        private void StatisticalForm_Load(object sender, EventArgs e)
        {

            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalNoClass = Convert.ToDouble(student.totalNoClassStudent());
            double totalClass = Convert.ToDouble(student.totalClassStudent());

            double NoClassStudentsPercentage = (totalNoClass * (100 / total));
            double ClassStudentsPercentage = (totalClass * (100 / total));

            labelStudentClass.Text = ("Danh sách sinh viên: " + total.ToString());
            labelNoClass.Text = ("Chưa có lớp: " + (NoClassStudentsPercentage.ToString("0.00") + "%"));
            labelClass.Text = ("Đã có lớp: " + (ClassStudentsPercentage.ToString("0.00") + "%"));

        
    }
    }
}
