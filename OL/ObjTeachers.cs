using DB;

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
                    return new SQL().Single<ObjClasses>("select * from TblSınıflar where Sınıf_ID=" + this.Sınıf_ID);
                }
                return _Classes;
            }
        }
        #endregion
    }
}
