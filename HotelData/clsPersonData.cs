using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsPersonData
    {

        //----ADD NEW FUNCTION--- 
        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int NewID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_AddNewPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters 
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    if (LastName == null)
                        command.Parameters.AddWithValue("@LastName", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    if (Email == null)
                        command.Parameters.AddWithValue("@Email", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);


                    // Output parameter to capture the new Patient ID
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@NewPersonID";
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
        public static bool DeletePerson(int PersonID)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_DeletePersonByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

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

        //----GET ALL FUNCTION--- 
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_GetAllPeople", connection))
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
        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = true;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change procedure name
                using (SqlCommand command = new SqlCommand("sp_IsPersonExist", connection))
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


        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = true;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change procedure name
                using (SqlCommand command = new SqlCommand("sp_IsPersonExistbyNationalNO", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
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
        public static DataTable FindPersonByID(int PersonID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_FindPersonByID", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);

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
        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int RowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                //change the procedure name
                using (SqlCommand command = new SqlCommand("sp_UpdatePersonByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    if (LastName == null)
                        command.Parameters.AddWithValue("@LastName", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    if (Email == null)
                        command.Parameters.AddWithValue("@Email", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);


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
