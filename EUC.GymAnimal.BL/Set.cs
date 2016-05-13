using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    class Set
    {
        public Set()
        {
        }

        public Set(int setId)
        {
            this.SetId = setId;
        }

        public Set Retrive()
        {
            return new Set();
        }

        public List<Set> Retrieve()
        {
            return new List<Set>();
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

        public int SetId { get; set; }
        public int NumberOfReps { get; set; }
        public double Weight { get; set; }
        public double WeightRight { get; set; }
        public double WeightLeft { get; set; }

    }
}
