using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class PersonRepository
    {
        public Person Retrieve(int personId)
        {
            Person person = new Person(personId);

            //temporary hard coded data for testing
            if (personId==1)
            {
                person.Age = 48;
                person.EmailAddress = "jlopez@jlopez.co.uk";
                person.FirstName = "Juan";
                person.LastName = "Lopez";
                person.Sex = Sex.Male;
            }

            //retrieve the requested person by Id

            return person;
        }

        public List<Person> Retrieve()
        {
            return new List<Person>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
