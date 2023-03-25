
namespace Project_CuoiKi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1Login = new System.Windows.Forms.Button();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.radioButtonHR = new System.Windows.Forms.RadioButton();
            this.linkLabelQuenMK = new System.Windows.Forms.LinkLabel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.radioButtonTeacher = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Login
            // 
            this.button1Login.BackColor = System.Drawing.Color.Coral;
            this.button1Login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Login.Location = new System.Drawing.Point(265, 521);
            this.button1Login.Name = "button1Login";
            this.button1Login.Size = new System.Drawing.Size(125, 33);
            this.button1Login.TabIndex = 0;
            this.button1Login.Text = "Sign In";
            this.button1Login.UseVisualStyleBackColor = false;
            this.button1Login.Click += new System.EventHandler(this.button1Login_Click);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.BackColor = System.Drawing.Color.Red;
            this.radioButtonStudent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStudent.Location = new System.Drawing.Point(228, 393);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(112, 30);
            this.radioButtonStudent.TabIndex = 1;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = false;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.Black;
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.errorProvider1.SetError(this.textBoxUserName, "Cần nhập username");
            this.textBoxUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.Color.White;
            this.textBoxUserName.Location = new System.Drawing.Point(308, 233);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(316, 23);
            this.textBoxUserName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxUserName, "Nhập username");
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.BackColor = System.Drawing.Color.Black;
            this.textBoxPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.errorProvider2.SetError(this.textBoxPassWord, "Cần nhập password");
            this.textBoxPassWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassWord.ForeColor = System.Drawing.Color.White;
            this.textBoxPassWord.Location = new System.Drawing.Point(308, 323);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '*';
            this.textBoxPassWord.Size = new System.Drawing.Size(316, 23);
            this.textBoxPassWord.TabIndex = 7;
            this.toolTip2.SetToolTip(this.textBoxPassWord, "Nhập password");
            // 
            // radioButtonHR
            // 
            this.radioButtonHR.AutoSize = true;
            this.radioButtonHR.BackColor = System.Drawing.Color.Red;
            this.radioButtonHR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHR.Location = new System.Drawing.Point(505, 393);
            this.radioButtonHR.Name = "radioButtonHR";
            this.radioButtonHR.Size = new System.Drawing.Size(153, 30);
            this.radioButtonHR.TabIndex = 8;
            this.radioButtonHR.TabStop = true;
            this.radioButtonHR.Text = "H.Resource";
            this.radioButtonHR.UseVisualStyleBackColor = false;
            // 
            // linkLabelQuenMK
            // 
            this.linkLabelQuenMK.AutoSize = true;
            this.linkLabelQuenMK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelQuenMK.Location = new System.Drawing.Point(223, 455);
            this.linkLabelQuenMK.Name = "linkLabelQuenMK";
            this.linkLabelQuenMK.Size = new System.Drawing.Size(184, 26);
            this.linkLabelQuenMK.TabIndex = 9;
            this.linkLabelQuenMK.TabStop = true;
            this.linkLabelQuenMK.Text = "Forgot password";
            this.linkLabelQuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelQuenMK_LinkClicked);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Coral;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(520, 521);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 33);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 50;
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.ReshowDelay = 50;
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegister.Location = new System.Drawing.Point(518, 455);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(140, 26);
            this.linkLabelRegister.TabIndex = 12;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Register HR";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.BackColor = System.Drawing.Color.Red;
            this.radioButtonTeacher.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTeacher.Location = new System.Drawing.Point(362, 393);
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Size = new System.Drawing.Size(115, 30);
            this.radioButtonTeacher.TabIndex = 13;
            this.radioButtonTeacher.TabStop = true;
            this.radioButtonTeacher.Text = "Teacher";
            this.radioButtonTeacher.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.imageForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 591);
            this.Controls.Add(this.radioButtonTeacher);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.linkLabelQuenMK);
            this.Controls.Add(this.radioButtonHR);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.button1Login);
            this.Name = "Form1";
            this.Text = "TRANG HỌC PHẦN";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Login;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.LinkLabel linkLabelQuenMK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        public System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        public System.Windows.Forms.RadioButton radioButtonHR;
        public System.Windows.Forms.RadioButton radioButtonTeacher;
    }
}

