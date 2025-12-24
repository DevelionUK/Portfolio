using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;

namespace AiT.WebTest.PageObjectModels;

public abstract class BasePageModel
{    public IPage Page { get; private set; }

    public BasePageModel(IPage page)
    {
        Page = page;
    }
    
    public async Task<string> GetTitle()
    {
        return await Page.TitleAsync();
    }
    
    public async Task<string?> GetHeader(int level)
    {
        var header = Page
            .GetByRole(AriaRole.Heading, new() { Level = level });
        return await header.TextContentAsync();
    }

    public async Task<ILocator> GetGameNavbarElement()
    {
        return Page.GetByTestId("game-link");
    }

    public async Task ClickItem(ILocator locator)
    {
        await locator.ClickAsync();
    }

    protected async Task GotoUrl(string url)
    {
        await Page.GotoAsync(url);
    }
}
