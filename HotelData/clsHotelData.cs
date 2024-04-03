using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsHotelData
    {
        //done
        public static int AddNewHotel(string name, decimal? rate, string address, string description, bool BreakfastIncluded)
        {
            int NewID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewHotel", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters 
                    command.Parameters.AddWithValue("@name", name);
                    if (rate == null)
                        command.Parameters.AddWithValue("@rate", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@rate", rate);
                    command.Parameters.AddWithValue("@address", address);
                    if (description == null)
                        command.Parameters.AddWithValue("@description", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@BreakfastIncluded", BreakfastIncluded);


                    // Output parameter to capture the new Patient ID
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@NewhotelID";
                    outputParameter.SqlDbType = SqlDbType.Int;
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        NewID = Convert.ToInt32(outputParameter.Value);

                    }
                    catch (Exception ex)
                    {
                        //clsLog.LogMessageError(ex.Message);
                        Console.WriteLine(ex.Message);

                    }
                }
            }
            return NewID;
        }

        //done
        public static bool UpdateHotel(int hotelID, string name, decimal? rate, string address, string description, bool BreakfastIncluded)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_UpdatehHotelByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    command.Parameters.AddWithValue("@hotelID", hotelID);
                    command.Parameters.AddWithValue("@name", name);
                    if (rate == null)
                        command.Parameters.AddWithValue("@rate", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@rate", rate);
                    command.Parameters.AddWithValue("@address", address);
                    if (description == null)
                        command.Parameters.AddWithValue("@description", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@BreakfastIncluded", BreakfastIncluded);


                    try
                    {
                        connection.Open();
                        RowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        // clsLog.LogMessageError("Error: " + ex.Message);
                    }
                }
            }
            return RowsEffected > 0;
        }

        //done
        public static DataTable GetAllHotels()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_GetAllHotels", connection))
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
                        //clsLog.LogMessageError(ex.Message);
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            return dt;

        }

        //done 
        public static bool DeleteHotel(int HotelID)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_DeleteHotelByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@HotelID", HotelID);

                    try
                    {
                        connection.Open();
                        RowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        //clsLog.LogMessageError(ex.Message);

                        return false;
                    }
                }
            }

            return (RowsEffected > 0);
        }

        //done
        public static DataTable FindHotelByID(int HotelID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindHotelByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@HotelID", HotelID);

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
