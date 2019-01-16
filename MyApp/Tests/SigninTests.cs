using NUnit.Framework;

namespace MyApp.Tests
{
    [TestFixture]
    public class SigninTests
    {
        [TestCase]
        public void SignIn()
        {
            var homepage = MyAppWebApp.Open();
            homepage.WaitLoading();
            var signin = homepage.ClickSignIn();
            signin.EnterEmail.SendKeys("markboucher1990@gmail.com");
            signin.EnterPassword.SendKeys("mark1990");
            signin.ClickSigninbutton();
        }
    }
}
