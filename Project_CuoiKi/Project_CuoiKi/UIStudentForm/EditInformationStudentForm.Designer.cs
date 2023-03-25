
namespace Project_CuoiKi
{
    partial class EditInformationStudentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelClassName = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelIdStudent = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioButtonMale);
            this.panel1.Controls.Add(this.RadioButtonFemale);
            this.panel1.Location = new System.Drawing.Point(275, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 68);
            this.panel1.TabIndex = 235;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.Location = new System.Drawing.Point(26, 21);
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
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(490, 472);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 57);
            this.buttonEdit.TabIndex = 234;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(675, 100);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(248, 101);
            this.textBoxAddress.TabIndex = 233;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(275, 406);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(248, 35);
            this.textBoxPhone.TabIndex = 232;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(275, 221);
            this.textBoxLName.Multiline = true;
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(248, 35);
            this.textBoxLName.TabIndex = 231;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(271, 159);
            this.textBoxFName.Multiline = true;
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(248, 35);
            this.textBoxFName.TabIndex = 230;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 229;
            this.label1.Text = "Thông Tin Sinh Viên ";
            // 
            // labelClass
            // 
            this.labelClass.BackColor = System.Drawing.Color.Silver;
            this.labelClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(671, 399);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(264, 41);
            this.labelClass.TabIndex = 228;
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(671, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 227;
            this.pictureBox1.TabStop = false;
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassName.Location = new System.Drawing.Point(579, 406);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(74, 26);
            this.labelClassName.TabIndex = 226;
            this.labelClassName.Text = "Class:";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicture.Location = new System.Drawing.Point(557, 225);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(96, 26);
            this.labelPicture.TabIndex = 225;
            this.labelPicture.Text = "Picture:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(550, 100);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(103, 26);
            this.labelAddress.TabIndex = 224;
            this.labelAddress.Text = "Address:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(275, 294);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.DateTimePicker1.TabIndex = 223;
            // 
            // labelIdStudent
            // 
            this.labelIdStudent.BackColor = System.Drawing.Color.Silver;
            this.labelIdStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdStudent.Location = new System.Drawing.Point(271, 100);
            this.labelIdStudent.Name = "labelIdStudent";
            this.labelIdStudent.Size = new System.Drawing.Size(248, 35);
            this.labelIdStudent.TabIndex = 222;
            this.labelIdStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(145, 414);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(84, 26);
            this.labelPhone.TabIndex = 221;
            this.labelPhone.Text = "Phone:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(132, 350);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(97, 26);
            this.labelGender.TabIndex = 220;
            this.labelGender.Text = "Gender:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.Location = new System.Drawing.Point(100, 290);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(129, 26);
            this.labelBirthDate.TabIndex = 219;
            this.labelBirthDate.Text = "Birth Date:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(100, 230);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(130, 26);
            this.labelLastName.TabIndex = 218;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(95, 170);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(135, 26);
            this.labelFirstName.TabIndex = 217;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(183, 98);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(46, 26);
            this.labelID.TabIndex = 216;
            this.labelID.Text = "ID:";
            // 
            // EditInformationStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.UIimageNen_Ngang_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.labelIdStudent);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelID);
            this.DoubleBuffered = true;
            this.Name = "EditInformationStudentForm";
            this.Text = "EditInformationStudentForm";
            this.Load += new System.EventHandler(this.EditInformationStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelClass;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelAddress;
        public System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label labelIdStudent;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelID;
    }
}