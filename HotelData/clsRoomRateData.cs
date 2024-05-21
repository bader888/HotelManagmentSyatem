using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsRoomRateData
    {
        public static int AddNewRoomRate(int roomID, int customerID, string description, decimal score)
        {
            int NewID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddRoomsRate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    command.Parameters.AddWithValue("@roomID", roomID);
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@score", score);


                    // Output parameter to capture the new Patient ID
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@newRateID";
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
                        clsErrorLog.LogMessageError(ex.Message);
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return NewID;
        }

        public static bool UpdateRoomRate(int rateID, int roomID, int customerID, string description, decimal score)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_UpdateRoomsRate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    command.Parameters.AddWithValue("@rateID", rateID);
                    command.Parameters.AddWithValue("@roomID", roomID);
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@score", score);


                    try
                    {
                        connection.Open();
                        RowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsErrorLog.LogMessageError("Error: " + ex.Message);
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return RowsEffected > 0;
        }

        public static DataTable GetAllRoomsRate()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_GetAllRoomsRate", connection))
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
                        clsErrorLog.LogMessageError(ex.Message);
                        Console.WriteLine(ex.Message);

                    }

                }
            }
            return dt;

        }


        public static DataTable FindRoomRateByID(int RoomRateID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindRoomRateByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RoomRateID", RoomRateID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsErrorLog.LogMessageError(ex.Message);
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            return dt;
        }


        public static DataTable FindRoomRateByCustomerIDAndRoomID(int CustomerID, int RoomID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindRoomRateByCustomerIDAndRoomID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RoomID", RoomID);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsErrorLog.LogMessageError(ex.Message);
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            return dt;
        }

    }
}
