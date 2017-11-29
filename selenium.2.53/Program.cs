using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace selenium1
{
	class Hello
	{
		static void Main()
		{
			Console.WriteLine("###### Running client 2.53.1");

			ChromeOptions options = new ChromeOptions();

			DesiredCapabilities dc = (DesiredCapabilities)options.ToCapabilities();
			dc.SetCapability("e34:token", "57ffedec");

			//IWebDriver driver = new RemoteWebDriver(new Uri("http://192.168.1.115:4444/wd/hub"), dc);
			IWebDriver driver = new RemoteWebDriver(new Uri("https://vm-106.element34.net/wd/hub"), dc);
			//IWebDriver driver = new RemoteWebDriver(new Uri("https://192.168.34.106/wd/hub"), dc);

			//comment
			driver.Navigate().GoToUrl("https://www.lhsystems.com");
			Console.WriteLine(driver.Title);

			driver.Quit();

		}
	}
}
