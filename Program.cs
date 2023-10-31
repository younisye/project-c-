using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_sharp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager();
            char s;

            do
            {
            B:
                Console.Clear();
                Console.WriteLine("----------LAITH's cars -------------");
                Console.WriteLine("********* Menu OF Cars ************* " +
                                  "\n \t 1- add Car TO High \n \t 2- add Car TO Middle \n \t 3- add Car TO Low" +
                                  "\n \t 4- show Car From Middle \n \t 5- show Car From Low \n \t 6- show Car From High\n \t 7- search by ID\n \t 8- To exit \n \t 9- Show All Cars");

                int ch;
                Console.WriteLine("Enter Number of Choice From Menu:");
                try
                {
                    ch = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    goto B;
                }

                Console.Clear();
                String name = "", color = "";
                int id = 1;
                double price = 0;
                if (ch == 1 || ch == 2 || ch == 3)
                {
                    Console.WriteLine("Enter Name OF Cars ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Color OF Cars ");
                    color = Console.ReadLine();
                    Console.WriteLine("Enter Id OF Cars ");
                I:
                    try
                    {
                        id = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You must enter a number for ID. Please enter again ...");
                        goto I;
                    }
                    Console.WriteLine("Enter Price OF Cars ");
                P:
                    try
                    {
                        price = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You must enter a valid price. Please enter again ...");
                        goto P;
                    }
                }

                Console.Clear();
                switch (ch)
                {
                    case 1:
                        High h = new High();
                        h.Name = name;
                        h.Id = id;
                        h.Price = price;
                        h.Color = color;
                        h.Add_data();
                        Console.WriteLine(" Done to High");
                        break;
                    case 2:
                        Middle m = new Middle();
                        m.Name = name;
                        m.Id = id;
                        m.Price = price;
                        m.Color = color;
                        m.Add_data();
                        Console.WriteLine(" Done to Middle");
                        break;
                    case 3:
                        Low l = new Low();
                        l.Name = name;
                        l.Id = id;
                        l.Price = price;
                        l.Color = color;
                        l.Add_data();
                        Console.WriteLine(" Done to Low");
                        break;
                    case 4:
                        Middle mm = new Middle();
                        String[] arr = mm.Show_result();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            try
                            {
                                String[] ss = arr[i].Split(' ');
                                Console.WriteLine("id is : " + ss[0] + " " +
                                                  "  and name Cars is : " + ss[1] +
                                                  "  price is :" + ss[3] +
                                                  "  and color is " + ss[2]);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("  ");
                            }
                        }
                        break;
                    case 5:
                        Low ll = new Low();
                        String[] arr1 = ll.Show_result();
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            try
                            {
                                String[] ss1 = arr1[i].Split(' ');
                                Console.WriteLine("ID is : " + ss1[0] + " " +
                                                  "  and NAME Cars is : " + ss1[1] +
                                                  "  PRICE is :" + ss1[3] +
                                                  "  and COLOR is " + ss1[2]);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("  ");
                            }
                        }
                        break;
                    case 6:
                        High hh = new High();
                        String[] arr2 = hh.Show_result();
                        for (int i = 0; i < arr2.Length; i++)
                        {
                            try
                            {
                                String[] ss2 = arr2[i].Split(' ');
                                Console.WriteLine("id is : " + ss2[0] + " " +
                                                  "  and name Cars is : " + ss2[1] +
                                                  "  price is :" + ss2[3] +
                                                  "  and color is " + ss2[2]);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("  ");
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("enter id ");
                        int new_id = int.Parse(Console.ReadLine());
                        High hh1 = new High();
                        Middle hh2 = new Middle();
                        Low hh3 = new Low();
                        String[] l1 = hh1.Show_result();
                        String[] l2 = hh2.Show_result();
                        String[] l3 = hh3.Show_result();
                        for (int i = 0; i < l1.Length; i++)
                        {
                            if (l1[i].Contains(new_id.ToString()))
                                Console.WriteLine(l1[i]);
                        }
                        for (int i = 0; i < l2.Length; i++)
                        {
                            if (l2[i].Contains(new_id.ToString()))
                                Console.WriteLine(l2[i]);
                        }
                        for (int i = 0; i < l3.Length; i++)
                        {
                            if (l3[i].Contains(new_id.ToString()))
                                Console.WriteLine(l3[i]);
                        }
                        break;
                    case 8:
                        return;
                    case 9:
                        carManager.ShowAllCarsData();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\n \n to show menu enter y , or any character to exit ...");
                s = char.Parse(Console.ReadLine());
            } while (s == 'y');

            Console.ReadKey();
        }
    }
}

