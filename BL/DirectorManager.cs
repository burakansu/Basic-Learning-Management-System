using DB;
using OL;
using System;
using System.Data;

namespace BL
{
    public class DirectorManager
    {               
        public ObjDirector GetDirector(int Director_ID)
        {
            SQL sQL = new SQL();
            DataTable tbl = sQL.GetDataTable("select * from TblMudurler where Mudur_ID="+ Director_ID);
            ObjDirector objDirector = new ObjDirector();
            objDirector.Mudur_ID = (Int32)tbl.Rows[0]["Mudur_ID"];
            objDirector.Mudur_Ad = tbl.Rows[0]["Mudur_Ad"].ToString();
            objDirector.Mudur_Soyad = tbl.Rows[0]["Mudur_Soyad"].ToString();
            return objDirector;
        }
    }
}