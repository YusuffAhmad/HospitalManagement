using System;

namespace Hospital_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine($"+++++++++ WELCOME TO THE PRAISED HOSPITAL+++++++");
                Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Select one of the following options to proceed ");
                Console.WriteLine("\t1. Register");
                Console.WriteLine("\t2. Discharge Patient");
                Console.WriteLine("\t3. login");

                var request = Convert.ToInt32(Console.ReadLine());

                if (request == 1)
                {
                    RegistrationMenu.Registration();
                }
                else if (request == 2)
                {
                    DischargePatienet.Dischargepatients();
                }
                else if (request == 3)
                {
                    Login.LogIn();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }

        }
    }
}
