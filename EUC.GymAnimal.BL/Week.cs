using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    class Week : BaseEntity
    {
        public Week()
        {
        }

        public Week(int weekId)
        {
            this.WeekId = WeekId;
        }

        public override bool Validate()
        {
            bool isValid = true;
            //if (MeasurementDate == null) isValid = false;

            return isValid;
        }

        public int WeekId { get; private set; }
        public int WeekNumber { get; set; }

    }
}
