using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DAL
{
    public class Class1
    {
    }
    public class Demo
    {
        public string Name { get; set; }
        public string Id { get; set; }
       public List<string> GetName()
        {
            List<string> Names = new List<string>();
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand("spGetAllData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader rdr= cmd.ExecuteReader();
            while(rdr.Read())
            {
                Names.Add(rdr["Name"].ToString());
            }
            return Names;
        }
        public string GetIdByName()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spGetIdByName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                con.Open();
                string Id = cmd.ExecuteScalar().ToString();
                return Id;
            }
        }
        public int UpdateNameById()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spUpdateNameById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID",this.Id);
                cmd.Parameters.AddWithValue("@Name", Name);
                con.Open();
                int RE = cmd.ExecuteNonQuery();
                return RE;
            }
        }
       
    }
}
