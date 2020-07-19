using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Domain.Person
{
    /*
    namespace System.Runtime.CompilerServices
    {
        public data class Person2
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }
            public int Id { get; init; }
            public string Email { get; init; }
            public DateTime DateOfBirth { get; init; }
        }
    }
    */

    public class ImmutablePerson
    {
        public ImmutablePerson(int id, string firstName, string lastName, string email, DateTime dateOfBirth)
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
