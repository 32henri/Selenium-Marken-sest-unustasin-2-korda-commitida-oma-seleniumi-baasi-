using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Script;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Numerics;

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
            //AutopoodTestGoToCarAndCreateNew(); //Working/Pass
            //AutopoodTestGoToCarAndDetails(); //Working/Pass
            //AutopoodTestGoToCarAndEdit(); //Working/Pass
            //AutopoodTestGoToCarAndDelete(); //Working/Pass
            //AutopoodTestGoToCarClientAndDetails(); //Working/Pass
            //AutopoodTestGoToPlaneAndDetails(); //Working/Pass
            //AutopoodTestGoToPlaneAndCreateNew(); //Working/Pass
            //AutopoodTestGoToPlaneAndEdit(); //Working/Pass
            //AutopoodTestGoToPlaneClientAndDetails(); //Working/Pass






            //TestClick(); // Working/Pass
            //TestDouubleClick(); // Working/Pass
            //TestHiddenLayers(); // Working/Pass
            //TestClienntDelay(); // Working/Pass
            //Testloaddelays();  //Working/Pass
            //TestUpload();  //Working/Pass
            //TestHidingButton(); //Working/Pass

        }

        [Test]

        public static void AutopoodTestGoToPlaneClientAndDetails()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            driver.Url = "http://localhost:5115/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField.SendKeys("Henri");

            IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField.SendKeys("Henri");

            IWebElement loginButton = driver.FindElement(By.CssSelector("input[type='submit'][name='submit']"));
            loginButton.Click();

            IWebElement carButton = driver.FindElement(By.LinkText("Planes Client"));
            carButton.Click();

            IWebElement carCreateButton = driver.FindElement(By.LinkText("Details"));
            carCreateButton.Click();


            wait.Until(driver => driver.Url.Contains("http://localhost:5115/PlanesForClients/details/"));

            Console.WriteLine("Plane client details success!");

        }

        [Test]

        public static void AutopoodTestGoToPlaneAndCreateNew()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            driver.Url = "http://localhost:5115/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField.SendKeys("Henri");

            IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField.SendKeys("Henri");

            IWebElement loginButton = driver.FindElement(By.CssSelector("input[type='submit'][name='submit']"));
            loginButton.Click();

            IWebElement carButton = driver.FindElement(By.LinkText("Planes"));
            carButton.Click();

            IWebElement carCreateButton = driver.FindElement(By.LinkText("Add Car"));
            carCreateButton.Click();

            IWebElement markField = wait.Until(driver => driver.FindElement(By.Id("Name")));
            markField.SendKeys("BMW");

            IWebElement priceField = wait.Until(driver => driver.FindElement(By.Id("Price")));
            priceField.SendKeys("123456");

            IWebElement dercriptionField = wait.Until(driver => driver.FindElement(By.Id("Description")));
            dercriptionField.SendKeys("Blinker where");

            IWebElement modelField = wait.Until(driver => driver.FindElement(By.Id("Model")));
            modelField.SendKeys("X5");

            IWebElement yearField = wait.Until(driver => driver.FindElement(By.Id("Year")));
            yearField.SendKeys("2020");

            IWebElement registerField = wait.Until(driver => driver.FindElement(By.Id("Register")));
            registerField.SendKeys("ABC1234");

            IWebElement serialNumberField = wait.Until(driver => driver.FindElement(By.Id("SerialNumber")));
            serialNumberField.SendKeys("123456789");

            IWebElement engineField = wait.Until(driver => driver.FindElement(By.Id("Engine")));
            engineField.SendKeys("V8");

            IWebElement seatsField = wait.Until(driver => driver.FindElement(By.Id("Seats")));
            seatsField.SendKeys("5");

            IWebElement mileageField = wait.Until(driver => driver.FindElement(By.Id("Propeller")));
            mileageField.SendKeys("Fixed-Pitch");

            IWebElement timeField = wait.Until(driver => driver.FindElement(By.Id("TotalTime")));
            mileageField.SendKeys("10");

            IWebElement inspectionCheckbox = wait.Until(driver => driver.FindElement(By.Id("Inspection")));
            inspectionCheckbox.Click();

            IWebElement fileInput = wait.Until(driver => driver.FindElement(By.Id("Files")));
            string filePath = @"C:\Users\opilane\source\repos\Untitled.jpg";
            fileInput.SendKeys(filePath);

            IWebElement submitButton = wait.Until(driver => driver.FindElement(By.CssSelector("input[type='submit'].btn.btn-primary[value='Update']")));
            submitButton.Click();

            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Planes"));

            Console.WriteLine("Plane creation success!");

        }

        [Test]

        public static void AutopoodTestGoToPlaneAndEdit()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            driver.Url = "http://localhost:5115/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField.SendKeys("Henri");

            IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField.SendKeys("Henri");

            IWebElement loginButton = driver.FindElement(By.CssSelector("input[type='submit'][name='submit']"));
            loginButton.Click();

            IWebElement carButton = driver.FindElement(By.LinkText("Planes"));
            carButton.Click();

            IWebElement carCreateButton = driver.FindElement(By.LinkText("Edit"));
            carCreateButton.Click();

            IWebElement markField = wait.Until(driver => driver.FindElement(By.Id("Name")));
            markField.Clear();
            markField.SendKeys("Audi");

            IWebElement submitButton = wait.Until(driver => driver.FindElement(By.CssSelector("input[type='submit'].btn.btn-primary[value='Update']")));
            Thread.Sleep(500); 
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", submitButton);
            Thread.Sleep(500);
            submitButton.Click();



            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Planes"));

            Console.WriteLine("Plane edit success!");

        }

        [Test]

        public static void AutopoodTestGoToPlaneAndDetails()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            driver.Url = "http://localhost:5115/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField.SendKeys("Henri");

            IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField.SendKeys("Henri");

            IWebElement loginButton = driver.FindElement(By.CssSelector("input[type='submit'][name='submit']"));
            loginButton.Click();

            IWebElement carButton = driver.FindElement(By.LinkText("Planes"));
            carButton.Click();

            IWebElement carCreateButton = driver.FindElement(By.LinkText("Details"));
            carCreateButton.Click();


            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Planes/details/"));

            Console.WriteLine("Plane client details success!");

        }


        [Test]

        public static void AutopoodTestLoginFail()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

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

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

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

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

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

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

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

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

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

            IWebElement modelField = wait.Until(driver => driver.FindElement(By.Id("Model")));
            modelField.SendKeys("X5");

            IWebElement yearField = wait.Until(driver => driver.FindElement(By.Id("Year")));
            yearField.SendKeys("2020");

            IWebElement registerField = wait.Until(driver => driver.FindElement(By.Id("Register")));
            registerField.SendKeys("ABC1234");

            IWebElement serialNumberField = wait.Until(driver => driver.FindElement(By.Id("SerialNumber")));
            serialNumberField.SendKeys("SN123456789");

            IWebElement engineField = wait.Until(driver => driver.FindElement(By.Id("Engine")));
            engineField.SendKeys("V8");

            IWebElement seatsField = wait.Until(driver => driver.FindElement(By.Id("Seats")));
            seatsField.SendKeys("5");

            IWebElement mileageField = wait.Until(driver => driver.FindElement(By.Id("Tires")));
            mileageField.SendKeys("50000");

            IWebElement inspectionCheckbox = wait.Until(driver => driver.FindElement(By.Id("Inspection")));
            inspectionCheckbox.Click();

            IWebElement fileInput = wait.Until(driver => driver.FindElement(By.Id("Files")));
            string filePath = @"C:\Users\opilane\source\repos\Untitled.jpg";
            fileInput.SendKeys(filePath);

            IWebElement submitButton = wait.Until(driver => driver.FindElement(By.CssSelector("input[type='submit'].btn_edit[value='Create']")));
            submitButton.Click();

            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Cars"));

            Console.WriteLine("Car creation success!");

        }

        [Test]

        public static void AutopoodTestGoToCarAndDetails()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

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

            IWebElement carCreateButton = driver.FindElement(By.LinkText("Details"));
            carCreateButton.Click();


            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Cars"));

            Console.WriteLine("Car details success!");

        }

        [Test]

        public static void AutopoodTestGoToCarAndEdit()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

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

            IWebElement carCreateButton = driver.FindElement(By.LinkText("Edit"));
            carCreateButton.Click();

            IWebElement modelField = wait.Until(driver => driver.FindElement(By.Id("Model")));
            modelField.Clear();
            modelField.SendKeys("X6");

            IWebElement submitButton = wait.Until(driver => driver.FindElement(By.CssSelector("input[type='submit'].btn_edit[value='Update']")));
            submitButton.Click();

            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Cars"));

            Console.WriteLine("Car edit success!");


        }

        [Test]

        public static void AutopoodTestGoToCarAndDelete()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

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

            IWebElement carCreateButton = driver.FindElement(By.LinkText("Delete"));
            carCreateButton.Click();
            IWebElement deleteButton = driver.FindElement(By.CssSelector("input[type='submit'][value='Delete']"));
            deleteButton.Click();

            wait.Until(driver => driver.Url.Contains("http://localhost:5115/Cars"));

            Console.WriteLine("Car delete success!");


        }

        [Test]

        public static void AutopoodTestGoToCarClientAndDetails()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);

            driver.Url = "http://localhost:5115/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
            usernameField.SendKeys("Henri");

            IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
            passwordField.SendKeys("Henri");

            IWebElement loginButton = driver.FindElement(By.CssSelector("input[type='submit'][name='submit']"));
            loginButton.Click();

            IWebElement carButton = driver.FindElement(By.LinkText("Cars Client"));
            carButton.Click();

            IWebElement carCreateButton = driver.FindElement(By.LinkText("Details"));
            carCreateButton.Click();


            wait.Until(driver => driver.Url.Contains("http://localhost:5115/client-cars/details/"));

            Console.WriteLine("Car client details success!");

        }



      

        public static void TestClick()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\TARpe23\\Uesson\\Selenium-Marken-sest-unustasin-2-korda-commitida-oma-seleniumi-baasi-\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/click";

            IWebElement element = driver.FindElement(By.Id("badButton"));
            element.Click();
        }

       
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