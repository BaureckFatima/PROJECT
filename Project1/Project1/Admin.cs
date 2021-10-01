using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{ 
    
    class Admin : Program
    {
        private static readonly int options, menu;

        public static void chooseFile()
        {
            Console.Clear();
            Console.WriteLine("1.2 Welcome to Admin Mode!");
            Console.WriteLine("\nFILES\n");
            //Use of Dictionary to store key/value pairs
            Dictionary<int, string> MyCSV = new Dictionary<int, string>();

            MyCSV.Add(1, "Experience");
            MyCSV.Add(2, "Description");
            MyCSV.Add(3, "Year1");

            foreach (KeyValuePair<int, string> element in MyCSV)
            {
                Console.WriteLine("{0} --> {1}", element.Key, element.Value);
            }

            Console.WriteLine("\nChoose a CSV file from above to perform UPDATE operation:");
            Console.ReadLine();

            Console.WriteLine("\nEnter additional details: ");
            string a = Console.ReadLine();
            //Use of string interpolation to format and manipulate strings
            File.AppendAllText(@"..\\csv\\description.csv", $"{a}");
            deleteFile();
        }

        public static void deleteFile()
        {
            Console.WriteLine("\nChoose the file you want to DELETE from the ones provided above:");
            Console.ReadLine();

            switch (options)
            {
                case (int)Options.year1:
                    try
                    {
                        System.IO.File.Delete("..\\csv\\year1.csv");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Cannot delete this file");
                        Console.WriteLine(e.Message);
                    }
                    redirectUserMenu();
                    break;
                case (int)Options.experience:
                    try
                    {
                        System.IO.File.Delete("..\\csv\\experience.csv");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Cannot delete this file");
                        Console.WriteLine(e.Message);
                    }
                    break;
                case (int)Options.description:
                    try
                    {
                        System.IO.File.Delete("..\\csv\\description.csv");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Cannot delete this file");
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        }
    }
}
