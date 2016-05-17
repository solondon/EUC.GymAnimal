using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public enum TypeOfSet
    {
        UnKnown = 0,
        SingleSet = 1,
        SuperSet = 2,
        GiantSet = 3,
        ProgressiveSet,
        ForceSet
    }

    public class SetMaster : BaseEntity
    {
        public SetMaster()
        {
        }

        public SetMaster(int setMasterId)
        {
            this.SetMasterId = setMasterId;
        }

        public override bool Validate()
        {
            bool isValid = true;
            if (SetType == TypeOfSet.UnKnown) isValid = false;
            if (string.IsNullOrWhiteSpace(Exercise)) isValid = false;

            return isValid;
        }

        public int SetMasterId { get; private set; }
        public TypeOfSet SetType { get; set; }
        public string Exercise { get; set; }
        public string Notes { get; set; }

    }
}
