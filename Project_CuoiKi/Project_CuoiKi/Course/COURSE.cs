using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CuoiKi
{
    class COURSE
    {
        My_DB mydb = new My_DB();
        public bool checkCourseName(string courseName, int courseId = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE label=@cName and Id <> @CID", mydb.getConnection);
            command.Parameters.Add("@cName", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool insertCourse(int id, string courseName, int hoursName, string description, int id_teacher)
        {
            SqlCommand command = new SqlCommand("INSERT INTO course(Id,label,period,description,id_contact)" +
                "VALUES (@id,@name,@hrs,@descr,@idt)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursName;
            command.Parameters.Add("@descr", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("@idt", SqlDbType.Int).Value = id_teacher;
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
        public bool removeCourse(int ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM course WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
        public DataTable getAllCourses()
        {
            SqlCommand commad = new SqlCommand("select * from course");
            commad.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commad);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseById(int id)
        {
            SqlCommand commad = new SqlCommand("select * from course where Id=" + id);
            commad.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commad);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateCourse(int id, string courseName, int hoursName, string description, int id_teacher)
        {
            //ID where
            SqlCommand command = new SqlCommand("UPDATE course SET Id=@id,label=@name,period=@hrs,description=@descr,id_contact=@idt" +
                " WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursName;
            command.Parameters.Add("@descr", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("@idt", SqlDbType.Int).Value = id_teacher;
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
        string exeCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalCourses()
        {
            return exeCount("SELECT COUNT(*) FROM course");
        }
        public string execCount(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, mydb.getConnection);
            mydb.openConnection();
            string result = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return result;
        }


        // xóa toàn bộ mọi môn học khi mà contact bị xóa
        public bool removeCoursebyContact(int ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM course WHERE id_contact=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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

