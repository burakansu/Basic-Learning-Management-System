using DB;
using OL;
using System.Collections.Generic;

namespace BL
{
    public class NoteManager
    {
        SQL sQL = new SQL();
        public List<ObjNotes> GetNotes(int Student_ID, int Lesson_ID)
        {
            return sQL.Get<ObjNotes>("select Not_ID as 'ID', Ders_ID as 'Ders ID', Ogrenci_ID as 'Ogrenci ID', [Not] from TblNotlar where Ders_ID=" + Lesson_ID + "and Ogrenci_ID=" + Student_ID);
        }
        public void UpdateNote(int Student_ID,int Note_ID, int Lesson_ID, int note)
        {
            sQL.Run("UPDATE TblNotlar SET [Not]="+ note + " WHERE Ogrenci_ID="+ Student_ID + " and Ders_ID="+ Lesson_ID + "and Not_ID="+ Note_ID);
        }
        public void AddStudentLessonNote(int Student_ID, int Lesson_ID, int note)
        {
            sQL.Run("insert into TblNotlar (Ders_ID,Ogrenci_ID,[Not]) values ("+ Lesson_ID + ","+ Student_ID +","+ note +")");
        }
    }
}