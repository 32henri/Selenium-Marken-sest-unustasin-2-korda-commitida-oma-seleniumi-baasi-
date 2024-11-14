using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace SeleniumMarken
{
    public class SecondTestCase
    {
        static void Main(string[] args)
        {
            //TestClick(); // Working/Pass
            //TestDouubleClick(); // Working/Pass
            //TestHiddenLayers(); // Working/Pass
            //TestClienntDelay(); // Working/Pass
            //Testloaddelays();  //Working/Pass
            //TestUpload();  //Working/Pass
            //TestHidingButton(); //Working/Pass

        }

        [Test]
        public static void TestClick()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/click";

            IWebElement element = driver.FindElement(By.Id("badButton"));
            element.Click();
        }
    }
}
