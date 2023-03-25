using Aspose.Words;
using Aspose.Words.Drawing;
using Aspose.Words.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienWinform.Report.AsposeWordExtension;

namespace Project_CuoiKi
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        My_DB mydb = new My_DB();

        public void fillGrid(SqlCommand command)
        {
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.Columns[0].HeaderText = "Student ID";
            DataGridView1.Columns[1].HeaderText = "First name";
            DataGridView1.Columns[2].HeaderText = "Last name";
            DataGridView1.Columns[3].HeaderText = "Birthday";
            DataGridView1.Columns[4].HeaderText = "Gender";
            DataGridView1.Columns[5].HeaderText = "Phone";
            DataGridView1.Columns[6].HeaderText = "Address";
            DataGridView1.Columns[7].HeaderText = "Picture";
            DataGridView1.Columns[8].HeaderText = "Class Name";
        }
        
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            
            string a = comboBox1.Text;
            SqlCommand command = new SqlCommand("SELECT s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c  on s.id_class = c.Id where Name_Class= '"+ a +"' ");

            fillGrid(command);

        }

        private void buttonSaveFileWord_Click(object sender, EventArgs e)
        {
            var homNay = DateTime.Now;
            Document report = new Document("Template\\Mau_Danh_Sach_SV.doc");
            //Bước 2: Điền các thông tin cố định
            report.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TPHCM, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            //Bước 3: Điền thông tin lên bảng
            Table dt = report.GetChild(NodeType.Table, 1, true) as Table;//Lấy bảng thứ 1 trong file mẫu
            int currentRow = 0;
            dt.InsertRows(currentRow, currentRow, DataGridView1.Rows.Count+1);
            for (int i = 0; i < DataGridView1.Columns.Count; i++)
            {
                dt.PutValue(currentRow, i, DataGridView1.Columns[i].HeaderText);//Cột STT

            }
            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < DataGridView1.Columns.Count; j++)
                {
                    if (j == 7)
                    {
                        byte[] pic;
                        pic = (byte[])DataGridView1.Rows[i].Cells[7].Value;
                        MemoryStream picture = new MemoryStream(pic);
                        DocumentBuilder builder = new DocumentBuilder(report);
                        Cell cell = dt.Rows[i + 1].Cells[7];
                        builder.MoveTo(cell.FirstParagraph);
                        Shape shape = builder.InsertImage(picture);
                        // Chaging image size. ConvertUtil Provides helper functions to convert between various measurement units. like Converts inches to points.
                        shape.Width = ConvertUtil.InchToPoint(0.5);
                        shape.Height = ConvertUtil.InchToPoint(0.5);
                    }
                    else if (j == 3)
                    {
                        DateTime bd = new DateTime();
                        bd = (DateTime)DataGridView1.Rows[i].Cells[j].Value;
                        string strbd = bd.Date.Day + "/" + bd.Date.Month + "/" + bd.Date.Year;
                        dt.PutValue(i + 1, j, strbd);
                    }
                    else
                        dt.PutValue(i + 1, j, DataGridView1.Rows[i].Cells[j].Value.ToString()); //Cột STT

                }
            }
            //Bước 4: Lưu và mở file
            report.SaveAndOpenFile("DanhSachSinhVien.doc");
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
        void loadcombo()
        {
            SqlCommand command = new SqlCommand("Select * from class", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "Name_Class";
            comboBox1.ValueMember = "Id";

        }
        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            loadcombo();
            SqlCommand command = new SqlCommand("SELECT s.Id, s.fname, s.lname, s.bdate, s.gender, s.phone, s.address, s.picture, c.Name_Class from std as s inner join class as c  on s.id_class = c.Id ");
            fillGrid(command);
        }
    }
}
