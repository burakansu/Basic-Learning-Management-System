using DB;
using OL;
using System;
using System.Data;

namespace BL
{
    public class TeacherManager
    {
        public ObjTeachers GetTeacher(int Teacher_ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select * from TblOgretmenler where Ogretmen_ID=" + Teacher_ID);
            
            ObjTeachers objTeacher = new ObjTeachers();
            objTeacher.Ogretmen_ID = (Int32)tbl.Rows[0]["Ogretmen_ID"];
            objTeacher.Ogretmen_Ad = tbl.Rows[0]["Ogretmen_Ad"].ToString();
            objTeacher.Ogretmen_Soyad = tbl.Rows[0]["Ogretmen_Soyad"].ToString();
            objTeacher.Sınıf_ID = (Int32)tbl.Rows[0]["Sınıf_ID"];
            objTeacher.Kullanıcı_ID = (Int32)tbl.Rows[0]["Kullanıcı_ID"];

            return objTeacher; 
        }
        public ObjTeachers GetTeacherForClassID(int Class_ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select * from TblOgretmenler where Sınıf_ID=" + Class_ID);
            if (tbl.Rows.Count > 0)
            {
                ObjTeachers objTeacher = new ObjTeachers();
                objTeacher.Ogretmen_ID = (Int32)tbl.Rows[0]["Ogretmen_ID"];
                objTeacher.Ogretmen_Ad = tbl.Rows[0]["Ogretmen_Ad"].ToString();
                objTeacher.Ogretmen_Soyad = tbl.Rows[0]["Ogretmen_Soyad"].ToString();
                objTeacher.Sınıf_ID = (Int32)tbl.Rows[0]["Sınıf_ID"];
                objTeacher.Kullanıcı_ID = (Int32)tbl.Rows[0]["Kullanıcı_ID"];
                return objTeacher;
            }
            else
            {
                ObjTeachers objTeacher = new ObjTeachers();
                objTeacher.Ogretmen_ID = 0;
                return objTeacher;
            }           
        }
        public void Add_Teacher(string name, string surname, int class_id, string password, string nick)
        {
            SQL sQL = new SQL();
            int User_ID = sQL.SaveUserAndGetNewUserID("insert into TblKullanıcılar (Kullanıcı_Tipi,Sifre,Kullanıcı_Ad) values (" + 1 + ", " + password + ",'"+ nick +"')" + "SELECT CAST(scope_identity() AS int)");

            sQL.Execute("insert into TblOgretmenler (Ogretmen_Ad,Ogretmen_Soyad,Sınıf_ID,Kullanıcı_ID) values ('" + name + "','" + surname + "'," + class_id + "," + User_ID + ")");
        }
        public void Delete_Teacher(int id)
        {
            SQL sQL = new SQL();
            sQL.Execute("DELETE FROM TblOgretmenler WHERE Ogretmen_ID="+ id);           
        }
    }
}