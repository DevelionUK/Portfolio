using Microsoft.Playwright;

namespace AiT.WebTest.PageObjectModels;

public class QuestsPageModel : BasePageModel
{
    private const string QuestsBaseUrl = "http://localhost:5109/Quests/";

    public QuestsPageModel(IPage page) : base(page) { }

    public async Task Setup()
    {
        await GotoUrl(QuestsBaseUrl);
    }

    public async Task SetQuest(string questName)
    {
        await GotoUrl(QuestsBaseUrl + "Set/" + questName);
    }
}
