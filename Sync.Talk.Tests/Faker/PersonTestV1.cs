using Domain.Person;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests.UnitTests.Faker
{
    public class PersonTestV1
    {
        [Theory]
        [InlineData(1, "John", "Smith", "john@gmail.com", 30, 1, 2000)]
        public void ShoudHaveCorrectPropertyValues(int id, string firstName, string lastName, string email, int day, int month, int year)
        {
            // Arrange
            var dateOfBirth = new DateTime(year, month, day);

            // Act
            var person = new Person(id, firstName, lastName, email, dateOfBirth);

            // Assert
            Assert.Equal(person.Id, id);
            Assert.Equal(person.FirstName, firstName);
            Assert.Equal(person.LastName, lastName);
            Assert.Equal(person.Email, email);
            Assert.Equal(person.DateOfBirth, dateOfBirth);
        }
    }
}
