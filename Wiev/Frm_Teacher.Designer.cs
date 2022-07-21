namespace OBS.Wiev
{
    partial class Frm_Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Teacher));
            this.DataGrid_Class = new System.Windows.Forms.DataGridView();
            this.LBL_TeacherClass = new System.Windows.Forms.Label();
            this.LBL_TeacherNameSurname = new System.Windows.Forms.Label();
            this.DataGrid_Lessons = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGrid_Notes = new System.Windows.Forms.DataGridView();
            this.BTN_Add_Note = new System.Windows.Forms.Button();
            this.LBL_Note = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Back = new System.Windows.Forms.PictureBox();
            this.BTN_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Lessons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Notes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Class
            // 
            this.DataGrid_Class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Class.Location = new System.Drawing.Point(9, 188);
            this.DataGrid_Class.Name = "DataGrid_Class";
            this.DataGrid_Class.Size = new System.Drawing.Size(540, 498);
            this.DataGrid_Class.TabIndex = 0;
            this.DataGrid_Class.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_Class_CellMouseClick);
            // 
            // LBL_TeacherClass
            // 
            this.LBL_TeacherClass.AutoSize = true;
            this.LBL_TeacherClass.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TeacherClass.Location = new System.Drawing.Point(260, 156);
            this.LBL_TeacherClass.Name = "LBL_TeacherClass";
            this.LBL_TeacherClass.Size = new System.Drawing.Size(169, 23);
            this.LBL_TeacherClass.TabIndex = 6;
            this.LBL_TeacherClass.Text = "Ögremenin Sınıfı";
            // 
            // LBL_TeacherNameSurname
            // 
            this.LBL_TeacherNameSurname.AutoSize = true;
            this.LBL_TeacherNameSurname.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TeacherNameSurname.Location = new System.Drawing.Point(190, 33);
            this.LBL_TeacherNameSurname.Name = "LBL_TeacherNameSurname";
            this.LBL_TeacherNameSurname.Size = new System.Drawing.Size(323, 33);
            this.LBL_TeacherNameSurname.TabIndex = 4;
            this.LBL_TeacherNameSurname.Text = "Öğretmen Adı Soyadı";
            // 
            // DataGrid_Lessons
            // 
            this.DataGrid_Lessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Lessons.Location = new System.Drawing.Point(555, 188);
            this.DataGrid_Lessons.Name = "DataGrid_Lessons";
            this.DataGrid_Lessons.Size = new System.Drawing.Size(491, 498);
            this.DataGrid_Lessons.TabIndex = 7;
            this.DataGrid_Lessons.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_Lessons_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sınıf :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 170);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // DataGrid_Notes
            // 
            this.DataGrid_Notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Notes.Location = new System.Drawing.Point(1052, 188);
            this.DataGrid_Notes.Name = "DataGrid_Notes";
            this.DataGrid_Notes.Size = new System.Drawing.Size(342, 498);
            this.DataGrid_Notes.TabIndex = 12;
            this.DataGrid_Notes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Notes_CellDoubleClick);
            // 
            // BTN_Add_Note
            // 
            this.BTN_Add_Note.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add_Note.Location = new System.Drawing.Point(1243, 157);
            this.BTN_Add_Note.Name = "BTN_Add_Note";
            this.BTN_Add_Note.Size = new System.Drawing.Size(151, 25);
            this.BTN_Add_Note.TabIndex = 14;
            this.BTN_Add_Note.Text = "Not Ekle";
            this.BTN_Add_Note.UseVisualStyleBackColor = true;
            this.BTN_Add_Note.Click += new System.EventHandler(this.BTN_Add_Note_Click);
            // 
            // LBL_Note
            // 
            this.LBL_Note.AutoSize = true;
            this.LBL_Note.BackColor = System.Drawing.Color.White;
            this.LBL_Note.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Note.ForeColor = System.Drawing.Color.IndianRed;
            this.LBL_Note.Location = new System.Drawing.Point(1133, 398);
            this.LBL_Note.Name = "LBL_Note";
            this.LBL_Note.Size = new System.Drawing.Size(184, 19);
            this.LBL_Note.TabIndex = 15;
            this.LBL_Note.Text = "Not Girisi Yapılmamıs !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(191, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ögretmen";
            // 
            // BTN_Back
            // 
            this.BTN_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Back.BackgroundImage")));
            this.BTN_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Back.Location = new System.Drawing.Point(1322, 3);
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
            this.BTN_Exit.Location = new System.Drawing.Point(1364, 3);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(30, 30);
            this.BTN_Exit.TabIndex = 22;
            this.BTN_Exit.TabStop = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // Frm_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 690);
            this.Controls.Add(this.BTN_Back);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_Note);
            this.Controls.Add(this.BTN_Add_Note);
            this.Controls.Add(this.DataGrid_Notes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGrid_Lessons);
            this.Controls.Add(this.LBL_TeacherClass);
            this.Controls.Add(this.LBL_TeacherNameSurname);
            this.Controls.Add(this.DataGrid_Class);
            this.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Frm_Teacher";
            this.Text = "Öğretmen Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Teacher_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Teacher_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Teacher_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Lessons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Notes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Class;
        private System.Windows.Forms.Label LBL_TeacherClass;
        private System.Windows.Forms.Label LBL_TeacherNameSurname;
        private System.Windows.Forms.DataGridView DataGrid_Lessons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DataGrid_Notes;
        private System.Windows.Forms.Button BTN_Add_Note;
        private System.Windows.Forms.Label LBL_Note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BTN_Back;
        private System.Windows.Forms.PictureBox BTN_Exit;
    }
}