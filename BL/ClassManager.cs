using OL;
using System.Collections.Generic;
using System.Data;

namespace DB
{
    public class ClassManager
    {
        public ObjClasses GetClass(int class_id)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select * from TblSınıflar where Sınıf_ID=" + class_id);
            ObjClasses objClasses = new ObjClasses();
            objClasses.Sınıf_ID = (int)tbl.Rows[0]["Sınıf_ID"];
            objClasses.Sınıf_Ad = tbl.Rows[0]["Sınıf_Ad"].ToString();
            return objClasses;
        }
        public ObjClasses GetClassStudent(int student_id)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select * from TblSınıflar where Ogrenci_ID=" + student_id);
            ObjClasses objClasses = new ObjClasses();

            objClasses.Sınıf_Ad = tbl.Rows[0]["Sınıf_Ad"].ToString();
            return objClasses;
        }
        public List<ObjClasses> GetAllClass()
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select Sınıf_ID,Sınıf_Ad as 'Sınıf Adı' from TblSınıflar");

            List<ObjClasses> ObjClassList = new List<ObjClasses>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ObjClasses objClasses = new ObjClasses();
                objClasses.Sınıf_ID = (int)tbl.Rows[i]["Sınıf_ID"];
                objClasses.Sınıf_Ad = (string)tbl.Rows[i]["Sınıf Adı"];
                ObjClassList.Add(objClasses);
            }
            return ObjClassList;
        }
        public void SaveClass(ObjClasses _class)
        {
            SQL sQL = new SQL();
            sQL.Execute("insert into TblSınıflar (Sınıf_Ad) values ('" + _class.Sınıf_Ad + "')");
        }
        public void DeleteClass(int _class)
        {
            SQL sQL = new SQL();
            sQL.Execute("DELETE FROM TblSınıflar WHERE Sınıf_ID=" + _class);
            sQL.Execute("DELETE FROM TblOgrenciler WHERE Sınıf_ID=" + _class);
            sQL.Execute("DELETE FROM TblOgretmenler WHERE Sınıf_ID=" + _class);
        }
        public void UpdateClass(int ID,string name)
        {
            SQL sQL = new SQL();
            sQL.Execute("UPDATE TblSınıflar SET Sınıf_Ad='" + name + "' WHERE Sınıf_ID=" + ID);
        }

    }
}