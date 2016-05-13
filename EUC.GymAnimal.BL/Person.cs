﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.GymAnimal.BL
{
    public class Person
    {
        public Person()
        {
        }

        public Person(int personId)
        {
            this.PersonId = personId;
        }

        private int _age;
        private Sex _sex;

        public int PersonId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static int InstanceCount { get; set; }

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

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Sex Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

 

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(FullName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}