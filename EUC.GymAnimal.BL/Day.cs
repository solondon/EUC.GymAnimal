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

    public class Day : BaseEntity
    {
        public Day()
        {
        }

        public Day(int dayId)
        {
            this.DayId = dayId;
        }

        public override bool Validate()
        {
            bool isValid = true;
            //if (MeasurementDate == null) isValid = false;

            return isValid;
        }

        public int DayId { get; private set; }
        public DateTime? WorkoutDate { get; set; }
        public int DayNumber { get; set; }
        public Phase ProgramPhase { get; set; }

    }
}
