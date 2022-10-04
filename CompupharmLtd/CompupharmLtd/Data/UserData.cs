﻿using CompupharmLtd.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CompupharmLtd.Data
{
    public class UserData
    {


        public static LoginUser LoginData(string value)
        { var result = new LoginUser();
            

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

                    using (SqlCommand command = new SqlCommand($"SELECT [UserID] ,Password ,UserName,[LastLogin] FROM[dbo].[LoginCred] where UserName = '{value}'", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                          
                                result.UserID = Convert.ToInt32(reader.GetOrdinal("UserID"));
                                result.Password = reader["Password"].ToString().Trim() ;
                                result.UserName = reader["UserName"].ToString().Trim();
                                result.LastLogin = Convert.ToDateTime(reader["LastLogin"]);

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
    }
}           