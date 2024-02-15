using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI; 

namespace demosite_testing;

    
    public class TestProject 
    { 
        private IWebDriver driver; 
        private TestMethods testMethods; 
        private Path path;


        [SetUp] 
        public void Setup() 
        { 
            driver = new ChromeDriver(); 
           
            testMethods = new TestMethods(driver); 
            path = new Path(); 
        } 
 
        [Test] 
        public void Test1() 
        { 
            driver.Navigate().GoToUrl("https://www.saucedemo.com/"); 
           
           String username="standard_user";
           String password="secret_sauce";
           
      
          testMethods.WaitAndSendKeys(path.user_name, username); 
          testMethods.WaitAndSendKeys(path.password_txt,password ); 
          testMethods.WaitAndClick(path.submitButton); 
               
        } 

  

        [TearDown] 
       public void TearDown() 
        { 
           // Close the browser 
         // driver.Quit(); 
        } 
    } 

