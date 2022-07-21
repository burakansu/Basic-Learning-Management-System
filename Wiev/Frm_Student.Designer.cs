namespace OBS.Wiev
{
    partial class Frm_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Student));
            this.DataGrid_Student_Lesson_And_Note = new System.Windows.Forms.DataGridView();
            this.LBL_StudentNameSurname = new System.Windows.Forms.Label();
            this.LBL_StudentClass = new System.Windows.Forms.Label();
            this.LBL_StudentsTeacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGrid_Lessons_Student = new System.Windows.Forms.DataGridView();
            this.LBL_Note = new System.Windows.Forms.Label();
            this.BTN_Back = new System.Windows.Forms.PictureBox();
            this.BTN_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Student_Lesson_And_Note)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Lessons_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Student_Lesson_And_Note
            // 
            this.DataGrid_Student_Lesson_And_Note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Student_Lesson_And_Note.Location = new System.Drawing.Point(321, 200);
            this.DataGrid_Student_Lesson_And_Note.Name = "DataGrid_Student_Lesson_And_Note";
            this.DataGrid_Student_Lesson_And_Note.Size = new System.Drawing.Size(515, 280);
            this.DataGrid_Student_Lesson_And_Note.TabIndex = 0;
            // 
            // LBL_StudentNameSurname
            // 
            this.LBL_StudentNameSurname.AutoSize = true;
            this.LBL_StudentNameSurname.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_StudentNameSurname.Location = new System.Drawing.Point(193, 35);
            this.LBL_StudentNameSurname.Name = "LBL_StudentNameSurname";
            this.LBL_StudentNameSurname.Size = new System.Drawing.Size(290, 33);
            this.LBL_StudentNameSurname.TabIndex = 1;
            this.LBL_StudentNameSurname.Text = "Öğrenci Adı Soyadı";
            // 
            // LBL_StudentClass
            // 
            this.LBL_StudentClass.AutoSize = true;
            this.LBL_StudentClass.Location = new System.Drawing.Point(277, 130);
            this.LBL_StudentClass.Name = "LBL_StudentClass";
            this.LBL_StudentClass.Size = new System.Drawing.Size(65, 25);
            this.LBL_StudentClass.TabIndex = 2;
            this.LBL_StudentClass.Text = "Sınıfı";
            // 
            // LBL_StudentsTeacher
            // 
            this.LBL_StudentsTeacher.AutoSize = true;
            this.LBL_StudentsTeacher.Location = new System.Drawing.Point(338, 86);
            this.LBL_StudentsTeacher.Name = "LBL_StudentsTeacher";
            this.LBL_StudentsTeacher.Size = new System.Drawing.Size(126, 25);
            this.LBL_StudentsTeacher.TabIndex = 3;
            this.LBL_StudentsTeacher.Text = "Öğretmeni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sınıfı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğretmeni :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 182);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // DataGrid_Lessons_Student
            // 
            this.DataGrid_Lessons_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Lessons_Student.Location = new System.Drawing.Point(6, 200);
            this.DataGrid_Lessons_Student.Name = "DataGrid_Lessons_Student";
            this.DataGrid_Lessons_Student.Size = new System.Drawing.Size(309, 280);
            this.DataGrid_Lessons_Student.TabIndex = 13;
            this.DataGrid_Lessons_Student.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_Lessons_Student_CellMouseClick);
            // 
            // LBL_Note
            // 
            this.LBL_Note.AutoSize = true;
            this.LBL_Note.BackColor = System.Drawing.Color.White;
            this.LBL_Note.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Note.ForeColor = System.Drawing.Color.IndianRed;
            this.LBL_Note.Location = new System.Drawing.Point(491, 327);
            this.LBL_Note.Name = "LBL_Note";
            this.LBL_Note.Size = new System.Drawing.Size(184, 19);
            this.LBL_Note.TabIndex = 16;
            this.LBL_Note.Text = "Not Girisi Yapılmamıs !";
            // 
            // BTN_Back
            // 
            this.BTN_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Back.BackgroundImage")));
            this.BTN_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Back.Location = new System.Drawing.Point(764, 5);
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.Size = new System.Drawing.Size(30, 30);
            this.BTN_Back.TabIndex = 23;
            this.BTN_Back.TabStop = false;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Exit.BackgroundImage")));
            this.BTN_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Exit.Location = new System.Drawing.Point(806, 5);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(30, 30);
            this.BTN_Exit.TabIndex = 22;
            this.BTN_Exit.TabStop = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // Frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 485);
            this.Controls.Add(this.BTN_Back);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.LBL_Note);
            this.Controls.Add(this.DataGrid_Lessons_Student);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_StudentsTeacher);
            this.Controls.Add(this.LBL_StudentClass);
            this.Controls.Add(this.LBL_StudentNameSurname);
            this.Controls.Add(this.DataGrid_Student_Lesson_And_Note);
            this.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Frm_Student";
            this.Text = "Öğrenci Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Student_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Student_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Student_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Student_Lesson_And_Note)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Lessons_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Student_Lesson_And_Note;
        private System.Windows.Forms.Label LBL_StudentNameSurname;
        private System.Windows.Forms.Label LBL_StudentClass;
        private System.Windows.Forms.Label LBL_StudentsTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DataGrid_Lessons_Student;
        private System.Windows.Forms.Label LBL_Note;
        private System.Windows.Forms.PictureBox BTN_Back;
        private System.Windows.Forms.PictureBox BTN_Exit;
    }
}