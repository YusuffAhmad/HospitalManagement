using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    class Doctor : Person
    {
        public string Specialization;
        public DoctorLevel Level;
        public static int RegNo = 0;
        public string RegistrationID;
        public static List<Doctor> doctors = new List<Doctor>();

        public Doctor(string name, int age, long phoneNumber, string emailAddress, 
           Gender sex, Tittle namePreFix, string specialization, DoctorLevel level) :base(name, age, phoneNumber, emailAddress, sex, namePreFix)
        {
            Specialization = specialization;
            Level = level;
            Name = name;
            Age = age;
            NamePreFix = namePreFix;
            RegNo++;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Sex = sex;
            RegistrationID = GenerateDocID();
            AddDoctor();
        }
        public void AddDoctor()
        {
            doctors.Add(this);
        }
        public string GenerateDocID()
        {
            return $"DC{RegNo + 1.ToString("000")}";
        }
        public static Doctor GetDoctorReg(string identity)
        {
            foreach (var doctor in doctors)
            {
                if (doctor.RegistrationID.Equals(identity))
                {
                    return doctor;
                }
            }
            return null;
        }

        public void PrintDoctorRegDetails()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"+++++++++ REGISTRATION SUCCESSFUL ++++++++++++");
            Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"{NamePreFix}.{Name}, Your Registration ID is {RegistrationID}");

            Console.WriteLine("Press Enter to return to the Menu");
        }

        public string GenerateRegID()
        {
            return $"PT{RegNo + 1.ToString("000")}";
        }
        public static void DoctorRegistration()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("---------------------------DOCTOR REGISTRATION--------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your Full name: ");
            var fullName = Console.ReadLine();
            Console.Write("Enter your Age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your phone number: ");
            var phoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter your email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Choose your Sex: ");
            Console.WriteLine("\t1. Male");
            Console.WriteLine("\t2. Female");
            Console.WriteLine("\t3. Gender Not Specified");
            var sex = (Gender)int.Parse(Console.ReadLine());
            Console.WriteLine("Choose your Name Prefix: ");
            Console.WriteLine("\t1. Mr");
            Console.WriteLine("\t2. Master");
            Console.WriteLine("\t3. Miss");
            Console.WriteLine("\t4. Mrs");
            var nameprefix = (Tittle)int.Parse(Console.ReadLine());
            Console.Write("Enter your Specialization: ");
            var specialization = Console.ReadLine();
            Console.WriteLine("Choose your Level: ");
            Console.WriteLine("\t1. JuniorDoctor");
            Console.WriteLine("\t2. SeniorDoctor");
            var level = (DoctorLevel)int.Parse(Console.ReadLine());
            Doctor doctor = new Doctor(fullName, age, phoneNumber, email, sex, nameprefix, specialization, level);
            doctor.PrintDoctorRegDetails();
        }
    }
    public enum DoctorLevel
    {
        JuniorDoctor=1,
        SeniorDoctor
    }
}
