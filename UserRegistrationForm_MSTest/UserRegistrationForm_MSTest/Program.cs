using UserRegistrationForm_MSTest.UserRegistrationForm_MSTesting;

namespace UserRegistrationForm_MSTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** WELCOME TO USER REGISTRATION FORM PROGRAM *********************");

            Console.Write("Enter first name : ");
            string fName = Console.ReadLine();
            UserRegistrationForm.UserForm(fName);

            Console.Write("Enter last name : ");
            string lName = Console.ReadLine();
            UserRegistrationForm.UserFormLastName(lName);

            Console.Write("Enter the email address : ");
            string emailAddress = Console.ReadLine();
            UserRegistrationForm.UserFormLastName(emailAddress);


            Console.Write("Enter the Mobile Number : ");
            string mobileNumber = Console.ReadLine();
            UserRegistrationForm.UserFormLastName(mobileNumber);

            Console.Write("Enter the Mobile Number : ");
            string userPassWord = Console.ReadLine();
            UserRegistrationForm.UserFormLastName(userPassWord);
        }
    }
}