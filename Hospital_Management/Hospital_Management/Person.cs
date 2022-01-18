using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public abstract class Person
    {
        public string Name;
        public int Age;
        public long PhoneNumber;
        public string EmailAddress;
        public Gender Sex;
        public Tittle NamePreFix;

        public Person(string name, int age, long phoneNumber, string emailAddress, Gender sex, Tittle namePreFix)
        {
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Sex = sex;
            NamePreFix = namePreFix;
        }
    }
    public enum Tittle
    {
        Mr=1,
        Master,
        Mrs,
        Miss
    }

}
