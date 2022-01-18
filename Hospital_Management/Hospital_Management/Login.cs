using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    class Login
    {
        public static void LogIn()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine($"+++++++ WELCOME TO THE PRAISED HOSPITAL +++++++");
                Console.WriteLine($"+++++++++++++++++ LOGIN PAGE ++++++++++++++++++");
                Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press for Patient Log in an 2 for staff Log in");
                var request = int.Parse(Console.ReadLine());

                switch (request)
                {
                    case 1:
                        PatientLogIn();
                        break;
                    case 2:
                        StaffLogIn();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
           
        }
        public static void PatientLogIn()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"+++++++ WELCOME TO THE PRAISED HOSPITAL +++++++");
            Console.WriteLine($"++++++++++++++ PATIENT LOG IN PAGE ++++++++++++++");
            Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Are you a registered Patient? if yes enter 1 and if no enter 2 ");
            var condition = int.Parse(Console.ReadLine());
            if (condition == 1)
            {
                Console.WriteLine("Input you Registration ID ");
                var identity = Console.ReadLine();
                Patient p = Patient.GetPatient(identity);
                if (p != null)
                {
                    Console.WriteLine("Registration Confimed");
                    Console.WriteLine("You are welcome back");
                }
                else
                {
                    Console.WriteLine("Sorry, we can find an account that correspond your input, Kindly Registration, Thank you!!");
                }
            }
            else if (condition == 2)
            {
                Console.WriteLine("Please go for your Registration, Thank you!!");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
        public static void StaffLogIn()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"+++++++ WELCOME TO THE PRAISED HOSPITAL +++++++");
            Console.WriteLine($"++++++++++++++ STAFF LOG IN PAGE ++++++++++++++");
            Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Are you a Staff? if yes enter 1 and if no enter 2 ");
            var condition = int.Parse(Console.ReadLine());
            if (condition == 1)
            {
                Console.WriteLine("Enter 1 if you are a Doctor and 2 for Nurse");
                var discipline = int.Parse(Console.ReadLine());
                switch (discipline)
                {
                    case 1:
                        DoctorLogIn();
                        break;
                    case 2:
                        NurseLogIn();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            else if (condition == 2)
            {
                Console.WriteLine("Sorry, Only Staffs are allowed to Use this Platform");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
            
        }
        public static void DoctorLogIn()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"+++++++ WELCOME TO THE PRAISED HOSPITAL +++++++");
            Console.WriteLine($"+++++++++++ DOCTOR LOG IN PAGE ++++++++++++++++");
            Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Are you a Doctor? if yes enter 1 and if no enter 2 ");
            var condition = int.Parse(Console.ReadLine());
            if (condition == 1)
            {
                Console.WriteLine("Enter your Doctor ID");
                var identity = Console.ReadLine();
                Doctor dc = Doctor.GetDoctorReg(identity);
                if (dc != null)
                {
                    Console.WriteLine("Identity Confimed");
                    Console.WriteLine("You are welcome back");

                }
                else
                {
                    Console.WriteLine("ID not found");
                }
            }
            else if (condition == 2)
            {
                Console.WriteLine("Sorry, Only Doctor is allowed to Use this Platform");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        public static void NurseLogIn()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"+++++++ WELCOME TO THE PRAISED HOSPITAL +++++++");
            Console.WriteLine($"+++++++++++ NURSE LOG IN PAGE ++++++++++++++++");
            Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Are you a Nurse? if yes enter 1 and if no enter 2 ");
            var condition = int.Parse(Console.ReadLine());
            if (condition == 1)
            {
                Console.WriteLine("Enter your Nurse ID");
                var identity = Console.ReadLine();
                Nurse nr = Nurse.GetNurseReg(identity);
                if (nr != null)
                {
                    Console.WriteLine("Identity Confimed");
                    Console.WriteLine("You are welcome back");

                }
                else
                {
                    Console.WriteLine("ID not found");
                }
            }
            else if (condition == 2)
            {
                Console.WriteLine("Sorry, Only Nurse is allowed to Use this Platform");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
