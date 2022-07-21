using BL;
using System;
using System.Windows.Forms;

namespace OBS.Wiev
{
    public partial class Frm_Update_Note : Form
    {
        public int Student_ID;
        public int Lesson_ID;
        public int Note_ID;
        public Frm_Update_Note()
        {
            InitializeComponent();
        }
        private void Frm_Update_Note_Load(object sender, EventArgs e)
        {
            
        }
        public void GetNote(int student_id,int lesson_id,string note,int note_id)
        {
            this.Student_ID = student_id;
            this.Lesson_ID = lesson_id;
            this.Note_ID = note_id;
            TXT_Note.Text = note;
        }
        private void Save_Note_Click(object sender, EventArgs e)
        {
            Entering();           
        }
        public void Entering()
        {
            if (TXT_Note.Text != null)
            {
                NoteManager noteManager = new NoteManager();
                noteManager.UpdateNote(Student_ID, Note_ID, Lesson_ID, Convert.ToInt32(TXT_Note.Text));
                this.Close();
            }
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
        private void TXT_Note_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
