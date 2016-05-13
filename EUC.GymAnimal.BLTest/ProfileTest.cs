using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EUC.GymAnimal.BL;

namespace EUC.GymAnimal.BLTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ProfileTest
    {

        [TestMethod]
        public void ValidateValid()
        {
            //Assign
            Profile personMonitor = new Profile();
            personMonitor.MeasurementDate = DateTime.Now;

            bool expected = true;

            //Act
            bool actual= personMonitor.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateInValid()
        {
            //Assign
            Profile personMonitor = new Profile();

            bool expected = false;

            //Act
            bool actual = personMonitor.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateWeightStatusValid()
        {
            //Assign
            Profile personMonitor = new Profile();
            personMonitor.Height = 180;
            personMonitor.Weight = 94.4;

            WeightStatus expected = WeightStatus.Overweight;

            //Act
            WeightStatus actual = personMonitor.CalculateWeightStatus(Sex.Male);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateWeightStatusInValid()
        {
            //Assign
            Profile personMonitor = new Profile();
            WeightStatus expected = WeightStatus.UnKnown;

            //Act
            WeightStatus actual = personMonitor.CalculateWeightStatus(Sex.Male);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateBMIValid()
        {
            //Assign
            Profile personMonitor = new Profile();
            personMonitor.Height = 181;
            personMonitor.Weight = 94.4;

            double expected = 28.8;

            //Act
            double actual = personMonitor.CalculateBMI();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateBMIInValidNoHeight()
        {
            //Assign
            Profile personMonitor = new Profile();
            //personMonitor.Height = 181;
            personMonitor.Weight = 94.4;

            double expected = 28.8;

            //Act
            double actual = personMonitor.CalculateBMI();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
