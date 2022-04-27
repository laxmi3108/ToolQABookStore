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
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Actions a = new Actions(Driver);

            Driver.Navigate().GoToUrl("https://demoqa.com/books");

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,700)");
            Thread.Sleep(2000);

            Login.LoginId(Driver);
            Thread.Sleep(2000);

            Login.GotoBookStore(Driver);
            Thread.Sleep(2000);

            BooksStore.Search(Driver);
            Thread.Sleep(2000);

            BooksStore.AddtoCollection(Driver);
            Thread.Sleep(2000);

            BooksStore.AddBook(Driver);
            Thread.Sleep(2000);

            Profile.SearchBook(Driver);
            Thread.Sleep(2000);

            Profile.DeleteBook(Driver);
            Thread.Sleep(2000);

            Profile.RowsIncrease(Driver);
            Thread.Sleep(2000);

            Profile.DeleteAllBook(Driver);
            Thread.Sleep(2000);

            Driver.Close();

        }
    }
}
