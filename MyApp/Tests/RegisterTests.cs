using NUnit.Framework;

namespace MyApp.Tests
{
    [TestFixture]
    public class RegisterTests
    {
        [TestCase]
        public void Register()
        {
            var homepage = MyAppWebApp.Open();
            homepage.WaitLoading();
            var registerpage = homepage.ClickRegister();
            registerpage.EnterFirstName.SendKeys("Mark");
            registerpage.EnterLastName.SendKeys("Boucher");
            registerpage.SelectCountry.SelectByText("India");
            registerpage.EnterAddress.SendKeys("36/2 Lord Grandson Road, Colorado");
            registerpage.EnterContactNo.SendKeys("9856320140");
            registerpage.EnterDateOfBirth.SendKeys("20-09-1990");
            registerpage.EnterContactNo.Click();
            registerpage.EnterEmail.SendKeys("markboucher1990@gmail.com");
            registerpage.EnterPassword.SendKeys("mark1990");
            registerpage.EnterConfirmPassword.SendKeys("mark1990");

            registerpage.ClickCreateProfile();
        }
    }
}
