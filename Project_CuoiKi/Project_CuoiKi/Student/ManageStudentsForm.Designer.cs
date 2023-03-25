
namespace Project_CuoiKi
{
    partial class ManageStudentsForm
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelTotalStudent = new System.Windows.Forms.Label();
            this.labelEnterAValueToSearch = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.ButtonUploadImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextBoxLName = new System.Windows.Forms.TextBox();
            this.ButtonAddStudent = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxFName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxClassName = new System.Windows.Forms.ComboBox();
            this.labelClassName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSearchClass = new System.Windows.Forms.Button();
            this.buttonNoClass = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelIDStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.Color.Bisque;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(449, 74);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(842, 442);
            this.DataGridView.TabIndex = 100;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Tomato;
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(938, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 31);
            this.buttonSearch.TabIndex = 99;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(728, 40);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(186, 26);
            this.textBoxSearch.TabIndex = 98;
            // 
            // labelTotalStudent
            // 
            this.labelTotalStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelTotalStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalStudent.Location = new System.Drawing.Point(955, 627);
            this.labelTotalStudent.Name = "labelTotalStudent";
            this.labelTotalStudent.Size = new System.Drawing.Size(213, 45);
            this.labelTotalStudent.TabIndex = 97;
            this.labelTotalStudent.Text = "Total Student:";
            this.labelTotalStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEnterAValueToSearch
            // 
            this.labelEnterAValueToSearch.AutoSize = true;
            this.labelEnterAValueToSearch.BackColor = System.Drawing.Color.DarkSalmon;
            this.labelEnterAValueToSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterAValueToSearch.Location = new System.Drawing.Point(442, 40);
            this.labelEnterAValueToSearch.Name = "labelEnterAValueToSearch";
            this.labelEnterAValueToSearch.Size = new System.Drawing.Size(264, 26);
            this.labelEnterAValueToSearch.TabIndex = 96;
            this.labelEnterAValueToSearch.Text = "Enter A Value To Search";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(291, 574);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(95, 23);
            this.buttonDownload.TabIndex = 95;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Tomato;
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(205, 700);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 51);
            this.buttonEdit.TabIndex = 94;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Tomato;
            this.buttonReset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(539, 700);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(117, 51);
            this.buttonReset.TabIndex = 93;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ButtonUploadImage
            // 
            this.ButtonUploadImage.Location = new System.Drawing.Point(161, 574);
            this.ButtonUploadImage.Name = "ButtonUploadImage";
            this.ButtonUploadImage.Size = new System.Drawing.Size(95, 23);
            this.ButtonUploadImage.TabIndex = 92;
            this.ButtonUploadImage.Text = "UpLoad ";
            this.ButtonUploadImage.UseVisualStyleBackColor = true;
            this.ButtonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.RadioButtonMale);
            this.panel1.Controls.Add(this.RadioButtonFemale);
            this.panel1.Location = new System.Drawing.Point(161, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 68);
            this.panel1.TabIndex = 91;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.Location = new System.Drawing.Point(16, 20);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(74, 27);
            this.RadioButtonMale.TabIndex = 21;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemale.Location = new System.Drawing.Point(128, 21);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(92, 27);
            this.RadioButtonFemale.TabIndex = 22;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(161, 427);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(225, 150);
            this.PictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxStudentImage.TabIndex = 87;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(161, 345);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(246, 76);
            this.TextBoxAddress.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSalmon;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 26);
            this.label7.TabIndex = 84;
            this.label7.Text = "Address:";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(161, 278);
            this.TextBoxPhone.Multiline = true;
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(250, 26);
            this.TextBoxPhone.TabIndex = 83;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(161, 172);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(238, 22);
            this.DateTimePicker1.TabIndex = 82;
            this.DateTimePicker1.Value = new System.DateTime(2022, 3, 6, 12, 19, 28, 0);
            // 
            // TextBoxLName
            // 
            this.TextBoxLName.Location = new System.Drawing.Point(161, 118);
            this.TextBoxLName.Multiline = true;
            this.TextBoxLName.Name = "TextBoxLName";
            this.TextBoxLName.Size = new System.Drawing.Size(250, 26);
            this.TextBoxLName.TabIndex = 81;
            // 
            // ButtonAddStudent
            // 
            this.ButtonAddStudent.BackColor = System.Drawing.Color.Tomato;
            this.ButtonAddStudent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddStudent.Location = new System.Drawing.Point(38, 700);
            this.ButtonAddStudent.Name = "ButtonAddStudent";
            this.ButtonAddStudent.Size = new System.Drawing.Size(113, 51);
            this.ButtonAddStudent.TabIndex = 90;
            this.ButtonAddStudent.Text = "Add";
            this.ButtonAddStudent.UseVisualStyleBackColor = false;
            this.ButtonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackColor = System.Drawing.Color.Tomato;
            this.ButtonRemove.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.Location = new System.Drawing.Point(371, 700);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(117, 51);
            this.ButtonRemove.TabIndex = 89;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = false;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 674);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSalmon;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 86;
            this.label8.Text = "Picture:  ";
            // 
            // TextBoxFName
            // 
            this.TextBoxFName.Location = new System.Drawing.Point(161, 70);
            this.TextBoxFName.Multiline = true;
            this.TextBoxFName.Name = "TextBoxFName";
            this.TextBoxFName.Size = new System.Drawing.Size(250, 26);
            this.TextBoxFName.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSalmon;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 26);
            this.label6.TabIndex = 78;
            this.label6.Text = "Phone: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSalmon;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 77;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 76;
            this.label4.Text = "BirthDate: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 75;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 74;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 73;
            this.label1.Text = "Student ID:";
            // 
            // ComboBoxClassName
            // 
            this.ComboBoxClassName.FormattingEnabled = true;
            this.ComboBoxClassName.Location = new System.Drawing.Point(161, 627);
            this.ComboBoxClassName.Name = "ComboBoxClassName";
            this.ComboBoxClassName.Size = new System.Drawing.Size(254, 24);
            this.ComboBoxClassName.TabIndex = 108;
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.BackColor = System.Drawing.Color.DarkSalmon;
            this.labelClassName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassName.Location = new System.Drawing.Point(2, 627);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(139, 26);
            this.labelClassName.TabIndex = 107;
            this.labelClassName.Text = "Class Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 611);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 106;
            // 
            // buttonSearchClass
            // 
            this.buttonSearchClass.BackColor = System.Drawing.Color.Tomato;
            this.buttonSearchClass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchClass.Location = new System.Drawing.Point(481, 627);
            this.buttonSearchClass.Name = "buttonSearchClass";
            this.buttonSearchClass.Size = new System.Drawing.Size(210, 31);
            this.buttonSearchClass.TabIndex = 110;
            this.buttonSearchClass.Text = "Search class";
            this.buttonSearchClass.UseVisualStyleBackColor = false;
            this.buttonSearchClass.Click += new System.EventHandler(this.buttonSearchClass_Click);
            // 
            // buttonNoClass
            // 
            this.buttonNoClass.BackColor = System.Drawing.Color.Tomato;
            this.buttonNoClass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNoClass.Location = new System.Drawing.Point(860, 706);
            this.buttonNoClass.Name = "buttonNoClass";
            this.buttonNoClass.Size = new System.Drawing.Size(363, 38);
            this.buttonNoClass.TabIndex = 112;
            this.buttonNoClass.Text = "List of students without classes";
            this.buttonNoClass.UseVisualStyleBackColor = false;
            this.buttonNoClass.Click += new System.EventHandler(this.buttonNoClass_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(1167, 512);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(124, 38);
            this.buttonRefresh.TabIndex = 113;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelIDStudent
            // 
            this.labelIDStudent.AutoSize = true;
            this.labelIDStudent.BackColor = System.Drawing.Color.LightGray;
            this.labelIDStudent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDStudent.Location = new System.Drawing.Point(156, 17);
            this.labelIDStudent.Name = "labelIDStudent";
            this.labelIDStudent.Size = new System.Drawing.Size(24, 26);
            this.labelIDStudent.TabIndex = 114;
            this.labelIDStudent.Text = "x";
            // 
            // ManageStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.formallinStudent;
            this.ClientSize = new System.Drawing.Size(1403, 763);
            this.Controls.Add(this.labelIDStudent);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonNoClass);
            this.Controls.Add(this.buttonSearchClass);
            this.Controls.Add(this.ComboBoxClassName);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelTotalStudent);
            this.Controls.Add(this.labelEnterAValueToSearch);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.ButtonUploadImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.TextBoxLName);
            this.Controls.Add(this.ButtonAddStudent);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxFName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageStudentsForm";
            this.Text = "ManageStudentsForm";
            this.Load += new System.EventHandler(this.ManageStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelTotalStudent;
        private System.Windows.Forms.Label labelEnterAValueToSearch;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button ButtonUploadImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.PictureBox PictureBoxStudentImage;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.TextBox TextBoxLName;
        private System.Windows.Forms.Button ButtonAddStudent;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxFName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxClassName;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSearchClass;
        private System.Windows.Forms.Button buttonNoClass;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelIDStudent;
    }
}