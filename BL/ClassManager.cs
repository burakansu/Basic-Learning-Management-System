using OL;
using System.Collections.Generic;

namespace DB
{
    public class ClassManager
    {
        SQL sQL = new SQL();
        public ObjClasses GetClass(int class_id)
        {
            return sQL.Single<ObjClasses>("select * from TblSınıflar where Sınıf_ID=" + class_id);
        }
        public ObjClasses GetClassStudent(int student_id)
        {
            return sQL.Single<ObjClasses>("select * from TblSınıflar where Ogrenci_ID=" + student_id);
        }
        public List<ObjClasses> GetAllClass()
        {
            return sQL.Get<ObjClasses>("select Sınıf_ID,Sınıf_Ad as 'Sınıf Adı' from TblSınıflar");
        }
        public void SaveClass(ObjClasses _class)
        {
            sQL.Run("insert into TblSınıflar (Sınıf_Ad) values ('" + _class.Sınıf_Ad + "')");
        }
        public void DeleteClass(int _class)
        {
            sQL.Run("DELETE FROM TblSınıflar WHERE Sınıf_ID=" + _class);
            sQL.Run("DELETE FROM TblOgrenciler WHERE Sınıf_ID=" + _class);
            sQL.Run("DELETE FROM TblOgretmenler WHERE Sınıf_ID=" + _class);
        }
        public void UpdateClass(int ID,string name)
        {
            sQL.Run("UPDATE TblSınıflar SET Sınıf_Ad='" + name + "' WHERE Sınıf_ID=" + ID);
        }
    }
}