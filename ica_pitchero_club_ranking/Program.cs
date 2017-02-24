using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ica_pitchero_club_ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 250;

            for(int i = 0; i < number; i++) {

                IWebDriver driver = new ChromeDriver(@"C:\Selenium\chromedriver");

                driver.Navigate().GoToUrl("http://www.icasports.com/");

                // Click on 'News & Calendar' Link
                driver.Navigate().GoToUrl("http://www.icasports.com/news/");

                // Click on 'Teams' Link
                driver.Navigate().GoToUrl("http://www.icasports.com/teams/");
            
                // Click on 'Forum' Link
                driver.Navigate().GoToUrl("http://www.icasports.com/forum/");
            
                // Click on 'Videos & Photos' Link
                driver.Navigate().GoToUrl("http://www.icasports.com/photos");
            
                // Click on 'Payments' Link
                driver.Navigate().GoToUrl("http://www.icasports.com/payments/");

                // Click on 'Shopping' Link
                driver.Navigate().GoToUrl("http://www.icasports.com/shopping/lovell-soccer");

                // Click on 'Shopping' Link
                driver.Navigate().GoToUrl("http://www.icasports.com/shopping/easyfundraising");

                // Click on 'Contact' Link
                driver.Navigate().GoToUrl("http://www.icasports.com/contact");

                // Click on 'Information' Link
                driver.Navigate().GoToUrl("http://www.icasports.com/information");

                // Close browser
                driver.Close();

                Console.WriteLine("Iteration " + i + " completed...");
            }
        }
    }
}
