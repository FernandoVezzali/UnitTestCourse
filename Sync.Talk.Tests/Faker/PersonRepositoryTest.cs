using Bogus;
using NSubstitute;
using Sync.Talk.PersonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Tests.UnitTests.Faker
{
    public class PersonRepositoryTest
    {
        [Theory]
        [InlineData(1, 10, 300)]
        [InlineData(10, 100, 400)]
        [InlineData(100, 1000, 500)]
        public void ShouldReturnCorrectAmountOfRows(int numberOfRowsToReturn, int numberOfTotalRows, int yearsToGoBack)
        {
            List<Domain.Person.Person> pessoas = new Faker<Domain.Person.Person>()
                .RuleFor(c => c.Id, f => f.Random.Int())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.DateOfBirth, f => f.Date.Past(yearsToGoBack))
                .Generate(numberOfTotalRows);

            var externalDatabase = Substitute.For<IExternalDatabase>();
            externalDatabase.GetAll().Returns(pessoas);

            var repo = new Sync.Talk.PersonRepository.PersonRepository(externalDatabase);

            Assert.Equal(numberOfRowsToReturn, repo.GetTop(numberOfRowsToReturn).Count());
        }
    }
}
