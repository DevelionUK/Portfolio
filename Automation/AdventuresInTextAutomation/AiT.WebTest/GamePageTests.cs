using AiT.WebTest.PageObjectModels;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;

namespace AiT.WebTest;

[TestClass]
public class GamePageTests : PageTest
{
    private GamePageModel gamePage;

    [TestInitialize]
    public async Task GamePageSetup()
    {
        gamePage = new(Page);
        await gamePage.Setup();  
    }

    [TestMethod]
    public async Task GamePageLoads()
    {
        string title = await gamePage.GetTitle();
        Assert.AreEqual("Adventures in Text", title);
    }

    [TestMethod]
    public async Task GamePageHasRoundTitle()
    {
        string? header = await gamePage.GetHeader(1);
        Assert.IsNotNull(header);
        Assert.AreEqual("An Unfortunate Awakening", header);
    }

    [TestMethod]
    public async Task GamePageMoveToNextPage()
    {
        await gamePage.TypeAnswer(2);
        await gamePage.ClickSubmit();
        
        string? header = await gamePage.GetHeader(1);
        Assert.IsNotNull(header);
        Assert.AreEqual("Not Alone", header);
    }
}
