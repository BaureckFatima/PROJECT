using System;
using System.Collections.Generic;
using System.IO;

namespace Project1
{  
    class Program
    {
        private static readonly int menu;
        private static readonly int mode;

        //Use of Delegate to define callback method and implement event handling
        public delegate void DoModeOperation();

        static void Main(string[] args)
        {
            MainMenu();
        }
        static int userinput;

        public static void MainMenu()
        {
            DoModeOperation currentMode;
            Console.WriteLine("==================================================\n                    1. MENU\n==================================================");
            Console.WriteLine("Select mode:");
            Console.WriteLine("1 -> Guest mode");
            Console.WriteLine("2 -> Admin mode");
            Console.WriteLine("**************************************************\n");

            try
            {
            Console.WriteLine("Enter your choice:");
            userinput = int.Parse(Console.ReadLine());

                if ((Mode)userinput >= Mode.exit && (Mode)userinput <=Mode.admin)
                {
                    switch ((Mode)userinput)
                    {
                        case Mode.exit:            
                            break;    
                            
                        case Mode.guest:                        
                                currentMode = new DoModeOperation(Guest.BriefIntro);
                                currentMode();       
                            break;

                        case Mode.admin:                          
                                currentMode = new DoModeOperation(Admin.chooseFile);
                                currentMode();                           
                            break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong input entered");
                }
            }
            catch
            {
                Console.WriteLine("Wrong input entered");             
            }
               MainMenu();   
        }

        public static void redirectUserMenu()
        {
            Console.WriteLine("\nEnter number '0' to Go Back:");
            Console.ReadLine();

            switch (menu)
            {
                case (int)Menu.goBack:
                    try
                    {
                        Guest.userMenu();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Cannot go back to previous menu");
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        }
    }
}

        public class accessFile
        {
            public string Column1 { get; set; }
            public string Column2 { get; set; }
        }
    



