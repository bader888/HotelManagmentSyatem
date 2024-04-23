using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsRoomFacilityData
    {
        public static bool AddNewRoomFacility(int room_id, string facilitites_ids)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("AddNewRoomFacility", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    command.Parameters.AddWithValue("@RoomID", room_id);
                    command.Parameters.AddWithValue("@FacilitiesIDs", facilitites_ids);



                    try
                    {
                        connection.Open();

                        int RowsEffected = command.ExecuteNonQuery();

                        return room_id > 0;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        //clsLog.LogMessageError(ex.Message);

                    }
                }
            }
            return false;
        }

        public static bool DeleteRoomFacility(int RoomFacilitiesID)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("DeleteRoomFacilityByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoomFacilityID", RoomFacilitiesID);

                    try
                    {
                        connection.Open();
                        RowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        //   clsLog.LogMessageError(ex.Message);

                        return false;
                    }
                }
            }

            return (RowsEffected > 0);
        }

        public static DataTable GetAllFacilitiesForRoomID(int RoomID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("GetRoomFacilitiesByRoomID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoomID", RoomID);


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

        public static bool IsFacilityExistForRoomID(int FacilityID, int RoomID)
        {
            bool isFound = true;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change procedure name
                using (SqlCommand command = new SqlCommand("IsRoomFacilityExistForRoomID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FacilityID", FacilityID);
                    command.Parameters.AddWithValue("@RoomID", RoomID);
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
                        // clsLog.LogMessageError(ex.Message);

                        return false;
                    }
                }
                return isFound;
            }

        }
    }
}
