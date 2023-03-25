using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CuoiKi
{
    class SCORE
    {
        My_DB mydb = new My_DB();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        public bool insertScore(int id, int courseID, float scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (id_student,id_course,student_score,description)" +
                "VALUES (@id,@course,@score,@descr)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@course", SqlDbType.VarChar).Value = courseID;
            command.Parameters.Add("@score", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE id_student=@sid and id_course=@cid", mydb.getConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
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

        //kiemtra trung tuong tu cac phan tu khac
        public bool studentScoreExist(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE id_student=@sid AND id_course=@cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
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

        //funciton to get student score
        public DataTable getStudentsScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT score.id_student, std.fname, std.lname, score.id_course, course.label, score." +
                "student_score from std inner join score on std.Id=score.id_student inner join course on score.id_course=course.Id");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //tih trung binh
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = "SELECT course.label, AVG (score.student_score) as AverageGrade FROM course, score WHERE course.Id=" +
                "score.id_course GROUP BY course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;

        }

        // get student's score by id 
        public DataTable getStudentScores(int studentId)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT score.id_student, std.fname, std.lname, score.id_course, course.label, score." +
                "student_score FROM std INNER JOIN score on std.Id= score.id_student  INNER JOIN course on score.id_course=course.Id WHERE score.id_student=" + studentId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable StaticbyResult()
        {
            int xuatxac = 0;
            int gioi = 0;
            int kha = 0;
            int trungbinh = 0;
            int yeu = 0;
            int khonghoc = 0;
            DataTable dt = new DataTable();
            DataTable ressult = new DataTable();
            ressult = getAVGResultByScore();
            int avg = ressult.Columns.Count;
            for (int i = 0; i < ressult.Rows.Count; i++)
            {
                if (ressult.Rows[i].ItemArray[avg - 1].ToString() == "Xuất sắc")
                {
                    xuatxac++;
                }
                else if (ressult.Rows[i].ItemArray[avg - 1].ToString() == "Giỏi")
                {
                    gioi++;
                }
                else if (ressult.Rows[i].ItemArray[avg - 1].ToString() == "Khá")
                {
                    kha++;
                }
                else if (ressult.Rows[i].ItemArray[avg - 1].ToString() == "Trung Bình")
                {
                    trungbinh++;
                }
                else if (ressult.Rows[i].ItemArray[avg - 1].ToString() == "Yếu")
                {
                    yeu++;
                }
                else if (ressult.Rows[i].ItemArray[avg - 1].ToString() == "Không học các môn này")
                {
                    khonghoc++;
                }
            }
            int tongsosv = int.Parse(student.execCount("select count(*) from std"));
            dt.Columns.Add("Xuất sắc", typeof(float));
            dt.Columns.Add("Giỏi", typeof(float));
            dt.Columns.Add("Khá", typeof(float));
            dt.Columns.Add("Trung Bình", typeof(float));
            dt.Columns.Add("Yếu", typeof(float));
            dt.Columns.Add("Không học các môn này", typeof(float));
            DataRow row;
            row = dt.NewRow();
            row["Xuất sắc"] = Math.Round((float)xuatxac / tongsosv * 100, 1);
            row["Giỏi"] = Math.Round((float)gioi / tongsosv * 100, 1);
            row["Khá"] = Math.Round((float)kha / tongsosv * 100, 1);
            row["Trung Bình"] = Math.Round((float)trungbinh / tongsosv * 100, 1);
            row["Yếu"] = Math.Round((float)yeu / tongsosv * 100, 1);
            row["Không học các môn này"] = Math.Round((float)khonghoc / tongsosv * 100, 1);
            dt.Rows.Add(row);
            return dt;
        }

        public DataTable getAVGResultByScore()
        {
            int courseCount = int.Parse(course.execCount("select count(*) from course"));
            int studentCount = int.Parse(student.execCount("select count(*) from std"));
            SqlCommand cmd1 = new SqlCommand("select Id,fname,lname from std ", mydb.getConnection);
            SqlCommand cmd2 = new SqlCommand("select Id, label from course", mydb.getConnection);
            //Lay SV
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //Lay khoa hoc
            DataTable courTable = new DataTable();
            adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(courTable);

            for (int i = 0; i < courseCount; i++)
            {
                dt.Columns.Add(courTable.Rows[i].ItemArray[1].ToString(), typeof(string));
            }
            dt.Columns.Add("Average Score", typeof(string));
            dt.Columns.Add("Result", typeof(string));
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = mydb.getConnection;
            for (int i = 0; i < studentCount; i++)
            {
                string studentid = dt.Rows[i].ItemArray[0].ToString();
                float AVGscore = 0;
                int count = 0;
                for (int j = 0; j < courseCount; j++)
                {
                    string courseid = courTable.Rows[j].ItemArray[0].ToString();
                    cmd3.CommandText = ("select label,student_score from score join course on score.id_course = course.Id where id_student='" + studentid + "' and id_course='" + courseid + "'");
                    adapter = new SqlDataAdapter(cmd3);
                    DataTable scoredata = new DataTable();
                    adapter.Fill(scoredata);
                    if (scoredata.Rows.Count > 0)
                    {
                        dt.Rows[i][scoredata.Rows[0].ItemArray[0].ToString()] = scoredata.Rows[0].ItemArray[1].ToString();
                        AVGscore += float.Parse(scoredata.Rows[0].ItemArray[1].ToString());
                        count++;
                    }
                }
                if (count != 0)
                {
                    AVGscore = AVGscore / count;
                    dt.Rows[i]["Average Score"] = AVGscore.ToString();
                    dt.Rows[i]["Result"] = CheckResult(AVGscore);
                }
                else
                {
                    AVGscore = 0;
                    dt.Rows[i]["Average Score"] = "";
                    dt.Rows[i]["Result"] = "Khong hoc cac mon nay";
                }
            }
            return dt;
            /*
            int courseCount = int.Parse(course.execCount("select count(*) from course"));
            int studentCount = int.Parse(student.execCount("select count(*) from std"));
            SqlCommand cmd1 = new SqlCommand("select Id,fname,lname from std ", mydb.getConnection);
            SqlCommand cmd2 = new SqlCommand("select Id, label from course", mydb.getConnection);
            //Lay SV
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //Lay khoa hoc
            DataTable courTable = new DataTable();
            adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(courTable);

            for (int i = 0; i < courseCount; i++)
            {
                dt.Columns.Add(courTable.Rows[i].ItemArray[1].ToString(), typeof(string));
            }
            dt.Columns.Add("Average Score", typeof(string));
            dt.Columns.Add("Result", typeof(string));
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = mydb.getConnection;
            for (int i = 0; i < studentCount; i++)
            {
                string studentid = dt.Rows[i].ItemArray[0].ToString();
                float AVGscore = 0;
                int count = 0;
                for (int j = 0; j < courseCount; j++)
                {
                    string courseid = courTable.Rows[j].ItemArray[0].ToString();
                    cmd3.CommandText = ("select label,student_score from score join course on score.id_course = course.Id where id_student='" + studentid + "' and id_course='" + courseid + "'");
                    adapter = new SqlDataAdapter(cmd3);
                    DataTable scoredata = new DataTable();
                    adapter.Fill(scoredata);
                    if (scoredata.Rows.Count > 0)
                    {
                        dt.Rows[i][scoredata.Rows[0].ItemArray[0].ToString()] = scoredata.Rows[0].ItemArray[1].ToString();
                        AVGscore += int.Parse(scoredata.Rows[0].ItemArray[1].ToString());
                        count++;
                    }
                }
                if (count != 0)
                {
                    AVGscore = AVGscore / count;
                    dt.Rows[i]["Average Score"] = AVGscore.ToString();
                    dt.Rows[i]["Result"] = CheckResult(AVGscore);
                }
                else
                {
                    AVGscore = 0;
                    dt.Rows[i]["Average Score"] = "";
                    dt.Rows[i]["Result"] = "Không học các môn này";
                }
            }
            return dt;*/
        }

        public string CheckResult(float avg)
        {
            if (avg >= 0 && avg < 5)
            {
                return "Trung Binh";
            }
            else if (5 <= avg && avg < 8)
            {
                return "Kha";
            }
            else
            {
                return "Gioi";
            }
        }


        public bool deleteScorebyStudent(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE id_student=@sid and id_course=@cid and student_score IS NULL", mydb.getConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool insertScorebyStudent(int idStudent, int idCourse)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (id_student, id_course)" +
                "VALUES (@studentid, @courseid)", mydb.getConnection);


            command.Parameters.Add("@studentid", SqlDbType.Int).Value = idStudent;
            command.Parameters.Add("@courseid", SqlDbType.Int).Value = idCourse;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool deleteScorebyTeacher(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE id_student=@sid and id_course=@cid", mydb.getConnection);


            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool updateScore(int studentID, int courseID, float score)
        {
            SqlCommand command = new SqlCommand("UPDATE score SET student_score=@sc where id_student=@sid and id_course=@cid", mydb.getConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@sc", SqlDbType.Float).Value = score;


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

        public bool updateDescription(int studentID, int courseID, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE score SET description=@descr where id_student=@sid and id_course=@cid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;

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


        /// hàm xóa tất cả điểm của sinh viên sau khi xóa sinh viên ra khỏi table
        public bool deleteAllScore(int studentID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE id_student=@sid ", mydb.getConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
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


        ///hàm xóa điểm tất cả các sinh viên sau khi humanresource thực hiện xóa một môn học bất kì 
        public bool deleteTableScoreINcourse(int course)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE id_course=@sid ", mydb.getConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = course;
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
