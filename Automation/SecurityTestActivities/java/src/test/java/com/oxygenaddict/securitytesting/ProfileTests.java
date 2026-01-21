package com.oxygenaddict.securitytesting;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.*;

import com.oxygenaddict.securitytesting.drivers.ProfileApi;

public class ProfileTests
{
    static String TestUsername = "TestUser";
    static String TestPassword = "TestPw";
    static ProfileApi profileApi;

    @BeforeAll
    static void setUp() {
        profileApi = new ProfileApi();
    }
    
    @BeforeEach
    void setupTest() {
        profileApi.addBasicAuthentication(TestUsername, TestPassword);
    }

    @Test
    @DisplayName("Root API call is available")
    void getRoot() {
        profileApi.getRoot();
    }

    @Test
    @DisplayName("Able to get your profile")
    void getProfile() {
        profileApi.getProfile();
        profileApi.assertResponseContains("username", TestUsername);
        profileApi.assertResponseContains("bio", "This is a test biography. Enjoy.");
    }

    @Test
    @DisplayName("Able to set your bio")
    void setBio() {
        profileApi.setProfile("I am a fish");
        profileApi.getProfile();
        profileApi.assertResponseContains("bio", "I am a fish");
    }

    @Disabled("This test is expected to fail - the activity is to find this defect")
    @Test
    @DisplayName("Attempts to increase your role are ignored")
    void exposeSecurityIssue() {
        profileApi.setProfile("Tee hee", "Admin");
        profileApi.getProfile();
        profileApi.assertResponseContains("bio", "Tee hee");

        // This next assertion is expected to fail as there is a known security defect.
        profileApi.assertResponseContains("role", "User");
    }

    @AfterAll
    static void tearDown() {
        profileApi.close();
    }
}
