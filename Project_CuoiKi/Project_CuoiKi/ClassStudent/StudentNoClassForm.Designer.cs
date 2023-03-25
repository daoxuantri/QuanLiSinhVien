
namespace Project_CuoiKi
{
    partial class StudentNoClassForm
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTotalStudent = new System.Windows.Forms.Label();
            this.TextIDStudent = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonManageStudent = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxClassName = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Coral;
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(688, 105);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(104, 41);
            this.buttonSearch.TabIndex = 130;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTotalStudent
            // 
            this.labelTotalStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelTotalStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalStudent.Location = new System.Drawing.Point(764, 495);
            this.labelTotalStudent.Name = "labelTotalStudent";
            this.labelTotalStudent.Size = new System.Drawing.Size(248, 45);
            this.labelTotalStudent.TabIndex = 129;
            this.labelTotalStudent.Text = "Total Student:";
            this.labelTotalStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextIDStudent
            // 
            this.TextIDStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIDStudent.Location = new System.Drawing.Point(207, 76);
            this.TextIDStudent.Name = "TextIDStudent";
            this.TextIDStudent.Size = new System.Drawing.Size(239, 30);
            this.TextIDStudent.TabIndex = 127;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Coral;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(688, 566);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 41);
            this.buttonCancel.TabIndex = 126;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonManageStudent
            // 
            this.buttonManageStudent.BackColor = System.Drawing.Color.Coral;
            this.buttonManageStudent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageStudent.Location = new System.Drawing.Point(378, 566);
            this.buttonManageStudent.Name = "buttonManageStudent";
            this.buttonManageStudent.Size = new System.Drawing.Size(223, 41);
            this.buttonManageStudent.TabIndex = 125;
            this.buttonManageStudent.Text = "Manage Student";
            this.buttonManageStudent.UseVisualStyleBackColor = false;
            this.buttonManageStudent.Click += new System.EventHandler(this.buttonManageStudent_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Coral;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(159, 566);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(142, 41);
            this.buttonAdd.TabIndex = 124;
            this.buttonAdd.Text = "Add Class";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(71, 166);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(941, 326);
            this.dgv.TabIndex = 123;
            
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(538, 32);
            this.label3.TabIndex = 122;
            this.label3.Text = "LIST OF STUDENT WITHOUT CLASSSES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 121;
            this.label2.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 120;
            this.label1.Text = "ID Student:";
            // 
            // ComboBoxClassName
            // 
            this.ComboBoxClassName.FormattingEnabled = true;
            this.ComboBoxClassName.Location = new System.Drawing.Point(207, 124);
            this.ComboBoxClassName.Name = "ComboBoxClassName";
            this.ComboBoxClassName.Size = new System.Drawing.Size(239, 24);
            this.ComboBoxClassName.TabIndex = 132;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(888, 134);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(124, 38);
            this.buttonRefresh.TabIndex = 133;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // StudentNoClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.formallinStudent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 661);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.ComboBoxClassName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelTotalStudent);
            this.Controls.Add(this.TextIDStudent);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonManageStudent);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "StudentNoClassForm";
            this.Text = "StudentNoClassForm";
            this.Load += new System.EventHandler(this.StudentNoClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTotalStudent;
        private System.Windows.Forms.TextBox TextIDStudent;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonManageStudent;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxClassName;
        private System.Windows.Forms.Button buttonRefresh;
    }
}