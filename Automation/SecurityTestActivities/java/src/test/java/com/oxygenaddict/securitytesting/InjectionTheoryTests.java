package com.oxygenaddict.securitytesting;

import com.microsoft.playwright.Browser;
import com.microsoft.playwright.Playwright;
import com.microsoft.playwright.BrowserType.LaunchOptions;
import com.oxygenaddict.securitytesting.drivers.InjectionTheoryPage;

import org.junit.jupiter.api.*;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.ValueSource;

public class InjectionTheoryTests 
{
    static Playwright playwright;
    static Browser browser;
    InjectionTheoryPage page;

    @BeforeAll
    static void setUp() {
        playwright = Playwright.create();

        // I would normally run tests headless but as I was experimenting with new
        // technology and it is fun to see the browser being actioned, why not? ^_^
        browser = playwright.chromium().launch(new LaunchOptions().setHeadless(false));
    }
    
    @BeforeEach
    void createPage() {
        page = new InjectionTheoryPage(browser.newPage());
    }

    @Test
    @DisplayName("Page loads with correct title")
    void testPageLoads() {
        page.navigate();
        page.assertTitle("Injection Activities");
    }

    @Test
    @DisplayName("Hint is hidden on load")
    void hintHiddenOnLoad() {
        page.navigate();
        page.assertHintShown(false);
    }

    @Test
    @DisplayName("No movie name shown on load")
    void noMovieNameOnLoad() {
        page.navigate();
        page.assertNoMovieName();
    }

    @Test
    @DisplayName("Submit a simple movie name")
    void submitMovieNameValidValues() {
        page.navigate();
        page.enterMovieFields("Tester", "Testing", "2");
        page.submitMovie();
        page.assertMovieName("Tester And Testing");
    }

    @Test
    @DisplayName("Submit the values from the hint")
    void submitMovieNameHintValues() {
        page.navigate();
        page.enterMovieFields(
            "Dawn of the Dead.",
            "the Dead was a really good film. I enjoyed this",
            "1"
            );
        page.submitMovie();
        page.assertMovieName("The Day of the Dead was a really good film. I enjoyed this and Dawn of the Dead.");
    }

    @ParameterizedTest
    @DisplayName("Invalid titles are rejected")
    @ValueSource(strings = { "11", "0" })
    void submitMovieNameHintValues(String title) {
        page.navigate();
        page.enterMovieFields("Tester", "Testing", title);
        page.submitMovie();
        page.assertNoMovieName();
    }
    
    @AfterEach
    void closePage() {
        page.close();
    }

    @AfterAll
    static void tearDown() {
        browser.close();
        playwright.close();
    }
}
