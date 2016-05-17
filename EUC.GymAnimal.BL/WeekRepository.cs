using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    class WeekRepository
    {
        public Week Retrieve(int weekId)
        {
            // Create the instance of the Product class
            // Pass in the requested Id
            Week week = new Week(weekId);

            // Code that retrieves the defined product

            // Temporary hard coded values to return 
            // a populated product
            if (weekId == 1)
            {
                week.WeekNumber = 1;
            }
            return week;
        }

        public List<Week> Retrieve()
        {
            return new List<Week>();
        }

        public bool Save(Week week)
        {
            var success = true;

            if (week.HasChanges && week.IsValid)
            {
                if (week.IsNew)
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
