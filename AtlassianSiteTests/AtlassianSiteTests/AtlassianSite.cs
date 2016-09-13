using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AtlassianSiteTests
{
    public class AtlassianSite
    {
        public void OpenMainPage(ChromeDriver driver)
        {
            driver.Navigate().GoToUrl("https://pagepage.atlassian.net/");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        }

        public void LoginToConfluence(ChromeDriver driver)
        {
            driver.FindElementById("username").SendKeys("the.hanging.gardens@gmail.com");
            driver.FindElementById("password").SendKeys("dupa1234");
            driver.FindElementById("login").Click();
            
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement regCompleted = wait.Until(drv => drv.FindElement(By.Id("WelcometoConfluence")));
        }

        public void LoginOffConfluence(ChromeDriver driver)
        {
            driver.FindElementById("user-menu-link").Click();
            driver.FindElementById("logout-link").Click();
            driver.FindElementById("logout").Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement regCompleted = wait.Until(drv => drv.FindElement(By.Id("logged-out")));
        }

        public void SetRestrictions(ChromeDriver driver)
        {
            //driver.FindElementById("space-menu-link").Click();
            //driver.FindElementById("view-all-spaces-link").Click();
            //driver.FindElementByLinkText("https://pagepage.atlassian.net/wiki/display/NEW").Click();
            ////*[@id="action-menu-link"]/span/span
            
            //driver.FindElementByXPath("*[@id='action - menu - link']/span/span").Click();
            //driver.FindElementById("action - page - permissions - link").Click();

            //*[@id="recent-spaces-section"]/ul/li[1]/a
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            //IWebElement regCompleted = wait.Until(drv => drv.FindElement(By.XPath("//*[contains(text(), 'Welcome to Confluence')]")));

            string baseURL = "https://pagepage.atlassian.net/";

            driver.Navigate().GoToUrl(baseURL + "/wiki/discover/all-updates");
            driver.FindElement(By.Id("space-menu-link")).Click();
            driver.FindElement(By.Id("view-all-spaces-link")).Click();
            driver.FindElement(By.LinkText("newspace")).Click();
            driver.FindElement(By.Id("action-menu-link")).Click();
            driver.FindElement(By.Id("action-page-permissions-link")).Click();
            driver.FindElement(By.Id("page-restrictions-dialog-save-button")).Click();

        }

        public void CreatePage(ChromeDriver driver)
        {
            //click 3 dots
            driver.FindElementById("create-page-button").Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            IWebElement regCompleted = wait.Until(drv => drv.FindElement(By.Id("create-dialog")));

            //click blank page
            driver.FindElementByXPath("//*[@data-content-blueprint-id='00000000-0000-0000-0000-000000000000']").Click();
            //click CREATE button
            driver.FindElementByXPath("//*[contains(@class,'create-dialog-create-button aui-button aui-button-primary')]").Click();

            //regCompleted = wait.Until(drv => drv.FindElement(By.Id("wysiwyg")));

            ////write page title
            //driver.FindElementById("content-title").SendKeys("Test page");    

            ////click SAVE button
            //driver.FindElementById("rte-button-publish").Click();
        }

        public void CreateSpace(ChromeDriver driver)
        {
            ////click 3 dots
            //driver.FindElementById("space-menu-link").Click();

            ////click 3 dots
            //driver.FindElementById("create-space-header").Click();

            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            //IWebElement regCompleted = wait.Until(drv => drv.FindElement(By.Id("create-dialog")));

            //
            //*[@id="create-dialog"]/div/div[1]/div/div[2]/div/div[2]/ol/li[1]

            ////click blank page
            //driver.FindElementByXPath("//*[@data-content-blueprint-id='00000000-0000-0000-0000-000000000000']").Click();
            ////click CREATE button
            //driver.FindElementByXPath("//*[contains(@class,'create-dialog-create-button aui-button aui-button-primary')]").Click();

            ////regCompleted = wait.Until(drv => drv.FindElement(By.Id("wysiwyg")));

            //////write page title
            ////driver.FindElementById("content-title").SendKeys("Test page");    

            //////click SAVE button
            ////driver.FindElementById("rte-button-publish").Click();
            //string baseURL = "https://pagepage.atlassian.net/";

            //driver.Navigate().GoToUrl(baseURL + "/wiki/discover/all-updates");
            //driver.FindElement(By.Id("space-menu-link")).Click();
            //driver.FindElement(By.Id("create-space-header")).Click();
            //driver.FindElement(By.CssSelector("button.item-button")).Click();
            //driver.FindElement(By.CssSelector("li.template.selected")).Click();
            //driver.FindElement(By.CssSelector("div.template-description")).Click();
            //driver.FindElement(By.XPath("//div[@id='create-dialog']/div/div[2]/button")).Click();
            //driver.FindElement(By.Name("name")).Clear();
            //driver.FindElement(By.Name("name")).SendKeys("newspace");
            //driver.FindElement(By.XPath("//div[@id='create-dialog']/div[2]/div[2]/button[2]")).Click();
            //driver.FindElement(By.CssSelector("p.title")).Click();

        }


    }
}
