using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bogus;
using Domain.Person;
using Domain.Transaction;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Extensions;
using NSubstitute;
using Sync.Talk.PersonRepository;
using Xunit;

namespace Tests.UnitTests.FluentAssertions
{
    /*
    public class FluentAssertionsTest
    {
        [Fact]
        public void ShouldReturnAmount100()
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Assert
            //Assert.Equal(200, transaction.Amount);
            transaction.Amount.Should().Be(200);
        }

        [Fact]
        public void ShouldHaveCorrectPropertyValues()
        {
            // Act
            var person = new ImmutablePerson(1, "John", "Smith", "johngmail.com", DateTime.Now);

            // Assert
            person.FirstName.Should().StartWith("J");
            person.LastName.Should().EndWith("h");
            person.Email.Should().Match("*@*", because: "any valid e-mail should at least contain @");
        }

        [Fact]
        public void ShouldReturnCorrectDateOfBirth()
        {
            // Act
            var person = new ImmutablePerson(1, "John", "Smith", "johngmail.com", new DateTime(2000, 1, 2));

            // Assert
            person.DateOfBirth.Should().Be(2.January(2000));
        }

        [Fact]
        public void ShouldHandleException()
        {
            // Arrange
            var transaction = new Transaction(Guid.NewGuid().ToString(), DateTime.Now, 100);

            // Assert
            //Assert.Throws<DivideByZeroException>(() => transaction.Divide(1));
            Action action = () => transaction.Divide(1);
            action.Should().Throw<DivideByZeroException>();
        }

        [Fact]
        public void ShouldReturnCorrectAmountOfRows()
        {
            // Arrange
            var listOfPeople = new Faker<Domain.Person.Person>()
                .RuleFor(c => c.Id, f => f.Random.Int())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.DateOfBirth, f => f.Date.Past(1))
                .Generate(100);

            var externalDatabase = (Substitute.For<IExternalDatabase>());
            externalDatabase.GetAll().Returns(listOfPeople);

            var repository = new PersonRepository(externalDatabase);
            var people = repository.GetTop(10);

            people.Should().NotBeNullOrEmpty();
            people.Should().HaveCount(9);
            people.Should().OnlyHaveUniqueItems();
            people.Should().BeInAscendingOrder(x => x.FirstName);
            people.Should().NotBeOfType<List<Domain.Person.Person>>();

        }

        [Fact]
        public void ShouldReturnCorrectAmountOfRowsWithScope()
        {
            // Arrange
            var listOfPeople = new Faker<Domain.Person.Person>()
                .RuleFor(c => c.Id, f => f.Random.Int())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.DateOfBirth, f => f.Date.Past(1))
                .Generate(100);

            var externalDatabase = (Substitute.For<IExternalDatabase>());
            externalDatabase.GetAll().Returns(listOfPeople);

            var repository = new PersonRepository(externalDatabase);
            List<Domain.Person.Person> people = repository.GetTop(10);

            using (new AssertionScope())
            {
                people.Should().NotBeNullOrEmpty();
                people.Should().HaveCount(9);
                people.Should().OnlyHaveUniqueItems();
                people.Should().BeInAscendingOrder(x => x.FirstName);
                people.Should().NotBeOfType<List<Domain.Person.Person>>();
            }
        }
    }

    */
}
