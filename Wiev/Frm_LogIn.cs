using BL;
using OBS.Wiev;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OBS
{
    public partial class Frm_LogIn : Form
    {
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
        public Frm_LogIn()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Entering()
        {
            UserManager userManager = new UserManager();
            if (TXT_No.Text != "" || TXT_Password.Text != "")
            {
                int id = userManager.CheckUser(TXT_No.Text, TXT_Password.Text);

                if (id == 0)
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
                }
                else
                {
                    int type = userManager.GetUserType(id.ToString(), TXT_Password.Text);
                    if (type == 0)
                    {
                        Frm_Student frm_Student = new Frm_Student();
                        int Student_ID = userManager.GetStudentID_Use_UserID(id);
                        frm_Student.StartStudent(Student_ID);
                        frm_Student.Show();                        
                        this.Hide();
                    }
                    else if (type == 1)
                    {
                        Frm_Teacher frm_Teacher = new Frm_Teacher();
                        int Teacher_ID = userManager.GetTeacher_ID_Use_UserID(id);
                        frm_Teacher.StartTeacher(Teacher_ID);
                        frm_Teacher.Show();                       
                        this.Hide();
                    }
                    else if (type == 2)
                    {
                        Frm_Director frm_Directror = new Frm_Director();
                        int Director_ID = userManager.GetDirector_ID_Use_UserID(id);
                        frm_Directror.StartDirector(Director_ID);
                        frm_Directror.Show();                       
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Eksik veya Yanlış Tuşladınız.");
            }
        }
        private void BTN_Enter_Click(object sender, EventArgs e)
        {
           Entering();
        }
        private void TXT_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void Frm_LogIn_Load(object sender, EventArgs e)
        {
            TXT_Password.PasswordChar = '*';
            Style.StyleSheet style = new Style.StyleSheet();
            style.TXTBoxMaxLenght(TXT_No);
            style.TXTBoxMaxLenght(TXT_Password);
        }
        private void TXT_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { Entering(); }
        }
        private void Frm_LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Frm_LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void BTN_Exit_MouseLeave(object sender, EventArgs e)
        {
            style.BTNHoverEffect(BTN_Exit, 30);
        }
        private void BTN_Exit_MouseEnter(object sender, EventArgs e)
        {
            style.BTNHoverEffect(BTN_Exit, 32);
        }
    }
}