using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ping
{
    class Program
    {
        //private static AutoResetEvent waitHandle = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            var capability = DesiredCapabilities.Chrome();
            IWebDriver _driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub/"), capability, TimeSpan.FromSeconds(600));

            _driver.Navigate().GoToUrl("http://ilovecode.com.br");

            _driver.Quit();

            //waitHandle.WaitOne();
        }
    }
}
