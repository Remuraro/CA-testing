// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

[TestFixture]
public class LogincreateadlogoutTest

{
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), new ChromeOptions().ToCapabilities());
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void logincreateadlogout() {
    driver.Navigate().GoToUrl("http://localhost:4200/login");
    driver.Manage().Window.Size = new System.Drawing.Size(1112, 753);
    driver.FindElement(By.CssSelector(".username")).Click();
    driver.FindElement(By.CssSelector(".username")).SendKeys("renata@test.com");
    driver.FindElement(By.CssSelector(".password")).Click();
    driver.FindElement(By.CssSelector(".password")).SendKeys("Tes");
    driver.FindElement(By.CssSelector(".login")).Click();
    driver.FindElement(By.CssSelector(".password")).Click();
    driver.FindElement(By.CssSelector(".password")).SendKeys("Test");
    driver.FindElement(By.CssSelector(".username")).Click();
    driver.FindElement(By.CssSelector(".username")).SendKeys("renata@test.co");
    driver.FindElement(By.CssSelector(".login")).Click();
    driver.FindElement(By.CssSelector(".username")).Click();
    driver.FindElement(By.CssSelector(".username")).SendKeys("renata@test.com");
    driver.FindElement(By.CssSelector(".password")).Click();
    driver.FindElement(By.CssSelector(".login")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".login"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    driver.FindElement(By.CssSelector(".nav:nth-child(1)")).Click();
    driver.FindElement(By.CssSelector(".svg-inline--fa")).Click();
    driver.FindElement(By.CssSelector(".ng-untouched:nth-child(1)")).Click();
    driver.FindElement(By.CssSelector("app-add-adverts")).Click();
    driver.FindElement(By.CssSelector(".ng-dirty")).SendKeys("Renata - ad 1");
    driver.FindElement(By.CssSelector(".ng-untouched:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".ng-untouched:nth-child(2)")).SendKeys("Renata - ad 1");
    driver.FindElement(By.CssSelector(".ng-untouched")).Click();
    driver.FindElement(By.CssSelector(".ng-valid:nth-child(3)")).SendKeys("https://www.google.com/search?q=cute+pets&tbm=isch&source=iu&ictx=1&fir=_hra-89_e6yRMM%252CK0Ch2LmxuZCLuM%252C_&vet=1&usg=AI4_-kTqeySwxZ8zU0LSQXjP9NgyQJY9ZA&sa=X&ved=2ahUKEwil7vXG3P3vAhXiRhUIHf9JB5QQ9QF6BAgWEAE#imgrc=_hra-89_e6yRMM");
    driver.FindElement(By.CssSelector(".ng-valid:nth-child(3)")).Click();
    driver.FindElement(By.CssSelector(".ng-valid:nth-child(3)")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".ng-valid:nth-child(3)"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.CssSelector(".ng-valid:nth-child(3)")).Click();
    driver.FindElement(By.CssSelector(".ng-valid:nth-child(3)")).Click();
    driver.FindElement(By.CssSelector(".ng-valid:nth-child(3)")).SendKeys("https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/lionel-animals-to-follow-on-instagram-1568319926.jpg?crop=0.922xw:0.738xh;0.0555xw,0.142xh&resize=640:*");
    driver.FindElement(By.CssSelector(".createAd")).Click();
    driver.FindElement(By.CssSelector(".swal2-confirm")).Click();
    driver.FindElement(By.CssSelector(".nav:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".nav:nth-child(3)")).Click();
    driver.FindElement(By.CssSelector(".registerLink")).Click();
    driver.FindElement(By.CssSelector(".firstname")).Click();
    driver.FindElement(By.CssSelector(".firstname")).SendKeys("Diego");
    driver.FindElement(By.CssSelector(".lastname")).SendKeys("Boff");
    driver.FindElement(By.CssSelector(".username")).SendKeys("diego@mydbs.ie");
    driver.FindElement(By.CssSelector(".password")).Click();
    driver.FindElement(By.CssSelector(".password")).SendKeys("Test@1!");
    driver.FindElement(By.CssSelector(".avatar")).Click();
    driver.FindElement(By.CssSelector(".avatar")).SendKeys("http://someimageurl");
    driver.FindElement(By.CssSelector(".login")).Click();
    driver.FindElement(By.CssSelector("path")).Click();
    driver.FindElement(By.CssSelector(".ng-untouched:nth-child(1)")).Click();
    driver.FindElement(By.CssSelector(".ng-dirty")).Click();
    driver.FindElement(By.CssSelector(".ng-dirty")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".ng-dirty"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.CssSelector(".ng-dirty")).Click();
    driver.FindElement(By.CssSelector(".ng-dirty")).Click();
    driver.FindElement(By.CssSelector(".ng-dirty")).Click();
    driver.FindElement(By.CssSelector("app-root")).Click();
    driver.FindElement(By.CssSelector(".ng-dirty")).SendKeys("Diego - ad 1");
    driver.FindElement(By.CssSelector(".ng-untouched:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".ng-untouched:nth-child(2)")).SendKeys("Diego - ad 1");
    driver.FindElement(By.CssSelector(".ng-untouched")).Click();
    driver.FindElement(By.CssSelector(".ng-valid:nth-child(3)")).SendKeys("https://64.media.tumblr.com/4a981a3043441a8c4c8d13208222f7f4/tumblr_phkozt6AB61vf93px_1280.jpg");
    driver.FindElement(By.CssSelector(".createAd")).Click();
    js.ExecuteScript("window.scrollTo(0,0)");
    driver.FindElement(By.CssSelector(".swal2-confirm")).Click();
    driver.FindElement(By.CssSelector(".login")).Click();
    driver.FindElement(By.CssSelector(".username")).Click();
    driver.FindElement(By.CssSelector(".username")).SendKeys("diego@mydbs.ie");
    driver.FindElement(By.CssSelector(".password")).Click();
    driver.FindElement(By.CssSelector(".password")).SendKeys("Test@1!");
    driver.FindElement(By.CssSelector(".login")).Click();
    driver.FindElement(By.CssSelector(".nav:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".nav:nth-child(1)")).Click();
    driver.FindElement(By.CssSelector(".svg-inline--fa")).Click();
    driver.FindElement(By.CssSelector(".ng-untouched:nth-child(1)")).Click();
    driver.FindElement(By.CssSelector("app-root")).Click();
    driver.FindElement(By.CssSelector(".ng-dirty")).SendKeys("Diego - AD 1");
    driver.FindElement(By.CssSelector(".ng-untouched:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".ng-untouched:nth-child(2)")).SendKeys("Diego - AD 1");
    driver.FindElement(By.CssSelector(".ng-untouched")).Click();
    driver.FindElement(By.CssSelector(".ng-valid:nth-child(3)")).SendKeys("https://64.media.tumblr.com/4a981a3043441a8c4c8d13208222f7f4/tumblr_phkozt6AB61vf93px_1280.jpg");
    driver.FindElement(By.CssSelector(".createAd")).Click();
    js.ExecuteScript("window.scrollTo(0,0)");
    driver.FindElement(By.CssSelector(".swal2-confirm")).Click();
    driver.FindElement(By.CssSelector(".nav:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".nav:nth-child(1)")).Click();
    driver.FindElement(By.CssSelector(".nav:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".nav:nth-child(3)")).Click();
  }
}
