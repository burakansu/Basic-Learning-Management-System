using System.Drawing;
using System.Windows.Forms;

namespace Style
{
    public class StyleSheet
    {
        public void BTNHoverEffect(PictureBox pictureBox,int Size)
        {           
            pictureBox.Width = Size;
            pictureBox.Height = Size;
        }
        public void TXTBoxMaxLenght(TextBox textBox,int MaxLength = 14)
        {
            textBox.MaxLength = MaxLength; 
        }
        public void Style(DataGridView Datagrid)
        {
            Datagrid.BorderStyle = BorderStyle.None;
            Datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Datagrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235);
            Datagrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
            Datagrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            Datagrid.RowTemplate.Height = 40;
            Datagrid.AllowUserToAddRows = false;
            Datagrid.AllowUserToDeleteRows = false;
            Datagrid.ReadOnly = true;
            Datagrid.AllowUserToResizeColumns = false;
            Datagrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Datagrid.RowHeadersVisible = false;
            Datagrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Montserrat; 17,9999981pt; style=Bold", 14, FontStyle.Bold);
            Datagrid.DefaultCellStyle.Font = new System.Drawing.Font("Montserrat; 17,9999981pt; style=Normal", 13, FontStyle.Regular);
            Datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datagrid.AllowUserToResizeRows = false;
            Datagrid.AllowUserToResizeColumns = false;
            Datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Datagrid.MultiSelect = false;
            Datagrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Datagrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            Datagrid.BackgroundColor = Color.White;            
        }
        public void HideDataGridSomeColumns(DataGridView Datagrid, string GridType)
        {
            switch (GridType)
            {
                case "Students":
                    Datagrid.Columns["Kullanıcı_ID"].Visible = false;
                    Datagrid.Columns["Sınıf_ID"].Visible = false;
                    Datagrid.Columns["FullName"].Visible = false;
                    Datagrid.Columns["Kullanıcı_Tipi"].Visible = false;
                    Datagrid.Columns["Ogrenci_ID"].HeaderText = "Numara";
                    Datagrid.Columns["Ogrenci_Ad"].HeaderText = "Ad";
                    Datagrid.Columns["Ogrenci_Soyad"].HeaderText = "Soyad";
                    break;
                case "Teachers":
                    Datagrid.Columns["Kullanıcı_ID"].Visible = false;
                    Datagrid.Columns["Sınıf_ID"].Visible = false;
                    Datagrid.Columns["Ders_ID"].Visible = false;
                    Datagrid.Columns["Ogretmen_ID"].Visible = false;
                    Datagrid.Columns["FullName"].Visible = false;
                    Datagrid.Columns["Ogretmen_Ad"].HeaderText = "Ad";
                    Datagrid.Columns["Ogretmen_Soyad"].HeaderText = "Soyad";
                    break;
                case "Directors":
                    Datagrid.Columns["Mudur_ID"].Visible = false;
                    Datagrid.Columns["Kullanıcı_ID"].Visible = false;
                    Datagrid.Columns["FullName"].Visible = false;
                    break;
                case "Lessons":
                    Datagrid.Columns["Ders_ID"].Visible = false;
                    Datagrid.Columns["Ogrenci_ID"].Visible = false;
                    Datagrid.Columns["Sınıf_ID"].Visible = false;
                    Datagrid.Columns["Ders_Ad"].HeaderText = "Sınıf Dersleri";
                    break;
                case "Classes":
                    Datagrid.Columns["Sınıf_ID"].Visible = false;
                    Datagrid.Columns["Sınıf_Ad"].HeaderText = "Sınıflar";
                    break;
                case "Notes":
                    Datagrid.Columns["Not_ID"].Visible = false;
                    Datagrid.Columns["Ders_ID"].Visible = false;
                    Datagrid.Columns["Ogrenci_ID"].Visible = false;                    
                    Datagrid.Columns["Not"].HeaderText = "Notlar";
                    break;
            }           
        }       
    }
}
