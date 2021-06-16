
namespace StudentDatabaseManager
{
    partial class AddStudentFRM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Student_AddBTN = new System.Windows.Forms.Button();
            this.studentNameLBL = new System.Windows.Forms.Label();
            this.studentMajorLBL = new System.Windows.Forms.Label();
            this.sNameRSP = new System.Windows.Forms.TextBox();
            this.sMajorRSP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Student_AddBTN
            // 
            this.Student_AddBTN.Location = new System.Drawing.Point(105, 219);
            this.Student_AddBTN.Name = "Student_AddBTN";
            this.Student_AddBTN.Size = new System.Drawing.Size(163, 34);
            this.Student_AddBTN.TabIndex = 0;
            this.Student_AddBTN.Text = "Add Student";
            this.Student_AddBTN.UseVisualStyleBackColor = true;
            this.Student_AddBTN.Click += new System.EventHandler(this.Student_AddBTN_Click);
            // 
            // studentNameLBL
            // 
            this.studentNameLBL.AutoSize = true;
            this.studentNameLBL.Location = new System.Drawing.Point(21, 63);
            this.studentNameLBL.Name = "studentNameLBL";
            this.studentNameLBL.Size = new System.Drawing.Size(63, 25);
            this.studentNameLBL.TabIndex = 1;
            this.studentNameLBL.Text = "Name:";
            // 
            // studentMajorLBL
            // 
            this.studentMajorLBL.AutoSize = true;
            this.studentMajorLBL.Location = new System.Drawing.Point(21, 140);
            this.studentMajorLBL.Name = "studentMajorLBL";
            this.studentMajorLBL.Size = new System.Drawing.Size(62, 25);
            this.studentMajorLBL.TabIndex = 2;
            this.studentMajorLBL.Text = "Major:";
            // 
            // sNameRSP
            // 
            this.sNameRSP.Location = new System.Drawing.Point(114, 60);
            this.sNameRSP.Name = "sNameRSP";
            this.sNameRSP.Size = new System.Drawing.Size(208, 31);
            this.sNameRSP.TabIndex = 3;
            // 
            // sMajorRSP
            // 
            this.sMajorRSP.Location = new System.Drawing.Point(114, 140);
            this.sMajorRSP.Name = "sMajorRSP";
            this.sMajorRSP.Size = new System.Drawing.Size(208, 31);
            this.sMajorRSP.TabIndex = 4;
            // 
            // AddStudentFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 284);
            this.Controls.Add(this.sMajorRSP);
            this.Controls.Add(this.sNameRSP);
            this.Controls.Add(this.studentMajorLBL);
            this.Controls.Add(this.studentNameLBL);
            this.Controls.Add(this.Student_AddBTN);
            this.Name = "AddStudentFRM";
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Student_AddBTN;
        private System.Windows.Forms.Label studentNameLBL;
        private System.Windows.Forms.Label studentMajorLBL;
        private System.Windows.Forms.TextBox sNameRSP;
        private System.Windows.Forms.TextBox sMajorRSP;
    }
}

