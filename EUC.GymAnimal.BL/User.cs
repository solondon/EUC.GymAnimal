using EUC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class User : BaseEntity, ILoggable
    {
        public User()
        {
        }

        public User(int userID)
        {
            this.UserID = userID;
        }

        public override string ToString()
        {
            return FullName;
        }

        public string FullName
        {
            get
            {
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }

        //Calculate age
        public int Age
        {
            get
            {
                if (BirthDate == DateTime.MinValue) throw new ArgumentException("BirthDate has not been set, required to calculate age.");

                DateTime today = DateTime.Today;
                int age = today.Year - BirthDate.Year;
                if (BirthDate > today.AddYears(-age)) age--;

                return age;
            }
        }

        public Sex Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(FullName)) return false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) return false;
            return true;
        }

        public string Log()
        {
            var logString = this.UserID + ": " +
                              this.FullName + " " +
                              "Email: " + this.EmailAddress + " " +
                              "Status: " + this.EntityState.ToString();
            return logString;
        }

        private Sex _sex;

        public int UserID { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
