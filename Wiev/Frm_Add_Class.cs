using DB;
using OL;
using System;
using System.Windows.Forms;

namespace OBS.Wiev
{
    public partial class Frm_Add_Class : Form
    {
        public Frm_Add_Class()
        {
            InitializeComponent();
        }
        private void Save_Class_Click(object sender, EventArgs e)
        {
            Entering();
        }
        private void Entering()
        {
            if (TXT_Class_Name.Text != "")
            {
                ClassManager classManager = new ClassManager();
                ObjClasses objClass = new ObjClasses();
                objClass.Sınıf_Ad = TXT_Class_Name.Text;
                classManager.SaveClass(objClass);
                this.Close();
            }
        }

        private void Frm_Add_Class_Load(object sender, EventArgs e)
        {
            Style.StyleSheet style = new Style.StyleSheet();
            style.TXTBoxMaxLenght(TXT_Class_Name);
        }

        private void TXT_Class_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void Save_Class_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { Entering(); }
        }
    }
}
