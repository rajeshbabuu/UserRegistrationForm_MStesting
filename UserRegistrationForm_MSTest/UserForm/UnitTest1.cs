using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserForm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void fName()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.userForm("Rajesh");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LastName()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.UserFormLastName("Kumar");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValideEmail(object UserRegistrationForm_MSTesting)
        {
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.UserValideEmail("abc.xyz@bl.co.in");
            Assert.IsTrue(result);
        }
    }
}

