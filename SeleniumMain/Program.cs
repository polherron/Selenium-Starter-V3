using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SeleniumMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string webURL = @"file:///C:/Users/Paul/Source/Repos/Selenium/SeleniumMain/Default.html";
            IWebDriver driver = new ChromeDriver(@"C:\libraries\");
            string googleUrl = "https://www.google.com/";

            //ClickPluralsightImageExample.DoSearch(driver, googleUrl);
            int i;
            HTMLExample.SelectRadioButtons(driver, webURL);
            HTMLExample.SelectOptionDDL(driver, webURL);
            HTMLExample.SelectOptionDDLUsingSupport(driver, webURL);
            HTMLExample.SelectTableCell(driver, webURL);
            HTMLExample.SelectTableCellByXPath(driver, webURL);
            HTMLExample.SelectTableCellByLinkText(driver, webURL);
            //PluralsightTestWithExpicitWait(driver, webURL);*/

            Console.ReadLine();

            driver.Close();

        }

     
        }

    }
