using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ProductADO
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-79NDUF0\SQLEXPRESS;Initial Catalog=practiceDB;User ID=sa;Password=pass@word1");
        SqlCommand cmd = null;
        public void Add(int id,string name,int price,int stock)
        {
            try
            {
                cmd = new SqlCommand("Insert into product values(@id,@name,@price,@stock)", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
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
        public void Get(int id)
        {
            try
            {
                cmd = new SqlCommand("Select * from Product where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();//execute select statement
                if (dr.HasRows) //check rows existence
                {
                    //read records in data reader
                    dr.Read();//read only one record
                    Console.WriteLine("ID:{0} Name:{1} Price:{2} Stock:{3}", dr["id"], dr["name"], dr["price"], dr["stock"]);

                }
                else
                    Console.WriteLine("Inavalid product ID");
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
        public void GetAll()
        {
            try
            {
                cmd = new SqlCommand("Select * from Product", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("ID:{0} Name:{1} Price:{2} Stock:{3}", dr["id"],
                            dr["name"], dr["price"], dr["stock"]);
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
        public void Delete(int id)
        {
            try
            {
                cmd = new SqlCommand("delete from Product where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();   
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
        public void Update(int id,int price,int stock)
        {
            try
            {
                cmd = new SqlCommand("Update Product set price=@price,stock=@stock where id=@id", con);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
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

        static void Main(string[] args)
        {
            Program obj = new Program();
            //obj.Add(3,"fsgda",1400,6);
            // obj.Get(2);
            //obj.GetAll();
            obj.Delete(1);
          
            //obj.Update(1, 1300, 6);
        }
    }
}
