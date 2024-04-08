using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsUserData
    {

        //----ADD NEW FUNCTION--- 

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive, byte Role)
        {
            int NewID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters 
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@Role", Role);


                    // Output parameter to capture the new Patient ID
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@NewUserID";
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

        //----DELETE  FUNCTION---
        public static bool DeleteUserbyID(int userID)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_DeleteUserByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userID", userID);

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
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_GetAllUsers", connection))
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
        public static bool IsUserExist(int userID)
        {
            bool isFound = true;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change procedure name
                using (SqlCommand command = new SqlCommand("sp_IsUserExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userID", userID);
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

        public static bool IsUserExist(string userName)
        {
            bool isFound = true;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change procedure name
                using (SqlCommand command = new SqlCommand("sp_IsUserExistbyUserName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", userName);
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
        public static DataTable FindUserbyID(int userID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindUserByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@userID", userID);

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
        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive, byte Role)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_UpdateUserByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@Role", Role);


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

        public static bool IsUserExistsForPersonID(int PersonID)
        {
            bool isFound = true;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change procedure name
                using (SqlCommand command = new SqlCommand("sp_IsUserExistForPersonID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
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

        enum enLoginStatus
        {
            Success = 1
        }

        public static bool UserLogin(string UserName, string Password)
        {

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change procedure name
                using (SqlCommand command = new SqlCommand("sp_UserLogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    try
                    {
                        connection.Open();
                        object LoginSuccess = command.ExecuteScalar();
                        return (int)LoginSuccess == (int)enLoginStatus.Success;
                    }
                    catch (Exception ex)
                    {
                        //clsLog.LogMessageError(ex.Message);
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }

            }

        }
    }


}

