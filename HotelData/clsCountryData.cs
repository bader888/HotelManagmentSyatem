using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsCountryData
    {
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_GetAllCountries", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        //clsLog.LogMessageError(ex.Message);
                    }

                }
            }
            return dt;

        }

        public static DataTable FindCountryByID(int CountryID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindCountryByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CountryID", CountryID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        //clsLog.LogMessageError(ex.Message);
                    }

                }
            }
            return dt;
        }

        public static DataTable FindCountryByName(string CountryName)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindCountryByName", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CountryName", CountryName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        //clsLog.LogMessageError(ex.Message);
                    }

                }
            }
            return dt;
        }



    }
}
