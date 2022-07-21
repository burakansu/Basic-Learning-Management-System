using DB;
using OL;
using System;
using System.Collections.Generic;
using System.Data;

namespace BL
{
    public class LessonManager
    {
        //public ObjLessons GetLessons()
        //{
        //    SQL sQL = new SQL();
        //    DataTable tbl = sQL.GetDataTable("select * from TblDersler");
        //    ObjLessons objLessons = new ObjLessons();
        //    objLessons.Ders_ID = (Int32)tbl.Rows[0]["Ders_ID"];
        //    objLessons.Ders_Ad = (String)tbl.Rows[0]["Ders_Ad"];
        //    objLessons.Ogrenci_ID = (Int32)tbl.Rows[0]["Ogrenci_ID"];
        //    objLessons.Sınıf_ID = (Int32)tbl.Rows[0]["Sınıf_ID"];
        //    return objLessons;
        //}
        public List<ObjLessons> GetLessonsStudent(int Student_ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select * from TblDersler where Ogrenci_ID="+ Student_ID);
            List<ObjLessons> listobjLessons = new List<ObjLessons>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ObjLessons objLesson = new ObjLessons();
                objLesson.Sınıf_ID = (Int32)tbl.Rows[i]["Sınıf_ID"];
                objLesson.Ders_ID = (Int32)tbl.Rows[i]["Ders_ID"];
                objLesson.Ders_Ad = (String)tbl.Rows[i]["Ders_Ad"];
                objLesson.Ogrenci_ID = (Int32)tbl.Rows[i]["Ogrenci_ID"];
                listobjLessons.Add(objLesson);
            }

            return listobjLessons;
        }
        public List<ObjLessons> GetClassLessons(int Class_ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select distinct Ders_Ad from TblDersler where Sınıf_ID=" + Class_ID);
            List<ObjLessons> ListobjLessons = new List<ObjLessons>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ObjLessons objLessons = new ObjLessons();
                objLessons.Ders_Ad = (String)tbl.Rows[i]["Ders_Ad"];
                ListobjLessons.Add(objLessons);
            }
            
            return ListobjLessons;
        }
        public List<ObjLessons> GetStudentLessons(int Student_ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select * from TblDersler where Ogrenci_ID=" + Student_ID);
            List<ObjLessons> ListobjLessons = new List<ObjLessons>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ObjLessons objLessons = new ObjLessons();
                objLessons.Ders_Ad = (String)tbl.Rows[i]["Ders_Ad"];
                objLessons.Ders_ID = (Int32)tbl.Rows[i]["Ders_ID"];
                objLessons.Sınıf_ID = (Int32)tbl.Rows[i]["Sınıf_ID"];
                objLessons.Ogrenci_ID = (Int32)tbl.Rows[i]["Ogrenci_ID"];
                ListobjLessons.Add(objLessons);
            }

            return ListobjLessons;
        }
        public void AddLessonClass(string Lesson_Name,int Class_ID)
        {
            SQL sQL = new SQL();            
            DataTable tbl = sQL.GetDataTable("select Ogrenci_ID, Ogrenci_Ad, Ogrenci_Soyad,Sınıf_ID,Kullanıcı_ID from TblOgrenciler where Sınıf_ID=" + Class_ID);

            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                sQL.Execute("insert into TblDersler (Ders_Ad,Sınıf_ID,Ogrenci_ID) values ('" + Lesson_Name + "'," + Class_ID + ","+ tbl.Rows[i]["Ogrenci_ID"] +")");
            }
        }
        public void AddLessonStudent(string name, int student_id, int class_id)
        {
            SQL sQL = new SQL();
            sQL.Execute("insert into TblDersler (Ders_Ad,Sınıf_ID,Ogrenci_ID) values ('" + name + "'," + class_id + "," + student_id + ")");
        }
        public void DeleteLesson(string lessonad, int classid)
        {
            SQL sQL = new SQL();
            sQL.Execute("DELETE FROM TblDersler WHERE Ders_Ad='" + lessonad + "' AND Sınıf_ID=" + classid);
        }
    }
}