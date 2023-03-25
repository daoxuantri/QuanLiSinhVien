
namespace Project_CuoiKi
{
    partial class CourseGradeList
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.buttonAllCourse = new System.Windows.Forms.Button();
            this.labelCourse = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(88, 134);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(956, 408);
            this.dgv.TabIndex = 181;
            // 
            // buttonAllCourse
            // 
            this.buttonAllCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllCourse.Location = new System.Drawing.Point(896, 101);
            this.buttonAllCourse.Name = "buttonAllCourse";
            this.buttonAllCourse.Size = new System.Drawing.Size(148, 38);
            this.buttonAllCourse.TabIndex = 180;
            this.buttonAllCourse.Text = "Refresh";
            this.buttonAllCourse.UseVisualStyleBackColor = true;
            this.buttonAllCourse.Click += new System.EventHandler(this.buttonAllCourse_Click);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.BackColor = System.Drawing.Color.MistyRose;
            this.labelCourse.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(83, 74);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(93, 26);
            this.labelCourse.TabIndex = 177;
            this.labelCourse.Text = "Course:";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel.Location = new System.Drawing.Point(196, 70);
            this.textBoxLabel.Multiline = true;
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(183, 38);
            this.textBoxLabel.TabIndex = 229;
            this.textBoxLabel.TextChanged += new System.EventHandler(this.textBoxLabel_TextChanged);
            // 
            // CourseGradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.Màu_Xanh__ngang_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 647);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.buttonAllCourse);
            this.Controls.Add(this.labelCourse);
            this.DoubleBuffered = true;
            this.Name = "CourseGradeList";
            this.Text = "CourseGradeList";
            this.Load += new System.EventHandler(this.CourseGradeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonAllCourse;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.TextBox textBoxLabel;
    }
}