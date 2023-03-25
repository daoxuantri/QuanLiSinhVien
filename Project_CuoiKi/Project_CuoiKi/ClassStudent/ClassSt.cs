using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CuoiKi
{
    class ClassSt
    {
        My_DB mydb = new My_DB();
        public bool insertClass(int ID, string classname)
        {
            SqlCommand command = new SqlCommand("INSERT INTO class(Id, Name_Class)" +
                "VALUES (@id,@nm)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@nm", SqlDbType.NVarChar).Value = classname;

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

        public bool updateClass(int ID, string classname)
        {
            SqlCommand command = new SqlCommand("UPDATE class SET Name_Class=@nm WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@nm", SqlDbType.NVarChar).Value = classname;

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
        // Hàm xóa class
        public bool deleteClass(int id)
        {
            SqlCommand command = new SqlCommand("delete from class where id=@id", mydb.getConnection);

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

        public DataTable getClass(SqlCommand command)
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
        public string totalClass()
        {
            return execCount("SELECT COUNT(*) FROM class");
        }

        public DataTable getAllClass()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM class", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getClassByIdStudent(int id)
        {

            SqlCommand command = new SqlCommand("select s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c on s.id_class = c.Id where s.Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllNoClass()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM class where id  !=1", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Hàm reset id_class của std thành 1 khi xóa class
        public bool resetidClass(int id)
        {

            SqlCommand com = new SqlCommand("UPDATE std set id_class = 1 WHERE id_class =@id", mydb.getConnection);

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





