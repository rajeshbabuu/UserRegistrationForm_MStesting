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
        [TestMethod]
        public void MobileNumber()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.MobileNumber("8865851436");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PassWordRule_1()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.PassWordRule1("rajeshkumar");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void UpperCasePassWordRule_2()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.UpperCasePassWordRule_2("RajeshKumar");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Atleast1NumberPassWordRule_3()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.Atleast1NumberPassWordRule_3("RajeshKumar1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Atleast1SpecialCharPassWordRule_4()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.Atleast1SpecialCharPassWordRule_4("RajeshKumar@1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmailSample()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc@yahoo.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample2()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc-100@yahoo.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample3()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc.100@yahoo.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample4()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc111@abc.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample5()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc-100@abc.net");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample6()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc.100@abc.com.au");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample7()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc@1.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample8()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc@gmail.com.com");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailSample9()
        {
            object UserRegistrationForm_MSTesting = null;
            bool result = UserRegistrationForm_MSTesting.UserRegistrationForm.EmailSample("abc+100@gmail.com");
            Assert.IsTrue(result);
        }
    }
}

