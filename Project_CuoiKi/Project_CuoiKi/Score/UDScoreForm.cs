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
    public partial class UDScoreForm : Form
    {
        public UDScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try

            {
                int studentId = (int)DataGridView1.CurrentRow.Cells[0].Value;
                int courseId = (int)DataGridView1.CurrentRow.Cells[3].Value;
                if ((MessageBox.Show("Are You sure You want To Delete This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (score.deleteScore(studentId, courseId))
                    {
                        MessageBox.Show("Score deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UDScoreForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Score not deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please choose student id and course id", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UDScoreForm_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = score.getStudentsScore();
        }
    }
}
