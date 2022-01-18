using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    class DischargePatienet
    {
        public static void Dischargepatients()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"+++++++ WELCOME TO THE PRAISED HOSPITAL +++++++");
            Console.WriteLine($"+++++++++++ PATIENT DISCHARGE CENTER +++++++++++");
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
                    Patient.GetAddmittedPatients();
                    Console.WriteLine("Enter the patient Identity, from the above listed Addmitted Patient");
                    var patientId = Console.ReadLine();

                    var patient = Patient.GetPatient(patientId);
                    if(patient != null)
                    {
                        patient.AddmissionStatus = false;
                        Console.WriteLine("Patient Discharged");
                    }
                    else 
                    {
                        Console.WriteLine("Patient Addmission Identity Not found");
                    }

                }
                else
                {
                    Console.WriteLine("ID not found");
                }
            }
            else if (condition == 2)
            {
                Console.WriteLine("Sorry, Only Doctor is allowed to discharge patients");
            }
            else
            {
                Console.WriteLine("Invalid Input");

            }
            Console.ReadKey();
        }
    }
}
