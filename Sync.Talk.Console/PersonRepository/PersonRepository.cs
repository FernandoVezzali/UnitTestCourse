using Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sync.Talk.PersonRepository
{
    public class PersonRepository
    {
        IExternalDatabase _externalDatabase;

        public PersonRepository(IExternalDatabase externalDatabase)
        {
            _externalDatabase = externalDatabase;
        }

        public string GetFullNameById(int id)
        {
            return $"{_externalDatabase.GetAll().FirstOrDefault(x => x.Id == id).FirstName} {_externalDatabase.GetAll().FirstOrDefault(x => x.Id == id).LastName}";
        }

        public IEnumerable<Person> GetTop(int numberOfRows)
        {
            return _externalDatabase.GetAll().OrderBy(x=>x.FirstName).Take(numberOfRows);
        }
    }

    public interface IExternalDatabase
    {
        public Person GetById(int id);
        public IEnumerable<Person> GetAll();
        public IEnumerable<Person> GetTop(int numberOfRows);
    }
}
