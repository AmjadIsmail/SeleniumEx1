using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCoreDemo.Pages;

namespace SeleniumCoreDemo
{
    class LoginTest
    {
        IWebDriver webDriver = new ChromeDriver();

        // Hooks in NUnit
        [SetUp]
        public void Setup()
        {

            // Navigate to Site

            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");

        }


        [Test]
        public void Login()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();


            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("admin", "password");
            Assert.That(homePage.IsEmployeeDetailsExists, Is.True);

            homePage.ClickEmployeeDetails();


        }
    }
}