using DB;
using OL;
using System.Collections.Generic;

namespace BL
{
    public class UserManager
    {
        SQL sQL = new SQL();
        public List<ObjUsers> GetUsers()
        {
            return sQL.Get<ObjUsers>("select * from TblKullanıcılar");
        }
        public int CheckUser(string ID,string Password)
        {
            return sQL.Value<int>("select * from TblKullanıcılar where Kullanıcı_Ad='" + ID +"' and Sifre=" + Password);
        }
        public int GetUserType(string ID, string Password)
        {
            return sQL.Value<int>("select * from TblKullanıcılar where Kullanıcı_ID=" + ID + " and Sifre=" + Password);
        }
        public int GetStudentID_Use_UserID(int ID)
        {
            return sQL.Value<int>("select Ogrenci_ID from TblOgrenciler where Kullanıcı_ID=" + ID +"");
        }
        public int GetTeacher_ID_Use_UserID(int ID)
        {
            return sQL.Value<int>("select Ogretmen_ID from TblOgretmenler where Kullanıcı_ID=" + ID + "");
        }
        public int GetDirector_ID_Use_UserID(int ID)
        {
            return sQL.Value<int>("select Mudur_ID from TblMudurler where Kullanıcı_ID=" + ID + "");
        }
    }
}