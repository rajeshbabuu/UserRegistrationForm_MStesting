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
        public static bool UserForm(string fName)
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
        public static bool UserValideEmail(string emailName)
        {
            string userEmail = @"^[a][b][c]+([.][a-z A-Z 0-9]+)*@[bl]+.[co]{2,10}([.][a-z A-Z]{1,5})?$";

            Regex name = new Regex(userEmail);
            bool valideEmail = name.IsMatch(emailName);
            return valideEmail;
        }
        public static bool MobileNumber(string mobileNum)
        {
            string userMobile = @"[6-9][0-9]{9}";

            Regex name = new Regex(userMobile);
            bool mobileNumber = name.IsMatch(mobileNum);
            return mobileNumber;
        }
        public static bool PassWordRule1(string password)
        {
            string passwordRule1 = @"^[a-z A-Z]{8,}";

            Regex name = new Regex(passwordRule1);
            bool formPassword = name.IsMatch(password);
            return formPassword;
        }
    }
}