using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsRoomData
    {
        public static int AddNewRoom(int room_type_id, byte? room_status, decimal? room_rate, string room_description, byte? room_size, bool is_pet_friendly, bool is_smoking_allowed, int number_of_people, byte? room_view, int room_number, int number_of_beds)
        {
            int NewID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("AddNewRoom", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters

                    command.Parameters.AddWithValue("@room_type_id", room_type_id);
                    command.Parameters.AddWithValue("@room_description", room_description);
                    command.Parameters.AddWithValue("@is_pet_friendly", is_pet_friendly);
                    command.Parameters.AddWithValue("@is_smoking_allowed", is_smoking_allowed);
                    command.Parameters.AddWithValue("@number_of_people", number_of_people);
                    command.Parameters.AddWithValue("@room_number", room_number);
                    command.Parameters.AddWithValue("@number_of_beds", number_of_beds);
                    command.Parameters.AddWithValue("@room_size", room_size);
                    command.Parameters.AddWithValue("@room_view", room_view);
                    command.Parameters.AddWithValue("@room_status", 1);
                    if (room_rate == null)
                        command.Parameters.AddWithValue("@room_rate", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@room_rate", room_rate);


                    // Output parameter to capture the new Patient ID
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@NewRoomID";
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
                        Console.WriteLine(ex.Message);
                        clsErrorLog.LogMessageError(ex.Message);

                    }
                }
            }
            return NewID;
        }

        public static bool UpdateRoom(int room_id, int room_type_id, byte? room_status, decimal? room_rate, string room_description, byte? room_size, bool is_pet_friendly, bool is_smoking_allowed, int number_of_people, byte? room_view, int room_number, int number_of_beds)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("UpdateRoom", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    command.Parameters.AddWithValue("@room_id", room_id);
                    command.Parameters.AddWithValue("@room_type_id", room_type_id);
                    command.Parameters.AddWithValue("@room_status", 1);

                    if (room_rate == null)
                        command.Parameters.AddWithValue("@room_rate", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@room_rate", room_rate);
                    command.Parameters.AddWithValue("@room_description", room_description);
                    if (room_size == null)
                        command.Parameters.AddWithValue("@room_size", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@room_size", room_size);
                    command.Parameters.AddWithValue("@is_pet_friendly", is_pet_friendly);
                    command.Parameters.AddWithValue("@is_smoking_allowed", is_smoking_allowed);
                    command.Parameters.AddWithValue("@number_of_people", number_of_people);
                    if (room_view == null)
                        command.Parameters.AddWithValue("@room_view", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@room_view", room_view);
                    command.Parameters.AddWithValue("@room_number", room_number);
                    command.Parameters.AddWithValue("@number_of_beds", number_of_beds);


                    try
                    {
                        connection.Open();
                        RowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return RowsEffected > 0;
        }

        public static DataTable GetAllRooms()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("GetAllRooms", connection))
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
                    }

                }
            }
            return dt;

        }

        public static bool DeleteRoom(int RoomID)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("DeleteRoomByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoomID", RoomID);

                    try
                    {
                        connection.Open();
                        RowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }

            return (RowsEffected > 0);
        }


        public static bool IsRoomAvailable(int RoomID)
        {
            bool isFound = true;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change procedure name
                using (SqlCommand command = new SqlCommand("IsRoomAvailable", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@roomID", RoomID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;

                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                        return false;
                    }
                }
                return isFound;
            }

        }

        public static bool ChangeRoomStatus(int RoomID, byte? @NewStatus)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("ChangeRoomStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    command.Parameters.AddWithValue("@RoomID", RoomID);
                    command.Parameters.AddWithValue("@NewStatus", NewStatus);

                    try
                    {
                        connection.Open();
                        RowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return RowsEffected > 0;
        }

        public static DataTable FindRoomByID(int RoomID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("FindRoomByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            return dt;
        }
    }
}
