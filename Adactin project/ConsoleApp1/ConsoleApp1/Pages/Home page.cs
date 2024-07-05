using Adactin_2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_2024.Pages
{
    public class Home_Page
    {
        public void HomeActions(IWebDriver driver)
        {
            //Identify location dropdown box and select location
            IWebElement Locationdropdownbox = driver.FindElement(By.Id("location"));
            Locationdropdownbox.Click();
            IWebElement SelectSydney = driver.FindElement(By.XPath("//*[@id=\"location\"]/option[2]"));
            SelectSydney.Click();

            //Identify Hotels dropdown box and select hotel
            IWebElement Hotelsdropdownbox = driver.FindElement(By.Id("hotels"));
            Hotelsdropdownbox.Click();
            IWebElement SelectHotel = driver.FindElement(By.XPath("//*[@id=\"hotels\"]/option[2]"));
            SelectHotel.Click();

            //Identify Roomtype dropdown and select room
            IWebElement Roomtypedropdown = driver.FindElement(By.Id("room_type"));
            Roomtypedropdown.Click();
            IWebElement selectroom = driver.FindElement(By.XPath("//*[@id=\"room_type\"]/option[2]"));
            selectroom.Click();

            //Identify numberofroomsdropdownbox and select numberofrooms
            IWebElement Numberofroomsdropdownbox = driver.FindElement(By.Id("room_nos"));
            Numberofroomsdropdownbox.Click();
            IWebElement selectnumberofrooms = driver.FindElement(By.XPath("//*[@id=\"room_nos\"]/option[3]"));
            selectnumberofrooms.Click();

            //Identify Checkindate textbox and enter date
            IWebElement Checkindatetextbox = driver.FindElement(By.Id("datepick_in"));
            Checkindatetextbox.SendKeys("26/07/2024");

            //Identify Checkoutdatetextbox and enter date
            IWebElement Checkoutdatetextbox = driver.FindElement(By.Id("datepick_out"));
            Checkoutdatetextbox.SendKeys("02/08/2024");

            //Identify adults per room dropdown box and enter the valid data
            IWebElement Adultperroomdropdownbox = driver.FindElement(By.Id("adult_room"));
            Adultperroomdropdownbox.Click();
            IWebElement Enteradultsperroom = driver.FindElement(By.XPath("//*[@id=\"adult_room\"]/option[2]"));
            Enteradultsperroom.Click();

            //Identify Childrenperroom dropdownbox and enter valid data
            IWebElement Childrenperroomdropdownbox = driver.FindElement(By.Id("child_room"));
            Childrenperroomdropdownbox.Click();
            IWebElement Enterchildrenperroom = driver.FindElement(By.XPath("//*[@id=\"child_room\"]/option[2]"));
            Enterchildrenperroom.Click();

            //Identify search button and click on search
            IWebElement Searchbutton = driver.FindElement(By.Id("Submit"));
            Searchbutton.Click();
            Wait.WaitToBeClickable(driver, "Id", "radiobutton_0", 30);

            //Identify Select button click on that button
            IWebElement SelectButton = driver.FindElement(By.Id("radiobutton_0"));
            SelectButton.Click();
            Wait.WaitToBeClickable(driver, "Id", "continue", 30);

            //Identify continue button and click on it
            IWebElement ContinueButton = driver.FindElement(By.Id("continue"));
            ContinueButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"book_hotel_form\"]/table/tbody/tr[2]/td", 30);


            IWebElement Newcode = driver.FindElement(By.XPath("//*[@id=\"book_hotel_form\"]/table/tbody/tr[2]/td"));

            Assert.That(Newcode.Text == "Book A Hotel", "Cannot find text 'Book A Hotel'");

        }
    }
}
