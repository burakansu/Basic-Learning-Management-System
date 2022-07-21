using DB;
using OL;
using System;
using System.Collections.Generic;
using System.Data;

namespace BL
{
    public class UserManager
    {
        public List<ObjUsers> GetUsers()
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select * from TblKullanıcılar");           

            List<ObjUsers> ListObjUsers = new List<ObjUsers>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ObjUsers objUsers = new ObjUsers();
                objUsers.Kullanıcı_ID = (Int32)tbl.Rows[i]["Kullanıcı_ID"];
                objUsers.Kullanıcı_Tipi = (Int32)tbl.Rows[i]["Kullanıcı_Tipi"];
                ListObjUsers.Add(objUsers);
            }
            return ListObjUsers;
        }
        public int CheckUser(string ID,string Password)
        {
            SQL sQL = new SQL();
            int id = Convert.ToInt32(sQL.CheckUserId("select * from TblKullanıcılar where Kullanıcı_Ad='" + ID +"' and Sifre=" + Password));
            return id;
        }
        public int GetUserType(string ID, string Password)
        {
            SQL sQL = new SQL();
            int id = Convert.ToInt32(sQL.GetUserType("select * from TblKullanıcılar where Kullanıcı_ID=" + ID + " and Sifre=" + Password));
            return id;
        }
        public int GetStudentID_Use_UserID(int ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select Ogrenci_ID from TblOgrenciler where Kullanıcı_ID=" + ID +"");
            return (Int32)tbl.Rows[0][0];
        }
        public int GetTeacher_ID_Use_UserID(int ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select Ogretmen_ID from TblOgretmenler where Kullanıcı_ID=" + ID + "");
            return (Int32)tbl.Rows[0]["Ogretmen_ID"];
        }
        public int GetDirector_ID_Use_UserID(int ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select Mudur_ID from TblMudurler where Kullanıcı_ID=" + ID + "");
            return (Int32)tbl.Rows[0]["Mudur_ID"];
        }
    }
}