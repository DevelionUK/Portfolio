package com.oxygenaddict.securitytesting.drivers;

import static com.microsoft.playwright.assertions.PlaywrightAssertions.assertThat;

import com.microsoft.playwright.*;
import com.microsoft.playwright.ElementHandle.FillOptions;

public class InjectionTheoryPage
{
    Page page;

    private final Locator hintLocator;
    private final Locator nounLocator;
    private final Locator verbLocator;
    private final Locator titleLocator;
    private final Locator submitLocator;
    private final Locator userTitleLocator;

    public InjectionTheoryPage(Page newPage)
    {
        page = newPage;
        hintLocator = page.locator("#hintDetails");
        nounLocator = page.locator("[name=noun]");
        verbLocator = page.locator("[name=verb]");
        titleLocator = page.locator("[name=title]");
        submitLocator = page.locator("[name=submit]");
        userTitleLocator = page.locator("[name=userTitle]");
    }

    public void navigate()
    {
        page.navigate("https://www.r-adams.co.uk/securitytestactivity/injection/theory.php");
    }

    public void enterMovieFields(String noun, String verb, String title)
    {
        nounLocator.fill(noun);
        verbLocator.fill(verb);
        titleLocator.fill(title);
    }

    public void submitMovie()
    {
        submitLocator.click();
    }

    public void assertTitle(String expectedTitle)
    {
        assertThat(page).hasTitle(expectedTitle);
    }

    public void assertHintShown(boolean hintShown)
    {
        hintLocator.getAttribute("open");
        if (hintShown)
        {

            assertThat(hintLocator).hasAttribute("open", "true");
        }
        else
        {
            assertThat(hintLocator).not().hasAttribute("open", "null");
        }
    }

    public void assertNoMovieName()
    {
        assertThat(userTitleLocator).hasCount(0);
    }

    public void assertMovieName(String expectedMovieName)
    {
        assertThat(userTitleLocator).hasText(expectedMovieName);
    }

    public void close()
    {
        page.close();
    }
}
