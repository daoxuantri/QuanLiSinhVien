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
    public partial class AvgScoreForm : Form
    {
        public AvgScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void AvgScoreForm_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = score.getAvgScoreByCourse();
        }
    }
}
