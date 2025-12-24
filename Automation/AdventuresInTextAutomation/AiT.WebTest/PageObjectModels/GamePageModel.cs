using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;

namespace AiT.WebTest.PageObjectModels;

public class GamePageModel
{
    private const string GameUrl = "http://localhost:5109/Game/Reset";
    public IPage Page { get; private set; }

    public GamePageModel(IPage page)
    {
        Page = page;
    }

    public async Task Setup()
    {
        await Page.GotoAsync(GameUrl);
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

    public async Task TypeAnswer(int answer)
    {
        var inputBox = Page.GetByRole(AriaRole.Spinbutton);
        await inputBox.FillAsync($"{answer}");
    }

    public async Task ClickSubmit()
    {
        var submitButton = Page.GetByRole(AriaRole.Button);
        await submitButton.ClickAsync();
    }
}
