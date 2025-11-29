using ClsDVLD_Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ClsDVLD_Data_Access_Layer.clsLocalDrivingLicenseApplicationData;
using static System.Net.Mime.MediaTypeNames;

namespace ClsDVLDBusinessLayer
{
    public class clsCountry
    {
        public int ID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            this.ID = -1;
            this.CountryName = "";
        }
        public clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
        }
        public static clsCountry Find(int ID)
        {
            string CountryName = "";
            if (clsCountryData.GetCountryInfoByID(ID, ref CountryName))
            {
                return new clsCountry(ID, CountryName);
            }
            else
            {
                return null;
            }
        }
        public static clsCountry Find(string CountryName)
        {
            int ID = -1;
            if (clsCountryData.GetCountryInfoByName(CountryName, ref ID))
            {
                return new clsCountry(ID, CountryName);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
    }
    public class clsPerson
    {

        public enum enMode { AddMode = 0, UpdateMode = 1 };
        public enMode Mode = enMode.AddMode;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }

        public clsCountry CountryInfo;

        private string _ImagePath { get; set; }
        public string ImagePath
        {
            get { return _ImagePath; }
            set
            { _ImagePath = value; }
        }

        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddMode;
        }
        private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone,
            string Email, int NationalityCountryID, string ImagePath)
        {


            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.FullName = FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            this.ImagePath = ImagePath;

            Mode = enMode.UpdateMode;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.NationalNo, this.FirstName,
                this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address,
                this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return (clsPersonData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName,
                this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address,
                this.Phone, this.Email, this.NationalityCountryID, this.ImagePath));

        }
        static public clsPerson Find(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "";
            DateTime DateOfBirth = new DateTime();
            short Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            string NationalNo = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            if (clsPersonData.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                    Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
                return null;
        }
        static public clsPerson Find(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "";
            DateTime DateOfBirth = new DateTime();
            short Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int PersonID = -1;
            int NationalityCountryID = -1;
            string ImagePath = "";

            if (clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                    Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:

                    if (_AddNewPerson())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UpdateMode:

                    return _UpdatePerson();
                default:
                    return false;
            }


        }
        static public DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }
        static public bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        static public bool IsPersonExist(int ID)
        {
            return clsPersonData.IsPersonExist(ID);
        }
        static public bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }
        static public bool IsEmailExist(string Email)
        {
            return clsPersonData.IsEmailExist(Email);
        }
        static public bool IsNationalNoExist(string NationalNo)
        {
            return clsPersonData.IsNationalNoExist(NationalNo);
        }

    }
    public class clsUsers
    {
        enum enMode { AddMode = 1, UpdateMode = 2 }
        enMode _Mode = enMode.AddMode;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public clsUsers()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.UserName = "";
            this.IsActive = false;
            _Mode = enMode.AddMode;
        }
        private clsUsers(int PersonID, int UserID, string UserName, string Password, bool isActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = isActive;
            _Mode = enMode.UpdateMode;
        }
        public static clsUsers FoundUserByPersonID(int PersonID)
        {
            int UserID = -1;
            string Password = "";
            string UserName = "";
            bool IsActive = false;

            if (clsUsersData.FindUserByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUsers(PersonID, UserID, UserName, Password, IsActive);
            }
            else
                return null;
        }
        public static clsUsers FoundUserByUserID(int UserID)
        {
            string UserName = "";
            string Password = "";
            int PersonID = -1;
            bool IsActive = false;

            if (clsUsersData.FindUserByUserID(UserID, ref UserName, ref PersonID, ref Password, ref IsActive))
            {
                return new clsUsers(PersonID, UserID, UserName, Password, IsActive);
            }
            else
                return null;
        }
        public static clsUsers FoundUserByUserName(string UserName)
        {
            int UserID = -1;
            string Password = "";
            int PersonID = -1;
            bool IsActive = false;

            if (clsUsersData.FindUserByUserName(UserName, ref UserID, ref PersonID, ref Password, ref IsActive))
            {
                return new clsUsers(PersonID, UserID, UserName, Password, IsActive);
            }
            else
                return null;
        }
        private bool _AddNewUser()
        {
            this.UserID = clsUsersData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return (this.UserID > -1);
        }
        private bool _UpdateUser()
        {
            return (clsUsersData.UpdateUser(this.UserID, this.UserName, this.Password, this.IsActive));
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:

                    if (_AddNewUser())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UpdateMode:

                    return _UpdateUser();
                default: return false;
            }
        }
        public static bool DeleteuserByID(int UserID)
        {
            return clsUsersData.DeleteUser(UserID);
        }
        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }
        public static bool IsUserActive(int UserID)
        {
            return clsUsersData.IsActive(UserID);
        }
        public static bool IsUserExist(int PersonID)
        {
            return clsUsersData.IsExist(PersonID);
        }
    }
    public class clsApplicationTypes
    {


        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public int ApplicationFees { get; set; }



        private clsApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, int ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public static clsApplicationTypes FoundApplicationByID(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            int ApplicationFees = default;

            if (clsApplicationsTypesData.GetApplicationTypeByID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else { return null; }
        }
        public bool Update()
        {
            return (clsApplicationsTypesData.UpdateApplicationTypes(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees));

        }
        public static DataTable ListApplicationTypes()
        {
            return clsApplicationsTypesData.GetAllApplicationTypes();
        }

    }
    public class clsTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public int TestTypeFees { get; set; }

        private clsTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, int TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }
        public static clsTestTypes FindTestTypeByID(int TestTypeID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            int TestTypeFees = default;

            if (clsTestTypesData.GetTestTypeByID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestTypes(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            else { return null; }
        }
        public bool Update()
        {
            return (clsTestTypesData.UpdateTestTypes(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees));
        }
        public static DataTable ListTestTypes()
        {
            return clsTestTypesData.GetAllTestTypes();
        }

    }
    public class clsLicenseClasses
    {
        public int ClassID { get; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public int ClassFees { get; set; }

        private clsLicenseClasses(int ClassID, string ClassName, string ClassDescription,
            int MinimumAllowedAge, int DefaultValiditylength, int ClassFees)
        {
            this.ClassID = ClassID;
            this.ClassName = ClassName;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValiditylength;
            this.ClassFees = ClassFees;
        }

        public static clsLicenseClasses Find(int ClassID)
        {
            string ClassName = "";
            string ClassDescription = "";
            int MinimumAllowedAge = -1;
            int DefaultValidityLength = -1;
            int ClassFees = -1;
            if (clsLicenseClassesData.GetLicenseClass(ClassID, ref ClassName, ref ClassDescription,
                ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClasses(ClassID, ClassName, ClassDescription, MinimumAllowedAge,
                    DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }
        public static DataTable ListLicenseClasses()
        {
            return clsLicenseClassesData.GetAllLicenseClasses();
        }
    }
    public class clsLocalDrivingLicenseApplication
    {
         enum enMode {AddMode =0,UpdateMode = 1};
        enMode Mode = enMode.AddMode;

        public int LDLAppID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public int PassedTest { get; set; }
        public string ApplicationStatus { get; set; }
        public string ApplicantName { get; set; }
        public int PersonID { get; set; }
        public int ApplicationFees { get; set; }
        public int createdByUserID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsLocalDrivingLicenseApplication()
        {
            this.PersonID = -1;
            this.ApplicationFees = -1;
            this.createdByUserID = -1;
            this.ApplicationTypeID = -1;
            this.ApplicationDate = DateTime.Now;
            this.LastDate = DateTime.Now;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
            this.ApplicationStatus = "New";
            Mode = enMode.AddMode;
        }
        private clsLocalDrivingLicenseApplication(int LDLAppID, int ApplicationID,int ApplicationTypeID, int LicenseClassID, string ClassName, int PassedTest, string ApplicationStatus, string ApplicantName)
        {
            this.LDLAppID = LDLAppID;
            this.ApplicationID = ApplicationID;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ClassName = ClassName;
            this.LicenseClassID = LicenseClassID;
            this.PassedTest = PassedTest;
            this.ApplicationStatus = ApplicationStatus;
            this.ApplicantName = ApplicantName;
            Mode = enMode.UpdateMode;
        }
        public static clsLocalDrivingLicenseApplication FoundLocalLicenseApplication(int LDLAppID)
        {
            string ClassName = "";
            int PassedTest = -1;
            string ApplicationStatus = "";
            string ApplicantName = "";
            int LicenseClassID = -1;
            int ApplicationID = -1;
            int ApplicationTypeID = -1;

            if (clsLocalDrivingLicenseApplicationData.GetLocalApplication(LDLAppID, ref ApplicationID,ref ApplicationTypeID, ref LicenseClassID, ref ClassName, ref PassedTest, ref ApplicationStatus, ref ApplicantName))
            {
                return new clsLocalDrivingLicenseApplication(LDLAppID, ApplicationID, ApplicationTypeID, LicenseClassID, ClassName, PassedTest, ApplicationStatus, ApplicantName);
            }
            else
                return null;
        }
        private bool _AddNewLocalLicense()
        {
            this.ApplicationID = clsApplicatationsData.AddNewApplication(this.PersonID, this.ApplicationDate, this.ApplicationTypeID,
                this.ApplicationStatus, this.LastDate, this.ApplicationFees, this.createdByUserID);

            if (this.ApplicationID > -1 && this.ApplicationTypeID != 7)
            {
                this.LDLAppID = clsLocalDrivingLicenseApplicationData.AddNewLocalLicenseApplication(this.ApplicationID, this.LicenseClassID);
                return (this.LDLAppID > -1);
            }
            else if (this.ApplicationID > -1)
            {
                return true;
            }
            {
                return false;
            }
        }

        private bool _UpdateLocalLicense()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalApplication(this.LDLAppID,this.ApplicationID);
        }

        public static DataTable ListLocalLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalLicenseApplication();
        }
        public static bool UpdateLocalApplicationStatus(int LDLAppID, int ApplicationStatus)
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalApplicationStatus(LDLAppID, ApplicationStatus);
        }
        public static bool DeleteApplication(int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationData.DeleteLocalApplication(LDLAppID);
        }
        public static int IsApplicationExist(int PersonID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationData.IsLocalApplicationExist(PersonID, LicenseClassID);
        }
        public static bool LocalApplicationIsCancel(int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationData.LocalApplicationIsCancel(LDLAppID);
        }
        public bool Save()
        {
            switch(Mode )
            {
                case enMode.AddMode:
                    
                    if(_AddNewLocalLicense())
                    {
                        return true;
                    }
                    return false;

                case enMode.UpdateMode:

                    return _UpdateLocalLicense();

                default:
                    return false;
            }

        }
    }
    public class clsApplicatations
    {
        public int LDLAppID { get; set; }
        public int ApplicationID { get; set; }
        public int PersonID { get; set; }
        public int ApplicationTypeID { get; set; }
        public int CreatedByUserID { get; set; }
        public int ApplicationFees { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastDate { get; set; }
        public string ApplicationStatus { get; set; }

        public clsLocalDrivingLicenseApplication LocalLicenseApplication;
        public clsUsers UserInfo;
        public clsApplicationTypes ApplicationTypeInfo;

        public clsApplicatations()
        {

        }
        private clsApplicatations(int LDLAppID, int ApplicationID, int PersonID, int ApplicationTypeID, int CreatedByUserID, int ApplicationFees, DateTime ApplicationDate, DateTime LastDate)
        {
            this.LDLAppID = LDLAppID;
            this.ApplicationID = ApplicationID;
            this.PersonID = PersonID;
            this.ApplicationTypeID = ApplicationTypeID;
            this.CreatedByUserID = CreatedByUserID;
            ApplicationTypeInfo = clsApplicationTypes.FoundApplicationByID(ApplicationTypeID);
            UserInfo = clsUsers.FoundUserByUserID(CreatedByUserID);
            LocalLicenseApplication = clsLocalDrivingLicenseApplication.FoundLocalLicenseApplication(LDLAppID);
            this.ApplicationStatus = LocalLicenseApplication.ApplicationStatus;
            this.ApplicationFees = ApplicationFees;
            this.ApplicationDate = ApplicationDate;
            this.LastDate = LastDate;

        }
        public static clsApplicatations FoundApplication(int LDLAppID)
        {
            int ApplicationID = -1;
            int ApplicationTypeID = -1;
            int PersonID = -1;
            int CreatedByUserID = -1;
            int ApplicationFees = -1;
            DateTime ApplicationDate = new DateTime();
            DateTime LastDate = new DateTime();
            if (clsApplicatationsData.GetApplication(LDLAppID, ref ApplicationID, ref PersonID, ref ApplicationTypeID, ref CreatedByUserID, ref ApplicationFees, ref ApplicationDate, ref LastDate))
            {
                return new clsApplicatations(LDLAppID, ApplicationID, PersonID, ApplicationTypeID, CreatedByUserID, ApplicationFees, ApplicationDate, LastDate);
            }
            else
                return null;
        }
        private bool _Add()
        {
            this.ApplicationID = clsApplicatationsData.AddNewApplication(this.PersonID, this.ApplicationDate, this.ApplicationTypeID,
               this.ApplicationStatus, this.LastDate, this.ApplicationFees, this.CreatedByUserID);
            return (this.ApplicationID > -1);
        }

        public bool Save()
        {
            if(_Add())
            {
                return true;
            }
            return false;
        }


        //public static clsApplicatations FoundApplication(int ApplicationID)
        //{
        //    int ApplicationID = -1;
        //    int ApplicationTypeID = -1;
        //    int PersonID = -1;
        //    int CreatedByUserID = -1;
        //    int ApplicationFees = -1;
        //    DateTime ApplicationDate = new DateTime();
        //    DateTime LastDate = new DateTime();
        //    if (clsApplicatationsData.GetApplication(LDLAppID, ref ApplicationID, ref PersonID, ref ApplicationTypeID, ref CreatedByUserID, ref ApplicationFees, ref ApplicationDate, ref LastDate))
        //    {
        //        return new clsApplicatations(LDLAppID, ApplicationID, PersonID, ApplicationTypeID, CreatedByUserID, ApplicationFees, ApplicationDate, LastDate);
        //    }
        //    else
        //        return null;
        //}

    }
    public class clsTestAppointments
    {
        enum enMode { AddMode = 1, UpdateMode = 2 };
        private enMode _Mode = enMode.AddMode;

        public int LDLAppID { get; set; }
        public int AppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public string ClassName { get; set; }
        public string ApplicantName { get; set; }
        public int trialTestNumber { get; set; }
        public int TestAppointmentFees { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int CreatedBy { get; set; }
        public string IsLocked { get; set; }
        public int RApplicationID { get; set; }

        public clsTestAppointments()
        {


            this.LDLAppID = -1;
            this.AppointmentID = -1;
            this.TestTypeID = -1;
            this.ClassName = "";
            this.ApplicantName = "";
            this.trialTestNumber = -1;
            this.TestAppointmentFees = -1;
            this.AppointmentDate = DateTime.Now;
            this.CreatedBy = -1;
            this.IsLocked = "No";
            this.RApplicationID = -1;
            _Mode = enMode.AddMode;

        }
        private clsTestAppointments(int LDLAppID, int TestTypeID, int TestAppointmentID, string ClassName, string ApplicantName,
              int trialTestNumber, int TestAppointmentFees)
        {
            this.LDLAppID = LDLAppID;
            this.TestTypeID = TestTypeID;
            this.AppointmentID = TestAppointmentID;
            this.ClassName = ClassName;
            this.ApplicantName = ApplicantName;
            this.trialTestNumber = trialTestNumber;
            this.TestAppointmentFees = TestAppointmentFees;
            _Mode = enMode.UpdateMode;

        }
        private clsTestAppointments(int TestTypeID,int LDLAppID, DateTime AppointmentDate)
        {
            this.AppointmentDate = AppointmentDate;
            this.TestTypeID = TestTypeID;
            this.LDLAppID = LDLAppID;
            _Mode = enMode.UpdateMode;
        }

        private bool _AddNewTestAppointment()
        {
            this.AppointmentID = clsTestAppointmentsData.AddNewAppointment(this.TestTypeID, this.LDLAppID, this.AppointmentDate,
                this.TestAppointmentFees, this.CreatedBy, this.IsLocked, this.RApplicationID);
            return (this.AppointmentID > -1);
        }

        private bool _UpdateTestAppointment()
        {
            return (clsTestAppointmentsData.UpdateAppointment(this.AppointmentID, this.AppointmentDate, this.IsLocked));
        }

        public static clsTestAppointments FoundTestAppointmentData(int TestAppointmentID)
        {
            DateTime AppointmentDate = new DateTime();
            int TestTypeID = -1;
            int LDLAppID = -1;

            if (clsTestAppointmentsData.FindTestAppointment(TestAppointmentID,ref TestTypeID,ref LDLAppID, ref AppointmentDate))
            {
                return new clsTestAppointments(TestTypeID,LDLAppID, AppointmentDate);
            }
            else
            {
                return null;
            }
        }

        public static clsTestAppointments FoundTestAppointmentBasicInfo(int LDLAppID, int TestTypeID)
        {
            string ClassName = "";
            string ApplicantName = "";
            int TestAppointmentID = -1;
            int trialTestNumber = -1;
            int TestAppointmentFees = -1;
            clsTestAppointmentsData.LoadAppointmentBasicInfo(LDLAppID, TestTypeID, ref TestAppointmentID, ref ClassName,
                ref ApplicantName, ref trialTestNumber, ref TestAppointmentFees);
            return new clsTestAppointments(LDLAppID, TestTypeID, TestAppointmentID, ClassName, ApplicantName,
                trialTestNumber, TestAppointmentFees);
        }

        public static DataTable ListTestAppointment(int LDLAppID, int TestTypeID)
        {
            return clsTestAppointmentsData.GetAllTestAppointments(LDLAppID, TestTypeID);
        }

        public static bool TestAppointmentIsValid(int LDLAppID, int TestTypeID)
        {
            return clsTestAppointmentsData.TestAppointmentIsValid(LDLAppID, TestTypeID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (!_AddNewTestAppointment())
                    {
                        return false;
                    }
                    _Mode = enMode.UpdateMode;
                    return true;

                case enMode.UpdateMode:
                    return _UpdateTestAppointment();

                default: return false;
            }
        }

    }
    public class clsScheduleTestAppointments
    {
        public int LDLAppID { get; set; }
        public int TestAppointmentID { get; set; }
        public int ApplicationID { get; set; }
        public int TestTypeID { get; set; }
        public string ClassName { get; set; }
        public string ApplicantName { get; set; }
        public int trialTestNumber { get; set; }
        public int TestAppointmentFees { get; set; }
        public int ApplicationFees { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int CreatedBy { get; set; }
        public string IsLocked { get; set; }

        public clsScheduleTestAppointments()
        {
            this.LDLAppID = -1;
            this.TestTypeID = -1;
            this.ClassName = "";
            this.ApplicantName = "";
            this.trialTestNumber = -1;
            this.TestAppointmentFees = -1;
            this.AppointmentDate = DateTime.Now;
            this.CreatedBy = -1;
            this.IsLocked = "No";
        }
        private clsScheduleTestAppointments(int LDLAppID, int TestTypeID, string ClassName, int trialTestNumber, string ApplicantName,
               int TestAppointmentFees, DateTime AppointmentDate, int TestAppointmentID)
        {
            this.LDLAppID = LDLAppID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.ClassName = ClassName;
            this.ApplicantName = ApplicantName;
            this.trialTestNumber = trialTestNumber;
            this.TestAppointmentFees = TestAppointmentFees;
            this.AppointmentDate = AppointmentDate;
        }
        private clsScheduleTestAppointments(int LDLAppID, int ApplicationID, int ApplicationFees)
        {
            this.LDLAppID = LDLAppID;
            this.ApplicationID = ApplicationID;
            this.ApplicationFees = ApplicationFees;
        }
        public static clsScheduleTestAppointments FindApplicationInfo(int LDLAppID, int TestTypeID, int TestAppointmentID)
        {
            string ClassName = "";
            string ApplicantName = "";
            int trialTestNumber = -1;
            int TestAppointmentFees = -1;
            DateTime AppointmentDate = DateTime.Now;
            clsScheduleTestAppointmentsData.GetApplicationInfo(LDLAppID, TestTypeID, ref ClassName, ref trialTestNumber,
                ref ApplicantName, ref TestAppointmentFees, ref AppointmentDate, TestAppointmentID);
            return new clsScheduleTestAppointments(LDLAppID, TestTypeID, ClassName, trialTestNumber,
                ApplicantName, TestAppointmentFees, AppointmentDate, TestAppointmentID);
        }

        public static clsScheduleTestAppointments FindRetakeApplicationInfo(int LDLAppID)
        {
            int RApplicationID = -1;
            int ApplicationFees = -1;

            if (clsScheduleTestAppointmentsData.GetRetakeApplicationInfo(LDLAppID, ref RApplicationID, ref ApplicationFees))
            {
                return new clsScheduleTestAppointments(LDLAppID, RApplicationID, ApplicationFees);
            }
            return null;
        }
    }
    public class clsTests
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        private int _ApplicationsStatus = -1;
        public clsTestAppointments TestAppointment;

        public static bool TestAppointmentIsPassed(int TestAppointmentID)
        {
            return clsTestsData.TestAppoinmentIsPassed(TestAppointmentID);
        }
        private bool _AddTest()
        {
            this.TestID = clsTestsData.TestAppointmentTaken(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            TestAppointment = clsTestAppointments.FoundTestAppointmentData(this.TestAppointmentID);
            if (TestTypeID == 3 && TestResult == true)
            {
                clsLocalDrivingLicenseApplication.UpdateLocalApplicationStatus(TestAppointment.LDLAppID, TestAppointment.TestTypeID);
            }
            TestAppointment.IsLocked = "Yes";
            TestAppointment.AppointmentID = TestAppointmentID;

            return (this.TestID > -1 && TestAppointment.Save());
        }
        public bool Save()
        {
            return _AddTest();
        }
    }

    public class clsDrivers
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CratedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }


        public clsDrivers()
        {
            this.PersonID = -1;
            this.CratedByUserID = -1;
            this.CreatedDate = DateTime.Now;
        }

        private clsDrivers(int DriverID)
        {
            this.DriverID = DriverID;
        }

        public static clsDrivers Find(int PersonID)
        {
            int DriverID = -1;

            if (clsDriversData.GetDriverByPersonID(PersonID, ref DriverID))
            {
                return new clsDrivers(DriverID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddDriver()
        {
            this.DriverID = clsDriversData.AddDriver(this.PersonID, this.CratedByUserID, this.CreatedDate);
            return (this.DriverID > -1);
        }

        public bool Save()
        {
            return _AddDriver();
        }

        public static DataTable ListDrivers()
        {
            return clsDriversData.GetAllDrivers();
        }

    }

    public class clsLicenses
    {
        enum enMode { AddMode = 1, UpdateMode = 2 }

        enMode _Mode = enMode.AddMode;
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int LDLAppID { get; set; }
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public int PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int CreatedByUserID { get; set; }



        public clsLicenses()
        {
            this.LicenseID =
            this.ApplicationID = -1;
            this.LDLAppID = -1;
            this.DriverID = -1;
            this.PersonID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = -1;
            this.IsActive = true;
            this.IssueReason = -1;
            this.CreatedByUserID = -1;
            _Mode = enMode.AddMode;
        }


        private clsLicenses(int applicationID, int licenseID, int driverID, int licenseClass, DateTime issueDate,
DateTime expirationDate, string notes, int paidFees, bool isActive, int issueReason, int createdByUserID)
        {
            this.ApplicationID = applicationID;
            this.LicenseID = licenseID;
            this.DriverID = driverID;
            this.LicenseClass = licenseClass;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.Notes = notes;
            this.PaidFees = paidFees;
            this.IsActive = isActive;
            this.IssueReason = issueReason;
            this.CreatedByUserID = createdByUserID;
        }
        private clsLicenses (int LicenseID,int LDLAppID)
        {
            this.LicenseID = LicenseID;
            this.LDLAppID = LDLAppID;


        }

        static public clsLicenses Find(int applicationID)
        {
            int licenseID = -1;
            int driverID = -1;
            int licenseClass = -1;
            DateTime issueDate = new DateTime();
            DateTime expirationDate = new DateTime();
            string notes = "";
            int paidFees = -1;
            bool isActive = false;
            int issueReason = -1;
            int createdByUserID = -1;

            if (clsLicensesData.GetLicense(applicationID, ref licenseID, ref driverID, ref licenseClass,
                    ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicenses(applicationID, licenseID, driverID, licenseClass, issueDate, expirationDate, notes, paidFees, isActive, issueReason, createdByUserID);
            }
            else
                return null;
        }

        //static public clsLicenses FindWithID(int LicenseID)
        //{
        //    int ApplicationID = -1;
        //    int driverID = -1;
        //    int licenseClass = -1;
        //    DateTime issueDate = new DateTime();
        //    DateTime expirationDate = new DateTime();
        //    string notes = "";
        //    int paidFees = -1;
        //    bool isActive = false;
        //    int issueReason = -1;
        //    int createdByUserID = -1;

        //    if (clsLicensesData.GetLicenseWithID(LicenseID, ref ApplicationID, ref driverID, ref licenseClass,
        //            ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
        //    {
        //        return new clsLicenses(ApplicationID, LicenseID, driverID, licenseClass, issueDate, expirationDate, notes, paidFees, isActive, issueReason, createdByUserID);
        //    }
        //    else
        //        return null;
        //}
        private bool _AddLicense()
        {
            this.LicenseID = clsLicensesData.AddLicense(this.ApplicationID, this.DriverID, this.LicenseClass,
                    this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive,
                    this.IssueReason, this.CreatedByUserID);
            return (this.LicenseID > -1);
        }
        public static clsLicenses  FindLocalLicenseID (int LicenseID)
        {
            int LDLAppID = -1;

            if (clsLicensesData.GetLicense(LicenseID, ref LDLAppID))
            {
                return new clsLicenses(LicenseID,LDLAppID);
            }
            else
            {
                return null;
            }
        }

        //private bool _UpdateLicense()
        //{
        //    return clsLicensesData.Update();
        //}

        public static bool  UpdateActivateLicense(int LLicenseID,bool Active)
        {
            return clsLicensesData.UpdateLicense(LLicenseID, Active);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddLicense())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {

                        return false;
                    }
                case enMode.UpdateMode:

                        //return _UpdateLicense;

                default:
                    return false;
            }
        }
        public static DataTable ListLicense(int DriverID)
        {
            return clsLicensesData.GetAllLicense(DriverID);
        }
        public static DataTable ListLicense()
        {
            return clsLicensesData.GetAllLicense();
        }
        public static DataTable ListLicenseMoreThanTow(short LicenseClass=2)
        {
            return clsLicensesData.GetAllLicense(LicenseClass);
        }

        public static bool LicenseIsExist(int LDLAppID)
        {
            return clsLicensesData.LicenseIsExist(LDLAppID);
        }
        public static bool LicenseIsActive(int LLicenseID)
        {
            return clsLicensesData.IsActive(LLicenseID);
        }
    }

    public class clsInternationalLicenses
    {
        public int ILicenseID { get; set; }
        public int LDLAppID { get; set; }
        public int PersonID { get; set; }
        public int ApplicationID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public string ApplicationStatus { get; set; }
        public DateTime LastDate { get; set; }
        public int ApplicationFees { get; set; }
        public int CreatedByUserID { get; set; }
        public int DriverID { get; set; }
        public int LLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }


        public clsInternationalLicenses()
        {
            ILicenseID = -1;
            PersonID = -1;
            ApplicationID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = "New";
            LastDate = DateTime.Now.AddYears(1);
            ApplicationFees = -1;
            CreatedByUserID = -1;
            DriverID = -1;
            LLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now.AddYears(1);
            IsActive = true ;
        }


        private clsInternationalLicenses(int applicationID, int driverID, int LLicenseID,
                                          DateTime issueDate, DateTime expirationDate, bool isActive,
                                          int createdByUserID, int internationalLicenseID)
        {
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.LLicenseID = LLicenseID;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.IsActive = isActive;
            this.CreatedByUserID = createdByUserID;
            this.ILicenseID = internationalLicenseID;
        }
        private clsInternationalLicenses(int LDLAppID,int PersonID)
        {
            this.LDLAppID = LDLAppID;
            this.PersonID = PersonID;
        }



        public static clsInternationalLicenses Find(int LLicenseID)
        {
            int internationalLicenseID = -1;
            int applicationID = -1;
            int driverID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            bool isActive = false;
            int createdByUserID = -1;

            if (clsInternationalLicensesData.GetLicense(LLicenseID,
                                                         ref internationalLicenseID,
                                                         ref applicationID,
                                                         ref driverID,
                                                         ref issueDate,
                                                         ref expirationDate,
                                                         ref isActive,
                                                         ref createdByUserID))
            {
                return new clsInternationalLicenses(applicationID, driverID, LLicenseID, issueDate, expirationDate, isActive, createdByUserID, internationalLicenseID);
            }
            else
            {
                return null;
            }
        }

        public static clsInternationalLicenses Find (int LLicenseID, bool yes= true)
        {
            int LDLAppID = -1;
            int PersonID = -1;

            if(clsInternationalLicensesData.GetLicense(LLicenseID,ref LDLAppID,ref PersonID))
            {
                return new clsInternationalLicenses(LDLAppID, PersonID);
            }
            else
            {
                return null;
            }
        }




        private bool _AddNewInterLicense()
        {
            this.ApplicationID = clsApplicatationsData.AddNewApplication(this.PersonID, this.ApplicationDate, this.ApplicationTypeID,
                this.ApplicationStatus, this.LastDate, this.ApplicationFees, this.CreatedByUserID);

            if (this.ApplicationID > -1)
            {

                this.ILicenseID = clsInternationalLicensesData.AddLicense(this.ApplicationID,this.DriverID,this.LLicenseID,IssueDate,this.ExpirationDate,this.IsActive,this.CreatedByUserID);
                return (this.ILicenseID > -1);
            }
            else if (this.ApplicationID > -1)
            {
                return true;
            }
            {
                return false;
            }
        }

        public bool Save()
        {
            return _AddNewInterLicense();
        }

        public static DataTable ListInternationalLicense(int DriverID)
        {
            return clsInternationalLicensesData.GetAlllicense(DriverID);
        }
        public static DataTable ListInternationalLicense()
        {
            return clsInternationalLicensesData.GetAlllicense();
        }

        public  bool IsExist(int LLicenseID)
        {
            int ILicenseID = -1;
            if( clsInternationalLicensesData.IsExist(LLicenseID,ref ILicenseID))
            {
                this.ILicenseID = ILicenseID;
            }
            return (ILicenseID > -1);
        }

    }

    public class clsDetainedLicenses
    {
        public static bool LicenseIsDetained(int LicenseID)
        {
            return clsDetainedLicensesData.LicenseIsDatined(LicenseID);
        }
    }
}










