using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    class Nurse : Person
    {
        public NurseLevel Level;
        public static int RegNo = 0;
        public string RegistrationID;
        public static List<Nurse> nurses = new List<Nurse>();

        public Nurse(string name, int age, long phoneNumber, string emailAddress,
           Gender sex, Tittle namePreFix, NurseLevel level) : base(name, age, phoneNumber, emailAddress, sex, namePreFix)
        {
            Level = level;
            Name = name;
            Age = age;
            NamePreFix = namePreFix;
            RegNo++;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Sex = sex;
            RegistrationID = GenerateNurseID();
            AddNurse();
        }
        public void AddNurse()
        {
           nurses.Add(this);
        }
        public string GenerateNurseID()
        {
            return $"NS{RegNo + 1.ToString("000")}";
        }
        public static Nurse GetNurseReg(string identity)
        {
            foreach (var nurse in nurses)
            {
                if (nurse.RegistrationID.Equals(identity))
                {
                    return nurse;
                }
            }
            return null;
        }
        public void PrintNurseRegDetails()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"+++++++++ REGISTRATION SUCCESSFUL ++++++++++++");
            Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"{NamePreFix}.{Name}, Your Registration ID is {RegistrationID}");

            Console.WriteLine("Press Enter to return to the Menu");
        }
        public static void NurseRegistration()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("---------------------------NURSE REGISTRATION--------------------------------");
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
            Console.WriteLine("Choose your Level: ");
            Console.WriteLine("\t1. AuxiliaryNurse");
            Console.WriteLine("\t2. MainNurse");
            var level = (NurseLevel)int.Parse(Console.ReadLine());
            Nurse doctor = new Nurse(fullName, age, phoneNumber, email, sex, nameprefix, level);
            doctor.PrintNurseRegDetails();
        }
    }
    public enum NurseLevel
    {
        MainNurse =1,
        AuxiliaryNurse
    }

}
