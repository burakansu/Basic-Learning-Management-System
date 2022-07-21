using System;
using System.Data;
using System.Data.SqlClient;

namespace DB
{
    public class SQL
    {
        public SqlConnection Connection = null;
        public SqlCommand Command = new SqlCommand();
        public SqlDataAdapter Mega_Adapter = null;
        public void Open()
        {
            Connection = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=OBS;Integrated Security=true");
            Command.Connection = Connection;
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
            }
        }
        public void Close()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
            Connection.Dispose();
        }
        public DataTable GetDataTable(string sql)
        {
            Open();
            DataTable tbl = new DataTable();
            Mega_Adapter = new SqlDataAdapter(sql, Connection);
            Mega_Adapter.Fill(tbl);
            Close();

            return tbl;
        }
        public int CheckUserId(string sql)
        {
            Open();
            Command.CommandText = sql;
            SqlDataReader cikti = Command.ExecuteReader();
            
            if (cikti.Read())
            {
                int id = (Int32)cikti["Kullanıcı_ID"];
                Close();
                return id;
            }
            else
            {
                Close();
                return 0;
            }    
        }
        public int GetUserType(string sql)
        {
            Open();
            Command.CommandText = sql;
            SqlDataReader cikti = Command.ExecuteReader();

            if (cikti.Read())
            {
                int type = (Int32)cikti["Kullanıcı_Tipi"];
                Close();
                return type;
            }
            else
            {
                Close();
                return 0;
            }
        }
        public void AddParameters(string key, SqlDbType type, object value)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = key;
            parameter.SqlDbType = type;
            parameter.Value = value;

            Command.Parameters.Add(parameter);
        }
        public void Execute(string sql)
        {
            Open();
            Command.CommandText = sql;
            Command.ExecuteNonQuery();
            Close();
        }    
        public string Delete(string sql, string sql2)
        {
            string ret = "";
            Open();
            SqlCommand silKomutu = new SqlCommand(sql, Connection);
            silKomutu.Parameters.AddWithValue("@Sporcu_ID", sql2);
            silKomutu.ExecuteNonQuery();
            Close();
            return ret;
        }
        public bool GetUpdate(string sql)
        {
            Open();
            Command = new SqlCommand(sql, Connection);
            var ret = Command.ExecuteNonQuery();
            Close();

            return ret > 0 ? true : false;
        }       
        public int Count_Database(string sql)
        {
            Open();
            SqlCommand comm = new SqlCommand(sql, Connection);
            Int32 count = (Int32)comm.ExecuteScalar();
            Close();
            return count;
        }
        public int SaveUserAndGetNewUserID(string sql)
        {
            Open();
            SqlCommand comm = new SqlCommand(sql, Connection);
            Int32 userid = (Int32)comm.ExecuteScalar();
            Close();
            return userid;
        }
    }
}
