using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    //TODO how to tie this into db table
    public enum SetType
    {
        UnKnown = 1,
        SingleSet=2 ,
        SuperSet=3,
        GiantSet=4,
        ProgressiveSet=5,
        ForceSet=6
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
            if (SetType == SetType.UnKnown) return false;
            if (string.IsNullOrWhiteSpace(Exercise)) return false;
            return true;
        }

        public int SetMasterId { get; private set; }
        public SetType SetType { get; set; }
        public string Exercise { get; set; }
        public string Notes { get; set; }
        public List<SetItem> setItems { get; set; }

    }
}
