using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsRoomImagesData
    {
        static public bool DeleteRoomImageByID(int imageID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("DeleteRoomImageByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@ImageID", imageID);

                        connection.Open();
                        int rowsEffected = command.ExecuteNonQuery();

                        return rowsEffected > 0; // Success
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false; // Failure
            }
        }

        static public bool AddRoomImages(int RoomID, string imagesPaths)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("AddRoomImages", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@RoomID", RoomID);
                        command.Parameters.AddWithValue("@ImagePaths", imagesPaths);

                        connection.Open();
                        int RowsEffected = command.ExecuteNonQuery();

                        return RowsEffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        static public bool ClearImagesRoom(int RoomID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("ClearImageRoom", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        connection.Open();
                        int rowsEffected = command.ExecuteNonQuery();

                        return rowsEffected > 0; // Success
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false; // Failure
            }
        }

        static public DataTable GetAllImagesForRoomID(int RoomID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("GetRoomImagesByRoomID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@RoomID", RoomID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                return dt;
            }


        }


    }
}
