using BL;
using DB;
using OL;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OBS.Wiev
{
    public partial class Frm_Director : Form
    {
        public int Director_ID;
        
        Style.StyleSheet style = new Style.StyleSheet();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public int VarCheck_Antrenor = 0;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Frm_Director()
        {
            InitializeComponent();
        }
        private void Frm_Director_Load(object sender, EventArgs e)
        {
            Style.StyleSheet style = new Style.StyleSheet();
            style.Style(DataGrid_Class);
            style.Style(DataGrid_Classes);
            style.Style(DataGrid_Lessons);
            style.TXTBoxMaxLenght(TXT_New_Class_Name);
            style.TXTBoxMaxLenght(TXT_New_LessonForStudent);
            RefreshData();
            DataGrid_Lessons.ClearSelection();
            DataGrid_Classes.ClearSelection();
            DataGrid_Class.ClearSelection();
            BTN_Add_Teacher.Enabled = false;
            Btn_DeleteTeacher.Visible = false;
            Btn_DeleteClass.Enabled = false;
            Btn_DeleteStudent.Enabled = false;
            Delete_ClassLesson.Enabled = false;            

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Panel_UpdateClass.Hide();
            Panel_ExstraLessonForStudent.Hide();
        }
        public void StartDirector(int DirectorID)
        {
            Director_ID = DirectorID;
        }
        private void DataGrid_Classes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentManager studentManager = new StudentManager();
            int Selected_Class_ID = (Int32)DataGrid_Classes.CurrentRow.Cells["Sınıf_ID"].Value;
            List<ObjStudents> objStudents = studentManager.GetSelectedClassStudents(Selected_Class_ID);
            DataGrid_Class.DataSource = objStudents;
            Style.StyleSheet dataGridStyle = new Style.StyleSheet();
            dataGridStyle.HideDataGridSomeColumns(DataGrid_Class, "Students");
            LessonManager lessonManager = new LessonManager();
            List<ObjLessons> ListobjLessons = lessonManager.GetClassLessons(Selected_Class_ID);
            DataGrid_Lessons.DataSource = ListobjLessons;
            dataGridStyle.HideDataGridSomeColumns(DataGrid_Lessons, "Lessons");

            RefreshTeacher();
            if (LBL_OpenedClassTeacherName.Text =="Sınıfın Ögretmeni Yok")
            {
                BTN_Add_Teacher.Enabled = true;
                Btn_DeleteTeacher.Visible = false;
            }
            else
            {
                BTN_Add_Teacher.Enabled = false;
                Btn_DeleteTeacher.Visible = true;
            }
            Btn_DeleteClass.Enabled = true;
            Btn_DeleteStudent.Enabled = false;
            Delete_ClassLesson.Enabled = false;
            Panel_UpdateClass.Hide();
        }
        public void RefreshData()
        {
            DirectorManager directorManager = new DirectorManager();
            ObjDirector objDirector = directorManager.GetDirector(Director_ID);
            LBL_DirectorNameSurname.Text = objDirector.Mudur_Ad;
            LBL_DirectorNameSurname.Text += " "+ objDirector.Mudur_Soyad;
            ClassManager classManager = new ClassManager();
            List<ObjClasses> objClasses = classManager.GetAllClass();
            DataGrid_Classes.DataSource = objClasses;
            Style.StyleSheet dataGridStyle = new Style.StyleSheet();
            dataGridStyle.HideDataGridSomeColumns(DataGrid_Classes,"Classes");           
            DataGrid_Class.DataSource = null;
            DataGrid_Lessons.DataSource = null;
            BTN_Add_Teacher.Enabled = false;
            Btn_DeleteTeacher.Visible = false;
            Btn_DeleteClass.Enabled = false;
            Btn_DeleteStudent.Enabled = false;
        }
        public void RefreshTeacher()
        {
            int Selected_Class_ID = (Int32)DataGrid_Classes.CurrentRow.Cells["Sınıf_ID"].Value;
            TeacherManager teacherManager = new TeacherManager();
            ObjTeachers objTeacher = teacherManager.GetTeacherForClassID(Selected_Class_ID);
            if (objTeacher.Ogretmen_ID == 0)
            {
                LBL_OpenedClassTeacherName.Text = "Sınıfın Ögretmeni Yok";               
            }
            else
            {
                LBL_OpenedClassTeacherName.Text = objTeacher.FullName;
            }
        }
        private void BTN_Add_Class_Click(object sender, EventArgs e)
        {
            Frm_Add_Class frm_Add_Class = new Frm_Add_Class();
            frm_Add_Class.ShowDialog();
            RefreshData();
        }
        private void BTN_Add_Teacher_Click(object sender, EventArgs e)
        {
            int Selected_Class_ID = (Int32)DataGrid_Classes.CurrentRow.Cells["Sınıf_ID"].Value;
            Frm_Add_Teacher frm_Add_Teacher = new Frm_Add_Teacher();
            frm_Add_Teacher.StartAddTeacher(Selected_Class_ID);
            frm_Add_Teacher.ShowDialog();
            RefreshData();
        }
        private void BTN_Add_Student_Click(object sender, EventArgs e)
        {
            int Selected_Class_ID = (Int32)DataGrid_Classes.CurrentRow.Cells["Sınıf_ID"].Value;
            Frm_Add_Student frm_Add_Student = new Frm_Add_Student();
            frm_Add_Student.StartAddStudent(Selected_Class_ID);
            frm_Add_Student.ShowDialog();
            RefreshData();
        }
        private void BTN_Add_Lesson_Click(object sender, EventArgs e)
        {
            int Selected_Class_ID = (Int32)DataGrid_Classes.CurrentRow.Cells["Sınıf_ID"].Value;
            Frm_Add_Lesson frm_Add_Lesson = new Frm_Add_Lesson();
            frm_Add_Lesson.Start_Class_Add_Lesson(Selected_Class_ID);
            frm_Add_Lesson.ShowDialog();
            RefreshData();
        }
        private void Frm_Director_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BTN_Back_Click(object sender, EventArgs e)
        {           
            Frm_LogIn frm_LogIn = new Frm_LogIn();
            frm_LogIn.Show();
            this.Hide();
        }
        private void Frm_Director_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Btn_DeleteClass_Click(object sender, EventArgs e)
        {
            ClassManager classManager = new ClassManager();
            int Selected_Class_ID = (Int32)DataGrid_Classes.CurrentRow.Cells["Sınıf_ID"].Value;
            classManager.DeleteClass(Selected_Class_ID);
            RefreshData();
            Delete_ClassLesson.Enabled = false;
        }
        private void DataGrid_Classes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Panel_UpdateClass.Show();
            TXT_New_Class_Name.Text = (string)DataGrid_Classes.CurrentRow.Cells["Sınıf_Ad"].Value;
            Delete_ClassLesson.Enabled = false;
        }
        private void Btn_Update_Class_Click(object sender, EventArgs e)
        {
            int Selected_Class_ID = (Int32)DataGrid_Classes.CurrentRow.Cells["Sınıf_ID"].Value;
            ClassManager classManager = new ClassManager();
            classManager.UpdateClass(Selected_Class_ID,TXT_New_Class_Name.Text);
            TXT_New_Class_Name.Text = "";
            Panel_UpdateClass.Hide();
            RefreshData();
        }
        private void Btn_DeleteTeacher_Click(object sender, EventArgs e)
        {
            TeacherManager teacherManager = new TeacherManager();
            int Selected_Class_ID = (Int32)DataGrid_Classes.CurrentRow.Cells["Sınıf_ID"].Value;
            ObjTeachers objTeacher = teacherManager.GetTeacherForClassID(Selected_Class_ID);
            teacherManager.Delete_Teacher(objTeacher.Ogretmen_ID);
            RefreshData();
            LBL_OpenedClassTeacherName.Text = "";
        }
        private void Btn_DeleteStudent_Click(object sender, EventArgs e)
        {
            StudentManager studentManager = new StudentManager();
            int Selected_Student_ID = (Int32)DataGrid_Class.CurrentRow.Cells["Ogrenci_ID"].Value;
            studentManager.DeleteStudent(Selected_Student_ID);
            RefreshData();
        }
        private void DataGrid_Class_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_DeleteStudent.Enabled = true;
            Delete_ClassLesson.Enabled = false;
            int Selected_Student_ID = (Int32)DataGrid_Class.CurrentRow.Cells["Ogrenci_ID"].Value;
            LessonManager lessonManager = new LessonManager();
            List<ObjLessons> ListobjLessons = lessonManager.GetStudentLessons(Selected_Student_ID);
            DataGrid_Lessons.DataSource = ListobjLessons;
            Panel_ExstraLessonForStudent.Hide();
        }
        private void Delete_ClassLesson_Click(object sender, EventArgs e)
        {
            LessonManager lessonManager = new LessonManager();
            int Selected_Class_ID = (Int32)DataGrid_Classes.CurrentRow.Cells["Sınıf_ID"].Value;
            string Selected_Lesson_Name = (string)DataGrid_Lessons.CurrentRow.Cells["Ders_Ad"].Value;
            lessonManager.DeleteLesson(Selected_Lesson_Name, Selected_Class_ID);
            RefreshData();
            Delete_ClassLesson.Enabled = false;
        }
        private void DataGrid_Lessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Delete_ClassLesson.Enabled = true;
        }
        private void BTN_Add_New_LessonForStudent_Click(object sender, EventArgs e)
        {
            LessonManager classManager = new LessonManager();
            int Selected_Student_ID = (Int32)DataGrid_Class.CurrentRow.Cells["Ogrenci_ID"].Value;
            int Selected_Class_ID = (Int32)DataGrid_Classes.CurrentRow.Cells["Sınıf_ID"].Value;
            classManager.AddLessonStudent(TXT_New_LessonForStudent.Text, Selected_Student_ID, Selected_Class_ID);
            Panel_ExstraLessonForStudent.Hide();
            TXT_New_LessonForStudent.Text = "";
            RefreshData();
        }
        private void DataGrid_Class_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Panel_ExstraLessonForStudent.Show();
        }
        private void TXT_New_Class_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }
        private void TXT_New_LessonForStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }
    }
}