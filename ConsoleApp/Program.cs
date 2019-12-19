using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleAppNowe01
{
    class Program
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new FirefoxDriver();
            IWebDriver driver = new ChromeDriver();

            driver.Url = "http://ux.up.krakow.pl/~mazela";

            driver.FindElement(By.LinkText("Bazy Danych")).Click();

        }
    }
}
