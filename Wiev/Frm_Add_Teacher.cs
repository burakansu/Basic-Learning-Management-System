using BL;
using System;
using System.Windows.Forms;

namespace OBS.Wiev
{
    public partial class Frm_Add_Teacher : Form
    {
        public int classid;
        public Frm_Add_Teacher()
        {
            InitializeComponent();
        }
        private void Frm_Add_Teacher_Load(object sender, EventArgs e)
        {
            Style.StyleSheet style = new Style.StyleSheet();
            style.TXTBoxMaxLenght(TXT_Name);
            style.TXTBoxMaxLenght(TXT_Surname);
            style.TXTBoxMaxLenght(TXT_Password);
        }
        public void StartAddTeacher(int class_id)
        {
            classid = class_id;
        }
        private void Save_Class_Click(object sender, EventArgs e)
        {
            Entering();
        }
        private void TXT_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void Entering()
        {
            if (TXT_Name.Text != "" || TXT_Surname.Text != "" || TXT_Nick.Text != "")
            {
                TeacherManager teacherManager = new TeacherManager();
                teacherManager.Add_Teacher(TXT_Name.Text, TXT_Surname.Text, classid, TXT_Password.Text, TXT_Nick.Text);
                this.Close();
            }
        }
        private void Save_Class_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { Entering(); }
        }

        private void TXT_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }
        private void TXT_Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }
    }
}
