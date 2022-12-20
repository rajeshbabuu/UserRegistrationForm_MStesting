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
    }
}
