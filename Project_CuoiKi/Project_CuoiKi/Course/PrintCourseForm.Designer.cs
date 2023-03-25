
namespace Project_CuoiKi
{
    partial class PrintCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSaveToTextFile = new System.Windows.Forms.Button();
            this.buttonToPrinter = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveToTextFile
            // 
            this.buttonSaveToTextFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveToTextFile.Location = new System.Drawing.Point(196, 335);
            this.buttonSaveToTextFile.Name = "buttonSaveToTextFile";
            this.buttonSaveToTextFile.Size = new System.Drawing.Size(207, 52);
            this.buttonSaveToTextFile.TabIndex = 15;
            this.buttonSaveToTextFile.Text = "Save To Text File";
            this.buttonSaveToTextFile.UseVisualStyleBackColor = true;
            this.buttonSaveToTextFile.Click += new System.EventHandler(this.buttonSaveToTextFile_Click);
            // 
            // buttonToPrinter
            // 
            this.buttonToPrinter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToPrinter.Location = new System.Drawing.Point(682, 335);
            this.buttonToPrinter.Name = "buttonToPrinter";
            this.buttonToPrinter.Size = new System.Drawing.Size(167, 52);
            this.buttonToPrinter.TabIndex = 14;
            this.buttonToPrinter.Text = "To Printer";
            this.buttonToPrinter.UseVisualStyleBackColor = true;
            this.buttonToPrinter.Click += new System.EventHandler(this.buttonToPrinter_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(69, 40);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(949, 289);
            this.DataGridView.TabIndex = 13;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.Màu_Xanh__ngang_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 420);
            this.Controls.Add(this.buttonSaveToTextFile);
            this.Controls.Add(this.buttonToPrinter);
            this.Controls.Add(this.DataGridView);
            this.DoubleBuffered = true;
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveToTextFile;
        private System.Windows.Forms.Button buttonToPrinter;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}