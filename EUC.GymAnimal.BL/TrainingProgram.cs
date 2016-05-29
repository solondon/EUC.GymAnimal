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
            if (string.IsNullOrEmpty(ProgramName)) return false;
            if (NumberOfWeeks == 0) return false;
            return true;
        }

        public int TrainingProgramId { get; set; }
        public string ProgramName { get; set; }
        public int NumberOfWeeks { get; set; }
        public string Description { get; set; }
    }
}
