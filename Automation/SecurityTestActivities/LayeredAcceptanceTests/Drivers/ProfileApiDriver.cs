using System.Net;
using RestSharp;
using RestSharp.Authenticators;

public sealed class ProfileApiDriver
{
    RestClient restClient;
    RestResponse? restResponse;
    CookieContainer? cookieJar = null;

    public void SetupAuthenticatedClient(string username, string password)
    {
        var options = new RestClientOptions("https://r-adams.co.uk/apitestactivities/profile") {
            Authenticator = new HttpBasicAuthenticator(username, password)
        };
        restClient = new RestClient(options);        
    }

    public void GetRoot() => MakeGetRequest("");


    public void GetProfile() => MakeGetRequest("get/");

    /// <summary>
    /// Set Bio usually is just the bio field but there's an option to add in
    /// extra fields for security testing.
    /// </summary>
    public void SetBio(String bio, string? param = null, string? value = null)
    {
        if (param == null || value == null)
        {
            MakePostRequest(
                "setbio/",
                "{\"bio\":\"" + bio + "\"}"
            );
        }
        else
        {
            MakePostRequest(
                "setbio/",
                "{\"bio\":\"" + bio + "\", \"" + param + "\":\"" + value + "\"}"
            );
        }
    }

    public void SetProfile(string bio, string? role = null)
    {
        var jsonBody = "{\"bio\":\"" + bio + "\"";
        if (role != null)
        {
            jsonBody += ", \"role\":\"" + role + "\"";
        }
        jsonBody += "}";
        
        MakePostRequest("setprofile/", jsonBody);
    }

    public void AssertResponseContains(string parameter, string expectedValue)
    {
        var expectedJson = $"\"{parameter}\":\"{expectedValue}\"";
        Assert.That(restResponse, Is.Not.Null);
        Assert.That(restResponse.Content, Is.Not.Null);
        Assert.That(restResponse.Content.Contains(expectedJson));
    }

    public void AssertOkResponse()
    {
        Assert.That(restResponse, Is.Not.Null);
        Assert.That(restResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }

    private void MakeGetRequest(string resource)
    {
        var request = new RestRequest(resource);

        if (cookieJar != null)
        {
            request.CookieContainer = cookieJar;
        }

        restResponse = restClient.Get(request);

        SaveSessionId();
    }

    private void MakePostRequest(string resource, string jsonBody)
    {
        var request = new RestRequest(resource);
        request.AddJsonBody(jsonBody, false);
        restResponse = restClient.Post(request);
        SaveSessionId();
    }

    private void SaveSessionId()
    {
        var sessionCookie = restResponse.Cookies.SingleOrDefault(x => x.Name == "PHPSESSID");
        if (sessionCookie != null && cookieJar == null)
        {
            cookieJar = new();
            cookieJar.Add(new Cookie(sessionCookie.Name, sessionCookie.Value, sessionCookie.Path, sessionCookie.Domain));
        }
    }
}