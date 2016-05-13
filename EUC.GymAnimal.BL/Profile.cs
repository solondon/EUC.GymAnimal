using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public enum WeightStatus
    {
        Underweight = 1,
        Normal,
        Overweight,
        UnKnown
    }

    public enum Sex
    {
        Male = 1,
        Female
    }

    public class Profile
    {
        public Profile()
        {
        }

        public Profile(int personMonitorId)
        {
            this.PersonMonitorId = personMonitorId;
        }

        public double BMI
        {
            get { return _bmi; }
            set { _bmi = value; }
        }

        public Profile Retrive()
        {
            return new Profile();
        }

        public List<Profile> Retrieve()
        {
            return new List<Profile>();
        }

        public double CalculateBMI()
        {
            double bmi = 0;

            //error checking
            if (Weight == 0) throw new Exception("Weight not specified cant calculate BMI");
            if (Height == 0) throw new Exception("Height not specified cant calculate BMI");

            //double BMI = kg / Math.Pow(heightInCm / 100.0, 2);
            bmi = Weight / Math.Pow(Height / 100.0, 2);
            bmi = Math.Round(bmi, 1);

            return bmi;
        }

        public WeightStatus CalculateWeightStatus(Sex gender)
        {
            WeightStatus status = WeightStatus.UnKnown;

            double bmi = CalculateBMI();

            if (gender == Sex.Male)
            {
                if (bmi < 20) status = WeightStatus.Underweight;
                else if (bmi >= 20 && bmi <= 25) status = WeightStatus.Normal;
                else if (bmi > 25) status = WeightStatus.Overweight;
            }
            else if (gender == Sex.Female)
            {
                if (bmi < 19) status = WeightStatus.Underweight;
                else if (bmi >= 20 && bmi <= 25) status = WeightStatus.Normal;
                else if (bmi > 25) status = WeightStatus.Overweight;
            }

            return status;
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValid = true;
            if (MeasurementDate==null) isValid = false;

            return isValid;
        }

        public int PersonMonitorId { get; set; }
        public DateTime? MeasurementDate { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BodyFatPercentage { get; set; }
        public double BodyFatMass { get; set; }
        public static int InstanceCount { get; set; }

        private double _bmi;

        //calculated
        public double IdealWeight { get; set; }
        public double IdealBMI { get; private set; }
        public double IdealBodyFatPercentage { get; private set; }
        public double IdealBodyFatMass { get; private set; }
        
    }
}
