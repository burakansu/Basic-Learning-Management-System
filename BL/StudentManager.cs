using OL;
using System;
using System.Collections.Generic;
using System.Data;

namespace DB
{
    public class StudentManager
    {
        public List<ObjStudents> GetStudentsForClassID(int classid)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select Ogrenci_ID as 'Numarası',Ogrenci_Ad as 'Ad', Ogrenci_Soyad as 'Soyad', Sınıf_ID as 'Sınıf ID', Kullanıcı_ID as 'Kullanıcı ID' from TblOgrenciler where Sınıf_ID="+ classid);
            List<ObjStudents> students = new List<ObjStudents>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ObjStudents objStudents = new ObjStudents();
                objStudents.Ogrenci_ID = (Int32)tbl.Rows[i]["Numarası"];
                objStudents.Ogrenci_Ad = (string)tbl.Rows[i]["Ad"];
                objStudents.Ogrenci_Soyad = (string)tbl.Rows[i]["Soyad"];
                objStudents.Sınıf_ID = (Int32)tbl.Rows[i]["Sınıf ID"];
                objStudents.Kullanıcı_ID = (Int32)tbl.Rows[i]["Kullanıcı ID"];
                students.Add(objStudents);
            }
            return students;
        }        
        public void Add_Student(string name,string surname,int class_id,string password,string nick)
        {
            SQL sQL = new SQL();
            int User_ID =  sQL.SaveUserAndGetNewUserID("insert into TblKullanıcılar (Kullanıcı_Tipi,Sifre,Kullanıcı_Ad) values ("+ 0 +", "+ password + ",'"+ nick +"')" + "SELECT CAST(scope_identity() AS int)");

            int Ogrenci_ID = sQL.SaveUserAndGetNewUserID("insert into TblOgrenciler (Ogrenci_Ad,Ogrenci_Soyad,Sınıf_ID,Kullanıcı_ID) values ('"+ name +"','"+ surname +"',"+ class_id +","+ User_ID +")" + "SELECT CAST(scope_identity() AS int)");

            DataTable tbl = sQL.GetDataTable("select distinct Ders_Ad from TblDersler where Sınıf_ID=" + class_id);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {                
                sQL.GetDataTable("insert into TblDersler (Ders_Ad,Sınıf_ID,Ogrenci_ID) values ('" + (String)tbl.Rows[i]["Ders_Ad"] + "'," + class_id + "," + Ogrenci_ID + ")");
            }
        }
        public DataTable GetStudentAndNoteCrossTab(int Student_ID,int Ders_ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select TblDersler.Ders_Ad, TblNotlar.[Not] from TblDersler Inner Join TblNotlar on (TblDersler.Ogrenci_ID = TblNotlar.Ogrenci_ID) where TblNotlar.Ders_ID="+ Ders_ID +" and TblNotlar.Ogrenci_ID="+ Student_ID +" and TblDersler.Ders_ID="+ Ders_ID);
            return tbl;
        }
        public List<ObjStudents> GetSelectedClassStudents(int Class_ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select Ogrenci_ID as 'Numara', Ogrenci_Ad as 'Ad', Ogrenci_Soyad as 'Soyad',Sınıf_ID,Kullanıcı_ID from TblOgrenciler where Sınıf_ID=" + Class_ID);

            List<ObjStudents> students = new List<ObjStudents>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ObjStudents objStudents = new ObjStudents();
                objStudents.Ogrenci_ID = (Int32)tbl.Rows[i]["Numara"];
                objStudents.Ogrenci_Ad = (string)tbl.Rows[i]["Ad"];
                objStudents.Ogrenci_Soyad = (string)tbl.Rows[i]["Soyad"];
                objStudents.Sınıf_ID = (Int32)tbl.Rows[i]["Sınıf_ID"];
                objStudents.Kullanıcı_ID = (Int32)tbl.Rows[i]["Kullanıcı_ID"];
                students.Add(objStudents);
            }
            return students;
        }
        public ObjStudents GetStudent(int Student_ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select * from TblOgrenciler where Ogrenci_ID="+ Student_ID);
            ObjStudents objStudents = new ObjStudents();
            objStudents.Ogrenci_ID = (Int32)tbl.Rows[0]["Ogrenci_ID"];
            objStudents.Ogrenci_Ad = (string)tbl.Rows[0]["Ogrenci_Ad"];
            objStudents.Ogrenci_Soyad = (string)tbl.Rows[0]["Ogrenci_Soyad"];
            objStudents.Sınıf_ID = (Int32)tbl.Rows[0]["Sınıf_ID"];
            objStudents.Kullanıcı_ID = (Int32)tbl.Rows[0]["Kullanıcı_ID"];
            return objStudents;
        }
        public void DeleteStudent(int id)
        {
            SQL sQL = new SQL();
            sQL.Execute("DELETE FROM TblOgrenciler WHERE Ogrenci_ID=" + id);
        }
    } 
}