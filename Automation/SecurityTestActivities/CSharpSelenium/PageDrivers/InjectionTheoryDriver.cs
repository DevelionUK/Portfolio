using OpenQA.Selenium;

namespace CSharpSelenium.PageDrivers;

/// <summary>
/// Page driver for the Injection Theory page.
/// </summary>
[TestClass]
public sealed class InjectionTheoryDriver : WebDriverBase
{
    private const string PageUrl = "https://www.r-adams.co.uk/securitytestactivity/injection/theory.php";
    private const string UserTitleName = "userTitle";
    
    public InjectionTheoryDriver(WebDriver driver) : base(driver)
    {
    }

    public void NavigateToInjectionTheoryPage()
    {
        NavigateToUrl(PageUrl);
    }

    public bool IsAtInjectionTheoryPage()
    {
        return GetCurrentUrl() == PageUrl;
    }

    public void SubmitMovieName(string noun, string verb, string title)
    {
        SetByName("noun", noun);
        SetByName("verb", verb);
        SetByName("title", title);
        ClickByName("submit");
    }

    public string GetSubmittedMovieName() => GetTextByName(UserTitleName);

    public bool IsMovieNameShown() => DoesElementExist(UserTitleName);

    public bool IsHintShown()
    {
        string? openStatus = GetOpenStatusById("hintDetails");
        return openStatus != null && openStatus.Equals("true");
    }

}