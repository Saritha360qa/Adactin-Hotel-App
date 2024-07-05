


using Adactin_2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Adactin_2024.Pages
{
    public class Login_Page
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            // Lunch Adactin hotel page
            driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            Wait.WaitToBeClickable(driver, "Id", "username", 10);

            // Identify the username textbox and enter valid username
            IWebElement UsernameTextbox = driver.FindElement(By.Id("username"));
            UsernameTextbox.SendKeys("test18062");

            // Identify the password textbox and enter valid password
            IWebElement PasswordTextbox = driver.FindElement(By.Id("password"));
            PasswordTextbox.SendKeys("CQB8T7");

            //Identify the loginbutton and click on it
            IWebElement Loginbutton = driver.FindElement(By.Id("login"));
            Loginbutton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/table[2]/tbody/tr[1]/td[1]", 20);
            
            IWebElement Newcode = driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr[1]/td[1]"));
                       
            Assert.That(Newcode.Text == "Welcome to Adactin Group of Hotels", "Cannot find text 'Welcome to Adactin Group of Hotels'");
            
        }
         

    }
}

