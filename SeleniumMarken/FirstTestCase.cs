using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumMarken
{
    public class FirstTestCase
    {
        static void Main(string[] args)
        {
            AutopoodTest();




            //TestClick(); // Working/Pass
            //TestDouubleClick(); // Working/Pass
            //TestHiddenLayers(); // Working/Pass
            //TestClienntDelay(); // Working/Pass
            //Testloaddelays();  //Working/Pass
            //TestUpload();  //Working/Pass
            //TestHidingButton(); //Working/Pass

        }

        [Test]

        public static void AutopoodTest()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\Source\\repos\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            try
            {
                driver.Url = "http://yourloginpage.com";

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
                usernameField.SendKeys("testuser");

                IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
                passwordField.SendKeys("TestPassword123");
                IWebElement loginButton = driver.FindElement(By.CssSelector("input[type='submit'][name='submit']"));
                loginButton.Click();

                wait.Until(driver => driver.Url.Contains("dashboard"));

                Console.WriteLine("Login successful!");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during login test: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }

        }

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

        [Test]
        public static void TestDouubleClick()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/mouseover";

            Actions actions = new Actions(driver);
            IWebElement element = driver.FindElement(By.ClassName("text-primary"));
            actions.DoubleClick(element).Perform();

        }

        [Test]
        public static void TestHiddenLayers()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/hiddenlayers";

            IWebElement element = driver.FindElement(By.Id("greenButton"));
            element.Click();
        }

        [Test]
        public static void TestClienntDelay()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/clientdelay";

            IWebElement element = driver.FindElement(By.Id("ajaxButton"));
            element.Click();
            Thread.Sleep(15000);
            IWebElement p = driver.FindElement(By.ClassName("bg-success"));
            p.Click();
        }

        [Test]
        public static void Testloaddelays()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/";

            IWebElement element = driver.FindElement(By.LinkText("Load Delay"));
            element.Click();
        }

        [Test]
        public static void TestUpload()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/upload";

            IWebElement fileInput = driver.FindElement(By.Id("file-upload"));
            string filePath = @"C:\path\to\your\file.txt";
            fileInput.SendKeys(filePath);

        }

        [Test]
        public static void TestHidingButton()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/scrollbars";

            IWebElement element = driver.FindElement(By.Id("hidingButton"));
            element.Click();
        }
    }
}
