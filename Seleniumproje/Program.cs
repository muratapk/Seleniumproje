using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
namespace Seleniumproje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver=new FirefoxDriver();
            string url = @"https://www.n11.com/";
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.ClassName("btnSignIn")).Click();
            driver.FindElement(By.Id("email")).SendKeys("muratapk@hotmail.com");
            driver.FindElement(By.Id("password")).SendKeys("75Ac5454");
            IWebElement loginButton = driver.FindElement(By.Id("loginButton"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", loginButton);
            loginButton.Click();
            driver.FindElement(By.Id("searchData")).SendKeys("Havya");
            driver.FindElement(By.ClassName("iconsSearch")).Click();

            IWebElement alink = driver.FindElement(By.ClassName("plink"));
            string linktext = alink.Text;
            string linka=alink.GetCssValue("href");
            Console.WriteLine(linktext);
            Console.WriteLine(linka);
            IList<IWebElement> listem = driver.FindElements(By.ClassName("plink"));
            foreach (IWebElement item in listem)
            {
                  Console.WriteLine(item.Text);
                   Console.WriteLine(item.GetAttribute("href"));

                //string resim = item.FindElement(By.XPath("//*[@id=\"app\"]/div/div[3]/div[2]/div[2]/div[2]/div/a[1]/div[1]/div[4]/div/div[1]/div[1]/div/img")).GetAttribute("src");
                //Console.WriteLine("resim");
                //Console.WriteLine(item.Text);
                //string altlink=item.GetAttribute("href");
                //Console.WriteLine(altlink);
                //Console.WriteLine(altlink);
                //driver.Navigate().GoToUrl(altlink);
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //driver.Navigate().Back();

                Console.WriteLine("***********************");
                //try
                //{
                //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //    IWebElement resim = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div/div[3]/div[1]/div/div[2]/div[1]/div/div/div/div[1]/div[1]/div[2]/div/img")));
                //    string resimyol = resim.GetAttribute("src");
                //    Console.WriteLine("Resim Yolu: " + resimyol);
                //}
                //catch (NoSuchElementException ex)
                //{
                //    Console.WriteLine("Resim bulunamadı: " + ex.Message);
                //}





            }




        }
    }
}
