
namespace Project_CuoiKi
{
    partial class EditCourseForm
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.ComboBoxteacher = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Red;
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(146, 369);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(144, 41);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Coral;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(39, 211);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(139, 26);
            this.labelDescription.TabIndex = 20;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxDescription.Location = new System.Drawing.Point(215, 215);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(195, 75);
            this.textBoxDescription.TabIndex = 19;
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDown.Location = new System.Drawing.Point(215, 145);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(148, 22);
            this.numericUpDown.TabIndex = 18;
            this.numericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(215, 16);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(148, 24);
            this.comboBoxSelectCourse.TabIndex = 17;
            this.comboBoxSelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCourse_SelectedIndexChanged);
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.BackColor = System.Drawing.Color.Coral;
            this.labelSelectCourse.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.Location = new System.Drawing.Point(17, 12);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(160, 26);
            this.labelSelectCourse.TabIndex = 16;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.BackColor = System.Drawing.Color.Coral;
            this.labelCourseName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseName.Location = new System.Drawing.Point(17, 79);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(158, 26);
            this.labelCourseName.TabIndex = 15;
            this.labelCourseName.Text = "Course Name:";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxCourseName.Location = new System.Drawing.Point(215, 83);
            this.textBoxCourseName.Multiline = true;
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(148, 26);
            this.textBoxCourseName.TabIndex = 14;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.BackColor = System.Drawing.Color.Coral;
            this.labelPeriod.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.Location = new System.Drawing.Point(86, 141);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(89, 26);
            this.labelPeriod.TabIndex = 13;
            this.labelPeriod.Text = "Period:";
            // 
            // ComboBoxteacher
            // 
            this.ComboBoxteacher.BackColor = System.Drawing.Color.Gainsboro;
            this.ComboBoxteacher.FormattingEnabled = true;
            this.ComboBoxteacher.Location = new System.Drawing.Point(215, 316);
            this.ComboBoxteacher.Name = "ComboBoxteacher";
            this.ComboBoxteacher.Size = new System.Drawing.Size(195, 24);
            this.ComboBoxteacher.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 26);
            this.label5.TabIndex = 110;
            this.label5.Text = "Teacher:";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.UIimageTeacher;
            this.ClientSize = new System.Drawing.Size(485, 457);
            this.Controls.Add(this.ComboBoxteacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.labelSelectCourse);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.labelPeriod);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.ComboBox ComboBoxteacher;
        private System.Windows.Forms.Label label5;
    }
}