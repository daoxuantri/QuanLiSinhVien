using Aspose.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienWinform.Report.AsposeWordExtension;

namespace Project_CuoiKi
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
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

        private void buttonFilwWord_Click(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count > 1)
            {
                var homNay = DateTime.Now;
                //Buowsc 1: goi file mau
                Aspose.Words.Document bangdiem = new Aspose.Words.Document("Template\\BangDiem.doc");
                int col = DataGridView1.ColumnCount;
                //Bước 2: Điền các thông tin cố định
                bangdiem.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TPHCM, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
                //Bước 3: Điền thông tin lên bảng
                Aspose.Words.Tables.Table dt = bangdiem.GetChild(NodeType.Table, 1, true) as Aspose.Words.Tables.Table;//Lấy bảng thứ 1 trong file mẫu   
                int currentRow = 0;
                dt.InsertRows(currentRow, currentRow, DataGridView1.Columns.Count);
                for (int i = 0; i < DataGridView1.Columns.Count; i++)
                {
                    dt.PutValue(currentRow, i, DataGridView1.Columns[i].HeaderText);

                }
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {

                    for (int j = 0; j < DataGridView1.Columns.Count; j++)
                    {
                        dt.PutValue(i + 1, j, DataGridView1.Rows[i].Cells[j].Value.ToString()); //Cột STT
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

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = score.getStudentsScore();
            DataGridView1.Columns[0].HeaderText = "Student ID";
            DataGridView1.Columns[1].HeaderText = "First name";
            DataGridView1.Columns[2].HeaderText = "Last name";
            DataGridView1.Columns[3].HeaderText = "Course ID";
            DataGridView1.Columns[4].HeaderText = "Tên môn học";
            DataGridView1.Columns[5].HeaderText = "Điểm";
        }
    }
}
