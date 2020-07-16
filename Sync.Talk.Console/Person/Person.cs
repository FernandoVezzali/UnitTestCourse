using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Domain.Person
{
    /*namespace System.Runtime.CompilerServices
    {
        public class IsExternalInit { }

        public class Person2
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }
            public int Id { get; }
            public string Email { get; }
            public DateTime DateOfBirth { get; }
        }
    }*/


    public class Person
    {
        public Person(int id, string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public DateTime DateOfBirth { get; }
    }
}
