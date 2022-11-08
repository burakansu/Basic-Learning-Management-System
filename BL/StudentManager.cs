using OL;
using System.Collections.Generic;
using System.Data;

namespace DB
{
    public class StudentManager
    {
        SQL sQL = new SQL();
        public List<ObjStudents> GetStudentsForClassID(int classid)
        {
            return sQL.Get<ObjStudents>("select Ogrenci_ID as 'Numarası',Ogrenci_Ad as 'Ad', Ogrenci_Soyad as 'Soyad', Sınıf_ID as 'Sınıf ID', Kullanıcı_ID as 'Kullanıcı ID' from TblOgrenciler where Sınıf_ID=" + classid);
        }        
        public void Add_Student(string name,string surname,int class_id,string password,string nick)
        {
            int User_ID =  sQL.Run("insert into TblKullanıcılar (Kullanıcı_Tipi,Sifre,Kullanıcı_Ad) values ("+ 0 +", "+ password + ",'"+ nick +"')" + "SELECT CAST(scope_identity() AS int)");

            int Ogrenci_ID = sQL.Run("insert into TblOgrenciler (Ogrenci_Ad,Ogrenci_Soyad,Sınıf_ID,Kullanıcı_ID) values ('"+ name +"','"+ surname +"',"+ class_id +","+ User_ID +")" + "SELECT CAST(scope_identity() AS int)");

            foreach (var item in sQL.Get<ObjLessons>("select distinct Ders_Ad from TblDersler where Sınıf_ID=" + class_id))
            {
                sQL.Run("insert into TblDersler (Ders_Ad,Sınıf_ID,Ogrenci_ID) values ('" + item.Ders_Ad + "'," + class_id + "," + Ogrenci_ID + ")");
            }
        }
        public DataTable GetStudentAndNoteCrossTab(int Student_ID,int Ders_ID)
        {
            return sQL.GetTbl("select TblDersler.Ders_Ad, TblNotlar.[Not] from TblDersler Inner Join TblNotlar on (TblDersler.Ogrenci_ID = TblNotlar.Ogrenci_ID) where TblNotlar.Ders_ID="+ Ders_ID +" and TblNotlar.Ogrenci_ID="+ Student_ID +" and TblDersler.Ders_ID="+ Ders_ID);
        }
        public List<ObjStudents> GetSelectedClassStudents(int Class_ID)
        {
            return sQL.Get<ObjStudents>("select Ogrenci_ID as 'Numara', Ogrenci_Ad as 'Ad', Ogrenci_Soyad as 'Soyad',Sınıf_ID,Kullanıcı_ID from TblOgrenciler where Sınıf_ID=" + Class_ID);
        }
        public ObjStudents GetStudent(int Student_ID)
        {
            return sQL.Single<ObjStudents>("select * from TblOgrenciler where Ogrenci_ID="+ Student_ID);
        }
        public void DeleteStudent(int id)
        {
            sQL.Run("DELETE FROM TblOgrenciler WHERE Ogrenci_ID="+ id);
        }
    } 
}