using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.XPath;
using static System.Net.Mime.MediaTypeNames;
using DVLD.Utilities;
using System.Configuration;



namespace ClsDVLD_Data_Access_Layer
{
    public class clsCountryData
    {
        public static bool GetCountryInfoByID(int ID, ref string CountryName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);


            string query = @"select * from Countries where CountryID=@CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    CountryName = (string)reader["CountryName"];
                }
                reader.Close();
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static bool GetCountryInfoByName(string CountryName, ref int ID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select * from Countries where CountryName=@CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["CountryID"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select * from Countries order by CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                clsLogger.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
    public class clsPersonData
    {
        static public bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName,
ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref short Gendor, ref string Address,
ref string Phone, ref string Email, ref int Nationality_CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select * from People where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    string gendorValue = reader["Gendor"].ToString();
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }
                    Nationality_CountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        static public bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
 ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref short Gendor, ref string Address,
 ref string Phone, ref string Email, ref int Nationality_CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select * from People where NationalNo=@NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    string gendorValue = reader["Gendor"].ToString();
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }
                    Nationality_CountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        static public int AddNewPerson(string NationalNo, string Firstname, string SecondName, string ThirdName,
         string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone, string Email,
         int Nationality_CountryID, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"insert into People(NationalNo,FirstName,SecondName,ThirdName,LastName,
DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath)
                            values(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,
@DateOfBirth,@Gendor,@Address,@Phone,@Email,
@NationalityCountryID,@ImagePath); select Scope_Identity();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", Firstname);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "" && ThirdName != null)
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "" && Email != null)
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@NationalityCountryID", Nationality_CountryID);
            if (ImagePath != "" && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(), out int resultID))
                {
                    PersonID = resultID;
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }

        static public bool UpdatePerson(int PersonID, string NationalNo, string Firstname, string SecondName, string ThirdName,
string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone, string Email,
int Nationality_CountryID, string ImagePath)
        {
            int AffectedRows = -1;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"update People set NationalNo=@NationalNo,FirstName=@FirstName,SecondName=@SecondName,
ThirdName=@ThirdName,LastName=@LastName,DateOfBirth=@DateOfBirth,Gendor=@Gendor,Address=@Address,Phone=@Phone,
Email=@Email,NationalityCountryID=@NationalityCountryID,ImagePath=@ImagePath where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", Firstname);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "" && ThirdName != null)
            { command.Parameters.AddWithValue("@ThirdName", ThirdName); }
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
            { command.Parameters.AddWithValue("@Email", Email); }
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", Nationality_CountryID);
            if (ImagePath != "" && ImagePath != null)
            { command.Parameters.AddWithValue("@ImagePath", ImagePath); }
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();
                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (AffectedRows > 0);
        }

        static public DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select People.PersonID,People.NationalNo,
