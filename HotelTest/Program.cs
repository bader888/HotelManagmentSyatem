using HotelData;
using System;
using System.Data;

namespace HotelTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable allCountries = clsCountryData.GetAllCountries();
            foreach (DataRow row in allCountries.Rows)
            {
                Console.WriteLine("Country ID: " + row["CountryID"].ToString() + ", Country Name: " + row["CountryName"].ToString());
                // Add more logic here if needed
            }

            int countryIDToFind = 1; // Replace with the actual ID of the country you want to find
            DataTable foundCountry = clsCountryData.FindCountryByID(countryIDToFind);
            if (foundCountry.Rows.Count > 0)
            {
                DataRow countryRow = foundCountry.Rows[0];
                Console.WriteLine("Found Country: " + countryRow["CountryName"].ToString());
                // Add more logic here if needed
            }
            else
            {
                Console.WriteLine("Country not found.");
            }


        }
    }
}
