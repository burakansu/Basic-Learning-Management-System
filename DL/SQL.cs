using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DB
{
    public class SQL
    {
        static string Sql = "data source=.\\SQLEXPRESS;Initial Catalog=OBS;Integrated Security=true";

        public List<T> Get<T>(string sql)
        {
            using (IDbConnection c = new SqlConnection(Sql))
            {
                return c.Query<T>(sql).ToList();
            }
        }
        public T Single<T>(string sql)
        {
            using (IDbConnection c = new SqlConnection(Sql))
            {
                return c.QuerySingle<T>(sql);
            }
        }
        public T Value<T>(string sql)
        {
            using (IDbConnection c = new SqlConnection(Sql))
            {
                return c.QueryFirstOrDefault<T>(sql);
            }
        }
        public int Run(string sql, object param = null)
        {
            using (IDbConnection c = new SqlConnection(Sql))
            {
               return c.ExecuteScalar<int>(sql, param);
            }
        }
        public DataTable GetTbl(string sql)
        {
            SqlCommand Command = new SqlCommand();
            SqlConnection Connection = new SqlConnection(Sql);
            Command.Connection = Connection;
            Connection.Open();
            SqlDataAdapter Mega_Adapter = new SqlDataAdapter(sql, Connection);
            DataTable tbl = new DataTable();
            Mega_Adapter.Fill(tbl);
            Connection.Close();
            Connection.Dispose();
            return tbl;
        }
    }
}
