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
    public partial class ShowContactGroup : Form
    {
        public ShowContactGroup()
        {
            InitializeComponent();
        }
        GROUP group = new GROUP();
        My_DB mydb = new My_DB();
        CONTACT contact = new CONTACT();
        private void buttonAddcontact_Click(object sender, EventArgs e)
        {
            AddContactForm add = new AddContactForm(); add.Show();
        }
        

        private void ShowContactGroup_Load(object sender, EventArgs e)
        {
            
            labelUser.Text = "Welcome ( " + Globals.GlobaltUser.ToString() + ")";
            labelName.Text = Globals.GlobaltName.ToString();
            comboBoxGroup.DataSource = group.SetAllGroupNull();
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "Id";
            
            comboBoxGroup.SelectedItem = null;
            comboBoxGroupRemove.DataSource = group.SetAllGroupNull();
            comboBoxGroupRemove.DisplayMember = "name";
            comboBoxGroupRemove.ValueMember = "Id";
            comboBoxGroupRemove.SelectedItem = null;
        }

        private void buttonEditcontact_Click(object sender, EventArgs e)
        {
            UpdateContactForm add = new UpdateContactForm(); add.Show();
        }

        private void buttonSelectContact_Click(object sender, EventArgs e)
        {
            SelectContact SelectContactF = new SelectContact();
            SelectContactF.ShowDialog();
            try
            {
                int contactId = Convert.ToInt32(SelectContactF.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textBoxContactidDel.Text = contactId.ToString();
            }
            catch (Exception)
            {
            }
        }
        COURSE course = new COURSE(); SCORE score = new SCORE(); 
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(textBoxContactidDel.Text);

                int idcoursetest;
                SqlCommand command = new SqlCommand("select Id from course where  id_contact= " + id + "", mydb.getConnection);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                for(int i=0; i<table.Rows.Count;i++)
                {
                    idcoursetest = Int32.Parse(table.Rows[i][0].ToString());
                    score.deleteTableScoreINcourse(idcoursetest);
                }
                course.removeCoursebyContact(id); 
                contact.deleteAccountTeacher(id);
                if (contact.deleteContact(id))
                    {
                        
                        MessageBox.Show("Delete thanh cong", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                   
               
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowFullList_Click(object sender, EventArgs e)
        {
            ShowFullContact showFullContact = new ShowFullContact();
            showFullContact.Show();
        }
        public bool verif()
        {
            if (textBoxid.Text == "" || textBoxname.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        private void buttonAddgroup_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = 0;
                int num = 0;
                if (Int32.TryParse(textBoxid.Text, out num))
                {
                    id = Int32.Parse(textBoxid.Text);
                }
                else
                {
                    MessageBox.Show("Phải nhập ID là số", "'Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = textBoxname.Text;
                SqlCommand check = new SqlCommand("select * from mygroup where id=@id");
                check.Parameters.Add("@id", SqlDbType.Int).Value = id;
                check.Connection = mydb.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(check);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    if (!group.groupExist(name, "add", id))
                    {
                        if (group.insertGroup(id, name))
                        {
                            MessageBox.Show("New group Added", "Add Group", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ShowContactGroup_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Group da ton tai", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Khong duoc trung id", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonEditgroup_Click(object sender, EventArgs e)
        {
            if (textBoxNamedit.Text == "")
            {
                MessageBox.Show("hay dien du cac truong", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = (int)(comboBoxGroup.SelectedValue);
                if (!group.groupExist(textBoxNamedit.Text, "edit", id))
                {
                    if (group.updateGroup(id, textBoxNamedit.Text))
                    {
                        MessageBox.Show("Group Update", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowContactGroup_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Edit fail", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Group da ton tai", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            
            if ((MessageBox.Show("Are You sure You want To Delete This Group", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int id = (int)(comboBoxGroupRemove.SelectedValue);
                contact.resetidGroup(id);
                
                    if (group.deleteGroup(id))
                    {
                        MessageBox.Show("Group deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowContactGroup_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Group not deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                
            }
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelEitprof_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm();
            editUserForm.Show();
        }

        private void buttonMainForm_Click(object sender, EventArgs e)
        {
            MainForm add = new MainForm(); add.Show();
        }
    }
}
