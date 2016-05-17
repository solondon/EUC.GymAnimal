using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EUC.Common;
using System.Collections.Generic;
using EUC.GymAnimal.BL;

namespace UnitTestProject1
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void LoggingServiceWriteToFile()
        {
            //Arrange
            var logItems = new List<ILoggable>();
            var person = new Person(1)
            {
                Age = 48,
                FirstName = "Juan",
                LastName="Lopez",
                EmailAddress="jlopez@jlopez.co.uk"
            };

            logItems.Add(person as ILoggable);

            var profile = new Profile(1)
            {
                HeightCm = 181,
                WeightKg = 90,
                MeasurementDate = DateTime.Now
            };

            logItems.Add(profile as ILoggable);

            //Act
            LoggingService.WriteToFile(logItems);

            //Assert
            //look at test output
        }
    }
}
