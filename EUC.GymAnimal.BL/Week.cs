using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    class Week
    {
        public Week()
        {
        }

        public Week(int weekId)
        {
            this.WeekId = WeekId;
        }

        public Week Retrive()
        {
            return new Week();
        }

        public List<Week> Retrieve()
        {
            return new List<Week>();
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

        public int WeekId { get; private set; }
        public int WeekNumber { get; set; }

    }
}
