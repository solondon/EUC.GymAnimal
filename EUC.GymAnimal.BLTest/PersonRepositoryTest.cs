using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EUC.GymAnimal.BL;


namespace EUC.GymAnimal.BLTest
{
    [TestClass]
    public class PersonRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //Arrange
            PersonRepository personRepository = new PersonRepository();
            var expected = new Person(1)
            {
                Age = 48,
                EmailAddress = "jlopez@jlopez.co.uk",
                FirstName = "Juan",
                LastName = "Lopez",
                Sex = Sex.Male
            };

            //Act
            var actual = personRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.PersonId, actual.PersonId);
            Assert.AreEqual(expected.Age, actual.Age);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Sex, actual.Sex);
        }
    }
}
