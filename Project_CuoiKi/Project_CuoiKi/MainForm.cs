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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ///student

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm add = new AddStudentForm(); add.Show();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm mana = new ManageStudentsForm();
            mana.Show();
        }

        private void studentListFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm add = new StudentListForm(); add.Show();
        }

        private void printStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentForm add = new PrintStudentForm(); add.Show();
        }

        private void staticticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticalForm add = new StatisticalForm(); add.Show();
        }

        private void cameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CameraForm add = new CameraForm(); add.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm add = new AddCourseForm(); add.Show();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm add = new ManageCourseForm(); add.Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm add = new EditCourseForm(); add.Show();
        }

        private void deleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UDCourseForm add = new UDCourseForm(); add.Show();
        }

        private void manageCourseFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm add = new ManageCourseForm();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm add = new AddScoreForm(); add.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm add = new ManageScoreForm(); add.Show();
        }

        private void averageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreForm add = new AvgScoreForm(); add.Show();
        }

        private void staticAverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResultScore add = new StaticResultScore(); add.Show();

        }

        private void printScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintScoreForm ad = new PrintScoreForm(); ad.Show();
        }

        private void deleteScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UDScoreForm add = new UDScoreForm(); add.Show();
        }

        private void uDClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClassForm add = new UpdateClassForm(); add.Show();
        }
    }

    }
