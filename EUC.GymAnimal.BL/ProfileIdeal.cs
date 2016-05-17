using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    class ProfileIdeal : BaseEntity
    {
        public ProfileIdeal()
        {
        }

        public ProfileIdeal(int idealProfileId)
        {
            this.IdealProfileId = idealProfileId;
        }

        public bool CalculateIdealProfile(Profile profile)
        {
            //lets calculate our perfect stats
            //from the data in the Profile object
            return true;
        }

        public double CalculateIdealBMI(Profile profile, Sex gender, int age)
        {
            double idealBmi = 0;

            //error checking
            if (profile.WeightKg == 0) throw new Exception("WeightKg not specified cant calculate BMI");
            if (profile.HeightCm == 0) throw new Exception("HeightCm not specified cant calculate BMI");

            if (gender==Sex.Male)
            {
                //Men Ideal BMI = 0.5 * kg / m2 + 11.5
                idealBmi = (0.5 * profile.WeightKg / Math.Pow(profile.HeightCm / 100.0, 2))+11.5;
                idealBmi = Math.Round(idealBmi, 1);
            }
            else
            {
                //Women	Ideal BMI	= 0.4 * kg/m2 + 0.03*Age + 11
                idealBmi = (0.4 * profile.WeightKg) / (Math.Pow(profile.HeightCm / 100.0, 2))+0.03*age + 11;
                idealBmi = Math.Round(idealBmi, 1);
            }

            IdealBMI = idealBmi;
            return idealBmi;
        }

        public double CalculateIdealBodyWeight(Profile profile, Sex gender, int age)
        {
            double idealWeight = 0;

            //1 ft = 0.30480m
            double F = Math.Floor(profile.HeightCm * 0.0328084);
            double Feet = profile.HeightCm * 0.0328084;
            double Inches = (Feet - F) * 12;
            Console.WriteLine("\nThe equivalent in feet and inches is {0:C} ft {1:G} ins", Feet, Inches);

            if (gender == Sex.Male)
            {
                //Males: IBW = 50 kg + 2.3 kg for each inch over 5 feet.
                /*
                int totalInches = ((int)profile.HeightCm / 2.54); // This will take a floor function of Centimetres/2.54
                int Feet = (totalInches - totalInches % 12) / 12; // This will make it divisible by 12
                int inches = totalInches % 12; // This will give you the remainder after you divide by 12
                Console.WriteLine("\nThe equivalent in feet and inches is {0:C} ft {1:G} ins", Feet, inches);
                */

                idealWeight =

                idealWeight = (0.5 * profile.WeightKg / Math.Pow(profile.HeightCm / 100.0, 2)) + 11.5;
                idealWeight = Math.Round(idealWeight, 1);
            }
            else
            {
                //Females: IBW = 45.5 kg + 2.3 kg for each inch over 5 feet

            }


                IdealWeight = 0;
            return idealWeight;
        }

        public int IdealProfileId { get; set; }

        //calculated
        public double IdealWeight { get; private set; }
        public double IdealBMI { get; private set; }
        public double IdealBodyFatPercentage { get; private set; }
        public double IdealBodyFatMass { get; private set; }

        public override bool Validate()
        {
            return true;
        }
    }
}
