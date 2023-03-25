
namespace Project_CuoiKi
{
    partial class ManageCourseForm
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
            this.labelTotalCourses = new System.Windows.Forms.Label();
            this.ListBoxCourses = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelHoursNumber = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalCourses
            // 
            this.labelTotalCourses.AutoSize = true;
            this.labelTotalCourses.BackColor = System.Drawing.Color.Yellow;
            this.labelTotalCourses.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCourses.Location = new System.Drawing.Point(739, 378);
            this.labelTotalCourses.Name = "labelTotalCourses";
            this.labelTotalCourses.Size = new System.Drawing.Size(226, 26);
            this.labelTotalCourses.TabIndex = 29;
            this.labelTotalCourses.Text = "Total Courses:           ";
            // 
            // ListBoxCourses
            // 
            this.ListBoxCourses.BackColor = System.Drawing.Color.LightGray;
            this.ListBoxCourses.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxCourses.FormattingEnabled = true;
            this.ListBoxCourses.ItemHeight = 23;
            this.ListBoxCourses.Location = new System.Drawing.Point(673, 53);
            this.ListBoxCourses.Name = "ListBoxCourses";
            this.ListBoxCourses.Size = new System.Drawing.Size(327, 303);
            this.ListBoxCourses.TabIndex = 18;
            this.ListBoxCourses.Click += new System.EventHandler(this.ListBoxCourses_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(180, 473);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 46);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(435, 473);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(97, 46);
            this.buttonRemove.TabIndex = 28;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(307, 473);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(97, 46);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(254, 394);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(97, 46);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonPrevious.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.Location = new System.Drawing.Point(384, 394);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(97, 46);
            this.buttonPrevious.TabIndex = 23;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonLast.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast.Location = new System.Drawing.Point(516, 394);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(97, 46);
            this.buttonLast.TabIndex = 25;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(127, 230);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(139, 26);
            this.labelDescription.TabIndex = 24;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxDescription.Location = new System.Drawing.Point(284, 234);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(186, 26);
            this.textBoxDescription.TabIndex = 17;
            // 
            // labelHoursNumber
            // 
            this.labelHoursNumber.AutoSize = true;
            this.labelHoursNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoursNumber.Location = new System.Drawing.Point(90, 169);
            this.labelHoursNumber.Name = "labelHoursNumber";
            this.labelHoursNumber.Size = new System.Drawing.Size(180, 26);
            this.labelHoursNumber.TabIndex = 22;
            this.labelHoursNumber.Text = "Hours Number: ";
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabel.Location = new System.Drawing.Point(181, 112);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(85, 26);
            this.labelLabel.TabIndex = 20;
            this.labelLabel.Text = "Label: ";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCourseName.Location = new System.Drawing.Point(284, 112);
            this.textBoxCourseName.Multiline = true;
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(186, 26);
            this.textBoxCourseName.TabIndex = 14;
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonFirst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirst.Location = new System.Drawing.Point(122, 394);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(97, 46);
            this.buttonFirst.TabIndex = 19;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(214, 49);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(52, 26);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID: ";
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDown.Location = new System.Drawing.Point(284, 173);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(186, 22);
            this.numericUpDown.TabIndex = 16;
            this.numericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxID.Location = new System.Drawing.Point(284, 53);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(186, 26);
            this.textBoxID.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 26);
            this.label5.TabIndex = 68;
            this.label5.Text = "Teacher:";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(284, 291);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(186, 37);
            this.comboBoxTeacher.TabIndex = 67;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.Thiết_kế_chưa_có_tên_ngang_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 566);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.labelTotalCourses);
            this.Controls.Add(this.ListBoxCourses);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelHoursNumber);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.textBoxID);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalCourses;
        private System.Windows.Forms.ListBox ListBoxCourses;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelHoursNumber;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
    }
}