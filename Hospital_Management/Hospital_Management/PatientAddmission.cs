using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    class PatientAddmission
    {
        public static void PatiAddReg()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"+++++++ WELCOME TO THE PRAISED HOSPITAL+++++++");
            Console.WriteLine($"+++++++++++ PATIENT ADDMISSION CENTER ++++++++++");
            Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Are you a registered Patient? if yes enter 1 and if no enter 2 and 3 to go back to the main menu");
            var condition = int.Parse(Console.ReadLine());
            if (condition == 1 )
            {
                Console.WriteLine("Input you Registration ID "); 
                var identity = Console.ReadLine();
                Console.WriteLine("Select you Sickness Level");
                Console.WriteLine("1.\t Minor");
                Console.WriteLine("2.\t Normal");
                Console.WriteLine("3.\t Critical");
                var sicknessLevel = int.Parse(Console.ReadLine());


                
                Patient p = Patient.GetPatient(identity);
                if (p != null)
                {
                    if (!p.AddmissionStatus)
                    {
                        Console.WriteLine("Registration Confimed");
                        switch (sicknessLevel)
                        {
                            case 1:
                                Console.WriteLine("Sorry Addmission Denined, The Hospital Only Addmit patients with critical condition");
                                break;
                            case 2:
                                Console.WriteLine("Sorry Addmission Denined, The Hospital Only Addmit patients with critical condition");
                                break;
                            case 3:
                                p.AddmissionStatus = true;
                                Console.WriteLine($"You have been Addmited into the Hospital, Your registration ID is {Patient.GenAddmissionID()}");
                                break;
                            default:
                                Console.WriteLine("Invalid Sickness level");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Patient already Addmitted");
                    }
                    
                            
                }
                else
                {
                    Console.WriteLine("ID not found");
                }
                
            }
            else if (condition == 2)
            {
                Console.WriteLine("Please go for your Registration, Thank you!!");
            }
            else if (condition == 3)
            {
                MainMenu.Mainmenu();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Press 1 to go back to the main menu");
            var menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                MainMenu.Mainmenu();
            }

            Console.ReadKey();

        }
        
    }
}
