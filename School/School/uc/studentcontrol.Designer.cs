namespace School.uc
{
    partial class studentcontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_addstudent = new System.Windows.Forms.Button();
            this.btn_editstudent = new System.Windows.Forms.Button();
            this.btn_studentmark = new System.Windows.Forms.Button();
            this.btn_studentattandance = new System.Windows.Forms.Button();
            this.btn_deleteStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addstudent
            // 
            this.btn_addstudent.Location = new System.Drawing.Point(0, 0);
            this.btn_addstudent.Name = "btn_addstudent";
            this.btn_addstudent.Size = new System.Drawing.Size(166, 34);
            this.btn_addstudent.TabIndex = 0;
            this.btn_addstudent.Text = "Add Student";
            this.btn_addstudent.UseVisualStyleBackColor = true;
            // 
            // btn_editstudent
            // 
            this.btn_editstudent.Location = new System.Drawing.Point(0, 40);
            this.btn_editstudent.Name = "btn_editstudent";
            this.btn_editstudent.Size = new System.Drawing.Size(166, 34);
            this.btn_editstudent.TabIndex = 1;
            this.btn_editstudent.Text = "Edit Student ";
            this.btn_editstudent.UseVisualStyleBackColor = true;
            // 
            // btn_studentmark
            // 
            this.btn_studentmark.Location = new System.Drawing.Point(0, 87);
            this.btn_studentmark.Name = "btn_studentmark";
            this.btn_studentmark.Size = new System.Drawing.Size(166, 34);
            this.btn_studentmark.TabIndex = 2;
            this.btn_studentmark.Text = "Student Marks";
            this.btn_studentmark.UseVisualStyleBackColor = true;
            // 
            // btn_studentattandance
            // 
            this.btn_studentattandance.Location = new System.Drawing.Point(0, 130);
            this.btn_studentattandance.Name = "btn_studentattandance";
            this.btn_studentattandance.Size = new System.Drawing.Size(166, 34);
            this.btn_studentattandance.TabIndex = 3;
            this.btn_studentattandance.Text = "Attandences";
            this.btn_studentattandance.UseVisualStyleBackColor = true;
            // 
            // btn_deleteStudent
            // 
            this.btn_deleteStudent.Location = new System.Drawing.Point(0, 174);
            this.btn_deleteStudent.Name = "btn_deleteStudent";
            this.btn_deleteStudent.Size = new System.Drawing.Size(166, 34);
            this.btn_deleteStudent.TabIndex = 4;
            this.btn_deleteStudent.Text = "Delete Student";
            this.btn_deleteStudent.UseVisualStyleBackColor = true;
            // 
            // studentcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_deleteStudent);
            this.Controls.Add(this.btn_studentattandance);
            this.Controls.Add(this.btn_studentmark);
            this.Controls.Add(this.btn_editstudent);
            this.Controls.Add(this.btn_addstudent);
            this.Name = "studentcontrol";
            this.Size = new System.Drawing.Size(166, 222);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addstudent;
        private System.Windows.Forms.Button btn_editstudent;
        private System.Windows.Forms.Button btn_studentmark;
        private System.Windows.Forms.Button btn_studentattandance;
        private System.Windows.Forms.Button btn_deleteStudent;
    }
}
