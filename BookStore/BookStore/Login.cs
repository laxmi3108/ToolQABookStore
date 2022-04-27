using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore
{
    class Login
    {
        public static void LoginId(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//span[text()='Login']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("Laxmi");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Laxmi@31");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='login']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

        }
        public static void GotoBookStore(IWebDriver Driver)
        {

            Driver.FindElement(By.XPath("//button[@id='gotoStore']")).Click();
            Thread.Sleep(2000);

        }
    }
}
