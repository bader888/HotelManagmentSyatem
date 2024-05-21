using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsMessageData
    {

        public static DataTable FindMessageByID(int MessageID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindMessageByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MessageID", MessageID);

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

        public static DataTable GetAllMessagesForCustomerByID(int CustomerID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_GetAllMessagesForCustomerByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

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


        public static int AddNewMessage(string MsgSubject, string MsgBody, DateTime? MsgDate, int? FromUserID, int? ToCustomerID)
        {
            int NewID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewMessage", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters 
                    command.Parameters.AddWithValue("@CustomerID", ToCustomerID);
                    command.Parameters.AddWithValue("@UserID", FromUserID);
                    command.Parameters.AddWithValue("@MsgSubject", MsgSubject);
                    command.Parameters.AddWithValue("@MsgBody", MsgBody);
                    command.Parameters.AddWithValue("@MsgDate", MsgDate);


                    // Output parameter to capture the new Patient ID
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@NewMessageID";
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
