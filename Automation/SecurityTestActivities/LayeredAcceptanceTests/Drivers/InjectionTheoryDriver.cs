using OpenQA.Selenium;

namespace LayeredAcceptanceTests.Drivers;

/// <summary>
/// Page driver for the Injection Theory page.
/// </summary>
public sealed class InjectionTheoryDriver : WebDriverBase
{
    private const string PageUrl = "https://www.r-adams.co.uk/securitytestactivity/injection/theory.php";
    private const string UserTitleName = "userTitle";
    
    public InjectionTheoryDriver()
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

    public void AssertIsHintShown(bool expectedResult)
    {
        string? openStatus = GetOpenStatusById("hintDetails");
        var hintShown = openStatus != null && openStatus.Equals("true");
        Assert.That(hintShown, Is.EqualTo(expectedResult));
    }

    public void AssertNameContains(string[] values)
    {
        var submittedName = GetTextByName(UserTitleName);
        foreach (var value in values)
        {
            Assert.That(submittedName.Contains(value));
        }
    }

    public void AssertNameIs(string expectedName)
    {
        var submittedName = GetTextByName(UserTitleName);
        Assert.That(submittedName, Is.EqualTo(expectedName));
    }

    public void AssertMovieNameShown(bool expectedResult)
    {
        Assert.That(
            DoesElementExist(UserTitleName),
            Is.EqualTo(expectedResult)
            );
    }
}