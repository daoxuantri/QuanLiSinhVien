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
    
    class USER
    {
        My_DB mydb = new My_DB();
        public DataTable getUserById(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE Id = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool insertUser(int id, string fname, string lname, string username, string password, MemoryStream picture, string gmail)
        {
            SqlCommand command = new SqlCommand("INSERT INTO hr (Id, fname, lname ,uname,pwd,fig,gmail) VALUES (@id, @fn, @ln, @un, @pass, @pic, @gmail)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@gmail", SqlDbType.VarChar).Value = gmail;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
                query = "SELECT * FROM hr WHERE uname = @un";
            else if (operation == "edit")
                query = "SELECT * FROM hr WHERE uname = @un AND Id <> @uid";
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public bool updateUser(int userid, string fname, string lname, string username, string password, MemoryStream picture, string gmail)
        {
            SqlCommand command = new SqlCommand("UPDATE hr SET fname = @fn, lname = @ln, uname = @un, pwd = @pass, fig = @pic, gmail=@gmail WHERE Id = @uid", mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@gmail", SqlDbType.VarChar).Value = gmail;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public bool updatePass(string username, string pass)
        {
            SqlCommand command = new SqlCommand("UPDATE hr SET pwd = @pass WHERE uname = @username", mydb.getConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
    public static class Globals
    {
        // parameterless constructor required for static class
        static Globals() { GlobalUserid = 1234; } // default value

        // public get, and private set for strict access control
        public static int GlobalUserid { get; private set; }
        public static int GlobalContactID { get; private set; }
        public static string GlobaltUser { get; private set; }
        public static string GlobaltName { get; private set; }
        // GlobalInt can be changed only via this method
        public static void setGlobalUserid(int userID)
        {
            GlobalUserid = userID;
        }
        public static void SetGlobalContactID(int id)
        {
            GlobalContactID = id;
        }
        public static void SetGlobalUser(string user)
        {
            GlobaltUser = user;
        }
        public static void SetGlobalName(string name)
        {
            GlobaltName = name;
        }
    }
}
