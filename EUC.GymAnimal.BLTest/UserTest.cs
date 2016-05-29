using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EUC.GymAnimal.BL;

namespace EUC.GymAnimal.BLTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void UserFullNameTestValid()
        {
            //Arrange
            User person = new User();
            person.FirstName = "Juan";
            person.LastName = "Lopez";

             string expected = "Lopez, Juan";

            //Act
            string actual = person.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserFullNameFirstNameEmpty()
        {
            //Arrange
            User person = new User();
            person.LastName = "Lopez";

            string expected = "Lopez";

            //Act
            string actual = person.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserFullNameLastNameEmpty()
        {
            //Arrange
            User person = new User();
            person.FirstName = "Juan";

            string expected = "Juan";

            //Act
            string actual = person.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserValidateValid()
        {
            //Arrange
            User person = new User();
            person.EmailAddress = "jlopez@jlopez.co.uk";
            person.FirstName = "Juan";
            person.LastName = "Lopez";

            bool expected = true;

            //Act
            bool actual = person.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserValidateInvalidOnlyEmailAddress()
        {
            //Arrange
            User person = new User();
            person.EmailAddress = "jlopez@jlopez.co.uk";

            bool expected = false;

            //Act
            bool actual = person.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserValidateInvalidNoEmailAddress()
        {
            //Arrange
            User person = new User();
            person.FirstName = "Juan";
            person.LastName = "Lopez";

            bool expected = false;

            //Act
            bool actual = person.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