People.FirstName,People.SecondName,People.ThirdName,People.LastName,People.DateOfBirth,
Case
when People.Gendor = 0 then 'Male'
else 'Female'
End as GendorCaption ,
People.Address,People.Phone,People.Email,
People.NationalityCountryID,Countries.CountryName,People.ImagePath
From People inner join Countries on People.NationalityCountryID = Countries.CountryID
Order by People.FirstName ";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally { connection.Close(); }
            return dt;
        }

        static public bool DeletePerson(int PersonID)
        {
            int AffectedRows = -1;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"delete from People where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (AffectedRows > 0);
        }

        static public bool IsPersonExist(int PersonID)
        {
            bool IsExist = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select Found =1 from People where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IsExist = true;
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsExist;
        }

        static public bool IsPersonExist(string NationalNo)
        {
            bool IsExist = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select Found =1 from People where NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IsExist = true;
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsExist;
        }

        static public bool IsNationalNoExist(string NationalNo)
        {
            bool IsExist = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select Found =1 from People where NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IsExist = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsExist;
        }

        static public bool IsEmailExist(string Email)
        {
            bool IsExist = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select Found =1 from People where Email=@Email";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", Email);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IsExist = true;
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsExist;
        }

        //static public bool SetImagePathNull(string imagePath)
        //{
        //    int AffectedRows = -1;
        //    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
        //    string query = @"update People set ImagePath=null where ImagePath=@ImagePath";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@ImagePath", imagePath);
        //    try
        //    {
        //        connection.Open();
        //        AffectedRows = command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        //  Console.WriteLine("Error" + ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return (AffectedRows > 0);
        //}
    }
    public class clsUsersData
    {
        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int NewUser = -1;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"Insert into Users (PersonID,UserName,Password,IsActive)
Values (@PersonID,@UserName,@Password,@IsActive);
select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int UserID))
                {
                    NewUser = UserID;
                }
            }
            catch (Exception ex)
            {
                clsLogger.LogError(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return NewUser;
        }
        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive)
        {
            bool IsUpdate = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"Update Users set UserName=@UserName,Password=@Password,IsActive=@IsActive where UserID=@UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    IsUpdate = true;
                }
            }
            catch { }
            finally { connection.Close(); }
            return IsUpdate;
        }
        public static bool DeleteUser(int UserID)
        {
            bool IsDelete = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"Delete From Users where UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsDelete = true;
                }
            }
            catch { }
            finally { connection.Close(); }
            return IsDelete;
        }
        public static bool FindUserByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select UserID, UserName,Password,IsActive from Users where PersonID= @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }
        public static bool FindUserByUserName(string UserName, ref int UserID, ref int PersonID, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select UserID,PersonID,Password,IsActive from Users where UserName= @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }
        public static bool FindUserByUserID(int UserID, ref string UserName, ref int PersonID, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select UserName,PersonID,Password,IsActive from Users where UserID= @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    UserName = (string)reader["UserName"];
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"SELECT Users.UserID,People.PersonID, FullName = People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName,
    Users.UserName, Users.IsActive
FROM People INNER JOIN Users ON  People.PersonID = Users.PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }
        public static bool IsActive(int UserID)
        {
            bool IsActive = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select Found =1 from Users where UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsActive = reader.HasRows;
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsActive;
        }

        public static bool IsExist(int PersonID)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select Found =1 from Users where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                IsExist = reader.HasRows;
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsExist;
        }
    }
    public class clsApplicationsTypesData
    {
        public static bool GetApplicationTypeByID(int ApplicationTypeID, ref string ApplicationTypeTitle, ref int ApplicationFees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"Select ApplicationTypeTitle,ApplicationFees from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToInt32((decimal)reader["ApplicationFees"]);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }
        public static bool UpdateApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            bool IsUpdate = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"Update ApplicationTypes set ApplicationTypeTitle=@ApplicationTypeTitle,ApplicationFees=@ApplicationFees from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            try
            {
                connection.Open();

                int UpdateRows = command.ExecuteNonQuery();
                if (UpdateRows > 0)
                {
                    IsUpdate = true;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return IsUpdate;
        }
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"Select ApplicationTypeID, ApplicationTypeTitle,Convert (int ,ApplicationFees) As ApplicationFees from ApplicationTypes";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }
    }
    public class clsTestTypesData
    {
        public static bool GetTestTypeByID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref int TestTypeFees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"Select TestTypeTitle,TestTypeDescription,TestTypeFees from TestTypes where TestTypeID=@TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = Convert.ToInt32((decimal)reader["TestTypeFees"]);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }


        public static bool UpdateTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, int TestTypeFees)
        {
            bool IsUpdate = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"Update TestTypes set TestTypeTitle=@TestTypeTitle,TestTypeDescription=@TestTypeDescription,TestTypeFees=@TestTypeFees from TestTypes where TestTypeID=@TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);

            command.Parameters.AddWithValue("@TestTypeFees", Convert.ToDecimal(TestTypeFees));
            try
            {
                connection.Open();

                int UpdateRows = command.ExecuteNonQuery();
                if (UpdateRows > 0)
                {
                    IsUpdate = true;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return IsUpdate;
        }
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"Select TestTypeID, TestTypeTitle,TestTypeDescription,CONVERT(int, TestTypeFees) AS TestTypeFees from TestTypes";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }
    }
    public class clsLocalDrivingLicenseApplicationData
    {
        public static bool GetLocalApplication(int LDLAppID, ref int ApplicationID,ref int ApplicationTypeID, ref int LicenseClassID, ref string ClassName, ref int PassedTest, ref string ApplicationStatus, ref string ApplicantName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select 
ClassName
,FullName
,PassedTestCount,
Status 
from
LocalDrivingLicenseApplications_View
where 
LocalDrivingLicenseApplicationID = @LDLAppID;
select
LicenseClassID 
from 
LocalDrivingLicenseApplications 
where
LocalDrivingLicenseApplicationID =@LDLAppID;
select
Applications.ApplicationID 
,Applications.ApplicationTypeID
from
Applications 
inner join 
LocalDrivingLicenseApplications 
on
LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
where 
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAppID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ClassName = (string)reader["ClassName"];
                    PassedTest = (int)reader["PassedTestCount"];
                    ApplicationStatus = (string)reader["Status"];
                    ApplicantName = (string)reader["FullName"];
                    if (reader.NextResult() && reader.Read())
                    {
                        LicenseClassID = (int)reader["LicenseClassID"];
                    }
                    if (reader.NextResult() && reader.Read())
                    {
                        ApplicationID = (int)reader["ApplicationID"];
                        ApplicationTypeID = Convert.ToInt32(reader["ApplicationTypeID"]);
                    }
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }
        public static int AddNewLocalLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalAppIDAdded = -1;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"Insert into LocalDrivingLicenseApplications(ApplicationID, LicenseClassID) values(@ApplicationID, @LicenseClassID);
	 select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int resultID))
                {
                    LocalAppIDAdded = resultID;
                }
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return LocalAppIDAdded;
        }
        public static DataTable GetAllLocalLicenseApplication()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select LocalDrivingLicenseApplicationID as [L.D.AppID] ,ClassName,NationalNo,FullName,ApplicationDate,PassedTestCount,Status from LocalDrivingLicenseApplications_View
