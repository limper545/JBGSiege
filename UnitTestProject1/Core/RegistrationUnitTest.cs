using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaB_1._0.Core;

namespace UnitTestProject1
{
    [TestClass]
    public class RegistrationUnitTest
    {
        [TestMethod]
        public void CheckCorrectEmailFormat()
        {
            bool checkEmailBool;
            string wrongEmail = "testr@";
            string nextWrongEmail = "sda";

            string correctEmail = "test@gmail.de";
            string nexrCorrectEmail = "test@gmx.net";

            checkEmailBool = Validations.CorrectEmailFormat(wrongEmail);
            Assert.AreEqual(checkEmailBool, false);
            Assert.AreNotEqual(checkEmailBool, true);

            checkEmailBool = Validations.CorrectEmailFormat(nextWrongEmail);
            Assert.AreEqual(checkEmailBool, false);
            Assert.AreNotEqual(checkEmailBool, true);


            checkEmailBool = Validations.CorrectEmailFormat(correctEmail);
            Assert.AreEqual(checkEmailBool, true);
            Assert.AreNotEqual(checkEmailBool, false);

            checkEmailBool = Validations.CorrectEmailFormat(nexrCorrectEmail);
            Assert.AreEqual(checkEmailBool, true);
            Assert.AreNotEqual(checkEmailBool, false);
        }

        [TestMethod]
        public void CheckIfFieldIsFilled()
        {
            //String vorname, String nachname, String email, String user, String passwordOne, String passwordTwo
            String response;

            string vorname = "test", nachname = "test", email = "test", user = "test", passwordOne = "test", passwordTwo = "test";
            response = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual(response, "OK");

            vorname = "test";
            nachname = "test";
            email = "test";
            user = "test";
            passwordOne = "test";
            passwordTwo = "";
            response = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual(response, "Passwort");

            vorname = "test";
            nachname = "test";
            email = "test";
            user = "test";
            passwordOne = "";
            passwordTwo = "";
            response = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual(response, "Passwort");

            vorname = "test";
            nachname = "test";
            email = "test";
            user = "";
            passwordOne = "";
            passwordTwo = "";
            response = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual(response, "Username");

            vorname = "test";
            nachname = "test";
            email = "";
            user = "";
            passwordOne = "";
            passwordTwo = "";
            response = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual(response, "E-Mail Adresse");

            vorname = "test";
            nachname = "";
            email = "";
            user = "";
            passwordOne = "";
            passwordTwo = "";
            response = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual(response, "Nachname");

            vorname = "";
            nachname = "";
            email = "";
            user = "";
            passwordOne = "";
            passwordTwo = "";
            response = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual(response, "Vorname");

        }
    }
}
