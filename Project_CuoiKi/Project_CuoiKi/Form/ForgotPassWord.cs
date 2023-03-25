using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKi
{
    public partial class ForgotPassWord : Form
    {
        public ForgotPassWord()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        USER user = new USER();  
        public bool checkinput()
        {
            if (textBoxCode.Text == "" || textBoxGmail.Text == "" || textBoxPass.Text == "" || textBoxRepass.Text == "" || textBoxUsername.Text == "")
            {
                return true;
            }
            return false;
        }
        public int randomcode()
        {
            int random = 0;
            Random r = new Random();
            random = r.Next(100000, 999999);
            return random;
        }
        Random random = new Random();
        int otp;
        private void buttonCode_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from hr where uname = @name and gmail=@gmail",
                mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = textBoxUsername.Text;
            cmd.Parameters.Add("@gmail", SqlDbType.VarChar).Value = textBoxGmail.Text;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                try
                {

                    otp = random.Next(100000, 999999);
                    var fromAddress = new MailAddress("dxtri20110581@gmail.com");
                    var ToAddress = new MailAddress(textBoxGmail.ToString());
                    const string frompass = "asabownpnyfgiexr";
                    const string subject = "OTP Code";
                    string body = otp.ToString();
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, frompass),
                        Timeout = 10000,

                    };
                    using (var message = new MailMessage(fromAddress, ToAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);

                    }
                    MessageBox.Show("OTP đã được gửi qua mail");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Username hoặc gmail không chính xác!!!", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (!checkinput())
            {
                string username = textBoxUsername.Text;
                string pass = textBoxPass.Text;
               
                if (otp.ToString().Equals(textBoxCode.Text))
                {
                    if (textBoxPass.Text == textBoxRepass.Text)
                    {
                        if (user.updatePass(username, pass))
                        {
                            MessageBox.Show("Reset pass successed", "Reset pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error!!!", "Reset pass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập trùng password!!!", "Reset pass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập đúng code!!!", "Reset pass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ các trường!!!", "Reset pass", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
