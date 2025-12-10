Feature: API Profile Activity

This feature is for a small activity from my API Profile Activity
(but used in some security resources and activities that I've used)
where there is a security defect around injecting values into the URL.

    Rule: The user can get their profile

        Scenario: Client requests their profile
            Given the user profile "TestUser" exists
            When the client requests the profile
            Then the client receives the "TestUser" profile

    Rule: The user can update their bio

        Scenario: Client updates the bio
            Given the user profile "TestUser" exists
            When the client sets their bio to "I am a fish"
            Then the client now receives the profile contains the bio "I am a fish"

        Scenario: Client updates the bio with extra field
            Given the user profile "TestUser" exists
            When the client sets their bio to "I am a fish" and role to "Admin"
            Then the client now receives the profile contains the bio "I am a fish"
            And the role is "User"

    Rule: The user can update their bio and username in the same request

        # There are a lot of different tests that I could do here but I just want to
        # demonstrate a test that would fail because the behaviour is wrong.
        # (this is the bug that people using this API are meant to find)
        @ignore
        Scenario: Client cannot update their bio
            Given the user profile "TestUser" exists
            When the client updates their profile, setting bio to "I am a fish" and role to "Admin"
            Then the client now receives the profile contains the bio "I am a fish"
            And the role is "User"