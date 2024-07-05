using Adactin_2024.Utilities;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Adactin_2024.Pages
{
    public class Register_Page
    {
        public void RegisterActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            // Lunch Adactin hotel page
            driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"login_form\"]/table/tbody/tr[7]/td/a", 10);

            //Identify Register here text box and click on it
            IWebElement Registerheretextbox = driver.FindElement(By.XPath("//*[@id=\"login_form\"]/table/tbody/tr[7]/td/a"));
            Registerheretextbox.Click();

            //Get Timestamp and generate unique email
            var Timestamp = Stopwatch.GetTimestamp();
            var username = "Saritha" + Timestamp.ToString();


            //Identify Username textbox and enter valid user name
            IWebElement Usernametextbox = driver.FindElement(By.Id("username"));
            Usernametextbox.SendKeys(username);

            //Identify Password textbox and enter valid password
            IWebElement Passwordtextbox = driver.FindElement(By.Id("password"));
            Passwordtextbox.SendKeys("CQB8T7");

            //Identify confirm password textbox and enter valid password
            IWebElement Confirmpasswordtextbox = driver.FindElement(By.Id("re_password"));
            Confirmpasswordtextbox.SendKeys("CQB8T7");

            //Identify Fullname textbox and enter valid name
            IWebElement Fullnametextbox = driver.FindElement(By.Id("full_name"));
            Fullnametextbox.SendKeys("test test");

            //Get Timestamp and generate unique email
            var email = "Saritha" + Timestamp.ToString() + "@grr.la";

            //Identify the Emailid textbox and enter the valid Emailid
            IWebElement emailidtextbox = driver.FindElement(By.Id("email_add"));
            emailidtextbox.SendKeys(email);


            //Identify Captcha image and enter valid captcha
            Console.WriteLine("please solve the captcha and press enter to continue");
            
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"captcha_span\"]/b", 30);

            IWebElement Newcode = driver.FindElement(By.XPath("//*[@id=\"captcha_span\"]/b"));
            Assert.That(Newcode.Text == "Captcha Verified Succesfully", "Actual code and expected code do Not match");

            //Identify Terms and conditions tik box and click on that
            IWebElement Termsandconditionscheckbox = driver.FindElement(By.Id("tnc_box"));
            Termsandconditionscheckbox.Click();

            //Identify Register button and click on it
            IWebElement Registerbutton = driver.FindElement(By.Id("Submit"));
            Registerbutton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/table[2]/tbody/tr/td[1]/table/tbody/tr/td", 60);
         
            IWebElement Newcode1 = driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[1]/table/tbody/tr/td"));
            
            Assert.That(
    Regex.IsMatch(Newcode1.Text, @"An email verification code has been sent to your email address."),
    "Cannot find text 'An email verification code has been sent to your email address.");
        }
    }
       
}





