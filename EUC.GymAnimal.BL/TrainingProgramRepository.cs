using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class TrainingProgramRepository
    {
        public TrainingProgram Retrieve(int trainingProgramRepositoryId)
        {
            // Create the instance of the TrainingProgram class
            // Pass in the requested Id
            TrainingProgram trainingProgram = new TrainingProgram(trainingProgramRepositoryId);

            //retrieve defined TrainingProgram

            // Temporary hard coded values to return 
            // a populated product
            trainingProgram.NumberOfWeeks = 12;
            trainingProgram.ProgramName = "Body Beast";

            return trainingProgram;
        }

        public List<TrainingProgram> Retrieve()
        {
            return new List<TrainingProgram>();
        }

        public bool Save(TrainingProgram trainingProgram)
        {
            var success = true;

            if (trainingProgram.HasChanges && trainingProgram.IsValid)
            {
                if (trainingProgram.IsNew)
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
