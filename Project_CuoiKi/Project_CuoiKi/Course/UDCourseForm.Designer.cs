
namespace Project_CuoiKi
{
    partial class UDCourseForm
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
            this.labelEnterTheCourse = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(472, 88);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(132, 34);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelEnterTheCourse
            // 
            this.labelEnterTheCourse.AutoSize = true;
            this.labelEnterTheCourse.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterTheCourse.Location = new System.Drawing.Point(50, 92);
            this.labelEnterTheCourse.Name = "labelEnterTheCourse";
            this.labelEnterTheCourse.Size = new System.Drawing.Size(195, 26);
            this.labelEnterTheCourse.TabIndex = 6;
            this.labelEnterTheCourse.Text = "Enter The Course";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(265, 92);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(136, 26);
            this.textBoxID.TabIndex = 5;
            // 
            // UDCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_CuoiKi.Properties.Resources.formallinStudent;
            this.ClientSize = new System.Drawing.Size(680, 208);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelEnterTheCourse);
            this.Controls.Add(this.textBoxID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UDCourseForm";
            this.Text = "UDCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelEnterTheCourse;
        private System.Windows.Forms.TextBox textBoxID;
    }
}