using Microsoft.Playwright;

namespace AiT.WebTest.PageObjectModels;

public class HomePageModel : BasePageModel
{
    private const string HomeUrl = "http://localhost:5109/";

    public HomePageModel(IPage page) : base(page) { }

    public async Task Setup()
    {
        await GotoUrl(HomeUrl);
    }
}
