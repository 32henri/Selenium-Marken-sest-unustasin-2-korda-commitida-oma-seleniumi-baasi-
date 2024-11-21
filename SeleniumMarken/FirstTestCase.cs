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
            //AutopoodTestLoginFail(); //Working/Pass
            //AutopoodTestLoginUser(); //Working/Pass
            //AutopoodTestSugnupUser(); //Working/Pass
            //AutopoodTestSugnupAndLoginUser(); //Working/Pass
            AutopoodTestGoToCarAndCreateNew(); //
            




            //TestClick(); // Working/Pass
            //TestDouubleClick(); // Working/Pass
            //TestHiddenLayers(); // Working/Pass
            //TestClienntDelay(); // Working/Pass
            //Testloaddelays();  //Working/Pass
            //TestUpload();  //Working/Pass
            //TestHidingButton(); //Working/Pass

        }

        [Test]

        public static void AutopoodTestLoginFail()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\Source\\repos\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            driver.Url = "http://localhost:5115/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField.SendKeys("nimi");

            IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField.SendKeys("parool");
            IWebElement loginButton = driver.FindElement(By.CssSelector("input[type='submit'][name='submit']"));
            loginButton.Click();

            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Login/Verify"));

            Console.WriteLine("Login successful!");


        }

        [Test]

        public static void AutopoodTestLoginUser()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\Source\\repos\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            driver.Url = "http://localhost:5115/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField.SendKeys("Henri");

            IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField.SendKeys("Henri");
            IWebElement loginButton = driver.FindElement(By.CssSelector("input[type='submit'][name='submit']"));
            loginButton.Click();

            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Login/Verify"));

            Console.WriteLine("Login successful!");


        }


        [Test]

        public static void AutopoodTestSugnupUser()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\Source\\repos\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            driver.Url = "http://localhost:5115/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement createAccountButton = driver.FindElement(By.LinkText("Create Account"));
            createAccountButton.Click();

            IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField.SendKeys("1");

            IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField.SendKeys("1");

            IWebElement signUpButton = driver.FindElement(By.CssSelector("button[type='submit']"));
            signUpButton.Click();

            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Signup/Register"));

            Console.WriteLine("SignUp successful!");


        }

        [Test]

        public static void AutopoodTestSugnupAndLoginUser()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\Source\\repos\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            driver.Url = "http://localhost:5115/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement createAccountButton = driver.FindElement(By.LinkText("Create Account"));
            createAccountButton.Click();

            IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField.SendKeys("1");

            IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField.SendKeys("1");

            IWebElement signUpButton = driver.FindElement(By.CssSelector("button[type='submit']"));
            signUpButton.Click();

            IWebElement loginButton = driver.FindElement(By.LinkText("Login"));
            loginButton.Click();

            IWebElement usernameField1 = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField1.SendKeys("1");

            IWebElement passwordField1 = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField1.SendKeys("1");

            IWebElement loginButton1 = driver.FindElement(By.CssSelector("input[type='submit'][name='submit']"));
            loginButton1.Click();

            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Login/Verify"));

            Console.WriteLine("SignUp and LogIn successful!");


        }

        [Test]

        public static void AutopoodTestGoToCarAndCreateNew()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\Source\\repos\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            driver.Url = "http://localhost:5115/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField.SendKeys("Henri");

            IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField.SendKeys("Henri");

            IWebElement loginButton = driver.FindElement(By.CssSelector("input[type='submit'][name='submit']"));
            loginButton.Click();

            IWebElement carButton = driver.FindElement(By.LinkText("Cars"));
            carButton.Click();

            IWebElement carCreateButton = driver.FindElement(By.LinkText("Create new car"));
            carCreateButton.Click();

            IWebElement markField = wait.Until(driver => driver.FindElement(By.Id("Mark")));
            markField.SendKeys("BMW");
            IWebElement dercriptionField = wait.Until(driver => driver.FindElement(By.Id("Description")));
            dercriptionField.SendKeys("Blinker where");
            IWebElement priceField = wait.Until(driver => driver.FindElement(By.Id("Price")));
            priceField.SendKeys("123456");
            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Login/Verify"));

            Console.WriteLine("SignUp and LogIn successful!");


        }

        [Test]

        public static void TestClick()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);
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