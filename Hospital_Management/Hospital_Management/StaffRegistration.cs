using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    class StaffRegistration
    {
        public static void PrintStaffRegistration()
        {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("---------------------------STAFF REGISTRATION--------------------------------");
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Select one of the following options to proceed ");
        Console.WriteLine("\t1. Doctor Registration");
        Console.WriteLine("\t2. Nurse Registration");
        var request = Convert.ToInt32(Console.ReadLine());

            switch (request)
            {
                case 1:
                    Doctor.DoctorRegistration();
                    break;
                case 2:
                    Nurse.NurseRegistration();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
    }
}
