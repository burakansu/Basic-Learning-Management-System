using DB;
using OL;
using System.Collections.Generic;

namespace BL
{
    public class LessonManager
    {
        SQL sQL = new SQL();
        public List<ObjLessons> GetLessonsStudent(int Student_ID)
        {
            return sQL.Get<ObjLessons>("select * from TblDersler where Ogrenci_ID=" + Student_ID);
        }
        public List<ObjLessons> GetClassLessons(int Class_ID)
        {
            return sQL.Get<ObjLessons>("select distinct Ders_Ad from TblDersler where Sınıf_ID=" + Class_ID);
        }
        public List<ObjLessons> GetStudentLessons(int Student_ID)
        {
            return sQL.Get<ObjLessons>("select * from TblDersler where Ogrenci_ID=" + Student_ID);
        }
        public void AddLessonClass(string Lesson_Name,int Class_ID)
        {
            foreach (var item in sQL.Get<ObjStudents>("select * from TblOgrenciler where Sınıf_ID=" + Class_ID))
            {
                sQL.Run("insert into TblDersler (Ders_Ad,Sınıf_ID,Ogrenci_ID) values ('" + Lesson_Name + "'," + Class_ID + "," + item.Ogrenci_ID + ")");
            }
        }
        public void AddLessonStudent(string name, int student_id, int class_id)
        {
            sQL.Run("insert into TblDersler (Ders_Ad,Sınıf_ID,Ogrenci_ID) values ('" + name + "'," + class_id + "," + student_id + ")");
        }
        public void DeleteLesson(string lessonad, int classid)
        {
            sQL.Run("DELETE FROM TblDersler WHERE Ders_Ad='" + lessonad + "' AND Sınıf_ID=" + classid);
        }
    }
}