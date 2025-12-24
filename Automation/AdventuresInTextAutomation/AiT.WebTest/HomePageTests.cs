using Microsoft.Playwright.MSTest;

namespace AiT.WebTest;

[TestClass]
public class HomePageTests : PageTest
{
    [TestMethod]
    public async Task HomePageLoads()
    {
        await Page.GotoAsync("http://localhost:5109/");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Adventures in Text"));
    }

    [TestMethod]
    public async Task HomePageHasGameLink()
    {
        await Page.GotoAsync("http://localhost:5109/");
        var getStarted = Page.GetByTestId("game-link");

        await Expect(getStarted).ToHaveAttributeAsync("href", "/Game");

        // Click the Game link.
        await getStarted.ClickAsync();

        // Expects the URL to contain Game.
        await Expect(Page).ToHaveURLAsync(new Regex(".*Game"));
    }
}
