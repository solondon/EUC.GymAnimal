using EUC.Common;
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

    public class Profile : BaseEntity, ILoggable
    {
        public Profile()
        {
        }

        public Profile(int profileId)
        {
            this.ProfileId = profileId;
        }

        public double BMI
        {
            get { return _bmi; }
            set { _bmi = value; }
        }

        public double CalculateBMI()
        {
            double bmi = 0;

            //error checking
            if (WeightKg == 0) throw new Exception("WeightKg not specified cant calculate BMI");
            if (HeightCm == 0) throw new Exception("HeightCm not specified cant calculate BMI");

            //double BMI = kg / Math.Pow(heightInCm / 100.0, 2);
            bmi = WeightKg / Math.Pow(HeightCm / 100.0, 2);
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

        public override bool Validate()
        {
            bool isValid = true;
            if (MeasurementDate==null) isValid = false;
            if (WeightKg == 0) isValid = false;
            if (HeightCm == 0) isValid = false;
            return isValid;
        }

        public string Log()
        {
            var logstring= this.ProfileId + ": Heightcm: " + this.HeightCm
                + " WeightKg: " + this.WeightKg + " " + this.EntityState.ToString();

            return logstring;
        }

        public int ProfileId { get; set; }
        public DateTime? MeasurementDate { get; set; }
        public double WeightKg { get; set; }
        public double HeightCm { get; set; }
        public double BodyFatPercentage { get; set; }
        public double BodyFatMass { get; set; }
        public static int InstanceCount { get; set; }

        private double _bmi;
        
    }
}
