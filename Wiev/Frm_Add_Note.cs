using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS.Wiev
{
    public partial class Frm_Add_Note : Form
    {
        public int student_id;
        public int lesson_id;
        public Frm_Add_Note()
        {
            InitializeComponent();
        }

        private void Save_Class_Click(object sender, EventArgs e)
        {
            Entering();
        }
        public void GetLessonForAddNote(int student_id, int lesson_id)
        {
            this.student_id = student_id;
            this.lesson_id = lesson_id;
        }
        private void Frm_Add_Note_Load(object sender, EventArgs e)
        {
            Style.StyleSheet style = new Style.StyleSheet();
            style.TXTBoxMaxLenght(TXT_Note);
        }
        private void TXT_Note_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void Entering()
        {
            NoteManager noteManager = new NoteManager();
            noteManager.AddStudentLessonNote(lesson_id, student_id, Convert.ToInt32(TXT_Note.Text));
            this.Close();
        }
        private void Save_Class_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { Entering(); }
        }

        private void TXT_Note_TextChanged(object sender, EventArgs e)
        {
            int text = Convert.ToInt32(TXT_Note.Text);
            if (text > 100)
            {
                TXT_Note.Text = "100";
            }
        }
    }
}
