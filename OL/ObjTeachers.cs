
using DB;
using System.Data;

namespace OL
{
    public class ObjTeachers : DBObjects.ObjectDBTeachers
    {
        public string FullName
        {
            get
            {
                return this.Ogretmen_Ad + " " + this.Ogretmen_Soyad;
            }
        }
        #region  Classes  
        private ObjClasses _Classes { get; set; }

        public ObjClasses Classes
        {
            get
            {
                if (_Classes == null)
                {
                    DataTable tbl = new SQL().GetDataTable("select * from TblSınıflar where Sınıf_ID=" + this.Sınıf_ID);
                    ObjClasses objClasses = new ObjClasses();
                    objClasses.Sınıf_ID = (int)tbl.Rows[0]["Sınıf_ID"];
                    objClasses.Sınıf_Ad = tbl.Rows[0]["Sınıf_Ad"].ToString();
                    _Classes = objClasses;
                }


                return _Classes;
            }
        }
        #endregion
    }
}
