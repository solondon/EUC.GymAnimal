using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class DayRepository
    {

        public Day Retrieve(int dayId)
        {
            Day day = new Day();

            //retrieve Day by Id

            // Temporary hard coded values to return 
            // a populated product
            if (dayId==1)
            {
                day.DayNumber = 1;
                day.ProgramPhase = Phase.Build;
                day.WorkoutDate = DateTime.Now;
            }

            return day;
        }

        public List<Day> Retrieve()
        {
            return new List<Day>();
        }

        public bool Save(Day day)
        {
            var success = true;

            if (day.HasChanges && day.IsValid)
            {
                if (day.IsNew)
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
