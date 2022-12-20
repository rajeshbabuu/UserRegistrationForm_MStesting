using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserForm
{
    [TestClass]
    public class UnitTest1
    {
        private object UserRegistrationForm_MSTesting;

        [TestMethod]
        public void TestMethod1()
        
            
            
            {
                bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.userForm("Sanjeev");
                Assert.IsTrue(result);
            }
    }
}
