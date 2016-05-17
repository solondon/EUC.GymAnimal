using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    class ProfileRepository
    {

        public bool Save(Profile profile)
        {
            var success = true;

            if (profile.HasChanges && profile.IsValid)
            {
                if (profile.IsNew)
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

        public Profile Retrive(int profileId)
        {
            Profile profile = new Profile(profileId);

            //retrieve instance of Profile class by Id

            // Temporary hard coded values to return 
            // a populated profile
            if (profileId==1)
            {
                profile.HeightCm = 181;
                profile.MeasurementDate = DateTime.Now;
                profile.WeightKg = 90;
            }

            return profile;
        }

    }
}
