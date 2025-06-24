using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;



namespace ParkingSeleniumProject.Core.Entities
{
    public class TestSelenium
    {
        [Test]
        public void Test1() 
        {
            //1.Krijimi i nje instace(kopje) te seleniumit
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //2.Navigimi ne URL
            driver.Navigate().GoToUrl("http://localhost:3000/");

            // 3. Kliko butonin e login
            driver.FindElement(By.XPath("//button[text()='Login']")).Click();

            // Prit që të jenë të disponueshme fushat
            var userField = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-testid='input-userName']")));
            var passField = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-testid='input-password']")));

            // Plotëson të dhënat
            userField.SendKeys("leart");
            passField.SendKeys("leart123");

            // Kliko butonin "Login"
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[data-testid='btn-primary']"))).Click();



            Thread.Sleep(5000);

            driver.Quit();
        } 

    
    }
}
