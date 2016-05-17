using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class SetMasterRepository
    {
        public SetMaster Retrieve(int setMasterId)
        {
            // Create the instance of the SetMaster class
            // Pass in the requested Id
            SetMaster setMaster = new SetMaster(setMasterId);

            // Code that retrieves the defined product

            // Temporary hard coded values to return 
            // a populated product
            if (setMasterId == 1)
            {
                setMaster.Exercise = "Front to Back Lunge";
                setMaster.Notes="Each Leg";
                setMaster.SetType = TypeOfSet.SingleSet;
            }

            return setMaster;
        }

        public List<SetMaster> Retrieve()
        {
            return new List<SetMaster>();
        }

        public bool Save(SetMaster setMaster)
        {
            var success = true;

            if (setMaster.HasChanges && setMaster.IsValid)
            {
                if (setMaster.IsNew)
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
