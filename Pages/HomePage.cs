using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCoreDemo.Pages
{
   public class HomePage
    {
        private IWebDriver Driver { get; }
        
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        public void ClickLogin() 
        {
            lnkLogin.Click();
        
        }

        public IWebElement lnkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));

        public bool IsEmployeeDetailsExists() => lnkEmployeeDetails.Displayed;

        public void ClickEmployeeDetails() 
        {
            lnkEmployeeDetails.Click();
        }
    }
}
