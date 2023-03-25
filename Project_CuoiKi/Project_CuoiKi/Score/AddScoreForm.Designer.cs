
namespace Project_CuoiKi
{
    partial class AddScoreForm
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
            this.DataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.TextBoxScore = new System.Windows.Forms.TextBox();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewStudents
            // 
            this.DataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudents.Location = new System.Drawing.Point(509, 50);
            this.DataGridViewStudents.Name = "DataGridViewStudents";
            this.DataGridViewStudents.RowHeadersWidth = 51;
            this.DataGridViewStudents.RowTemplate.Height = 24;
            this.DataGridViewStudents.Size = new System.Drawing.Size(583, 408);
            this.DataGridViewStudents.TabIndex = 73;
            this.DataGridViewStudents.Click += new System.EventHandler(this.DataGridViewStudents_Click);
            // 
            // TextBoxScore
            // 
            this.TextBoxScore.BackColor = System.Drawing.Color.LightGray;
            this.TextBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxScore.Location = new System.Drawing.Point(199, 177);
            this.TextBoxScore.Name = "TextBoxScore";
            this.TextBoxScore.Size = new System.Drawing.Size(258, 30);
            this.TextBoxScore.TabIndex = 72;
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.BackColor = System.Drawing.Color.LightGray;
            this.ComboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(199, 110);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(258, 37);
            this.ComboBoxCourse.TabIndex = 71;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAddCourse.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.ForeColor = System.Drawing.Color.White;
            this.buttonAddCourse.Location = new System.Drawing.Point(273, 412);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(170, 46);
            this.buttonAddCourse.TabIndex = 70;
            this.buttonAddCourse.Text = "Add Score";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.Color.LightGray;
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(199, 232);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(258, 94);
            this.TextBoxDescription.TabIndex = 69;
            // 
            // TextBoxStudentID
            // 
            this.TextBoxStudentID.BackColor = System.Drawing.Color.LightGray;
            this.TextBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStudentID.Location = new System.Drawing.Point(199, 50);
            this.TextBoxStudentID.Name = "TextBoxStudentID";
            this.TextBoxStudentID.ReadOnly = true;
            this.TextBoxStudentID.Size = new System.Drawing.Size(258, 30);
            this.TextBoxStudentID.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Select Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 64;
            this.label1.Text = "Student ID:";
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.UIimageTeacher;
            this.ClientSize = new System.Drawing.Size(1129, 503);
            this.Controls.Add(this.DataGridViewStudents);
            this.Controls.Add(this.TextBoxScore);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewStudents;
        private System.Windows.Forms.TextBox TextBoxScore;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
        private System.Windows.Forms.Button buttonAddCourse;
        public System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.TextBox TextBoxStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}