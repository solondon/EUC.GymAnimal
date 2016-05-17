using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class SetItemRepository
    {

        public SetItem Retrieve(int setItemId)
        {
            // Create the instance of the SetMaster class
            // Pass in the requested Id
            SetItem setItem = new SetItem(setItemId);

            // Code that retrieves the defined product

            // Temporary hard coded values to return 
            // a populated product
            if (setItemId == 1)
            {
                setItem.NumberOfReps = 15;
                setItem.Weight = 10;
            }

            return setItem;
        }

        public List<SetItem> Retrieve()
        {
            return new List<SetItem>();
        }

        public bool Save(SetItem setItem)
        {
            var success = true;

            if (setItem.HasChanges && setItem.IsValid)
            {
                if (setItem.IsNew)
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
    }
}
