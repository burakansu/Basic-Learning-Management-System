using BL;
using DB;
using OL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OBS.Wiev
{
    public partial class Frm_Student : Form
    {
        public int Student_ID;

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
        public Frm_Student()
        {
            InitializeComponent();
        }
        private void Frm_Student_Load(object sender, EventArgs e)
        {
            Style.StyleSheet style = new Style.StyleSheet();
            style.Style(DataGrid_Lessons_Student);
            style.Style(DataGrid_Student_Lesson_And_Note);

            StudentManager studentManager = new StudentManager();
            ObjStudents students = studentManager.GetStudent(Student_ID);
            LBL_StudentNameSurname.Text = students.FullName;

            ClassManager classManager = new ClassManager();
            ObjClasses objClass = classManager.GetClass(Student_ID);
            LBL_StudentClass.Text = objClass.Sınıf_Ad;
            LBL_Note.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void StartStudent(int Ogrenci_ID)
        {
            Student_ID = Ogrenci_ID;
            LessonManager lessonManager = new LessonManager();
            List<ObjLessons> list = lessonManager.GetLessonsStudent(Student_ID);
            DataGrid_Lessons_Student.DataSource = list;
            Style.StyleSheet style = new Style.StyleSheet();
            style.HideDataGridSomeColumns(DataGrid_Lessons_Student,"Lessons");

            TeacherManager teacherManager = new TeacherManager();
            ObjTeachers objTeacher = teacherManager.GetTeacherForClassID(list[0].Sınıf_ID);

            LBL_StudentsTeacher.Text = objTeacher.FullName;            
        }
        private void DataGrid_Lessons_Student_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StudentManager studentManager = new StudentManager();
            int selected_id_Lesson = (Int32)DataGrid_Lessons_Student.CurrentRow.Cells["Ders_ID"].Value;
            DataTable tbl = studentManager.GetStudentAndNoteCrossTab(Student_ID,selected_id_Lesson);
            DataGrid_Student_Lesson_And_Note.DataSource = null;
            DataGrid_Student_Lesson_And_Note.DataSource = tbl;
            if (tbl.Rows.Count <= 0)
            {
                LBL_Note.Show();
            }
            else { LBL_Note.Hide(); }
        }
        private void Frm_Student_FormClosing(object sender, FormClosingEventArgs e)
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
        private void Frm_Student_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}