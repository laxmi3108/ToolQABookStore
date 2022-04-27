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
    class BooksStore
    {
        public static void Search(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Git");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[text()='Git Pocket Guide']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);
        }

        public static void AddtoCollection(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//button[text()='Add To Your Collection']")).Click();
            Thread.Sleep(2000);

            IAlert simpleAlert = Driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            simpleAlert.Accept();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[text()='Back To Book Store']")).Click();
            Thread.Sleep(2000);
        }
        public static void AddBook(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Learning");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[text()='Learning JavaScript Design Patterns']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            AddtoCollection(Driver);
            Thread.Sleep(2000);
        }

    }
}
