using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    class TrainingProgram
    {
        public TrainingProgram()
        {
        }

        public TrainingProgram(int trainingProgramId)
        {
            this.TrainingProgramId = trainingProgramId;
        }

        public Profile Retrive()
        {
            return new Profile();
        }

        public List<TrainingProgram> Retrieve()
        {
            return new List<TrainingProgram>();
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

        public int TrainingProgramId { get; set; }
        public string ProgramName { get; set; }
        public int NumberOfWeeks { get; set; }
    }
}
