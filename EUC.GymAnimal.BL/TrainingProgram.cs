using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class TrainingProgram : BaseEntity
    {
        public TrainingProgram()
        {
        }

        public TrainingProgram(int trainingProgramId)
        {
            this.TrainingProgramId = trainingProgramId;
        }

        public override bool Validate()
        {
            bool isValid = true;
            //if (MeasurementDate == null) isValid = false;

            return isValid;
        }

        public int TrainingProgramId { get; set; }
        public string ProgramName { get; set; }
        public int NumberOfWeeks { get; set; }
    }
}
