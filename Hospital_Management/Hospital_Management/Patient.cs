using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{

    public class Patient : Person
    {
        public double Height;
        public double Weight;
        public double Temperature;
        public Genotype BloodGroup;
        public BloodTypes BloodType;
        public string NatureOfSickness;
        public SicknessLevels SicknessLevel;
        public static int RegNo = 0;
        public string RegistrationID;
        public string AddmissionID;
        public bool AddmissionStatus = false;

        public static List<Patient> patients = new List<Patient>();

        public Patient(string name, int age, long phoneNumber, string emailAddress, Gender sex, Tittle namePreFix, double height, double weight, 
            double temperature,Genotype bloodGroup, BloodTypes bloodTypes, string natureOfSicknes,SicknessLevels sicknessLevel) :base(name, age, phoneNumber, emailAddress, sex, namePreFix)
        {
            Height = height;
            Weight = weight;
            NamePreFix = namePreFix;
            Temperature = temperature;
            BloodGroup = bloodGroup;
            BloodType = bloodTypes;
            NatureOfSickness = natureOfSicknes;
            SicknessLevel = sicknessLevel;
            RegistrationID = GenerateRegID();
            //AddmissionID = GenAddmissionID();
            AddPatient();
            RegNo++;
        }
        public void AddPatient()
        {
            patients.Add(this);
        }
        public string GenerateRegID()
        {
            return $"PT{RegNo+1.ToString("000")}";
        }
        public static string GenAddmissionID()
        {
            Random RegNo = new Random();
            return $"PT{RegNo.Next(45,99).ToString("000")}";
        }
        public static Patient GetPatient(string RegNumber)
        {
            foreach (var patient in patients)
            {
                if (patient.RegistrationID.Equals(RegNumber))
                {
                    return patient;
                }
            }
            return null;

        }

      public static void GetAddmittedPatients()
      { 
        foreach (var p in patients)
        {
                int i = 1;
            if (p.AddmissionStatus)
            {
                    Console.WriteLine($"{i}.{p.NamePreFix}.{p.Name}\t{p.NatureOfSickness}\t{p.RegistrationID}");
            }
                i++;
        }  
      }
        public static void GetandDischargePatient(string patientid)
        {
        }

        public void PrintPatientRegDetails()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"+++++++++ REGISTRATION SUCCESSFUL ++++++++++++");
            Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine($"{NamePreFix}.{Name}, Your Registration ID is {RegistrationID}");
            Console.WriteLine($"Full Name: {Name}\tAge: {Age}\tPhone Number: {PhoneNumber}\nEmail Address: {EmailAddress}\tSex: " +
                $"{Sex}\tHeight: {Height}\nWeight: {Weight}\tTemperature: {Temperature}\nBlood Group: " +
                $"{BloodGroup}\tNature of Scickness: {NatureOfSickness}");
        }

        public static void PatientRegistration()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("------------------------PATIENT REGISTRATION--------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter your Full name: ");
            var fullNmae = Console.ReadLine();
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
            Console.Write("Enter your Height: ");
            Console.WriteLine("Choose your Name Prefix: ");
            Console.WriteLine("\t1. Mr");
            Console.WriteLine("\t2. Master");
            Console.WriteLine("\t3. Miss");
            Console.WriteLine("\t4. Mrs");
            var nameprefix = (Tittle)int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Height: ");
            var height = double.Parse(Console.ReadLine());
            Console.Write("Enter your Weight: ");
            var weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your Temperature: ");
            var temperature = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Genotype: ");
            Console.WriteLine("\t1. AA");
            Console.WriteLine("\t2. AS");
            Console.WriteLine("\t3. SS");
            Console.WriteLine("\t4. AC");
            Console.WriteLine("\t5. SC");
            var bloodGroup = (Genotype)int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Blood Group: ");
            Console.WriteLine("\t1. O Positive");
            Console.WriteLine("\t2. O Negative");
            var bloodType = (BloodTypes)int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Nature of sickness: ");
            var natureOfSickness = Console.ReadLine();
            Console.Write("Enter your Sickness Level: ");
            Console.WriteLine("\t1.  Minor");
            Console.WriteLine("\t2.  Normal");
            Console.WriteLine("\t3. Critical");
            var sicknessLevel = (SicknessLevels)int.Parse(Console.ReadLine());


            Patient patient = new Patient(fullNmae, age, phoneNumber, email, sex, nameprefix, height, weight, temperature, bloodGroup, bloodType, natureOfSickness, sicknessLevel);
            patient.PrintPatientRegDetails();
            Console.WriteLine();
            Console.WriteLine(".......Press 1 to go back to the main menu");
            var menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                MainMenu.Mainmenu();
            }
        }
        public static void PrintPatient()
        {
            int i = 1;
            foreach (var p in patients)
            {
                Console.WriteLine($"{i}.{p.NamePreFix}.{p.Name}\t{p.NatureOfSickness}\t{p.RegistrationID}");
            }
                
        }

    }
    public enum Genotype
    {
        AA,
        AS,
        SS,
        AC,
        SC
    }

    public enum BloodTypes
    {
        OPositive = 1,
        ONegative,
    }
    public enum SicknessLevels
    {
        Minor,
        Normal,
        Critical
    }
}

