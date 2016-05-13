using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EUC.GymAnimal.BL;

namespace EUC.GymAnimal.BLTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Person person = new Person();
            person.FirstName = "Juan";
            person.LastName = "Lopez";

             string expected = "Lopez, Juan";

            //Act
            string actual = person.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Person person = new Person();
            person.LastName = "Lopez";

            string expected = "Lopez";

            //Act
            string actual = person.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Person person = new Person();
            person.FirstName = "Juan";

            string expected = "Juan";

            //Act
            string actual = person.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            Person person = new Person();
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
        public void ValidateInvalidOnlyEmailAddress()
        {
            //Arrange
            Person person = new Person();
            person.EmailAddress = "jlopez@jlopez.co.uk";

            bool expected = false;

            //Act
            bool actual = person.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateInvalidNoEmailAddress()
        {
            //Arrange
            Person person = new Person();
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
