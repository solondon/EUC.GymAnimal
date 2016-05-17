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
        public void ProfileValidateValid()
        {
            //Assign
            Profile profile = new Profile();
            profile.MeasurementDate = DateTime.Now;
            profile.HeightCm = 181;
            profile.WeightKg = 94;

            bool expected = true;

            //Act
            bool actual= profile.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProfileValidateInValid()
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
        public void ProfileCalculateWeightStatusValid()
        {
            //Assign
            Profile personMonitor = new Profile();
            personMonitor.HeightCm = 180;
            personMonitor.WeightKg = 94.4;

            WeightStatus expected = WeightStatus.Overweight;

            //Act
            WeightStatus actual = personMonitor.CalculateWeightStatus(Sex.Male);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProfileCalculateWeightStatusInValid()
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
        public void ProfileCalculateBMIValid()
        {
            //Assign
            Profile personMonitor = new Profile();
            personMonitor.HeightCm = 181;
            personMonitor.WeightKg = 94.4;

            double expected = 28.8;

            //Act
            double actual = personMonitor.CalculateBMI();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProfileCalculateBMIInValidNoHeight()
        {
            //Assign
            Profile personMonitor = new Profile();
            //personMonitor.HeightCm = 181;
            personMonitor.WeightKg = 94.4;

            double expected = 28.8;

            //Act
            double actual = personMonitor.CalculateBMI();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
