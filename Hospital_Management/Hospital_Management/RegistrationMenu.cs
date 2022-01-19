using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    class RegistrationMenu
    {
        public static void Registration()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine($"+++++++++ WELCOME TO THE PRAISED HOSPITAL+++++++");
                Console.WriteLine($"+++++++++++++ REGISTRATION CENTER ++++++++++++++");
                Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Select one of the following options to proceed ");
                Console.WriteLine("\t1. Patient Registration");
                Console.WriteLine("\t2. Patient Addmission Registration");
                Console.WriteLine("\t3. staff Registration");
                Console.WriteLine("\t4. Back To Main Menu");



                var request = Convert.ToInt32(Console.ReadLine());

                switch (request)
                {
                    case 1:
                        Patient.PatientRegistration();
                        break;
                    case 2:
                        PatientAddmission.PatiAddReg();
                        break;
                    case 3:
                        StaffRegistration.PrintStaffRegistration();
                        break;
                    case 4:
                        MainMenu.Mainmenu();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
