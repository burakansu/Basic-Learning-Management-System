using DB;
using OL;
using System;
using System.Collections.Generic;
using System.Data;

namespace BL
{
    public class NoteManager
    {
        public List<ObjNotes> GetNotes(int Student_ID, int Lesson_ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select Not_ID as 'ID', Ders_ID as 'Ders ID', Ogrenci_ID as 'Ogrenci ID', [Not] from TblNotlar where Ders_ID=" + Lesson_ID + "and Ogrenci_ID=" + Student_ID);

            List <ObjNotes> ListObjNotes = new List<ObjNotes>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ObjNotes objNotes = new ObjNotes();
                objNotes.Not_ID = (Int32)tbl.Rows[i]["ID"];
                objNotes.Ders_ID = (Int32)tbl.Rows[i]["Ders ID"];
                objNotes.Ogrenci_ID = (Int32)tbl.Rows[i]["Ogrenci ID"];
                objNotes.Not = (Int32)tbl.Rows[i]["Not"];
                ListObjNotes.Add(objNotes);
            }
            return ListObjNotes;
        }
        public void UpdateNote(int Student_ID,int Note_ID, int Lesson_ID, int note)
        {
            SQL sQL = new SQL();
            sQL.GetUpdate("UPDATE TblNotlar SET [Not]="+ note + " WHERE Ogrenci_ID="+ Student_ID + " and Ders_ID="+ Lesson_ID + "and Not_ID="+ Note_ID);
        }
        public void AddStudentLessonNote(int Student_ID, int Lesson_ID, int note)
        {
            SQL sQL = new SQL();
            sQL.GetDataTable("insert into TblNotlar (Ders_ID,Ogrenci_ID,[Not]) values ("+ Lesson_ID + ","+ Student_ID +","+ note +")");
        }
    }
}