using LayeredAcceptanceTests.Drivers;

namespace LayeredAcceptanceTests.StepDefinitions;

[Binding]
public class ApiProfileActivityStepDefinitions
{
    private ProfileApiDriver driver = new ProfileApiDriver();

    [Given("the user profile {string} exists")]
    public void GivenUserProfileExists(string specifiedUsername)
    {
        driver.SetupAuthenticatedClient(specifiedUsername, "TestPw");
    }

    [When("the client requests the profile")]
    public void WhenClientRequestsProfile()
    {
        driver.GetProfile();
    }

    [When("the client sets their bio to {string}")]
    public void WhenClientUpdatesBioW(string specifiedBio)
    {
        driver.SetBio(specifiedBio);
    }

    [When("the client sets their bio to {string} and role to {string}")]
    public void WhenClientUpdatesBioWithRole(string specifiedBio, string role)
    {
        driver.SetBio(specifiedBio, "role", role);
    }

    [When("the client updates their profile, setting bio to {string} and role to {string}")]
    public void WhenUpdatesProfileWithRole(string specifiedBio, string specifiedRole)
    {
        driver.SetProfile(specifiedBio, specifiedRole);
    }

    [Then("the client receives the {string} profile")]
    public void ThenClientReceivedProfile(string specifiedUsername)
    {
        driver.AssertOkResponse();
        driver.AssertResponseContains("username", specifiedUsername);
    }

    [Then("the client now receives the profile contains the bio {string}")]
    public void ThenClientBioUpdated(string specifiedBio)
    {
        driver.AssertOkResponse();
        driver.GetProfile();
        driver.AssertResponseContains("bio", specifiedBio);
    }
    
    [Then("the role is {string}")]
    public void ThenRoleIsSet(string expecetdRole)
    {
        driver.AssertResponseContains("role", expecetdRole);
    }
}