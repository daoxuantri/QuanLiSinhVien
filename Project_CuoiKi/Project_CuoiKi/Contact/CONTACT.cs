using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CuoiKi
{
    class CONTACT
    {
        My_DB mydb = new My_DB();
        public bool insertContact(int id, string fname, string lname, string phone, string address, string email,
           int groupid, MemoryStream picture)
        {
            SqlCommand command =
                new SqlCommand("INSERT INTO contact (id, fname, lname, group_id , phone, email, address, pic)  VALUES (@id,@fn, @ln, @grp, @phn, @mail, @adrs , @pic)", mydb.getConnection);
            command.Parameters.Add("fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool updateContact(int contactid, string fname, string lname, string phone, string address, string email,
            int groupid, MemoryStream picture)
        {
            SqlCommand command =
                new SqlCommand(
                    "UPDATE contact SET fname = @fn, lname = @ln, group_id = @grp, phone = @phn, email = @mail, address = @adrs, pic = @pic where  id = @contactid",
                    mydb.getConnection);
            command.Parameters.Add("@contactid", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteContact(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM contact WHERE Id = @ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool editContact(int contactid, string phone, string address, string email, MemoryStream picture)
        {
            SqlCommand command =
                new SqlCommand(
                    "UPDATE contact SET phone = @phn, email = @mail, address = @adrs, pic = @pic where  Id = @contactid",
                    mydb.getConnection);
            command.Parameters.Add("@contactid", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool checkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM contact WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;

        }
        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetContactById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM contact WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }


        //hàm thêm tài khoản cho giảng viên khi thêm thông tin một giảng viên vào trong table 
        public bool insertAccountTeacher(int id, string username, string password )
        {
            SqlCommand command =
                new SqlCommand("INSERT INTO teacher (Id,username,password)  VALUES (@id,@fn, @ln )", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("fn", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("ln", SqlDbType.NVarChar).Value = password;
            
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

            /// 

        }
        public bool deleteAccountTeacher(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM teacher WHERE Id = @ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //Set groupid=null khi xóa cái mygroup

        public bool resetidGroup(int id)
        {

            SqlCommand com = new SqlCommand("UPDATE contact set group_id = 1 WHERE group_id =@id", mydb.getConnection);

            com.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if ((com.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

    }
}
