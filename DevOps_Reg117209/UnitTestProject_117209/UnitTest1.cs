
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System;

namespace UnitTestProject_117209
{

    [TestFixture]
    public class UnitTest1
    {

        [TestInitialize]
        public void SetupTest()
        {
           // FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\driver", "geckodriver.exe");
           // service.Port = 64444;
           // service.FirefoxBinaryPath = @"C:\Program Files (x86)\Firefox Developer Edition\firefox.exe";
            //IWebDriver driver = new FirefoxDriver(service);
           
        }

        [Test]
        public void TestTitle()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\driver", "geckodriver.exe");
            
           // service.FirefoxBinaryPath = @"D:\Program Files (x86)\Firefox Developer Edition\firefox.exe";
            IWebDriver driver=new FirefoxDriver(service);
            driver.Navigate().GoToUrl("http://localhost/Devops117209/login.aspx");
            Assert.AreEqual("Login", driver.Title);
            driver.Quit();
        }

       

        [Test]
        public void verifyValidLogin()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\driver", "geckodriver.exe");
            //service.Port = 56034;
            // service.FirefoxBinaryPath = @"D:\Program Files (x86)\Firefox Developer Edition\firefox.exe";
            IWebDriver driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("http://localhost/Devops117209/login.aspx");
            driver.FindElement(By.Id("txtUserId")).SendKeys("DEVOPS");
            driver.FindElement(By.Id("txtPwd")).SendKeys("Wipro@123");

            driver.FindElement(By.Id("cmdLogin")).Click();

            IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("SUCCESS"));
            driver.Quit();

        }

        [Test]
        public void verifyInValidLogin()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\driver", "geckodriver.exe");
            //service.Port = 56034;
            // service.FirefoxBinaryPath = @"D:\Program Files (x86)\Firefox Developer Edition\firefox.exe";
            IWebDriver driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("http://localhost/Devops117209/login.aspx");
            driver.FindElement(By.Id("txtUserId")).SendKeys("DEVOPS");
            driver.FindElement(By.Id("txtPwd")).SendKeys("fff@123");

            driver.FindElement(By.Id("cmdLogin")).Click();

            IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Login/Password Incorrect"));
            driver.Quit();
        }
    }

    internal class TestInitializeAttribute : Attribute
    {
    }
}
