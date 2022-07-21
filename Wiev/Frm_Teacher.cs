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
    public partial class Frm_Teacher : Form
    {
        private int selected_id_Student;
        private int teacher_ID;
        private int selected_Lesson_ID;

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
        public Frm_Teacher()
        {
            InitializeComponent();
        }
        private void Frm_Teacher_Load(object sender, EventArgs e)
        {
            Style.StyleSheet style = new Style.StyleSheet();
            style.Style(DataGrid_Class);
            style.Style(DataGrid_Lessons);
            style.Style(DataGrid_Notes);
            LBL_Note.Hide();
            BTN_Add_Note.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void StartTeacher(int Teacher_ID)
        {
            this.teacher_ID = Teacher_ID;
            TeacherManager teacherManager = new TeacherManager();
            ObjTeachers Teacher = teacherManager.GetTeacher(Teacher_ID);
            int class_id = Teacher.Sınıf_ID;
            LBL_TeacherNameSurname.Text = Teacher.FullName; 
            LBL_TeacherClass.Text = Teacher.Classes.Sınıf_Ad;
            LBL_TeacherClass.Text = Teacher.Classes.Sınıf_Ad;
            LBL_TeacherClass.Text = Teacher.Classes.Sınıf_Ad;
            LBL_TeacherClass.Text = Teacher.Classes.Sınıf_Ad; 

           StudentManager studentManager = new StudentManager();
            List<ObjStudents> objStudents =  studentManager.GetStudentsForClassID(class_id);
            DataGrid_Class.DataSource = objStudents;
            Style.StyleSheet style = new Style.StyleSheet();
            style.HideDataGridSomeColumns(DataGrid_Class,"Students");
        }
        public void RefreshData()
        {
            LessonManager lessonManager = new LessonManager();
            List<ObjLessons> list = lessonManager.GetLessonsStudent(selected_id_Student);
            DataGrid_Lessons.DataSource = list;
            Style.StyleSheet style = new Style.StyleSheet();
            style.HideDataGridSomeColumns(DataGrid_Lessons, "Lessons_Teacher");
            LBL_Note.Hide();                                  
        }
        private void DataGrid_Class_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshData();
            selected_id_Student = (Int32)DataGrid_Class.CurrentRow.Cells["Ogrenci_ID"].Value;
            LessonManager lessonManager = new LessonManager();
            List<ObjLessons> listlesson = lessonManager.GetLessonsStudent(selected_id_Student);
            DataGrid_Lessons.DataSource = listlesson;
            DataGrid_Notes.DataSource = null;
            LBL_Note.Hide();
            BTN_Add_Note.Enabled = false;
            Style.StyleSheet style = new Style.StyleSheet();
            style.HideDataGridSomeColumns(DataGrid_Lessons, "Lessons");
            DataGrid_Lessons.ClearSelection();
        }
        private void DataGrid_Notes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Update_Note frm_Update_Note = new Frm_Update_Note();
            int selected_id_Student = (Int32)DataGrid_Class.CurrentRow.Cells["Ogrenci_ID"].Value;
            int selected_Lesson_ID = (Int32)DataGrid_Lessons.CurrentRow.Cells["Ders_ID"].Value;
            string selected_Note = DataGrid_Notes.CurrentRow.Cells["Not"].Value.ToString();
            int Selected_Note_ID = (Int32)DataGrid_Notes.CurrentRow.Cells["Not_ID"].Value;
            frm_Update_Note.GetNote(selected_id_Student, selected_Lesson_ID, selected_Note, Selected_Note_ID);
            frm_Update_Note.ShowDialog();
            LBL_Note.Hide();
            BTN_Add_Note.Enabled = false;            
            Refresh_Notes();
        }

        private void BTN_Add_Note_Click(object sender, EventArgs e)
        {
            Frm_Add_Note frm_Add_Note = new Frm_Add_Note();
            int selected_Lesson_ID = (Int32)DataGrid_Lessons.CurrentRow.Cells["Ders_ID"].Value;
            int selected_id_Student = (Int32)DataGrid_Class.CurrentRow.Cells["Ogrenci_ID"].Value;
            frm_Add_Note.GetLessonForAddNote(selected_Lesson_ID, selected_id_Student);
            frm_Add_Note.ShowDialog();
            Refresh_Notes();
        }
        private void DataGrid_Lessons_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Refresh_Notes();
        }
        private void Refresh_Notes()
        {
            DataGrid_Notes.DataSource = null;
            selected_id_Student = (Int32)DataGrid_Lessons.CurrentRow.Cells["Ogrenci_ID"].Value;
            selected_Lesson_ID = (Int32)DataGrid_Lessons.CurrentRow.Cells["Ders_ID"].Value;
            NoteManager lessonManager = new NoteManager();
            List<ObjNotes> listnote = lessonManager.GetNotes(selected_id_Student, selected_Lesson_ID);
            DataGrid_Notes.DataSource = listnote;
            if (listnote.Count == 0)
            {
                LBL_Note.Show();
                BTN_Add_Note.Enabled = true;
            }
            else 
            {
                LBL_Note.Hide();
                BTN_Add_Note.Enabled = false;
            }
            Style.StyleSheet style = new Style.StyleSheet();
            style.HideDataGridSomeColumns(DataGrid_Lessons, "Lessons");
            style.HideDataGridSomeColumns(DataGrid_Notes, "Notes");
            DataGrid_Notes.ClearSelection();
        }
        private void Frm_Teacher_FormClosing(object sender, FormClosingEventArgs e)
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
        private void Frm_Teacher_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}