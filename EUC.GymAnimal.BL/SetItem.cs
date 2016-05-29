using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class SetItem : BaseEntity
    {
        public SetItem()
        {
        }

        public SetItem(int setItemId)
        {
            this.SetItemId = setItemId;
        }

        public override bool Validate()
        {
            if (NumberOfReps == 0) return false;
            return true;
        }

        public int SetItemId { get; set; }
        public int NumberOfReps { get; set; }
        public double Weight { get; set; }
        public double WeightRight { get; set; }
        public double WeightLeft { get; set; }

    }
}
