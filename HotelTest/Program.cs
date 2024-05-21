using HotelLogic;
using System;
using System.Data;

class Program
{
    static void Main()
    {
        clsRoomRate clsRoomRate = new clsRoomRate();

        clsRoomRate.score = 0;
        clsRoomRate.description = "pla pla";
        clsRoomRate.customerID = 10;
        clsRoomRate.roomID = 40;

        if (clsRoomRate.Save())
        {
            Console.WriteLine("Add done with id " + clsRoomRate.rateID);
        }

        clsRoomRate.score = 10;
        if (clsRoomRate.Save())
        {
            Console.WriteLine("update done with id " + clsRoomRate.rateID);
        }

        Console.WriteLine();
        Console.WriteLine(clsRoomRate.FindRoomRateByID(1).description);
        Console.WriteLine();

        foreach (DataRow row in clsRoomRate.GetAllRoomRate().Rows)
            Console.WriteLine(row.Field<string>("Description"));


    }
}
