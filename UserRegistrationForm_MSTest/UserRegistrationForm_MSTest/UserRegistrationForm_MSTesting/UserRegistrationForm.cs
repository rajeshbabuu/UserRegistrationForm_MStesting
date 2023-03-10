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


        public static bool UpperCasePassWordRule_2(string password_2)
        {
            string passwordRule2 = @"^(?=.*[a-z])(?=.*[A-Z]).{8,}$";

            Regex name = new Regex(passwordRule2);
            bool password = name.IsMatch(password_2);
            return password;
        }

        public static bool Atleast1NumberPassWordRule_3(string password_3)
        {
            string passwordRule3 = @"^(?=.*[a-z])(?=.*[A-Z]).{8,}$";

            Regex name = new Regex(passwordRule3);
            bool password = name.IsMatch(password_3);
            return password;

        }

        public static bool Atleast1SpecialCharPassWordRule_4(string password_4)
        {
            string min1SpecialChar = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";

            Regex name = new Regex(min1SpecialChar);
            bool password = name.IsMatch(password_4);
            return password;
        }

        public static bool EmailSample(string email)
        {
            string valideEmailSample = @"^(abc)([_\+\-\.]{0,1}[a-zA-Z0-9])*[@][a-z0-9]{1,} *[.][a-z]{2,}[\.\,]{0,}[a-z]{0,}$";

            Regex name = new Regex(valideEmailSample);
            bool emailSample = name.IsMatch(email);
            return emailSample;
        }
    }
}