using Bogus;
using Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Tests.UnitTests.Faker
{
    public class PersonTestV1
    {
        [Theory]
        [InlineData(1, "John", "Smith", "john@gmail.com")]
        public void ShoudHaveCorrectPropertyValues(int id, string firstName, string lastName, string email)
        {
            // Act
            var person = new Domain.Person.ImmutablePerson(id, firstName, lastName, email, DateTime.Now);

            // Assert
            Assert.Equal(person.Id, id);
            Assert.Equal(person.FirstName, firstName);
            Assert.Equal(person.LastName, lastName);
            Assert.Equal(person.Email, email); 
        }

        [Theory]
        [InlineData(1)]
        public void ShoudHaveCorrectPropertyValuesFaker(int id)
        {
            // Arrange
            Domain.Person.Person person = new Faker<Domain.Person.Person>("pt_BR")
                .RuleFor(c => c.Id, f => id)
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.DateOfBirth, f => f.Date.Past(15)).Generate(1).FirstOrDefault();

            // Assert
            Assert.Equal(person.Id, id);
            Assert.NotNull(person.FirstName);
            Assert.NotNull(person.LastName);
            Assert.NotNull(person.Email);
        }
    }
}
