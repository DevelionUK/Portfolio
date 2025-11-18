using OpenQA.Selenium;

namespace SecurityTestActivities.PageDrivers;

/// <summary>
/// Base class for WebDriver page drivers.
/// Provides common functionality for navigating and interacting with web pages.
/// </summary>
public class WebDriverBase {

  private WebDriver driver;

  public WebDriverBase(WebDriver driver) {
    this.driver = driver;
  }

  public void NavigateToUrl(string url) {
    driver.Navigate().GoToUrl(url);
  }
  
  public void EndSession() {
    driver.Quit();
  }

  protected string GetCurrentUrl() {
    return driver.Url;
  }

  protected void ClickByName(string elementName) {
    IWebElement clickElement = driver.FindElement(By.Name(elementName));
    clickElement.Click();
  }

  protected void SetByName(string elementName, string value) {
    IWebElement element = driver.FindElement(By.Name(elementName));
    ClearAndType(element, value);
  }

  protected string GetTextByName(string elementName) {
    IWebElement element = driver.FindElement(By.Name(elementName));
    return element.Text;
  }

  protected bool DoesElementExist(string elementName) {
    try
    {
      driver.FindElement(By.Name(elementName));
      return true;
    }
    catch (NoSuchElementException)
    {
      return false;
    }
  }

  protected string? GetOpenStatusById(string elementId) {
    IWebElement element = driver.FindElement(By.Id(elementId));
    return element.GetAttribute("open");
  }

  private void ClearAndType(IWebElement element, String text) {
    element.Clear();
    element.SendKeys(text);
  }
}