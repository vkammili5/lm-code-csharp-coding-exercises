using System;
namespace Exercises.Models
{
    public class Person
    {

        public Person(string firstname, string lastname, string city, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            City = city;
            Age = age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public int Age { get; set; }
    }
}
