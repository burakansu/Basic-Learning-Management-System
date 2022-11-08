using DB;
using OL;

namespace BL
{
    public class TeacherManager
    {
        SQL sQL = new SQL();
        public ObjTeachers GetTeacher(int Teacher_ID)
        {
            return sQL.Single<ObjTeachers>("select * from TblOgretmenler where Ogretmen_ID=" + Teacher_ID);
        }
        public ObjTeachers GetTeacherForClassID(int Class_ID)
        {
            return sQL.Single<ObjTeachers>("select * from TblOgretmenler where Sınıf_ID=" + Class_ID);     
        }
        public void Add_Teacher(string name, string surname, int class_id, string password, string nick)
        {
            int User_ID = sQL.Run("insert into TblKullanıcılar (Kullanıcı_Tipi,Sifre,Kullanıcı_Ad) values (" + 1 + ", " + password + ",'"+ nick +"')" + "SELECT CAST(scope_identity() AS int)");

            sQL.Run("insert into TblOgretmenler (Ogretmen_Ad,Ogretmen_Soyad,Sınıf_ID,Kullanıcı_ID) values ('" + name + "','" + surname + "'," + class_id + "," + User_ID + ")");
        }
        public void Delete_Teacher(int id)
        {
            sQL.Run("DELETE FROM TblOgretmenler WHERE Ogretmen_ID="+ id);           
        }
    }
}