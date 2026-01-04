using Microsoft.Playwright;

namespace AiT.WebTest.PageObjectModels;

public class GamePageModel : BasePageModel
{
    private const string GameUrl = "http://localhost:5109/Game/Reset";

    public GamePageModel(IPage page) : base(page) { }

    public async Task Setup()
    {
        await GotoUrl(GameUrl);
    }

    public async Task TypeAnswer(int answer)
    {
        var inputBox = Page.GetByRole(AriaRole.Spinbutton);
        await inputBox.FillAsync($"{answer}");
    }

    public async Task ClickSubmit()
    {
        var submitButton = Page.GetByRole(AriaRole.Button, new() { Name = "Submit" });
        await submitButton.ClickAsync();
    }
}
