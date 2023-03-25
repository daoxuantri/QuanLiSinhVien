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

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int idstudent;
        public static int idteacher;
        private void button1Login_Click(object sender, EventArgs e)
        {
           
            My_DB db = new My_DB(); 
            if (radioButtonStudent.Checked)
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username=@User AND password=@Pass", db.getConnection);// id,us,pass
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUserName.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    idstudent = Int32.Parse(table.Rows[0]["Id"].ToString());
                    search.std(idstudent);
                    //idstudent=
                    this.DialogResult = DialogResult.OK;
                    /*
                    string x = table.Rows[0][0].ToString();
                    int y = Convert.ToInt32(x);
                    AWSSS.std(y);*/   
                }
                else
                {
                    MessageBox.Show("Invalid Username or PassWord", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            /// Đăng nhập teacher, phòng điều hành 
            else if( radioButtonHR.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from hr where uname = @name and pwd = @pwd",
                    db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBoxUserName.Text;
                cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = textBoxPassWord.Text;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                if (textBoxPassWord.Text.Trim() == "" || textBoxUserName.Text.Trim() == "")
                {
                    MessageBox.Show("Username or Password Empty", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dt.Rows.Count > 0)
                {
                    Globals.setGlobalUserid(Convert.ToInt32(dt.Rows[0][0].ToString()));
                    this.DialogResult = DialogResult.OK;
                    Globals.SetGlobalUser(dt.Rows[0][3].ToString().Trim());
                    Globals.SetGlobalName(dt.Rows[0][2].ToString().Trim() + " " + dt.Rows[0][1].ToString().Trim());

                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error");
                }
            }
            else if (radioButtonTeacher.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM teacher WHERE username=@User AND password=@Pass", db.getConnection);// id,us,pass
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUserName.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    idteacher = Int32.Parse(table.Rows[0]["Id"].ToString());
                    search.std(idteacher);
                    this.DialogResult = DialogResult.OK;
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or PassWord", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }





        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterHR re = new RegisterHR(); re.Show();
        }

        private void linkLabelQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassWord aaa = new ForgotPassWord(); aaa.Show();
        }

        
    }
}
