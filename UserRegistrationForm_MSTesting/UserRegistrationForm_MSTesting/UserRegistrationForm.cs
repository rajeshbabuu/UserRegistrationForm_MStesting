using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationForm_MSTesting
{
    public class UserRegistrationForm
    {
        public static bool userForm(string fName)
        {
            string first = @"^[A-Z]{1}[a-z A-Z]{2,10}";

            Regex name = new Regex(first);
            bool frst = name.IsMatch(fName);
            return frst;
        }
    }
}
