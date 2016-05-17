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

            //code to retrieve instance of the Person class

            // Temporary hard coded values to return 
            // a populated Person
            if (personId==1)
            {
                person.Age = 48;
                person.EmailAddress = "jlopez@jlopez.co.uk";
                person.FirstName = "Juan";
                person.LastName = "Lopez";
                person.Sex = Sex.Male;
            }

            return person;
        }

        public bool Save(Person person)
        {
            var success = true;

            if (person.HasChanges && person.IsValid)
            {
                if (person.IsNew)
                {
                    // Call an Insert Stored Procedure

                }
                else
                {
                    // Call an Update Stored Procedure
                }
            }
            return success;
        }
    }
}
