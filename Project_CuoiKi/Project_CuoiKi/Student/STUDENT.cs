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
    public static class search
    {
        public static int idstu { get; private set; }

        public static void std(int id)
        {
            idstu = id;
        }
    }


    class STUDENT
    {
        My_DB mydb = new My_DB();

        public bool insertStudent(int ID, string firstname, string lastname, DateTime bdate, string gender, string phone, string address, MemoryStream picture, int idclass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std(Id,fname,lname,bdate,gender,phone,address,picture,id_class)" +
                "VALUES (@id,@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic,@idc)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = firstname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lastname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@idc", SqlDbType.Int).Value = idclass;

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

        public bool updateStudent(int ID, string firstname, string lastname, DateTime bdate, string gender, string phone, string address, MemoryStream picture, int idclass)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname=@fn, lname=@ln, bdate=@bdt, gender=@gdr, phone=@phn, ad" +
                "dress=@adrs,picture=@pic,id_class=@idc WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = firstname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lastname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@idc", SqlDbType.Int).Value = idclass;

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

        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE Id =@id", mydb.getConnection);
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

        public bool insertclassforstudent(int ID, int idclass)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET id_class=@idc WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@idc", SqlDbType.Int).Value = idclass;

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

        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string execCount(string query)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            string count = command.ExecuteScalar().ToString();

            mydb.closeConnection();
            ///mydb.closeConnection();
            return count;
        }

        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM std");
        }
        public string totalNoClassStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE id_class =1");
        }
        public string totalClassStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE id_class !=1");
        }

        public bool insertUser(int ID, string user, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login(Id,username,password)" +
                "VALUES (@id,@us,@pa)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@us", SqlDbType.NVarChar).Value = user;
            command.Parameters.Add("@pa", SqlDbType.NVarChar).Value = pass;


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
        public bool editStudent(int ID, string firstname, string lastname, DateTime bdate, string gender, string phone, string address)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname=@fn, lname=@ln, bdate=@bdt, gender=@gdr, phone=@phn, ad" +
                "dress=@adrs WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = firstname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lastname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;


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

        public bool deleteAccountStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM login WHERE Id =@id", mydb.getConnection);
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
    }

}