";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }
        public static bool UpdateLocalApplicationStatus(int LocalDrivingLicenseApplicationID, int ApplicationStatus)
        {
            bool IsUpdate = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"Update Applications set ApplicationStatus= @ApplicationStatus  from Applications 
inner join
LocalDrivingLicenseApplications on LocalDrivingLicenseApplications.ApplicationID= Applications.ApplicationID 
						where
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND ApplicationStatus=1";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);

            try
            {
                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    IsUpdate = true;
                }
            }
            catch { }
            finally { connection.Close(); }
            return IsUpdate;
        }
        public static bool UpdateLocalApplication(int LDLAppID,int ApplicaitonID)
        {
            bool IsUpdate = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"update LocalDrivingLicenseApplications set ApplicationID = @ApplicationID
where LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicaitonID);
            command.Parameters.AddWithValue("@LDLAppID",LDLAppID);

            try
            {
                connection.Open();

                int Update = command.ExecuteNonQuery();

                if (Update > 0)
                {
                    IsUpdate = true;
                }
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return IsUpdate;
        }

        public static bool  DeleteLocalApplication(int LDLAppID)
        {
            bool IsDelete = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"delete LocalDrivingLicenseApplications where 
LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();

                if(RowsAffected>0)
                {
                    IsDelete = true;    
                }
            }
            catch { }
            finally { connection.Close(); }
            return IsDelete;
        }
        public static int IsLocalApplicationExist(int PersonID, int LicenseClassID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select ApplicationID from LocalDrivingLicenseFullApplications_View 
where
ApplicantPersonID = @PersonID and  (ApplicationTypeID =1 and (LicenseClassID = @LicenseClassID and ApplicationStatus !=2 ))";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return ApplicationID;
        }
        public static bool LocalApplicationIsCancel(int LDLAppID)
        {
            bool IsCancel = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select
found =1
from
Applications 
inner join
LocalDrivingLicenseApplications 
on
LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID 
where
(Applications.ApplicationStatus = 2
and
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =@LDLAppID)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                IsCancel = reader.HasRows;
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsCancel;
        }

    }
    public class clsApplicatationsData
    {
        public static bool GetApplication(int LDLAppID, ref int ApplicationID, ref int PersonID, ref int ApplicationTypeID, ref int CreatedByUserID, ref int ApplicationFees,
     ref DateTime StartDate, ref DateTime LastDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select ApplicationID,ApplicantPersonID,ApplicationTypeID,CreatedByUserID,PaidFees ,ApplicationDate,LastStatusDate
from
LocalDrivingLicenseFullApplications_View
where
LocalDrivingLicenseApplicationID =@LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    PersonID = (int)reader["ApplicantPersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    ApplicationFees = Convert.ToInt32((decimal)reader["PaidFees"]);
                    StartDate = (DateTime)reader["ApplicationDate"];
                    LastDate = (DateTime)reader["LastStatusDate"];
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }
        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
                               string ApplicationStatus, DateTime LastStatusDate, int PaidFees, int CreatedByUserID)
        {
            int ApplicationIDAdded = -1;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"INSERT INTO Applications
           (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
     VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
     SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            if (ApplicationStatus == "Completed")
            {
                command.Parameters.AddWithValue("@ApplicationStatus", 3);
            }
            else
            {
                command.Parameters.AddWithValue("@ApplicationStatus", 1);
            }
                command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", Convert.ToDecimal(PaidFees));
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int resultID))
                {
                    ApplicationIDAdded = resultID;
                }
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return ApplicationIDAdded;
        }

    }
    public class clsLicenseClassesData
    {
        public static bool GetLicenseClass(int ClassID, ref string ClassName, ref string ClassDescription,
            ref int MinAge, ref int DefaultVlidityLength, ref int ClassFees)
        {
            bool IsFind = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"SELECT 
      ClassName
      ,ClassDescription
      ,MinimumAllowedAge
      ,DefaultValidityLength
      ,ClassFees
  FROM 
LicenseClasses
  where
LicenseClasses.LicenseClassID = @ClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassID", ClassID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinAge = Convert.ToInt32(reader["MinimumAllowedAge"]);

                    DefaultVlidityLength = Convert.ToInt32(reader["DefaultValidityLength"]);
                    ClassFees = (Convert.ToInt32((decimal)reader["ClassFees"]));

                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFind;
        }

        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select * from LicenseClasses";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }
    }
    public class clsTestAppointmentsData
    {
        public static int AddNewAppointment(int TestTypeID, int LDLAppID, DateTime AppointmentDate, int PaidFees, int CreatedByUserID,
       string IsLocked, int RApplicationID)
        {
            int AppointmentID = -1;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"INSERT INTO TestAppointments
           (TestTypeID
           ,LocalDrivingLicenseApplicationID
           ,AppointmentDate
           ,PaidFees
           ,CreatedByUserID
           ,IsLocked
           ,RetakeTestApplicationID)
     VALUES
           (@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID);
 select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", Convert.ToDecimal(PaidFees));
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@RetakeTestApplicationID", RApplicationID > -1 ? (object)RApplicationID : DBNull.Value);
            command.Parameters.AddWithValue("@IsLocked", IsLocked == "No" ? 0 : 1);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    AppointmentID = AppID;
                }
            }
            catch
            {
                // Log the exception (ex) for further analysis
            }
            finally
            {
                connection.Close();
            }
            return AppointmentID;
        }


        public static bool UpdateAppointment(int TestAppointmentID, DateTime AppointmentDate, string IsLocked)
        {
            bool IsUpdate = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            //AppointmentDate = @AppointmentDate,

            string query = @"Update TestAppointments set IsLocked =@IsLocked where 
TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


            if (IsLocked != "No" && IsLocked != null)
            {
                command.Parameters.AddWithValue("@IsLocked", 1);
            }
            else
            {
                command.Parameters.AddWithValue("@IsLocked", 0);
            }

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsUpdate = true;
                }
            }
            catch { }
            finally
            {
                connection.Close();

            }
            return IsUpdate;
        }

        public static bool FindTestAppointment(int TestAppointmentID,ref int TestTypeID,ref int LDLAppID, ref DateTime TestAppointmentDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select
TestAppointments.TestTypeID 
,TestAppointments.LocalDrivingLicenseApplicationID
,TestAppointments.AppointmentDate
from TestAppointments
where
TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TestAppointmentDate = (DateTime)reader["AppointmentDate"];
                    TestTypeID = Convert.ToInt32(reader["TestTypeID"]);
                    LDLAppID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static void LoadAppointmentBasicInfo(int LDLAppID, int TestTypeID, ref int TestAppointmentID, ref string ClassName, ref string ApplicantName,
          ref int TrialTestNumber, ref int TestApplicationFees)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select 
Max(LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID) As LDLAppID,
Max(TestAppointments.TestAppointmentID)as TestAppointmentID,
Max(LicenseClasses.ClassName) As ClassName,
Max(CONCAT
(People.FirstName,'',People.SecondName,
'',People.ThirdName,'',People.LastName)) As ApplicantName,
Count 
(TestAppointments.TestAppointmentID) As TrialTestNumber,
Max(TestTypes.TestTypeFees) As TestAppointmentFees
from
Applications
inner join
People 
on Applications.ApplicantPersonID=People.PersonID 
inner join 
LocalDrivingLicenseApplications
on LocalDrivingLicenseApplications.ApplicationID =Applications.ApplicationID
inner join
LicenseClasses
on LocalDrivingLicenseApplications.LicenseClassID =LicenseClasses.LicenseClassID
inner join
TestAppointments 
on TestAppointments.LocalDrivingLicenseApplicationID=LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
inner join
TestTypes 
on TestAppointments.TestTypeID = TestTypes.TestTypeID
where 
(LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAppID
AND
(TestTypes.TestTypeID = @TestTypeID AND TestAppointments.IsLocked=1))
group By LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ClassName = (string)reader["ClassName"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    ApplicantName = (string)reader["ApplicantName"];
                    TrialTestNumber = (int)reader["TrialTestNumber"];
                    TestApplicationFees = Convert.ToInt32((decimal)reader["TestAppointmentFees"]);
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }
        }
        public static DataTable GetAllTestAppointments(int LDLAppID, int TestTypeID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"Select TestAppointmentID As [Appointment ID],
 CONVERT(VARCHAR(10), AppointmentDate, 103) AS [Appointment Date],Convert(int,PaidFees) As[Paid Fees],IsLocked As [Is Locked]
from TestAppointments where LocalDrivingLicenseApplicationID = @LDLAppID AND TestTypeID=@TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool TestAppointmentIsValid(int LDLAppID, int TestTypeID)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select Found = Count(*) from TestAppointments 
where 
LocalDrivingLicenseApplicationID = @LDLAppID and (TestTypeID =@TestTypeID and IsLocked =0)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsExist = (Convert.ToInt32(reader["Found"]) > 0);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsExist;
        }
    }
    public class clsTestsData
    {
        public static bool TestAppoinmentIsPassed(int TestAppointmentID)
        {
            bool IsPassed = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select Passed = Count(*) from Tests where TestAppointmentID = @TestAppointmentID and TestResult = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsPassed = (Convert.ToInt32(reader["Passed"]) > 0);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsPassed;
        }

        public static int TestAppointmentTaken(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"  Insert into Tests 
( TestAppointmentID,TestResult,Notes,CreatedByUserID)
values
(@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID);
 select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", Convert.ToInt32(TestResult));
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int TestResultID))
                {
                    TestID = TestResultID;
                }
            }
            catch { }
            finally { connection.Close(); }
            return TestID;
        }
    }
    public class clsScheduleTestAppointmentsData
    {
        public static bool GetApplicationInfo(int LDLAppID, int TestTypeID, ref string ClassName, ref int TrialNumber,
            ref string ApplicantName, ref int TestApplicationFees, ref DateTime AppointmentDate, int TestAppointmentID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select ClassName,FullName from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID = @LDLAppID;
select TestTypes.TestTypeFees from TestTypes where TestTypeID= @TestTypeID;
select AppointmentDate from TestAppointments where TestAppointmentID =@TestAppointmentID;
 select Count (*) as TrialNumber from TestAppointments where LocalDrivingLicenseApplicationID = @LDLAppID and (TestTypeID = @TestTypeID  and IsLocked =1)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ClassName = (string)reader["ClassName"];
                    ApplicantName = (string)reader["FullName"];
                }
                if (reader.NextResult() && reader.Read())
                {
                    TestApplicationFees = Convert.ToInt32((decimal)reader["TestTypeFees"]);
                }
                if (reader.NextResult() && reader.Read())
                {
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                }
                if (reader.NextResult() && reader.Read())
                {
                    TrialNumber = (int)reader["TrialNumber"];
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }

        public static bool GetRetakeApplicationInfo(int LDLAppID, ref int RApplicationID, ref int RApplicationFees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"
						 select Applications.ApplicationID 
						 from
						 Applications inner join LocalDrivingLicenseApplications 
						 on
						 LocalDrivingLicenseApplications.ApplicationID =Applications.ApplicationID 
						 where LocalDrivingLicenseApplicationID = @LDLAppID;
			
						 select TestTypes.TestTypeFees 
						 from 
						 TestTypes inner join TestAppointments
						 on
						 TestAppointments.TestTypeID = TestTypes.TestTypeID
						 inner join LocalDrivingLicenseApplications
						 on
						 TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
						 where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAppID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    RApplicationID = (int)reader["ApplicationID"];
                    if (reader.NextResult() && reader.Read())
                    {
                        IsFound = true;
                        RApplicationFees = (Convert.ToInt32((decimal)reader["TestTypeFees"]));
                    }
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }
    }
    public class clsDriversData
    {

        static public bool GetDriverByPersonID(int PersonID, ref int DriverID)
        {
            bool IsFind = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select * from Drivers where Drivers.PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFind = true;
                    DriverID = (int)reader["DriverID"];
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFind;
        }

        static public int AddDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int DriverID = -1;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"Insert Into Drivers (PersonID,CreatedByUserID,CreatedDate)
values(@PersonID,@CreatedByUserID,@CreatedDate);
select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int RowID))
                {
                    DriverID = RowID;
                }
            }
            catch { }
            finally { connection.Close(); }
            return DriverID;
        }

        static public DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select * from Drivers_View";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }

    }
    public class clsLicensesData
    {

        public static bool GetLicense(
          int applicationID,
          ref int licenseID,
          ref int driverID,
          ref int licenseClass,
          ref DateTime issueDate,
          ref DateTime expirationDate,
          ref string notes,
          ref int paidFees,
          ref bool isActive,
          ref int issueReason,
          ref int createdByUserID)
        {
            bool IsFind = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"SELECT [LicenseID],
                                    [DriverID],
                                    [LicenseClass],
                                    [IssueDate],
                                    [ExpirationDate],
                                    [Notes],
                                    [PaidFees],
                                    [IsActive],
                                    [IssueReason],
                                    [CreatedByUserID]
                             FROM [dbo].[Licenses]
                             WHERE [ApplicationID] = @applicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@applicationID", applicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;

                    licenseID = Convert.ToInt32(reader["LicenseID"]);
                    driverID = Convert.ToInt32(reader["DriverID"]);
                    licenseClass = Convert.ToInt32(reader["LicenseClass"]);
                    issueDate = Convert.ToDateTime(reader["IssueDate"]);
                    expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    notes = (reader["Notes"] == DBNull.Value) ? string.Empty : reader["Notes"].ToString();
                    paidFees = Convert.ToInt32((decimal)reader["PaidFees"]);
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    issueReason = Convert.ToInt32(reader["IssueReason"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFind;
        }

      //  public static bool GetLicenseWithID(
      //            int LicenseID,
      //ref int applicationID,

      //ref int driverID,
      //ref int licenseClass,
      //ref DateTime issueDate,
      //ref DateTime expirationDate,
      //ref string notes,
      //ref int paidFees,
      //ref bool isActive,
      //ref int issueReason,
      //ref int createdByUserID)
      //  {
      //      bool IsFind = false;

      //      SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
      //      string query = @"SELECT [ApplicationID],
      //                              [DriverID],
      //                              [LicenseClass],
      //                              [IssueDate],
      //                              [ExpirationDate],
      //                              [Notes],
      //                              [PaidFees],
      //                              [IsActive],
      //                              [IssueReason],
      //                              [CreatedByUserID]
      //                       FROM [dbo].[Licenses]
      //                       WHERE [LicenseID] = @LicenseID";
      //      SqlCommand command = new SqlCommand(query, connection);
      //      command.Parameters.AddWithValue("@LicenseID", LicenseID);
      //      try
      //      {
                
      //          connection.Open();
      //          SqlDataReader reader = command.ExecuteReader();
      //          if (reader.Read())
      //          {
      //              IsFind = true;

      //              applicationID = Convert.ToInt32(reader["ApplicationID"]);
      //              driverID = Convert.ToInt32(reader["DriverID"]);
      //              licenseClass = Convert.ToInt32(reader["LicenseClass"]);
      //              issueDate = Convert.ToDateTime(reader["IssueDate"]);
      //              expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
      //              notes = (reader["Notes"] == DBNull.Value) ? string.Empty : reader["Notes"].ToString();
      //              paidFees = Convert.ToInt32((decimal)reader["PaidFees"]);
      //              isActive = Convert.ToBoolean(reader["IsActive"]);
      //              issueReason = Convert.ToInt32(reader["IssueReason"]);
      //              createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
      //          }
      //          reader.Close();
      //      }
      //      catch { }
      //      finally { connection.Close(); }
      //      return IsFind;
      //  }


        public static bool GetLicense(int LicenseID,ref int LDLAppID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
from LocalDrivingLicenseApplications 
inner join 
Applications on LocalDrivingLicenseApplications.ApplicationID
= Applications.ApplicationID
inner join Licenses 
on
Licenses.ApplicationID = Applications.ApplicationID
where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFound = true;
                    LDLAppID = (int)reader["LocalDrivingLicenseApplicationID"];
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFound;
        }

        public static int AddLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
            DateTime ExpirationDate, string Notes, int PaidFees, bool IsActive, int IssueReason,
            int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"INSERT INTO Licenses
           (ApplicationID
           ,DriverID
           ,LicenseClass
           ,IssueDate
           ,ExpirationDate
           ,Notes
           ,PaidFees
           ,IsActive
           ,IssueReason
           ,CreatedByUserID)
     VALUES
           (@ApplicationID
           ,@DriverID
           ,@LicenseClass 
           ,@IssueDate
           ,@ExpirationDate 
           ,@Notes
           ,@PaidFees 
           ,@IsActive 
           ,@IssueReason
           ,@CreatedByUserID);
		   select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (Notes != "")
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            }
            command.Parameters.AddWithValue("@PaidFees", Convert.ToDecimal(PaidFees));
            if (IsActive == true)
            {
                command.Parameters.AddWithValue("@IsActive", 1);
            }
            else
            {
                command.Parameters.AddWithValue("@IsActive", 0);
            }

                command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int RowID))
                {
                    LicenseID = RowID;
                }

            }
            catch { }
            finally { connection.Close(); }
            return LicenseID;
        }

        //public static bool UpdateLicense()
        //{
        //    bool IsUpdate = false;

        //    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

        //    string query = @"";

        //    SqlCommand command = new SqlCommand(query, connection);




        //    try
        //    {
        //        connection.Open();

        //        int RowsAffected = command.ExecuteNonQuery();

        //        if(RowsAffected>0)
        //        {
        //            IsUpdate = true;
        //        }

        //    }
        //    catch
        //    { }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return IsUpdate;
        //}

        public static bool UpdateLicense(int LLicenseID,bool Active)
        {
            bool IsUpdate = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"Update Licenses set IsActive = @Active 
where LicenseID = @LLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LLicenseID", LLicenseID);
            command.Parameters.AddWithValue("@Active", Convert.ToInt32(Active));


            try
            {
                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();

                if(RowsAffected>0)
                {
                    IsUpdate = true;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return IsUpdate;
        }

        public static DataTable GetAllLicense(int DriverID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select 
LicenseID as [Lic.ID]
,ApplicationID as [App.ID]
,ClassName as [Class Name]
,IssueDate as [Issue Date]
,ExpirationDate as [Expiration Date]
,IsActive as [Is Active]
from
Licenses
inner join 
LicenseClasses
on 
Licenses.LicenseClass = LicenseClasses.LicenseClassID
where
DriverID = @DriverID 
order by Licenses.IsActive DESC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }

        public static DataTable GetAllLicense()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select 
LicenseID as [LicenseID]
,ApplicationID as [ApplicationID]
,ClassName as [ClassName]
,IssueDate as [IssueDate]
,ExpirationDate as [ExpirationDate]
,IsActive as [IsActive]
from
Licenses
inner join 
LicenseClasses
on 
Licenses.LicenseClass = LicenseClasses.LicenseClassID

select * from Licenses";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }

        public static DataTable GetAllLicense(short LicenseClass)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select 
LicenseID as [LicenseID]
,ApplicationID as [ApplicationID]
,ClassName as [ClassName]
,IssueDate as [IssueDate]
,ExpirationDate as [ExpirationDate]
,IsActive as [IsActive]
from
Licenses
inner join 
LicenseClasses
on 
Licenses.LicenseClass = LicenseClasses.LicenseClassID
where 
LicenseClasses.LicenseClassID>@LicenseClass
order by Licenses.IsActive DESC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }

        public static bool LicenseIsExist(int LDLAppID)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select found =1 from Licenses 
inner join
Applications 
on 
Licenses.ApplicationID= Applications.ApplicationID 
inner join
LocalDrivingLicenseApplications
on
LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
where 
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                IsExist = reader.HasRows;
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsExist;
        }

        public static bool IsActive(int LLicenseID)
        {
            bool IsActive = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            string query = @"select Licenses.IsActive  from Licenses where Licenses.LicenseID = @LLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LLicenseID", LLicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                }
                reader.Close();
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return IsActive;
        }

    }
    public class clsInternationalLicensesData
    {


        public static bool GetLicense(int LLicenseID, ref int LDLAppID, ref int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"SELECT 
    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID AS [LDLAppID],
    Applications.ApplicantPersonID AS [PersonID]
FROM 
    Applications
    INNER JOIN LocalDrivingLicenseApplications 
        ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
    INNER JOIN Licenses 
        ON Applications.ApplicationID = Licenses.ApplicationID
WHERE 
    Licenses.LicenseID = @LLicenseID;
";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LLicenseID", LLicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    LDLAppID = Convert.ToInt32(reader["LDLAppID"]);
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool GetLicense(int LLicenseID, ref int internationalLicenseID, ref int applicationID, ref int driverID,
                                   ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"SELECT [InternationalLicenseID]
                           ,[ApplicationID]
                           ,[DriverID]
                           ,[IssuedUsingLocalLicenseID]
                           ,[IssueDate]
                           ,[ExpirationDate]
                           ,[IsActive]
                           ,[CreatedByUserID]
                     FROM [dbo].[InternationalLicenses] 
                     WHERE IssuedUsingLocalLicenseID = @LLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LLicenseID", LLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    internationalLicenseID = Convert.ToInt32(reader["InternationalLicenseID"]);
                    applicationID = Convert.ToInt32(reader["ApplicationID"]);
                    driverID = Convert.ToInt32(reader["DriverID"]);
                    issueDate = Convert.ToDateTime(reader["IssueDate"]);
                    expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    isFound = true;
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return isFound;
        }




        public static int AddLicense(
            int applicationID,
            int driverID,
            int issuedUsingLocalLicenseID,
            DateTime issueDate,
            DateTime expirationDate,
            bool isActive,
            int createdByUserID)
        {
            int ILicenseID = -1;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"Insert Into InternationalLicenses 
(ApplicationID
,DriverID
,IssuedUsingLocalLicenseID
,IssueDate
,ExpirationDate
,IsActive
,CreatedByUserID)
Values 
(@ApplicationID
,@DriverID
,@IssuedUsingLocalLicenseID
,@IssueDate
,@ExpirationDate
,@IsActive
,@CreatedByUserID)
select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            // إضافة المعاملات بالقيم المناسبة
            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@DriverID", driverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            command.Parameters.AddWithValue("@IsActive",Convert.ToInt32( isActive));
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int RowID))
                {
                    ILicenseID = RowID;
                }
            }
            catch { }
            finally { connection.Close(); }
            return ILicenseID;
        }


        public static DataTable GetAlllicense(int DriverID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select 
InternationalLicenses.InternationalLicenseID as [Int.License ID]
,InternationalLicenses.ApplicationID as [Application ID]
,InternationalLicenses.IssuedUsingLocalLicenseID as [L.License ID]
,InternationalLicenses.IssueDate as [Issue Date]
,InternationalLicenses.ExpirationDate as [Expiration Date]
,InternationalLicenses.IsActive as [Is Active]
from
InternationalLicenses
where DriverID = @DriverID
order by InternationalLicenses.IsActive DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }

        public static DataTable GetAlllicense()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select 
InternationalLicenses.InternationalLicenseID as [Int.LicenseID]
,InternationalLicenses.ApplicationID as [ApplicationID]
,InternationalLicenses.DriverID as [DriverID]
,InternationalLicenses.IssuedUsingLocalLicenseID as [L.LicenseID]
,InternationalLicenses.IssueDate as [IssueDate]
,InternationalLicenses.ExpirationDate as [ExpirationDate]
,InternationalLicenses.IsActive as [IsActive]
from
InternationalLicenses
order by InternationalLicenses.IsActive DESC";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }

        public static bool IsExist(int LLicenseID,ref int ILicenseID)
        {
            bool IsFind = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select InternationalLicenseID
from
InternationalLicenses 
where 
IssuedUsingLocalLicenseID = @LocalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalLicenseID", LLicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFind = true;
                    ILicenseID = Convert.ToInt32(reader["InternationalLicenseID"]);
                }

                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsFind;
        }

    }
    public class clsDetainedLicensesData
    {


        public static bool LicenseIsDatined(int LicenseID)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            string query = @"select Found = 1 from DetainedLicenses where LicenseID =@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                IsExist = reader.HasRows;
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return IsExist;
        }
    }
}