using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsImageData
    {
        public static bool DeleteImage(int ImageID)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_DeleteImageByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ImageID", ImageID);

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



        public static int AddNewImage(string imgUrl)
        {
            int NewID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewImage", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters 
                    command.Parameters.AddWithValue("@imgUrl", imgUrl);


                    // Output parameter to capture the new Patient ID
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@NewImageID";
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
    }
}
