using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1
{
    class Guest : Program
    {
        private static readonly int chooseAGAIN;
        public static void BriefIntro()
        {
            Console.Clear();
            Console.WriteLine("1.1 Welcome to Guest Mode! \n");
            Console.WriteLine("1.1.1 BRIEF INTRODUCTION \n");
            Console.Write(" Name: BAURECK CORELAB-USER Zohra \n Profession: Student \n Age: 21 \n Course: BSc(Hons) Software Engineering -Year II \n University: UoM");
            Console.ReadLine();

            userMenu();
        }

        public static void userMenu()
        {
            Console.WriteLine("\n==================================================\n                    1.1.2 MENU\n==================================================");
            Console.WriteLine("Select from menu:");
            Console.WriteLine("1 -> Experience / Job History ");
            Console.WriteLine("2 -> Education / Training ");
            Console.WriteLine("3 -> Personal Skills ");
            Console.WriteLine("4 -> Technological Skills ");
            Console.WriteLine("5 -> Contact Details ");
            Console.WriteLine("0 --> GO BACK");
            Console.WriteLine("**************************************************\n");
            Console.WriteLine("Enter your choice:");
            //Use of int.Parse as a fail-safe method to prevent app from crashing
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case (int)Choices.previous:
                    try
                    {
                        MainMenu();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Cannot go back to previous menu");
                        Console.WriteLine(e.Message);
                    }
                    break;

                case (int)Choices.experience:
                    try
                    {
                        var lines = File.ReadAllLines("..\\csv\\experience.csv");
                        foreach (var line in lines)
                        {
                            var values = line.Split(',');
                            var data = new accessFile() { Column1 = values[0], Column2 = values[0] };
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("\nEnter number to view job description:");
                        int option = int.Parse(Console.ReadLine());

                        switch (chooseAGAIN)
                        {
                            case (int)chooseAgain.description:
                                try
                                {
                                    var lines1 = File.ReadAllLines("..\\csv\\description.csv");
                                    foreach (var line in lines1)
                                    {
                                        var values = line.Split(',');
                                        Console.WriteLine(line);
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("The file could not be read");
                                    Console.WriteLine(e.Message);
                                }
                                break;

                            default:
                                MainMenu();
                                break;
                        }
                        redirectUserMenu();
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("The file could not be read");
                        Console.WriteLine(e.Message);
                    }
                    break;

                case (int)Choices.courses:
                    try
                    {
                        Console.WriteLine("Course: Software Engineering \nSelect Year 1, 2 or 3: ");

                        Console.WriteLine("\nEnter number:");
                        int option = int.Parse(Console.ReadLine());

                        if (option == (int)courses.firstChoice)
                        {
                            var lines1 = File.ReadAllLines("..\\csv\\year3.csv");
                            foreach (var line in lines1)
                            {
                                var values = line.Split(',');
                                Console.WriteLine(line);
                            }
                            redirectUserMenu();
                        }

                        else if (option == (int)courses.secondChoice)
                        {
                            var lines1 = File.ReadAllLines("..\\csv\\year1.csv");
                            foreach (var line in lines1)
                            {
                                var values = line.Split(',');
                                Console.WriteLine(line);
                            }
                            redirectUserMenu();
                        }
                        else if (option == (int)courses.thirdChoice)
                        {
                            var lines1 = File.ReadAllLines("..\\csv\\year2.csv");

                            foreach (var line in lines1)
                            {
                                var values = line.Split(',');
                                Console.WriteLine(line);
                            }
                            redirectUserMenu();
                        }

                        else 
                        {
                            var lines1 = File.ReadAllLines("..\\csv\\year3.csv");
                            foreach (var line in lines1)
                            {
                                var values = line.Split(',');
                                Console.WriteLine(line);
                            }
                            redirectUserMenu();
                        }

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("The file could not be read");
                        Console.WriteLine(e.Message);
                    }
                    break;

                case (int)Choices.skills:
                    try
                    {
                        var lines = File.ReadAllLines("..\\csv\\skills.csv");
                        foreach (var line in lines)
                        {
                            var values = line.Split(',');
                            Console.WriteLine(line);
                        }
                        redirectUserMenu();
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The file could not be read");
                        Console.WriteLine(e.Message);
                    }
                    break;

                case (int)Choices.technologicalSkills:
                    try
                    {
                        var lines = File.ReadAllLines("..\\csv\\technologicalSkills.csv");
                        foreach (var line in lines)
                        {
                            var values = line.Split(',');
                            var data = new accessFile() { Column1 = values[0], Column2 = values[0] };
                            Console.WriteLine(line);
                        }

                        //else goBack to previous menu***
                        redirectUserMenu();
                        
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The file could not be read");
                        Console.WriteLine(e.Message);
                    }
                    break;
                case (int)Choices.contact:
                    try
                    {
                        var lines = File.ReadAllLines("..\\csv\\contact.csv");
                        foreach (var line in lines)
                        {
                            var values = line.Split(',');
                            var data = new accessFile() { Column1 = values[0], Column2 = values[0] };
                            Console.WriteLine(line);
                        }

                        //else goBack to previous menu***
                        redirectUserMenu();

                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The file could not be read");
                        Console.WriteLine(e.Message);
                    }
                    break;

                default:
                    //else goBack to previous menu***
                    MainMenu();
                    break;
            }
        }
    }
}
