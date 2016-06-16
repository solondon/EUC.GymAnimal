using EUC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    //TODO plug into db call
    public enum Phase
    {
        Unknown=1,
        Build = 2,
        Bulk=3,
        Beast=4
    }

    public class WeekSchedule : BaseEntity, ILoggable
    {
        public WeekSchedule()
        {
        }

        public WeekSchedule(int weekScheduleID)
        {
            this.WeekScheduleID = weekScheduleID;
        }
        
        public override bool Validate()
        {
            if (WeekNumber==0) return false;
            if (DayNumber==0) return false;
            if (string.IsNullOrEmpty(BodyParts)) return false;
            return true;
        }

        public string Log()
        {
            var logString = this.WeekScheduleID + ": " +
                              "WeekNumber: " + this.WeekNumber + " " +
                              "DayNumber: " + this.DayNumber + " " +
                              "BlockDescription: " + this.BlockDescription + " " +
                              "BodyParts: " + this.BodyParts + " " +
                              "ProgramPhase: " + this.ProgramPhase.ToString() + " " +
                              "Status: " + this.EntityState.ToString();
            return logString;
        }

        public int WeekScheduleID { get; set; }
        public int WeekNumber { get; set; }
        public int DayNumber { get; set; }
        public Phase ProgramPhase { get; set; }
        public string BlockDescription { get; set; }
        public string BodyParts { get; set; }

    }
}
