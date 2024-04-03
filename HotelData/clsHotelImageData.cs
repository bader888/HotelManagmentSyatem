using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsHotelImageData
    {
        public static bool DeletehotelImage(int hotelImageID)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("sp_DeleteHotelImageByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@HotelImageID", hotelImageID);

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

        public static int AddNewhotelImage(int? hotelId, int? imageId)
        {
            int NewID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewHotelImageMapping", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    if (hotelId == null)
                        command.Parameters.AddWithValue("@hotelId", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@hotelId", hotelId);
                    if (imageId == null)
                        command.Parameters.AddWithValue("@imageId", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@imageId", imageId);


                    // Output parameter to capture the new Patient ID
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@NewHotelImageID";
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
                        //clsLog.LogMessageError(ex.Message);

                    }
                }
            }
            return NewID;
        }

        public static DataTable GetAllhotelImages(int HotelID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_GetAllhotelImages", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@hotelID", HotelID);
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

        public static bool ClearHotelImages(int HotelID)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_ClearHotelImagesByHotelID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@hotelID", HotelID);

                    try
                    {
                        connection.Open();
                        RowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //   clsLog.LogMessageError(ex.Message);
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }

            return (RowsEffected > 0);
        }
    }
}
