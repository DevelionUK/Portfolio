using CSharpSelenium.PageDrivers;
using OpenQA.Selenium.Chrome;

namespace CSharpSelenium.Tests;

/// <summary>
/// Tests for the Injection Theory page
/// The Injection Theory page allows users to submit a noun, verb, and title ID
/// to generate a movie name.
/// The title ID corresponds is a number from 1-10 that the app uses to create
/// a movie name.
/// The activity is around putting in unexpected values to try and manipulate
/// the output movie name to be two complete sentences.
/// </summary>
[TestClass]
public sealed class InjectionTheory
{
    private InjectionTheoryDriver? injectionTheoryPage;

    /// <summary>
    /// Setup before each test by navigating to the page
    /// </summary>
    [TestInitialize]
    public void Setup()
    {
        injectionTheoryPage = new InjectionTheoryDriver(new ChromeDriver());
        injectionTheoryPage.NavigateToInjectionTheoryPage();
    }
    
    /// <summary>
    /// Cleanup after each test by ending session
    /// </summary>
    [TestCleanup]
    public void Cleanup()
    {
        injectionTheoryPage.EndSession();
    }

    /// <summary>
    /// Given the page is navigated to
    /// Then the correct page is loaded
    /// </summary>
    [TestMethod]
    public void PageLoads()
    {
        Assert.IsTrue(injectionTheoryPage.IsAtInjectionTheoryPage());
    }

    /// <summary>
    /// Given the page is loaded
    /// Then the hint should be hidden by default
    /// </summary>
    [TestMethod]
    public void HintHiddenOnLoad()
    {
        Assert.IsFalse(injectionTheoryPage.IsHintShown());
    }

    /// <summary>
    /// Given the page is loaded
    /// When no movie name has been submitted
    /// Then no movie name is shown
    /// </summary>
    [TestMethod]
    public void NoMovieNameOnLoad()
    {
        Assert.IsFalse(injectionTheoryPage.IsMovieNameShown());
    }

    /// <summary>
    /// Given the page is loaded
    /// When a movie name is submitted with valid inputs
    /// Then the correct movie name is shown
    /// </summary>
    [TestMethod]
    public void SubmitMovieName_ValidValues()
    {
        injectionTheoryPage.SubmitMovieName("Tester", "Testing", "2");
        var value = injectionTheoryPage.GetSubmittedMovieName();
        Assert.AreEqual("Tester And Testing", value);
    }

    /// <summary>
    /// Given the page is loaded
    /// When the user provides the inputs to solve the movie name in the hint
    /// Then the correct movie name is shown
    /// </summary>
    [TestMethod]
    public void SubmitMovieName_HintSolution()
    {
        injectionTheoryPage.SubmitMovieName(
            "Dawn of the Dead.",
            "the Dead was a really good film. I enjoyed this",
            "1"
            );
        var value = injectionTheoryPage.GetSubmittedMovieName();
        Assert.AreEqual(
            "The Day of the Dead was a really good film. I enjoyed this and Dawn of the Dead.",
             value
             );
    }

    /// <summary>
    /// Given the page is loaded
    /// When a movie name is submitted with an empty title ID
    /// Then a movie name is still shown
    /// </summary>
    [TestMethod]
    public void SubmitMovieName_NoTitle()
    {
        injectionTheoryPage.SubmitMovieName("Any", "Value", "");
        Assert.IsTrue(injectionTheoryPage.IsMovieNameShown());
    }

    /// <summary>
    /// Given the page is loaded
    /// When a movie name is submitted with an invalid title ID
    /// Then no movie name is shown
    /// </summary>
    /// <param name="titleId"></param>
    [TestMethod]
    [DataRow("11")]
    [DataRow("1; DROP TABLE Movies;--")]
    [DataRow("0")]
    public void SubmitInvalidTitleId(string titleId)
    {
        injectionTheoryPage.SubmitMovieName("Any", "Value", titleId);
        Assert.IsFalse(injectionTheoryPage.IsMovieNameShown());
    }
}
