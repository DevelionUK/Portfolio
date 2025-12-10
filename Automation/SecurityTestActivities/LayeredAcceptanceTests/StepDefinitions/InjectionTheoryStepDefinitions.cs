using LayeredAcceptanceTests.Drivers;

namespace LayeredAcceptanceTests.StepDefinitions;

[Binding]
public class InjectionTheoryStepDefinitions
{
    private InjectionTheoryDriver driver = new InjectionTheoryDriver();

    [Given("the client has just accessed the Injection Theory page")]
    public void GivenTheClientOnInjectionPage()
    {
        driver.NavigateToInjectionTheoryPage();
    }

    [When("the movie name is generated with the noun {string} and verb {string}")]
    public void WhenMovieNameGeneratedWithNounAndVerb(string noun, string verb)
    {
        driver.SubmitMovieName(noun, verb, "");
    }

    [When("the movie name is generated with the hint values")]
    public void WhenMovieNameGeneratedWithHintValues()
    {
        driver.SubmitMovieName(
            "Dawn of the Dead.",
            "the Dead was a really good film. I enjoyed this",
            "1"
            );
    }

    [When("they try to read the hint")]
    public void WhenTryToReadHint()
    {
    }

    [When("the provide invalid title {string}")]
    public void WhenProvideInvalidTitle(string title)
    {
        driver.SubmitMovieName(
            "Noun",
            "Verb",
            title
        );
    }
    
    [Then("the title contains the words {string} and {string}")]
    public void ThenTheMovieNameContainsBothWords(string noun, string verb)
    {
        driver.AssertNameContains(new string[]{noun, verb});
    }

    [Then("the title is {string}")]
    public void ThenTheMovieNameContainsBothWords(string expectedName)
    {
        driver.AssertNameIs(expectedName);
    }

    [Then("the hint is not visible")]
    public void ThenHintNotVisible()
    {
        driver.AssertIsHintShown(false);
    }

    [Then("no movie name is generated")]
    public void ThenNoMovieNameGenerated()
    {
        driver.AssertMovieNameShown(false);
    }

    [AfterScenario]
    public void TearDown()
    {
        driver.EndSession();
    }
}