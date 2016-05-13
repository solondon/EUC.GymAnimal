using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public enum Phase
    {
        Build=1,
        Bulk,
        Beast
    }

    public class Day
    {
        public Day()
        {
        }

        public Day(int dayRoutineId)
        {
            this.DayRoutineId = dayRoutineId;
        }

        public Day Retrive()
        {
            return new Day();
        }

        public List<Day> Retrieve()
        {
            return new List<Day>();
        }
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValid = true;
            //if (MeasurementDate == null) isValid = false;

            return isValid;
        }

        public int DayRoutineId { get; private set; }
        public DateTime? WorkoutDate { get; set; }
        public int DayNumber { get; set; }
        public Phase ProgramPhase { get; set; }

    }
}
