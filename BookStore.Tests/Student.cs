using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Tests
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Student()
        {
        }

        public Student(string firstName, string lastName, int age, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
