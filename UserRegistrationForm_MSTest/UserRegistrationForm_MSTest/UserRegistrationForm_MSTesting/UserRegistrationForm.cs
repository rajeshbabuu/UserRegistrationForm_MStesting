using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationForm_MSTest.UserRegistrationForm_MSTesting
{
    public class UserRegistrationForm
    {
        public static bool userForm(string fName)
        {

            string userFirstName = @"^[A-Z]{1}[a-z A-Z]{2,10}";

            Regex name = new Regex(userFirstName);
            bool firstName = name.IsMatch(fName);
            return firstName;
        }

        public static bool UserFormLastName(string lName)
        {
            string lastName = @"^[A-Z]{1}[a-z A-Z]{2,10}";

            Regex name = new Regex(lastName);
            bool LastName = name.IsMatch(lName);
            return LastName;
        }
    }
}