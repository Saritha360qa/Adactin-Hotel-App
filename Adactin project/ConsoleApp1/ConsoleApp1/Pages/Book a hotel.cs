using Adactin_2024.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_2024.Pages
{
    public class Bookahotel_Page
    {
        public void BookahotelActions(IWebDriver driver)
        {
            //Identify location dropdown box and select location
            IWebElement Locationdropdownbox = driver.FindElement(By.Id("location"));
            Locationdropdownbox.Click();
            IWebElement SelectSydney = driver.FindElement(By.XPath("//*[@id=\"location\"]/option[2]"));
            SelectSydney.Click();

            //Identify search button and click on search
            IWebElement Searchbutton = driver.FindElement(By.Id("Submit"));
            Searchbutton.Click();
            Wait.WaitToBeClickable(driver, "Id", "radiobutton_1", 10);

            //Identify Select button click on that button
            IWebElement SelectButton = driver.FindElement(By.Id("radiobutton_1"));
            SelectButton.Click();
            Wait.WaitToBeClickable(driver, "Id", "continue", 10);

            //Identify continue button and click on it
            IWebElement ContinueButton = driver.FindElement(By.Id("continue"));
            ContinueButton.Click();
            Wait.WaitToBeClickable(driver, "Id", "first_name", 10);

            //Identify firstnametextbox and click on
            IWebElement Firstnametextbox = driver.FindElement(By.Id("first_name"));
            Firstnametextbox.Click();

            //Identify lastnametextbox and click on 
            IWebElement Lastnametextbox = driver.FindElement(By.Id("last_name"));
            Lastnametextbox.Click();

            //Identify billingaddresstextbox and click on 
            IWebElement Billingaddresstextbox = driver.FindElement(By.Id("address"));
            Billingaddresstextbox.Click();

            //Identify Creditcardtextbox and click on 
            IWebElement Creditcardtextbox = driver.FindElement(By.Id("cc_num"));
            Creditcardtextbox.Click();
            IWebElement SelectCreditcardtypetextbox = driver.FindElement(By.XPath("//*[@id=\"cc_type\"]/option[2]"));
            SelectCreditcardtypetextbox.Click();

            //Identify Expirydatetextbox and click on 
            IWebElement Expirydatetextbox = driver.FindElement(By.Id("cc_exp_month"));
            Expirydatetextbox.Click();
            IWebElement SelectExpirydate = driver.FindElement(By.XPath("//*[@id=\"cc_exp_month\"]/option[2]"));
            SelectExpirydate.Click();

            //Identify Selectyeartextbox and click on
            IWebElement Selectyeartextbox = driver.FindElement(By.Id("cc_exp_year"));
            Selectyeartextbox.Click();
            IWebElement Selectyear = driver.FindElement(By.XPath("//*[@id=\"cc_exp_year\"]/option[2]"));
            Selectyear.Click();

            //Identify CVV number and click on
            IWebElement CVVtextbox = driver.FindElement(By.Id("cc_cvv"));
            CVVtextbox.Click();

            //Identify booknowtextbox click on it
            IWebElement BookNow = driver.FindElement(By.Id("book_now"));
            BookNow.Click();
        }
    }
}
