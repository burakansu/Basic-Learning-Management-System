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
    public partial class Frm_Add_Lesson : Form
    {
        public int classid;
        public Frm_Add_Lesson()
        {
            InitializeComponent();
        }
        private void Save_Lesson_Click(object sender, EventArgs e)
        {
            Entering();
        }
        public void Start_Class_Add_Lesson(int Class_ID)
        {
            classid = Class_ID;
        }
        private void TXT_Lesson_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
        private void Frm_Add_Lesson_Load(object sender, EventArgs e)
        {
            Style.StyleSheet style = new Style.StyleSheet();
            style.TXTBoxMaxLenght(TXT_Lesson_Name);
        }
        public void Entering()
        {
            if (TXT_Lesson_Name.Text != "")
            {
                LessonManager classManager = new LessonManager();
                classManager.AddLessonClass(TXT_Lesson_Name.Text, classid);
                this.Close();
            }
        }
        private void Save_Lesson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { Entering(); }
        }
    }
}
