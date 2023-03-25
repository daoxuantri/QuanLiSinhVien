using Aspose.Words;
using Microsoft.Office.Interop.Excel;
using System;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms;
using ThuVienWinform.Report.AsposeWordExtension;
using Aspose.Words.Tables;

namespace Project_CuoiKi
{
    public partial class StaticResultScore : Form
    {
        public StaticResultScore()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        My_DB mydb = new My_DB();
        SCORE score = new SCORE();
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int courseCount = int.Parse(course.execCount("select count(*) from course"));
            int studentCount = int.Parse(student.execCount("select count(*) from std where concat(Id, fname) LIKE N'%" + textBoxSearchByID.Text + "%'"));
            SqlCommand cmd1 = new SqlCommand("select Id, fname, lname from std where concat(Id, fname) LIKE N'%" + textBoxSearchByID.Text + "%'", mydb.getConnection);
            SqlCommand cmd2 = new SqlCommand("select Id, label from course", mydb.getConnection);
            //Lay SV
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter.Fill(dt);
            //Lay khoa hoc
            System.Data.DataTable courTable = new System.Data.DataTable();
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
                    cmd3.CommandText = ("select label,student_score from score join course on score.id_course = course.id where id_student='" + studentid + "' and id_course='" + courseid + "'");
                    adapter = new SqlDataAdapter(cmd3);
                    System.Data.DataTable scoredata = new System.Data.DataTable();
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
            DataGridView1.DataSource = dt;
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

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.DocumentName = "Print Document";
            printDialog.Document = printDocument;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            if (printDialog.ShowDialog() == DialogResult.OK) printDocument.Print();

        }
        /// <summary>
        /// luu y
        /// lam lai
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveTextFile_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < DataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < DataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("D:\\Đồ án CNTT-Winform\\Project_CuoiKi\\Project_CuoiKi\\bin\\Debug\\temp\\Score.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxStudentID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLastname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void StaticResultScore_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = score.getAVGResultByScore();
        }

        private void buttonExportFileWord_Click(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count > 1)
            {
                //laasy thong tin sv
                SqlCommand command = new SqlCommand("select bdate, gender, phone, address from std where Id =" + (int)DataGridView1.CurrentRow.Cells[0].Value, mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable thongtin = new System.Data.DataTable();
                adapter.Fill(thongtin);
                var homNay = DateTime.Now;
                //Buowsc 1: goi file mau
                Aspose.Words.Document bangdiem = new Aspose.Words.Document("Template\\Mau_Diem.doc");
                int col = DataGridView1.ColumnCount;
                //Bước 2: Điền các thông tin cố định
                bangdiem.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TPHCM, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
                bangdiem.MailMerge.Execute(new[] { "Ho_Ten" }, new[] { DataGridView1.CurrentRow.Cells[2].Value.ToString().Trim() + " " + DataGridView1.CurrentRow.Cells[1].Value.ToString().Trim() });
                bangdiem.MailMerge.Execute(new[] { "Ngay_Sinh" }, new[] { string.Format("{0}/{1}/{2}", ((DateTime)thongtin.Rows[0][0]).Date.Day, ((DateTime)thongtin.Rows[0][0]).Date.Month, ((DateTime)thongtin.Rows[0][0]).Date.Year) });
                bangdiem.MailMerge.Execute(new[] { "Que_Quan" }, new[] { thongtin.Rows[0][3].ToString().Trim() });
                bangdiem.MailMerge.Execute(new[] { "Tong_Diem" }, new[] { DataGridView1.CurrentRow.Cells[col - 2].Value.ToString().Trim() });
                bangdiem.MailMerge.Execute(new[] { "Xep_Loai" }, new[] { DataGridView1.CurrentRow.Cells[col - 1].Value.ToString().Trim() });
                if (thongtin.Rows[0][1].ToString().Trim() == "Male")
                    bangdiem.MailMerge.Execute(new[] { "GT" }, new[] { "Nam" });
                else
                    bangdiem.MailMerge.Execute(new[] { "GT" }, new[] { "Nữ" });
                bangdiem.MailMerge.Execute(new[] { "SDT" }, new[] { thongtin.Rows[0][2].ToString().Trim() });
                //Bước 3: Điền thông tin lên bảng
                Aspose.Words.Tables.Table dt = bangdiem.GetChild(NodeType.Table, 1, true) as Aspose.Words.Tables.Table;//Lấy bảng thứ 1 trong file mẫu   
                int currentRow = 0;
                dt.InsertRows(currentRow, currentRow, DataGridView1.Columns.Count - 4);
                for (int i = 3; i < DataGridView1.Columns.Count; i++)
                {
                    dt.PutValue(i - 3 + 1, 0, DataGridView1.Columns[i].HeaderText); //Cột STT
                    dt.PutValue(i - 3 + 1, 1, DataGridView1.CurrentRow.Cells[i].Value.ToString() == "" ? "Không học" : DataGridView1.CurrentRow.Cells[i].Value.ToString());
                    //
                }
                //Bước 4: Lưu và mở file
                bangdiem.SaveAndOpenFile("report.doc");
            }
            else
            {
                MessageBox.Show("Không có sinh viên!!!");
            }
        }
    }
}
