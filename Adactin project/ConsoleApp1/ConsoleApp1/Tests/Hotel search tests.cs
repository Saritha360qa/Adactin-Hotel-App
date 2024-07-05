using Adactin_2024.Pages;
using Adactin_2024.Reports;
using Adactin_2024.Utilities;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_2024.Tests
{
    [TestFixture]
    public class Hotelsearchtests : Commondriver
    {

        //page object intialization
        
        Register_Page RegisterPageobj = new Register_Page();
        Login_Page LoginPageobj = new Login_Page();
        Home_Page HomePageobj = new Home_Page();
        Bookahotel_Page BookahotelPageobj = new Bookahotel_Page();


        [Test, Order(1), Description("check if user is able to Register with valid data")]
        public void RegisterTest()
        {
            ExtentReporting.LogInfo($"Log on to Home page");
            RegisterPageobj.RegisterActions(driver);
        }
        [Test, Order(2), Description("check if user is able to enter valid data in login page")]
            public void LoginpageTest()
            {
                try
                {
                    ExtentReporting.CreateTest("LoginpageTest");
                    ExtentReporting.LogInfo("Log on to Home page");

                    // HomePage object initialization and definition
                    LoginPageobj.LoginActions(driver);

                    ExtentReporting.LogPass("LoginpageTest passed successfully.");
                }
                catch (Exception ex)
                {
                    ExtentReporting.LogFail($"LoginpageTest failed: {ex.Message}");
                    ExtentReporting.LogFail(ex.StackTrace);
                    throw; // Rethrow the exception to ensure the test is marked as failed in the test runner
                }
                finally
                {
                    ExtentReporting.EndReporting(); // Ensure the report is flushed
                }
            }

        [Test, Order(3), Description("check if user is able to enter valid data in hotel search page")]
        public void HomepageTest()
        {
            try
            {
                ExtentReporting.CreateTest("HomepageTest");
                ExtentReporting.LogInfo("Log on to Home page");

                // HomePage object initialization and definition
                LoginPageobj.LoginActions(driver);
                HomePageobj.HomeActions(driver);

                ExtentReporting.LogPass("LoginpageTest passed successfully.");
            }
            catch (Exception ex)
            {
                ExtentReporting.LogFail($"HomepageTest failed: {ex.Message}");
                ExtentReporting.LogFail(ex.StackTrace);
                throw; // Rethrow the exception to ensure the test is marked as failed in the test runner
            }
            finally
            {
                ExtentReporting.EndReporting(); // Ensure the report is flushed
            }
        }
        [Test, Order(4), Description("check if user is able to enter valid data in book a hotel page")]
        public void BookahotelTest()
        {
            try
            {
                ExtentReporting.CreateTest("BookahotelpageTest");
                ExtentReporting.LogInfo("Log on to Bookahotel page");

                // HomePage object initialization and definition
                LoginPageobj.LoginActions(driver);
                BookahotelPageobj.BookahotelActions(driver);

                ExtentReporting.LogPass("BookahotelpageTest passed successfully.");
            }
            catch (Exception ex)
            {
                ExtentReporting.LogFail($"BookahotelpageTest failed: {ex.Message}");
                ExtentReporting.LogFail(ex.StackTrace);
                throw; // Rethrow the exception to ensure the test is marked as failed in the test runner
            }
            finally
            {
                ExtentReporting.EndReporting(); // Ensure the report is flushed
            }
        }
    }    
}
