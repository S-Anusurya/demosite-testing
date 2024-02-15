using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI; 

namespace demosite_testing;

public class TestMethods 

    { 

        private readonly IWebDriver driver; 
        private readonly WebDriverWait wait; 

        public TestMethods(IWebDriver driver) 
        { 
            this.driver = driver; 
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20)); 
        } 

       
         public void WaitAndClick(By locator) 
        { 
             wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator)); 
            IWebElement element = driver.FindElement(locator); 
            element.Click(); 
        } 

       public void WaitAndSendKeys(By locator, string text) 
       { 
           wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator)); 
            IWebElement element =driver.FindElement(locator);
            element.SendKeys(text); 
        } 
       

     } 