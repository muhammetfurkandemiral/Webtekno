using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

public class Driver
{
    private Driver()
    {
        //cotr ?
    }

    public static IWebDriver driver;

    public static WebDriver get() {
    
        if(driver == null){
            string browser = (Environment.GetEnvironmentVariable("browserName") != null) ? Environment.GetEnvironmentVariable("browserName") : "";

            switch (browser.ToLower()){

                case "chrome-headless":
                    //WebDriverManager.chromedriver().setup();
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--headless");
                    driver = new ChromeDriver(chromeOptions);
                    break;
                case "firefox":
                    //WebDriverManager.firefoxdriver().setup();
                    driver = new FirefoxDriver();
                    break;
                case "firefox-headless":
                    //WebDriverManager.firefoxdriver().setup();
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("--headless");
                    driver = new FirefoxDriver(firefoxOptions);
                    break;
                case "ie":
                    if (!Environment.GetEnvironmentVariable("os.name").ToLower().Contains("windows"))
                        throw new WebDriverException("Your OS doesn't support Internet Explorer");
                    //WebDriverManager.iedriver().setup();
                    driver = new InternetExplorerDriver();
                    break;
                case "edge":
                    if (!Environment.GetEnvironmentVariable("os.name").ToLower().Contains("windows"))
                        throw new WebDriverException("Your OS doesn't support Edge");
                    //WebDriverManager.edgedriver().setup();
                    driver = new EdgeDriver();
                    break;
                case "safari":
                    if (!Environment.GetEnvironmentVariable("os.name").ToLower().Contains("mac"))
                        throw new WebDriverException("Your OS doesn't support Safari");
                    //WebDriverManager.getInstance(SafariDriver.class).setup();
                    driver = new SafariDriver();
                    break;
                default:
                    //WebDriverManager.chromedriver().setup();
                    driver = new ChromeDriver();
                    break;
            }
        }

        return (WebDriver)driver;
    }

    public static void closeDriver() {
        if (driver != null) {
            driver.Quit();
            driver = null;
        }
    }

}