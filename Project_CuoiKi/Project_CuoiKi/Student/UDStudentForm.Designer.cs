
namespace Project_CuoiKi
{
    partial class UDStudentForm
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
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonUploadPicture = new System.Windows.Forms.Button();
            this.labelPicture = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.panelGender = new System.Windows.Forms.Panel();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelID = new System.Windows.Forms.Label();
            this.labelClassName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelIDStudent = new System.Windows.Forms.Label();
            this.panelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.LightCoral;
            this.buttonRemove.Location = new System.Drawing.Point(782, 497);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(131, 52);
            this.buttonRemove.TabIndex = 60;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.LightCoral;
            this.buttonEdit.Location = new System.Drawing.Point(590, 497);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(131, 52);
            this.buttonEdit.TabIndex = 59;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonUploadPicture
            // 
            this.buttonUploadPicture.BackColor = System.Drawing.Color.LightCoral;
            this.buttonUploadPicture.Location = new System.Drawing.Point(658, 357);
            this.buttonUploadPicture.Name = "buttonUploadPicture";
            this.buttonUploadPicture.Size = new System.Drawing.Size(292, 23);
            this.buttonUploadPicture.TabIndex = 58;
            this.buttonUploadPicture.Text = "Upload Picture";
            this.buttonUploadPicture.UseVisualStyleBackColor = false;
            this.buttonUploadPicture.Click += new System.EventHandler(this.buttonUploadPicture_Click);
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.BackColor = System.Drawing.Color.Coral;
            this.labelPicture.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicture.Location = new System.Drawing.Point(549, 253);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(96, 26);
            this.labelPicture.TabIndex = 57;
            this.labelPicture.Text = "Picture:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(658, 85);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(292, 88);
            this.textBoxAddress.TabIndex = 56;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Coral;
            this.labelAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(549, 111);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(103, 26);
            this.labelAddress.TabIndex = 55;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(178, 422);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(292, 26);
            this.textBoxPhone.TabIndex = 54;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Coral;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(52, 418);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(84, 26);
            this.labelPhone.TabIndex = 53;
            this.labelPhone.Text = "Phone:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Coral;
            this.labelGender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(52, 357);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(97, 26);
            this.labelGender.TabIndex = 52;
            this.labelGender.Text = "Gender:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(21, 15);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale.TabIndex = 10;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.radioButtonFemale);
            this.panelGender.Controls.Add(this.radioButtonMale);
            this.panelGender.Location = new System.Drawing.Point(178, 347);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(284, 48);
            this.panelGender.TabIndex = 51;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(185, 15);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 11;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.BackColor = System.Drawing.Color.Coral;
            this.labelBirthDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.Location = new System.Drawing.Point(19, 294);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(129, 26);
            this.labelBirthDate.TabIndex = 50;
            this.labelBirthDate.Text = "Birth Date:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(178, 173);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(292, 26);
            this.textBoxFirstName.TabIndex = 49;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(178, 242);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(292, 26);
            this.textBoxLastName.TabIndex = 48;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Coral;
            this.labelLastName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(19, 238);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(130, 26);
            this.labelLastName.TabIndex = 47;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Coral;
            this.labelFirstName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(14, 169);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(135, 26);
            this.labelFirstName.TabIndex = 46;
            this.labelFirstName.Text = "First Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(658, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(171, 298);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(299, 22);
            this.DateTimePicker1.TabIndex = 42;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Coral;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(103, 111);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(46, 26);
            this.labelID.TabIndex = 43;
            this.labelID.Text = "ID:";
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.BackColor = System.Drawing.Color.Coral;
            this.labelClassName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassName.Location = new System.Drawing.Point(549, 414);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(74, 26);
            this.labelClassName.TabIndex = 62;
            this.labelClassName.Text = "Class:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(658, 414);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 24);
            this.comboBox1.TabIndex = 110;
            // 
            // labelIDStudent
            // 
            this.labelIDStudent.AutoSize = true;
            this.labelIDStudent.BackColor = System.Drawing.Color.LightGray;
            this.labelIDStudent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDStudent.Location = new System.Drawing.Point(183, 111);
            this.labelIDStudent.Name = "labelIDStudent";
            this.labelIDStudent.Size = new System.Drawing.Size(24, 26);
            this.labelIDStudent.TabIndex = 115;
            this.labelIDStudent.Text = "x";
            // 
            // UDStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.ContactForm;
            this.ClientSize = new System.Drawing.Size(1016, 587);
            this.Controls.Add(this.labelIDStudent);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonUploadPicture);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.panelGender);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.labelID);
            this.Name = "UDStudentForm";
            this.Text = "UDStudentForm";
            this.Load += new System.EventHandler(this.UDStudentForm_Load);
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonRemove;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.Button buttonUploadPicture;
        private System.Windows.Forms.Label labelPicture;
        public System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        public System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGender;
        public System.Windows.Forms.RadioButton radioButtonMale;
        public System.Windows.Forms.Panel panelGender;
        public System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelBirthDate;
        public System.Windows.Forms.TextBox textBoxFirstName;
        public System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelClassName;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label labelIDStudent;
    }
}