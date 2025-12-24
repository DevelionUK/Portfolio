using AiT.WebTest.PageObjectModels;

namespace AiT.WebTest;

[TestClass]
public class HomePageTests : PageTest
{
    private HomePageModel homePage;

    [TestInitialize]
    public async Task HomePageSetup()
    {
        homePage = new(Page);
        await homePage.Setup();  
    }

    [TestMethod]
    public async Task HomePageLoads()
    {
        string title = await homePage.GetTitle();
        Assert.AreEqual("Adventures in Text", title);
    }

    [TestMethod]
    public async Task HomePageHasGameLink()
    {
        var gameLink = await homePage.GetGameNavbarElement();
        await Expect(gameLink).ToHaveAttributeAsync("href", "/Game");
        await homePage.ClickItem(gameLink);

        // Expects the URL to contain Game.
        await Expect(Page).ToHaveURLAsync(new Regex(".*Game"));
    }
}
