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
            if (WeightKg == 0) throw new ArgumentException("WeightKg is required to calculate BMI");
            if (HeightCm == 0) throw new ArgumentException("HeightCm is required to calculate BMI");

            double bmi = WeightKg / Math.Pow(HeightCm / 100.0, 2);
            bmi = Math.Round(bmi, 1);
            return bmi;
        }

        public WeightStatus CalculateWeightStatus(Sex gender)
        {
            double bmi = CalculateBMI();

            const int lowMaleBmi = 20;
            const int lowFemaleBmi = 19;
            const int highBmi = 25;

            WeightStatus status = WeightStatus.UnKnown;
            if (gender == Sex.Male) status = CalculateUserWeightStatus(bmi, lowMaleBmi, highBmi);
            else if (gender == Sex.Female) status = CalculateUserWeightStatus(bmi, lowFemaleBmi, highBmi);

            return status;
        }

        private static WeightStatus CalculateUserWeightStatus( double bmi, int lowBmi, int highBmi)
        {
            WeightStatus status;

            if (bmi < lowBmi) status = WeightStatus.Underweight;
            else if (bmi >= lowBmi && bmi <= highBmi) status = WeightStatus.Normal;
            else if (bmi > highBmi) status = WeightStatus.Overweight;
            else status = WeightStatus.UnKnown;

            return status;
        }

        public override bool Validate()
        {
            if (MeasurementDate==null) return false;
            if (WeightKg == 0) return false;
            if (HeightCm == 0) return false;
            return true;
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

        private double _bmi;
        
    }
}
