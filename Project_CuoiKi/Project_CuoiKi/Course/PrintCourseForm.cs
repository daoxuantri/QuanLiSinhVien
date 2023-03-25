using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;

namespace Project_CuoiKi
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        public void fillGrid(SqlCommand command)
        {
            DataGridView.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView.RowTemplate.Height = 80;
            DataGridView.DataSource = course.getAllCourses();
            DataGridView.AllowUserToAddRows = false;
            DataGridView.Columns[0].HeaderText = "ID course";
            DataGridView.Columns[1].HeaderText = "Tên khóa học";
            DataGridView.Columns[2].HeaderText = "Thời gian học";
            DataGridView.Columns[3].HeaderText = "Mô tả";
            DataGridView.Columns[4].HeaderText = "Teacher ID";
        }
        private void buttonSaveToTextFile_Click(object sender, EventArgs e)
        {
            if (DataGridView.Rows.Count > 1)
            {
                var homNay = DateTime.Now;
                //Buowsc 1: goi file mau
                Aspose.Words.Document bangdiem = new Aspose.Words.Document("Template\\Mau_Bao_Cao.doc");
                int col = DataGridView.ColumnCount;
                //Bước 2: Điền các thông tin cố định
                bangdiem.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TPHCM, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
                //Bước 3: Điền thông tin lên bảng
                Aspose.Words.Tables.Table dt = bangdiem.GetChild(NodeType.Table, 1, true) as Aspose.Words.Tables.Table;//Lấy bảng thứ 1 trong file mẫu   
                int currentRow = 0;
                dt.InsertRows(currentRow, currentRow, DataGridView.Columns.Count -1);   //DataGridView.Columns.Count-1
                // DataGridView.Columns.Count+1 ko co teacher 
                for (int i = 0; i < DataGridView.Columns.Count ; i++)
                {
                    dt.PutValue(currentRow, i, DataGridView.Columns[i].HeaderText);

                }
                for (int i = 0; i < DataGridView.Rows.Count ; i++)
                {

                    for (int j = 0; j < DataGridView.Columns.Count ; j++)
                    {
                        dt.PutValue(i + 1, j, DataGridView.Rows[i].Cells[j].Value.ToString()); //Cột STT
                    }
                }
                //Bước 4: Lưu và mở file
                bangdiem.SaveAndOpenFile("report.doc");
            }
            else
            {
                MessageBox.Show("Không có điểm môn nào!!!");
            }
        }

        private void buttonToPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.DocumentName = "Print Document";
            printDialog.Document = printDocument;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;

            if (printDialog.ShowDialog() == DialogResult.OK) printDocument.Print();



            /*

            var homNay = DateTime.Now;

            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("Template\\Mau_Bao_Cao.doc");

            //Bước 2: Điền các thông tin cố định
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("Bắc Kạn, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            baoCao.MailMerge.Execute(new[] { "Ho_Ten" }, new[] { txtHoTen.Text });
            baoCao.MailMerge.Execute(new[] { "Ngay_Sinh" }, new[] { dateNgaySinh.Value.ToString("dd/MM/yyyy") });
            baoCao.MailMerge.Execute(new[] { "SDT" }, new[] { txtSoDienThoai.Text });
            baoCao.MailMerge.Execute(new[] { "Que_Quan" }, new[] { txtQueQuan.Text });
            baoCao.MailMerge.Execute(new[] { "Nguoi_Yeu" }, new[] { "Sơn Tùng MTP" });
            baoCao.MailMerge.Execute(new[] { "Nguoi_Giam_Ho" }, new[] { "Nguyễn Văn A" });

            //Bước 3: Điền thông tin lên bảng
            Table bangThongTinGiaDinh = baoCao.GetChild(NodeType.Table, 1, true) as Table;//Lấy bảng thứ 2 trong file mẫu
            int hangHienTai = 1;
            bangThongTinGiaDinh.InsertRows(hangHienTai, hangHienTai, 3);
            for (int i = 1; i <= 4; i++)
            {
                bangThongTinGiaDinh.PutValue(hangHienTai, 0, i.ToString());//Cột STT
                bangThongTinGiaDinh.PutValue(hangHienTai, 1, "Nguyễn Văn A");//Cột Họ và tên
                bangThongTinGiaDinh.PutValue(hangHienTai, 2, "Bố đẻ");//Cột quan hệ
                bangThongTinGiaDinh.PutValue(hangHienTai, 3, "0123456789");//Cột Số điện thoại
                hangHienTai++;
            }

            //Bước 4: Lưu và mở file
            baoCao.SaveAndOpenFile("BaoCao.doc");*/
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from course");
            fillGrid(command);
        }
    }
}
