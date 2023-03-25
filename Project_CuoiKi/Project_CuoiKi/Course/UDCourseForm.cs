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
    public partial class UDCourseForm : Form
    {
        public UDCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();SCORE score = new SCORE();

             
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int coursetId = Convert.ToInt32(textBoxID.Text);
                if ((MessageBox.Show("Are You sure You want To Delete This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    score.deleteTableScoreINcourse(coursetId);
                    
                        if (course.removeCourse(coursetId) )
                        {
                            MessageBox.Show("Course deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             

                        }
                        else
                        {
                            MessageBox.Show("Course not deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                    
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid Numberic ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


           
        }
    }
}
