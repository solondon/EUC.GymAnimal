using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public enum SetType
    {
        SingleSet = 1,
        SuperSet = 2,
        GiantSet = 3,
        ProgressiveSet,
        ForceSet
    }

    class SetItem
    {
        public SetItem()
        {
        }

        public SetItem(int setId)
        {
            this.SetId = setId;
        }

        public SetItem Retrive()
        {
            return new SetItem();
        }

        public List<SetItem> Retrieve()
        {
            return new List<SetItem>();
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

        public int SetId { get; private set; }
        public SetType SetType { get; set; }
        public string Exercise { get; set; }
        public string Notes { get; set; }

    }
}
