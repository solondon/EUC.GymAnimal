using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class WeekScheduleRepository
    {
        public WeekSchedule Retrieve(int weekScheduleID)
        {
            WeekSchedule weekSchedule = new WeekSchedule(weekScheduleID);

            //code to retrieve instance of the Person class

            // Temporary hard coded values to return 
            // a populated Person
            if (weekScheduleID == 1)
            {
                weekSchedule.WeekNumber = 1;
                weekSchedule.DayNumber = 1;
                weekSchedule.BlockDescription = "3 weeks: 6 days on, 1 day off";
                weekSchedule.BodyParts = "Chest/Tris";
            }

            return weekSchedule;
        }

        public bool Save(WeekSchedule weekSchedule)
        {
            var success = true;

            if (weekSchedule.HasChanges && weekSchedule.IsValid)
            {
                if (weekSchedule.IsNew)
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
