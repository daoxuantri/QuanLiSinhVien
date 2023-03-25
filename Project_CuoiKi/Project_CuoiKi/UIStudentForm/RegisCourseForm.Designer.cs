
namespace Project_CuoiKi
{
    partial class RegisCourseForm
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
            this.labelTotalCourse = new System.Windows.Forms.Label();
            this.ButtonCourseRegister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAll = new System.Windows.Forms.Button();
            this.labelIdCourse = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalCourse
            // 
            this.labelTotalCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelTotalCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCourse.Location = new System.Drawing.Point(815, 481);
            this.labelTotalCourse.Name = "labelTotalCourse";
            this.labelTotalCourse.Size = new System.Drawing.Size(248, 45);
            this.labelTotalCourse.TabIndex = 166;
            this.labelTotalCourse.Text = "Tolal Course:";
            this.labelTotalCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonCourseRegister
            // 
            this.ButtonCourseRegister.BackColor = System.Drawing.Color.Tomato;
            this.ButtonCourseRegister.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCourseRegister.ForeColor = System.Drawing.Color.Black;
            this.ButtonCourseRegister.Location = new System.Drawing.Point(282, 385);
            this.ButtonCourseRegister.Name = "ButtonCourseRegister";
            this.ButtonCourseRegister.Size = new System.Drawing.Size(118, 51);
            this.ButtonCourseRegister.TabIndex = 165;
            this.ButtonCourseRegister.Text = "Register";
            this.ButtonCourseRegister.UseVisualStyleBackColor = false;
            this.ButtonCourseRegister.Click += new System.EventHandler(this.ButtonCourseRegister_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(363, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(478, 46);
            this.label6.TabIndex = 163;
            this.label6.Text = "COURSE INFORMATION";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(431, 106);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(782, 372);
            this.dgv.TabIndex = 162;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Bisque;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 156;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 155;
            this.label3.Text = "Period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 154;
            this.label2.Text = "Label:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 153;
            this.label1.Text = "Course ID:";
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.Location = new System.Drawing.Point(1095, 477);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(118, 51);
            this.buttonAll.TabIndex = 170;
            this.buttonAll.Text = "Refresh";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // labelIdCourse
            // 
            this.labelIdCourse.BackColor = System.Drawing.Color.Silver;
            this.labelIdCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCourse.Location = new System.Drawing.Point(152, 103);
            this.labelIdCourse.Name = "labelIdCourse";
            this.labelIdCourse.Size = new System.Drawing.Size(248, 35);
            this.labelIdCourse.TabIndex = 224;
            this.labelIdCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLabel
            // 
            this.labelLabel.BackColor = System.Drawing.Color.Silver;
            this.labelLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabel.Location = new System.Drawing.Point(152, 176);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(248, 35);
            this.labelLabel.TabIndex = 225;
            this.labelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPeriod
            // 
            this.labelPeriod.BackColor = System.Drawing.Color.Silver;
            this.labelPeriod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.Location = new System.Drawing.Point(152, 237);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(248, 35);
            this.labelPeriod.TabIndex = 226;
            this.labelPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Silver;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(152, 310);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(248, 35);
            this.labelDescription.TabIndex = 227;
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Bisque;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(943, 65);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(81, 25);
            this.labelSearch.TabIndex = 229;
            this.labelSearch.Text = "Search";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel.Location = new System.Drawing.Point(1030, 64);
            this.textBoxLabel.Multiline = true;
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(183, 38);
            this.textBoxLabel.TabIndex = 230;
            this.textBoxLabel.TextChanged += new System.EventHandler(this.textBoxLabel_TextChanged);
            // 
            // RegisCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.formallinStudent;
            this.ClientSize = new System.Drawing.Size(1225, 593);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.labelIdCourse);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.labelTotalCourse);
            this.Controls.Add(this.ButtonCourseRegister);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisCourseForm";
            this.Text = "RegisCourseForm";
            this.Load += new System.EventHandler(this.RegisCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotalCourse;
        private System.Windows.Forms.Button ButtonCourseRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Label labelIdCourse;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxLabel;
    }
}