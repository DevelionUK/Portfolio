# Portfolio

This is the personal profile for Richard Adams, a quality and testing specialist based in the UK.

## Security Test Activities

Since 2022 I have been working on activities that people can go through to help learn security testing. Some of these are [publicly available activities](https://r-adams.co.uk/securitytestactivity/) but some are from workshops or created for demos in videos etc.

The tests here are testing my activities, rather than being dedicated security tests. After all - the tests would fail given I deliberately created vulnerabilities!

### C# And Selenium

As I've not had hands on experience with Selenium in the past, I thought it would be good to explore it. Rather than handling a new framework and less familiar language at the same time, I picked C#. I've also been using Visual Studio Code as a lightweight option to my usual go to of Visual Studio (plus I no longer have a Pro license!) so there may be some clunkiness in my project configuration.

So far I have created a simple test class for one of my security test activities, which tests that the hinted solution can be solved, the hint isn't shown by default and error handling for the "Title ID" is in place.

### Layered Acceptance Tests

I've often advocated for the use of layered acceptance tests but haven't written them in the full three layers (usually just 2). Consequently I thought it would be fun to spend a few hours putting some together.

As it has been a few years I decided to revisit SpecFlow, only to discover it has been replaced by Reqnroll (love the name!). As I was less fussed on the driver behaviour, I decided just to "steal" my tests from C# & Selenium but with a different structure. I have adapted them though to move assertions into the driver layer.

Within this project I have a feature file that details the expected behaviour in human readable language (gherkin). I'm then using the step definitions to map that to actual things that are done at a code level but the actual Selenium is then within a driver class. This means then when looking at the step definitions you're seeing what is being done, but not the mechanics of how. In theory if I wanted to switch from NUnit to MS Test or Selenium to another driver, I'm just changing my driver layer code. Behaviours and steps are the same as before.

I'll admit that I'm not happy with my scenarios, or including the tear down in the step definition class and having "driver." throughout... but it is quite nice having this behaviour differentiated.

For clarity, I have deliberately avoided using the term "BDD" here as I'm writing the tests after the fact. They may be similar to what I'd look to do when working within BDD but the most crucial aspect of BDD is that discovery phase.
