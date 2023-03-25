using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 frm = new Form1();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                if (frm.radioButtonStudent.Checked == true)
                    Application.Run(new MainFormStudent());
                else if(frm.radioButtonTeacher.Checked==true)
                    Application.Run(new MainFormTeacher());
                else
                    Application.Run(new ShowContactGroup());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
