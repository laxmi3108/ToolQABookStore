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
    class Profile
    {
        public static void SearchBook(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//span[text()='Profile']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Git");
            Thread.Sleep(2000);

        }

        public static void DeleteBook(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//span[@id='delete-record-undefined']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='closeSmallModal-ok']")).Click();
            Thread.Sleep(2000);
            Thread.Sleep(2000);

            IAlert simpleAlert = Driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            simpleAlert.Accept();
            Thread.Sleep(2000);
        }
        public static void DeleteAllBook(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//div[@class='text-right button di']//button[text()='Delete All Books']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='closeSmallModal-ok']")).Click();
            Thread.Sleep(2000);
            Thread.Sleep(2000);

            IAlert simpleAlert = Driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            simpleAlert.Accept();
            Thread.Sleep(2000);
        }
        public static void RowsIncrease(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,700)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//select[@aria-label='rows per page']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//option[text()='10 rows']")).Click();
            Thread.Sleep(2000);
        }
    }
}
