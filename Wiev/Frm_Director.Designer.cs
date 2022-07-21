namespace OBS.Wiev
{
    partial class Frm_Director
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Director));
            this.DataGrid_Classes = new System.Windows.Forms.DataGridView();
            this.DataGrid_Class = new System.Windows.Forms.DataGridView();
            this.LBL_DirectorNameSurname = new System.Windows.Forms.Label();
            this.LBL_OpenedClassTeacherName = new System.Windows.Forms.Label();
            this.BTN_Add_Student = new System.Windows.Forms.Button();
            this.BTN_Add_Class = new System.Windows.Forms.Button();
            this.BTN_Add_Teacher = new System.Windows.Forms.Button();
            this.BTN_Add_Lesson = new System.Windows.Forms.Button();
            this.DataGrid_Lessons = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_DeleteClass = new System.Windows.Forms.Button();
            this.Delete_ClassLesson = new System.Windows.Forms.Button();
            this.Btn_DeleteStudent = new System.Windows.Forms.Button();
            this.Btn_DeleteTeacher = new System.Windows.Forms.PictureBox();
            this.BTN_Back = new System.Windows.Forms.PictureBox();
            this.BTN_Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXT_New_Class_Name = new System.Windows.Forms.TextBox();
            this.Panel_UpdateClass = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Update_Class = new System.Windows.Forms.Button();
            this.Panel_ExstraLessonForStudent = new System.Windows.Forms.Panel();
            this.BTN_Add_New_LessonForStudent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_New_LessonForStudent = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Classes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Lessons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_DeleteTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_UpdateClass.SuspendLayout();
            this.Panel_ExstraLessonForStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid_Classes
            // 
            this.DataGrid_Classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Classes.Location = new System.Drawing.Point(7, 246);
            this.DataGrid_Classes.Name = "DataGrid_Classes";
            this.DataGrid_Classes.Size = new System.Drawing.Size(265, 395);
            this.DataGrid_Classes.TabIndex = 0;
            this.DataGrid_Classes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Classes_CellClick);
            this.DataGrid_Classes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Classes_CellDoubleClick);
            // 
            // DataGrid_Class
            // 
            this.DataGrid_Class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Class.Location = new System.Drawing.Point(278, 246);
            this.DataGrid_Class.Name = "DataGrid_Class";
            this.DataGrid_Class.Size = new System.Drawing.Size(669, 395);
            this.DataGrid_Class.TabIndex = 1;
            this.DataGrid_Class.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Class_CellClick);
            this.DataGrid_Class.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Class_CellDoubleClick);
            // 
            // LBL_DirectorNameSurname
            // 
            this.LBL_DirectorNameSurname.AutoSize = true;
            this.LBL_DirectorNameSurname.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DirectorNameSurname.Location = new System.Drawing.Point(192, 49);
            this.LBL_DirectorNameSurname.Name = "LBL_DirectorNameSurname";
            this.LBL_DirectorNameSurname.Size = new System.Drawing.Size(292, 35);
            this.LBL_DirectorNameSurname.TabIndex = 5;
            this.LBL_DirectorNameSurname.Text = "Müdür Adı Soyadı";
            // 
            // LBL_OpenedClassTeacherName
            // 
            this.LBL_OpenedClassTeacherName.AutoSize = true;
            this.LBL_OpenedClassTeacherName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_OpenedClassTeacherName.Location = new System.Drawing.Point(299, 224);
            this.LBL_OpenedClassTeacherName.Name = "LBL_OpenedClassTeacherName";
            this.LBL_OpenedClassTeacherName.Size = new System.Drawing.Size(122, 19);
            this.LBL_OpenedClassTeacherName.TabIndex = 7;
            this.LBL_OpenedClassTeacherName.Text = "Ögretmen Adı";
            // 
            // BTN_Add_Student
            // 
            this.BTN_Add_Student.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Add_Student.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTN_Add_Student.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add_Student.ForeColor = System.Drawing.Color.Black;
            this.BTN_Add_Student.Location = new System.Drawing.Point(817, 217);
            this.BTN_Add_Student.Name = "BTN_Add_Student";
            this.BTN_Add_Student.Size = new System.Drawing.Size(130, 26);
            this.BTN_Add_Student.TabIndex = 13;
            this.BTN_Add_Student.Text = "Yeni Ögrenci";
            this.BTN_Add_Student.UseVisualStyleBackColor = false;
            this.BTN_Add_Student.Click += new System.EventHandler(this.BTN_Add_Student_Click);
            // 
            // BTN_Add_Class
            // 
            this.BTN_Add_Class.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Add_Class.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTN_Add_Class.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add_Class.ForeColor = System.Drawing.Color.Black;
            this.BTN_Add_Class.Location = new System.Drawing.Point(7, 217);
            this.BTN_Add_Class.Name = "BTN_Add_Class";
            this.BTN_Add_Class.Size = new System.Drawing.Size(158, 26);
            this.BTN_Add_Class.TabIndex = 14;
            this.BTN_Add_Class.Text = "Yeni Sınıf";
            this.BTN_Add_Class.UseVisualStyleBackColor = false;
            this.BTN_Add_Class.Click += new System.EventHandler(this.BTN_Add_Class_Click);
            // 
            // BTN_Add_Teacher
            // 
            this.BTN_Add_Teacher.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Add_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTN_Add_Teacher.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add_Teacher.ForeColor = System.Drawing.Color.Black;
            this.BTN_Add_Teacher.Location = new System.Drawing.Point(545, 217);
            this.BTN_Add_Teacher.Name = "BTN_Add_Teacher";
            this.BTN_Add_Teacher.Size = new System.Drawing.Size(130, 26);
            this.BTN_Add_Teacher.TabIndex = 15;
            this.BTN_Add_Teacher.Text = "Yeni Ögretmen";
            this.BTN_Add_Teacher.UseVisualStyleBackColor = false;
            this.BTN_Add_Teacher.Click += new System.EventHandler(this.BTN_Add_Teacher_Click);
            // 
            // BTN_Add_Lesson
            // 
            this.BTN_Add_Lesson.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Add_Lesson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTN_Add_Lesson.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add_Lesson.ForeColor = System.Drawing.Color.Black;
            this.BTN_Add_Lesson.Location = new System.Drawing.Point(1108, 217);
            this.BTN_Add_Lesson.Name = "BTN_Add_Lesson";
            this.BTN_Add_Lesson.Size = new System.Drawing.Size(85, 26);
            this.BTN_Add_Lesson.TabIndex = 16;
            this.BTN_Add_Lesson.Text = "Yeni Ders";
            this.BTN_Add_Lesson.UseVisualStyleBackColor = false;
            this.BTN_Add_Lesson.Click += new System.EventHandler(this.BTN_Add_Lesson_Click);
            // 
            // DataGrid_Lessons
            // 
            this.DataGrid_Lessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Lessons.Location = new System.Drawing.Point(953, 246);
            this.DataGrid_Lessons.Name = "DataGrid_Lessons";
            this.DataGrid_Lessons.Size = new System.Drawing.Size(240, 395);
            this.DataGrid_Lessons.TabIndex = 17;
            this.DataGrid_Lessons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Lessons_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(193, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Okul Müdürü";
            // 
            // Btn_DeleteClass
            // 
            this.Btn_DeleteClass.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_DeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_DeleteClass.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteClass.ForeColor = System.Drawing.Color.Black;
            this.Btn_DeleteClass.Location = new System.Drawing.Point(171, 217);
            this.Btn_DeleteClass.Name = "Btn_DeleteClass";
            this.Btn_DeleteClass.Size = new System.Drawing.Size(101, 26);
            this.Btn_DeleteClass.TabIndex = 22;
            this.Btn_DeleteClass.Text = "Sınıfı Sil";
            this.Btn_DeleteClass.UseVisualStyleBackColor = false;
            this.Btn_DeleteClass.Click += new System.EventHandler(this.Btn_DeleteClass_Click);
            // 
            // Delete_ClassLesson
            // 
            this.Delete_ClassLesson.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Delete_ClassLesson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Delete_ClassLesson.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_ClassLesson.ForeColor = System.Drawing.Color.Black;
            this.Delete_ClassLesson.Location = new System.Drawing.Point(953, 217);
            this.Delete_ClassLesson.Name = "Delete_ClassLesson";
            this.Delete_ClassLesson.Size = new System.Drawing.Size(85, 26);
            this.Delete_ClassLesson.TabIndex = 23;
            this.Delete_ClassLesson.Text = "Dersi Sil";
            this.Delete_ClassLesson.UseVisualStyleBackColor = false;
            this.Delete_ClassLesson.Click += new System.EventHandler(this.Delete_ClassLesson_Click);
            // 
            // Btn_DeleteStudent
            // 
            this.Btn_DeleteStudent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_DeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_DeleteStudent.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteStudent.ForeColor = System.Drawing.Color.Black;
            this.Btn_DeleteStudent.Location = new System.Drawing.Point(681, 217);
            this.Btn_DeleteStudent.Name = "Btn_DeleteStudent";
            this.Btn_DeleteStudent.Size = new System.Drawing.Size(130, 26);
            this.Btn_DeleteStudent.TabIndex = 24;
            this.Btn_DeleteStudent.Text = "Öğrenciyi Sil";
            this.Btn_DeleteStudent.UseVisualStyleBackColor = false;
            this.Btn_DeleteStudent.Click += new System.EventHandler(this.Btn_DeleteStudent_Click);
            // 
            // Btn_DeleteTeacher
            // 
            this.Btn_DeleteTeacher.BackgroundImage = global::OBS.Properties.Resources.error;
            this.Btn_DeleteTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_DeleteTeacher.Location = new System.Drawing.Point(283, 228);
            this.Btn_DeleteTeacher.Name = "Btn_DeleteTeacher";
            this.Btn_DeleteTeacher.Size = new System.Drawing.Size(15, 15);
            this.Btn_DeleteTeacher.TabIndex = 26;
            this.Btn_DeleteTeacher.TabStop = false;
            this.Btn_DeleteTeacher.Click += new System.EventHandler(this.Btn_DeleteTeacher_Click);
            // 
            // BTN_Back
            // 
            this.BTN_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Back.BackgroundImage")));
            this.BTN_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Back.Location = new System.Drawing.Point(1124, 5);
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.Size = new System.Drawing.Size(30, 30);
            this.BTN_Back.TabIndex = 21;
            this.BTN_Back.TabStop = false;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Exit.BackgroundImage")));
            this.BTN_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Exit.Location = new System.Drawing.Point(1166, 5);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(30, 30);
            this.BTN_Exit.TabIndex = 20;
            this.BTN_Exit.TabStop = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 175);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // TXT_New_Class_Name
            // 
            this.TXT_New_Class_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_New_Class_Name.Location = new System.Drawing.Point(136, 39);
            this.TXT_New_Class_Name.Name = "TXT_New_Class_Name";
            this.TXT_New_Class_Name.Size = new System.Drawing.Size(263, 26);
            this.TXT_New_Class_Name.TabIndex = 27;
            this.TXT_New_Class_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_New_Class_Name_KeyPress);
            // 
            // Panel_UpdateClass
            // 
            this.Panel_UpdateClass.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_UpdateClass.Controls.Add(this.Btn_Update_Class);
            this.Panel_UpdateClass.Controls.Add(this.label1);
            this.Panel_UpdateClass.Controls.Add(this.TXT_New_Class_Name);
            this.Panel_UpdateClass.Location = new System.Drawing.Point(545, 114);
            this.Panel_UpdateClass.Name = "Panel_UpdateClass";
            this.Panel_UpdateClass.Size = new System.Drawing.Size(402, 100);
            this.Panel_UpdateClass.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sınıf Adı :";
            // 
            // Btn_Update_Class
            // 
            this.Btn_Update_Class.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Update_Class.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Update_Class.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update_Class.ForeColor = System.Drawing.Color.Black;
            this.Btn_Update_Class.Location = new System.Drawing.Point(3, 71);
            this.Btn_Update_Class.Name = "Btn_Update_Class";
            this.Btn_Update_Class.Size = new System.Drawing.Size(396, 26);
            this.Btn_Update_Class.TabIndex = 29;
            this.Btn_Update_Class.Text = "Güncelle";
            this.Btn_Update_Class.UseVisualStyleBackColor = false;
            this.Btn_Update_Class.Click += new System.EventHandler(this.Btn_Update_Class_Click);
            // 
            // Panel_ExstraLessonForStudent
            // 
            this.Panel_ExstraLessonForStudent.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_ExstraLessonForStudent.Controls.Add(this.richTextBox1);
            this.Panel_ExstraLessonForStudent.Controls.Add(this.BTN_Add_New_LessonForStudent);
            this.Panel_ExstraLessonForStudent.Controls.Add(this.label3);
            this.Panel_ExstraLessonForStudent.Controls.Add(this.TXT_New_LessonForStudent);
            this.Panel_ExstraLessonForStudent.Location = new System.Drawing.Point(953, 49);
            this.Panel_ExstraLessonForStudent.Name = "Panel_ExstraLessonForStudent";
            this.Panel_ExstraLessonForStudent.Size = new System.Drawing.Size(240, 165);
            this.Panel_ExstraLessonForStudent.TabIndex = 29;
            // 
            // BTN_Add_New_LessonForStudent
            // 
            this.BTN_Add_New_LessonForStudent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Add_New_LessonForStudent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTN_Add_New_LessonForStudent.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add_New_LessonForStudent.ForeColor = System.Drawing.Color.Black;
            this.BTN_Add_New_LessonForStudent.Location = new System.Drawing.Point(0, 136);
            this.BTN_Add_New_LessonForStudent.Name = "BTN_Add_New_LessonForStudent";
            this.BTN_Add_New_LessonForStudent.Size = new System.Drawing.Size(240, 26);
            this.BTN_Add_New_LessonForStudent.TabIndex = 29;
            this.BTN_Add_New_LessonForStudent.Text = "Alan Dışı Ders Ekle";
            this.BTN_Add_New_LessonForStudent.UseVisualStyleBackColor = false;
            this.BTN_Add_New_LessonForStudent.Click += new System.EventHandler(this.BTN_Add_New_LessonForStudent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ders Adı";
            // 
            // TXT_New_LessonForStudent
            // 
            this.TXT_New_LessonForStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_New_LessonForStudent.Location = new System.Drawing.Point(3, 36);
            this.TXT_New_LessonForStudent.Name = "TXT_New_LessonForStudent";
            this.TXT_New_LessonForStudent.Size = new System.Drawing.Size(231, 26);
            this.TXT_New_LessonForStudent.TabIndex = 27;
            this.TXT_New_LessonForStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_New_LessonForStudent_KeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Montserrat", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(21, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(197, 57);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "Ögrenciye Eklenen Ders Sınıf Ögretmeni Tarafından Verilecektir";
            // 
            // Frm_Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 646);
            this.Controls.Add(this.Panel_ExstraLessonForStudent);
            this.Controls.Add(this.Panel_UpdateClass);
            this.Controls.Add(this.Btn_DeleteTeacher);
            this.Controls.Add(this.Btn_DeleteStudent);
            this.Controls.Add(this.Delete_ClassLesson);
            this.Controls.Add(this.Btn_DeleteClass);
            this.Controls.Add(this.BTN_Back);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGrid_Lessons);
            this.Controls.Add(this.BTN_Add_Lesson);
            this.Controls.Add(this.BTN_Add_Teacher);
            this.Controls.Add(this.BTN_Add_Class);
            this.Controls.Add(this.BTN_Add_Student);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBL_OpenedClassTeacherName);
            this.Controls.Add(this.LBL_DirectorNameSurname);
            this.Controls.Add(this.DataGrid_Class);
            this.Controls.Add(this.DataGrid_Classes);
            this.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Frm_Director";
            this.Text = "Yönetici Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Director_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Director_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Director_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Classes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Lessons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_DeleteTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_UpdateClass.ResumeLayout(false);
            this.Panel_UpdateClass.PerformLayout();
            this.Panel_ExstraLessonForStudent.ResumeLayout(false);
            this.Panel_ExstraLessonForStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Classes;
        private System.Windows.Forms.DataGridView DataGrid_Class;
        private System.Windows.Forms.Label LBL_DirectorNameSurname;
        private System.Windows.Forms.Label LBL_OpenedClassTeacherName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Add_Student;
        private System.Windows.Forms.Button BTN_Add_Class;
        private System.Windows.Forms.Button BTN_Add_Teacher;
        private System.Windows.Forms.Button BTN_Add_Lesson;
        private System.Windows.Forms.DataGridView DataGrid_Lessons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BTN_Exit;
        private System.Windows.Forms.PictureBox BTN_Back;
        private System.Windows.Forms.Button Btn_DeleteClass;
        private System.Windows.Forms.Button Delete_ClassLesson;
        private System.Windows.Forms.Button Btn_DeleteStudent;
        private System.Windows.Forms.PictureBox Btn_DeleteTeacher;
        private System.Windows.Forms.TextBox TXT_New_Class_Name;
        private System.Windows.Forms.Panel Panel_UpdateClass;
        private System.Windows.Forms.Button Btn_Update_Class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_ExstraLessonForStudent;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BTN_Add_New_LessonForStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_New_LessonForStudent;
    }
}