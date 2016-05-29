using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class UserRepository
    {
        public User Retrieve(int userID)
        {
            User user = new User(userID);

            //code to retrieve instance of the Person class

            // Temporary hard coded values to return 
            // a populated Person
            if (userID==1)
            {
                user.BirthDate = new DateTime(1968,04,14);
                user.EmailAddress = "jlopez@jlopez.co.uk";
                user.FirstName = "Juan";
                user.LastName = "Lopez";
                user.Sex = Sex.Male;
            }

            return user;
        }

        public bool Save(User user)
        {
            var success = true;

            if (user.HasChanges && user.IsValid)
            {
                if (user.IsNew)
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
