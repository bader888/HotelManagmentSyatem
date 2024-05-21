using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsReservationData
    {
        //---- ADD NEW FUNCTION ---  
        public static int AddNewReservation(
            int customer_id,
            int room_id,
            DateTime check_in_date,
            DateTime check_out_date,
            int number_of_nights,
            string special_request,
            TimeSpan? arrived_time,
            byte reservation_status,
            decimal reservation_cost)
        {
            int NewID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewReservation", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters 
                    command.Parameters.AddWithValue("@customer_id", customer_id);
                    command.Parameters.AddWithValue("@room_id", room_id);
                    command.Parameters.AddWithValue("@check_in_date", check_in_date);
                    command.Parameters.AddWithValue("@check_out_date", check_out_date);
                    command.Parameters.AddWithValue("@number_of_nights", number_of_nights);


                    if (special_request == null)
                        command.Parameters.AddWithValue("@special_request", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@special_request", special_request);

                    if (arrived_time == null)
                        command.Parameters.AddWithValue("@arrived_time", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@arrived_time", arrived_time);

                    command.Parameters.AddWithValue("@reservation_status", reservation_status);
                    command.Parameters.AddWithValue("@reservation_cost", reservation_cost);


                    // Output parameter to capture the new Patient ID
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@reservation_id";
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
                    }
                }
            }
            return NewID;
        }

        //---- DELETE  FUNCTION ---
        public static bool DeleteReservations(int ReservationsID)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_DeleteReservationByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_reservation_id", ReservationsID);

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

        //---- GET ALL FUNCTION --- 
        public static DataTable GetAllreservations()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_GetAllReservation", connection))
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

        //----IS CUSTOMER HAVING PENDING RESERVATION FOR ROOM NUMBER
        public static bool IsCustomerHavePendingReservationForRoomNumber(int RoomNumber, int CustomerID)
        {
            bool isFound = true;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                //change procedure name
                using (SqlCommand command = new SqlCommand("sp_IsCustomerHavePendingReservationForRoomNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
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

        //---- GET BY ID FUNCTION ---
        public static DataTable FindReservationsByID(int ReservationsID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindReservationByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReservationID", ReservationsID);

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

        public static DataRow FindReservations(int ReservationsID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindReservationByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReservationID", ReservationsID);

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
            return dt.Rows[0];
        }

        //---- UPDATE FUNCTION ---
        public static bool UpdateReservation(
            int reservationID,
            int customer_id,
            int room_id,
            DateTime check_in_date,
            DateTime check_out_date,
            int number_of_nights,
            string special_request,
            TimeSpan arrived_time,
            byte reservation_status,
            decimal reservation_cost)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_UpdateReservationByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    command.Parameters.AddWithValue("@p_reservation_id", reservationID);
                    command.Parameters.AddWithValue("@p_customer_id", customer_id);
                    command.Parameters.AddWithValue("@p_room_id", room_id);
                    command.Parameters.AddWithValue("@p_check_in_date", check_in_date);
                    command.Parameters.AddWithValue("@p_check_out_date", check_out_date);
                    command.Parameters.AddWithValue("@p_number_of_nights", number_of_nights);
                    if (special_request == null)
                        command.Parameters.AddWithValue("@p_special_request", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@p_special_request", special_request);
                    if (arrived_time == null)
                        command.Parameters.AddWithValue("@p_arrived_time", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@p_arrived_time", arrived_time);

                    if (special_request == null)
                        command.Parameters.AddWithValue("@reservation_cost", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@reservation_cost", reservation_cost);

                    command.Parameters.AddWithValue("@p_reservation_status", reservation_status);


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

        //------ Get All Reservation for Customer 
        public static DataTable GetAllReservationForCustomer(int CustomerID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_GetAllReservationsForCustomerID", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);


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


    }
}
