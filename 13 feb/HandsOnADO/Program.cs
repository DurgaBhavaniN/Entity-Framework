using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HandsOnADO
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-79NDUF0\SQLEXPRESS;Initial Catalog=practiceDB;User ID=sa;Password=pass@word1");
        SqlCommand cmd = null;
        public void Add()
        {
            try
            {
                cmd = new SqlCommand("Insert into project values(@id,@pname,@sdate,@edate)", con);
                //passing values to parameters
                cmd.Parameters.AddWithValue("@id", "P007");
                cmd.Parameters.AddWithValue("@pname", "Boings");
                cmd.Parameters.AddWithValue("@sdate", DateTime.Parse("12.2.2019"));
                cmd.Parameters.AddWithValue("@edate", DateTime.Parse("10.2.2022"));
                con.Open();//open connection
                cmd.ExecuteNonQuery();//Execute query(dml)
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//closing connection
            }
        }
        public void GetProjectById(string pid)
        {
            try {
                cmd = new SqlCommand("Select * from Project where Pid=@pid", con);
                cmd.Parameters.AddWithValue("@pid", pid);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();//execute select statement
                if (dr.HasRows) //check rows existence
                {
                    //read records in data reader
                    dr.Read();//read only one record
                    Console.WriteLine("ID:{0} Name:{1} SDate:{2} EDate:{3}", dr["pid"], dr["pname"], dr["sdate"], dr["edate"]);

                }
                else
                    Console.WriteLine("Inavalid project ID");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            }
        public void GetAllProjects()
        {
            try
            {
                cmd = new SqlCommand("Select * from Project", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("ID:{0} Name:{1} SDate:{2} EDate:{3}", dr["pid"],
                            dr["pname"], dr["sdate"], dr["edate"]);
                    }
                }
                else
                    Console.WriteLine("Table Empty");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    
        static void Main(string[] args)
        {
                Program obj = new Program();
            //obj.Add();
            //obj.GetProjectById("p007");
            obj.GetAllProjects();
            Console.ReadKey();
        }
    }
}
