using HotelData;
using System.Data;

namespace HotelLogic
{
    public class clsUserLogin
    {
        public static DataTable GetAllUserLogin()
        {
            return clsUserLoginData.GetAllUserLogins();
        }
    }
}
