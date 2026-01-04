using AiT.WebTest.PageObjectModels;

namespace AiT.WebTest.Tests;

[TestClass]
public class GamePageTestsWithoutQuest : PageTest
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
    public async Task GamePageHasPlaceholderTitle()
    {
        string? header = await gamePage.GetHeader(1);
        Assert.IsNotNull(header);
        Assert.AreEqual("Adventures in Text", header);
    }
}
