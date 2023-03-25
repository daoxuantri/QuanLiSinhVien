using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CuoiKi
{
    class GROUP
    {
        My_DB mydb = new My_DB();
        public bool insertGroup(int id, string gname )
        {
            SqlCommand command = new SqlCommand("INSERT INTO mygroup (Id, name )  VALUES (@id, @gn )", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = gname;
            
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
        public bool updateGroup(int gid, string gname)
        {
            SqlCommand command = new SqlCommand("UPDATE mygroup SET name = @name WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@id", SqlDbType.Int).Value = gid;
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
        public bool deleteGroup(int groupid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mygroup WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
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
        /*
        public DataTable getGroups(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroup WHERE userid = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public bool groupExist(string name, string operation, int userid = 0, int groupid = 0)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if (operation == "add")
            {
                query = "SELECT * FROM mygroup WHERE name = @name AND userid = @uid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM mygroup WHERE name = @name AND userid = @uid  AND Id <> @gid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }
            command.Connection = mydb.getConnection;
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public DataTable getAllGroup(int userid)
        {
            SqlCommand commad = new SqlCommand("select * from mygroup where userid=@uid",mydb.getConnection);
            commad.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            commad.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commad);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }*/

        public DataTable AllGroup()
        {
            SqlCommand commad = new SqlCommand("select * from mygroup  ", mydb.getConnection);
             
            commad.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commad);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable SetAllGroupNull()
        {
            SqlCommand commad = new SqlCommand("select * from mygroup where id != 1 ", mydb.getConnection);

            commad.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commad);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool groupExist(string name, string operation, int groupid = 0)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if (operation == "add")
            {
                query = "SELECT * FROM mygroup WHERE name = @name ";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                
                command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM mygroup WHERE name = @name  AND Id <> @gid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
               
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }
            command.Connection = mydb.getConnection;
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
        public DataTable getGroup(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
    }
