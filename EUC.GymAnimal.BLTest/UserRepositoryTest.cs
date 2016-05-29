using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EUC.GymAnimal.BL;


namespace EUC.GymAnimal.BLTest
{
    [TestClass]
    public class UserRepositoryTest
    {
        [TestMethod]
        public void UserRepoRetrieveExisting()
        {
            //Arrange
            UserRepository personRepository = new UserRepository();
            var expected = new User(1)
            {
                EmailAddress = "jlopez@jlopez.co.uk",
                FirstName = "Juan",
                LastName = "Lopez",
                Sex = Sex.Male,
                BirthDate=new DateTime(1968,04,14)
            };

            //Act
            var actual = personRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.UserID, actual.UserID);
            Assert.AreEqual(expected.BirthDate, actual.BirthDate);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Sex, actual.Sex);
        }

        [TestMethod]    
        public void UserCalculateAgeValid()
        {
            //Arrange
            DateTime birthdate = new DateTime(1968, 04, 14); 
            var user = new User(1) {BirthDate = birthdate };

            DateTime today = DateTime.Today;
            int expectedAge = today.Year - birthdate.Year;

            //Act
            var actual = user.Age;

            //Assert
            Assert.AreEqual(expectedAge, actual);
        }

        [TestMethod]
        public void UserCalculateAgeInValid()
        {
            //Arrange
            DateTime birthdate = new DateTime(1966, 04, 14);
            var user = new User(1);

            DateTime today = DateTime.Today;
            int expectedAge = today.Year - birthdate.Year;

            //Act
            var actual = user.Age;

            //Assert
            Assert.AreEqual(expectedAge, actual);
        }

    }
}
