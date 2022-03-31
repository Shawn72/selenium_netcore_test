using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NotificationUnitTest
{    
    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            try
            {
                Driver.Navigate().GoToUrl("http://localhost:8007/");
                Driver.FindElement(By.Name("Email")).SendKeys("seanmbuvi5@gmail.com");
                Driver.FindElement(By.Name("Password")).SendKeys("2950Cherry*307");
                Driver.FindElement(By.ClassName("btnLogin")).Click();
                Assert.Pass();
            }
            catch(AssertionException ex)
            {
                throw new AssertionException(ex.Message);
            }
                     
        }

        [Test]
        public void TestRegister()
        {
            try
            {
                Driver.Navigate().GoToUrl("http://localhost:8007/Account/Register");
                Driver.FindElement(By.Id("FirstName")).SendKeys("shawn");
                Driver.FindElement(By.Id("LastName")).SendKeys("mbuvi");
                Driver.FindElement(By.Id("Email")).SendKeys("shawnmbuvi@gmail.com");
                Driver.FindElement(By.Id("Password")).SendKeys("2950Cherry");
                Driver.FindElement(By.Id("ConfirmPassword")).SendKeys("2950Cherry");
                Driver.FindElement(By.ClassName("btnRegister")).Click();
                Assert.Pass();
            }
            catch (AssertionException ex)
            {
                throw new AssertionException(ex.Message);
            }
        }
    }
}