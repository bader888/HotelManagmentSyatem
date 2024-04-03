using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsFacilitieData
    {

        //----ADD NEW FUNCTION---

        public static int AddNewFacilitie(string Name, string IconUrl)
        {
            int NewID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewFacilitie", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters 
                    command.Parameters.AddWithValue("@Name", Name);
                    if (IconUrl == null)
                        command.Parameters.AddWithValue("@IconUrl", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@IconUrl", IconUrl);


                    // Output parameter to capture the new Patient ID
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@NewFacilitieID";
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

        //----DELETE  FUNCTION---
        public static bool DeleteFacilitie(int FacilitieID)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_DeleteFacilitieByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FacilitieID", FacilitieID);

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

        //----GET ALL FUNCTION--- 
        public static DataTable GetAllFacilities()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_GetAllFacilities", connection))
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

        //----IS EXISTS FUNCTION---
        public static bool IsFacilitieExist(int FacilitieID)
        {
            bool isFound = true;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change procedure name
                using (SqlCommand command = new SqlCommand("sp_IsExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FacilitieID", FacilitieID);
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

        //----GET BY ID FUNCTION---
        public static DataTable FindFacilitieByID(int FacilitieID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindFacilitieByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FacilitieID", FacilitieID);

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

        //----UPDATE FUNCTION---
        public static bool UpdateFacilitie(int ID, string Name, string IconUrl)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_UpdateFacilitieByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@Name", Name);
                    if (IconUrl == null)
                        command.Parameters.AddWithValue("@IconUrl", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@IconUrl", IconUrl);


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
    }
}
