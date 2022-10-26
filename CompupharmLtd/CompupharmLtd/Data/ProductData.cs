﻿using CompupharmLtd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CompupharmLtd.Data
{
    public class ProductData
    {

        public static List<Product> ProductList(string value)
        {
            var res = new Product();
            List<Product> result = new List<Product>();


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "polling.database.windows.net";
            builder.UserID = "pollingAdmin";
            builder.Password = "pollAdmin$";
            builder.InitialCatalog = "CompupharmLtd";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            Console.WriteLine("\nQuery data example:");
            Console.WriteLine("=========================================\n");

            connection.Open();
            try
            {

                using (SqlCommand command = new SqlCommand($"SELECT * FROM[dbo].[products] where status = '{value}'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                               // ([id],[product_name],[short_desc],[full_desc],[price],[quantity],[created_date],[status]
                                res.ProductID = Convert.ToInt32(reader.GetOrdinal("id"));
                                res.ProductName = reader["product_name"].ToString().Trim();
                                res.ProductShortDescription = reader["short_desc"].ToString().Trim();
                                res.ProductfullDescription = reader["full_desc"].ToString().Trim();
                                res.ProductCreatedDate = Convert.ToDateTime(reader.GetDateTime("created_date"));
                                res.ProductStatus = reader["status"].ToString().Trim();
                                res.ProductPrice = Convert.ToInt32(reader.GetOrdinal("price"));
                                res.ProductQuantity = Convert.ToInt32(reader.GetOrdinal("quantity"));
                                result.Add(res);
                            }
                        }

                    }
                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();

                }
            }

            //Console.WriteLine("\nDone. Press enter.");
            //Console.ReadLine();



            return result;
        }

        internal static string DeleteProduct(int id)
        {
            string result = "01";
            var res = new Product();
            //   List<Product> result = new List<Product>();


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "polling.database.windows.net";
            builder.UserID = "pollingAdmin";
            builder.Password = "pollAdmin$";
            builder.InitialCatalog = "CompupharmLtd";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            Console.WriteLine("\nQuery data example:");
            Console.WriteLine("=========================================\n");

            connection.Open();
            try
            {
                DateTime date = DateTime.Now;

                using (SqlCommand command = new SqlCommand($"Delete FROM [dbo].[products] WHERE [id] ={id}", connection))
                {


                    var re = command.ExecuteNonQuery();

                    if (re == 1)
                    {
                        result = "00";
                    }


                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();

                }
            }

            //Console.WriteLine("\nDone. Press enter.");
            //Console.ReadLine();



            return result;
        }

        internal static string EditProduct(Product value)
        {
            string result = "01";
            var res = new Product();
            //   List<Product> result = new List<Product>();


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "polling.database.windows.net";
            builder.UserID = "pollingAdmin";
            builder.Password = "pollAdmin$";
            builder.InitialCatalog = "CompupharmLtd";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            Console.WriteLine("\nQuery data example:");
            Console.WriteLine("=========================================\n");

            connection.Open();
            try
            {
               // DateTime date = DateTime.Now;

                using (SqlCommand command = new SqlCommand($"UPDATE  [dbo].[products] SET [id]={value.ProductID},[product_name]='{value.ProductName}',[short_desc]='{value.ProductShortDescription}',[full_desc]='{value.ProductfullDescription}',[price]={value.ProductPrice},[quantity]={value.ProductQuantity},[created_date]={value.ProductCreatedDate},[status]='{value.ProductStatus}')", connection))
                {
                  //  command.Parameters.Add("@created_date", SqlDbType.DateTime).Value = date;


                    var re = command.ExecuteNonQuery();

                    if (re == 1)
                    {
                        result = "00";
                    }


                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();

                }
            }

            //Console.WriteLine("\nDone. Press enter.");
            //Console.ReadLine();



            return result;
        }

        internal static string CreateProduct(Product value)
        {
            string result = "01";
            var res = new Product();
            //   List<Product> result = new List<Product>();


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "polling.database.windows.net";
            builder.UserID = "pollingAdmin";
            builder.Password = "pollAdmin$";
            builder.InitialCatalog = "CompupharmLtd";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            Console.WriteLine("\nQuery data example:");
            Console.WriteLine("=========================================\n");

            connection.Open();
            try
            {
                DateTime date = DateTime.Now;

                using (SqlCommand command = new SqlCommand($"INSERT INTO [dbo].[products] ([id],[product_name],[short_desc],[full_desc],[price],[quantity],[created_date],[status])VALUES ({value.ProductID},'{value.ProductName}','{value.ProductShortDescription}','{value.ProductfullDescription}',{value.ProductPrice},{value.ProductQuantity},@created_date,'{value.ProductStatus}')", connection))
                {
                    command.Parameters.Add("@created_date", SqlDbType.DateTime).Value = date;


                    var re=   command.ExecuteNonQuery();

                    if (re == 1)
                    {
                        result = "00";
                    }
                   
                    
                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();

                }
            }

            //Console.WriteLine("\nDone. Press enter.");
            //Console.ReadLine();



            return result;
        }                                                                                                    

        internal static Product GetProduct(int id)
        {
            var res = new Product();
         //   List<Product> result = new List<Product>();


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "polling.database.windows.net";
            builder.UserID = "pollingAdmin";
            builder.Password = "pollAdmin$";
            builder.InitialCatalog = "CompupharmLtd";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            Console.WriteLine("\nQuery data example:");                                                                  
            Console.WriteLine("=========================================\n");

            connection.Open();
            try
            {

                using (SqlCommand command = new SqlCommand($"SELECT * FROM[dbo].[products] where id = '{id}'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                // ([id],[product_name],[short_desc],[full_desc],[price],[quantity],[created_date],[status]
                                res.ProductID = Convert.ToInt32(reader.GetOrdinal("id"));
                                res.ProductName = reader["product_name"].ToString().Trim();
                                res.ProductShortDescription = reader["short_desc"].ToString().Trim();
                                res.ProductfullDescription = reader["full_desc"].ToString().Trim();
                                res.ProductCreatedDate = Convert.ToDateTime(reader.GetDateTime("created_date"));
                                res.ProductStatus = reader["status"].ToString().Trim();
                                res.ProductPrice = Convert.ToInt32(reader.GetOrdinal("price"));
                                res.ProductQuantity = Convert.ToInt32(reader.GetOrdinal("quantity"));
                            }
                        }

                    }
                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();

                }
            }

            //Console.WriteLine("\nDone. Press enter.");
            //Console.ReadLine();



            return res;
        }
    }

}

