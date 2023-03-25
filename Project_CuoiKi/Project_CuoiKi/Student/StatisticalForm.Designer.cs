
namespace Project_CuoiKi
{
    partial class StatisticalForm
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
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelStudentClass = new System.Windows.Forms.Label();
            this.panelFamale = new System.Windows.Forms.Panel();
            this.labelClass = new System.Windows.Forms.Label();
            this.panelMale = new System.Windows.Forms.Panel();
            this.labelNoClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTotal.SuspendLayout();
            this.panelFamale.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelTotal.Controls.Add(this.labelStudentClass);
            this.panelTotal.Location = new System.Drawing.Point(45, 94);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(573, 213);
            this.panelTotal.TabIndex = 6;
            // 
            // labelStudentClass
            // 
            this.labelStudentClass.BackColor = System.Drawing.Color.Silver;
            this.labelStudentClass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentClass.Location = new System.Drawing.Point(129, 93);
            this.labelStudentClass.Name = "labelStudentClass";
            this.labelStudentClass.Size = new System.Drawing.Size(329, 50);
            this.labelStudentClass.TabIndex = 0;
            this.labelStudentClass.Text = "Danh Sách Sinh Viên: 100%";
            this.labelStudentClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFamale
            // 
            this.panelFamale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelFamale.Controls.Add(this.labelClass);
            this.panelFamale.Location = new System.Drawing.Point(335, 313);
            this.panelFamale.Name = "panelFamale";
            this.panelFamale.Size = new System.Drawing.Size(287, 222);
            this.panelFamale.TabIndex = 5;
            // 
            // labelClass
            // 
            this.labelClass.BackColor = System.Drawing.Color.Silver;
            this.labelClass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(11, 80);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(272, 50);
            this.labelClass.TabIndex = 3;
            this.labelClass.Text = "Đã có lớp: 50%";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMale
            // 
            this.panelMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelMale.Controls.Add(this.labelNoClass);
            this.panelMale.Location = new System.Drawing.Point(42, 313);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(287, 222);
            this.panelMale.TabIndex = 4;
            // 
            // labelNoClass
            // 
            this.labelNoClass.BackColor = System.Drawing.Color.Silver;
            this.labelNoClass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoClass.Location = new System.Drawing.Point(3, 80);
            this.labelNoClass.Name = "labelNoClass";
            this.labelNoClass.Size = new System.Drawing.Size(272, 50);
            this.labelNoClass.TabIndex = 1;
            this.labelNoClass.Text = "Chưa Có Lớp: 50%";
            this.labelNoClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thống Kê Sinh Viên Đã Được Thêm Vào Lớp và Chưa Vào Lớp ";
            // 
            // StatisticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.UIimageTeacher;
            this.ClientSize = new System.Drawing.Size(715, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelFamale);
            this.Controls.Add(this.panelMale);
            this.Name = "StatisticalForm";
            this.Text = "StatisticalForm";
            this.Load += new System.EventHandler(this.StatisticalForm_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelFamale.ResumeLayout(false);
            this.panelMale.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelStudentClass;
        private System.Windows.Forms.Panel panelFamale;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Label labelNoClass;
        private System.Windows.Forms.Label label1;
    }
}