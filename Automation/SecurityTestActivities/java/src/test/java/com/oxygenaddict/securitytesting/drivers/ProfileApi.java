package com.oxygenaddict.securitytesting.drivers;

import static com.microsoft.playwright.assertions.PlaywrightAssertions.assertThat;
import static org.junit.jupiter.api.Assertions.assertTrue;

import com.microsoft.playwright.*;
import com.microsoft.playwright.options.HttpHeader;
import com.microsoft.playwright.options.RequestOptions;

public class ProfileApi {

    private Playwright playwright;
    private APIRequestContext request;
    private APIResponse response;
    private String cookieValue = "";

    public ProfileApi()
    {
        playwright = Playwright.create();
        request = playwright.request().newContext(
            new APIRequest.NewContextOptions()
            .setBaseURL("https://r-adams.co.uk/apitestactivities/profile")
        );
    }

    public void addBasicAuthentication(String username, String password)
    {
        request = playwright.request().newContext(
            new APIRequest.NewContextOptions()
            .setBaseURL("https://r-adams.co.uk/apitestactivities/profile/")
            .setHttpCredentials(username, password)
        );
    }

    public void getRoot()
    {
        response = makeGetRequest("");
        saveSessionId();
        assertThat(response).isOK();
    }

    public void getProfile()
    {
        response = makeGetRequest("get/");
        saveSessionId();
        assertThat(response).isOK();
    }

    public void setProfile(String bio)
    {
        // Not very elegant, I know
        String jsonBody = "{\"bio\":\"" + bio + "\"}";

        response = makePostRequest("setprofile/", jsonBody);
        saveSessionId();
        assertThat(response).isOK();
    }

    public void setProfile(String bio, String role)
    {
        // Not very elegant, I know
        String jsonBody = "{\"bio\":\"" + bio + "\",\"role\":\"" + role + "\"}";

        response = makePostRequest("setprofile/", jsonBody);
        saveSessionId();
        assertThat(response).isOK();
    }

    public void assertResponseContains(String parameter, String expectedValue)
    {
        // Not very elegant, I know
        String responseText = response.text();
        String expectedBody = "\"" + parameter + "\":\"" + expectedValue;
        assertTrue(responseText.contains(expectedBody));
        // This failed as the response wasn't mapped to a JsonArray and instead was a JsonObject.
        // However it is intended as an array so something is unhappy.
        /*        
        JsonArray json = new Gson().fromJson(response.text(), JsonArray.class);
        String actualValue = null;
        for (JsonElement item : json) {
            JsonObject itemJson = item.getAsJsonObject();
            if (itemJson.has(parameter))
            {
                actualValue = itemJson.get(parameter).getAsString();
            }
        }
        assertNotNull(actualValue);
        assertEquals(expectedValue, actualValue);
        */
    }

    public void close()
    {
        if (request != null) {
            request.dispose();
            request = null;
        }
        if (playwright != null) {
            playwright.close();
            playwright = null;
        }
    }

    private APIResponse makeGetRequest(String resource)
    {
        return request.get(resource);
    }

    private APIResponse makePostRequest(String resource, String jsonBody)
    {
        return request.post(
            resource, 
            RequestOptions.create().setData(jsonBody)
                .setHeader("Cookie", cookieValue)
        );
    }
    

    private void saveSessionId()
    {
        for (HttpHeader header : response.headersArray()) {
            if (header.name == "Cookie")
            {
                cookieValue = header.value;
            }
        }
    }
}
