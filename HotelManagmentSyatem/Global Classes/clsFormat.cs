using System;

namespace HotelManagmentSyatem.Global_Classes
{
    public class clsFormat
    {
        public static string DateToShort(DateTime Dt1)
        {

            return Dt1.ToString("dd/MMM/yyyy");
        }
        public static string DateToFullDetailsWithOutTime(DateTime date)
        {
            // Format the date as "ddd/dd/MMMM/yyyy"
            return date.ToString("ddd, dd, MMMM, yyyy");


        }

        public static string DateCustomFormate(DateTime date, string Formate)
        {
            // Format the date as "ddd/dd/MMMM/yyyy"
            return date.ToString(Formate);


        }


    }
}
