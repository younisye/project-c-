using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project_C_sharp
{
    internal class CarManager
    {
        public void ShowAllCarsData()
        {
            Console.WriteLine("-------- High-Cars --------");
            ShowCarData("h.txt");

            Console.WriteLine("\n-------- Middle-Cars --------");
            ShowCarData("m.txt");

            Console.WriteLine("\n-------- Low-Cars --------");
            ShowCarData("l.txt");

        }

        private void ShowCarData(string fileName)
        {
            //string[] carData = File.ReadAllText(fileName).Split('*');
            //foreach (var carInfo in carData)
            //{
            //    string[] carDetails = carInfo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    //Validate that carDetails array has at least 4 elements before accessing them
            //    if (carDetails.Length >= 4)
            //    {
            //        Console.WriteLine($"ID: {carDetails[0]}, Name: {carDetails[1]}, Color: {carDetails[2]}, Price: {carDetails[3]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Invalid data format: {carInfo}");
            //    }
            //}
        }

    }
}
