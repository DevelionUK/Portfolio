# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 11 Lesson 5: The many ways to create test cases

### Activity: Try out and compare two test case methods

Throughout my years I've experienced many of these methods. Rather than practiving writing test cases, I thought I'd evaluated the different approaches. No particular one is "best" but they have pros and cons and I have my own preferences.

#### Formats

- **Document (Structured Test Cases)**: These are my least favourite type of test cases as they generally require the most maintenance. They can be very useful if you have a series of tests to execute for every release, however ideally we are automating these tests. For day-to-day testing the overhead is too much and they can very quickly rot and be incorrect.
- **Spreadsheet**: In the example the format is still very similar to the structured test cases above. I would prefer to use a spreadsheet when I'm looking to test a variety of states, inputs or preconditions. For example when testing with a range of different types of trust relationships for an Active Directory feature it was really useful to have a table with the combinations mapped out.
- **HISToW (How is is supposed to work)**: I've not used this explicitly before but it is very similar to the format that I liked using for user stories. I'd start by transferring the relevant ACs to describe the behaviours that I'll need to check. Then I would identify other test scenarios/cases to look at as a bulleted list.
- **Given-When-Then scenario**: I am a fan of using GWT and have used this in my testing on many occassions. I find it a much more desirable way to express the behaviour than having step by step instructions that end up covering bits of the UI / workflow that aren't relevant. Often I would combine GWT with my approach similar to HISToW where that step to transfer the ACs is actually formulating them into test scenarios using GWT.
- **Test Charter**: I quite like test charters where I am interested in discovering information and really diving into a product. Writing all the tests I'd perform in a structured way often isn't worthwhile.

In summary, I would use a format very similar to HISToW or use test charters depending upon the story or feature that I'm testing. I've also enjoyed using both where I articulate behaviours (possibly with GWT) and things to test, then also add a charter or two for where I want to go deeper or feel that I should explore to uncover information.

#### Tools

- **Sub Tasks**: This is my preferred option when working within a development team as it links my testing of the user story directly to the user story itself. This means that if we want to see how a story was tested, it is directly there within Jira.
- **Test Case Management Tool**: I would only use this for tests that I would expect to repeat frequently. The reason for this is that I've experienced having thousands of test cases meaning that your test case of interest is buried and probably out of date. I have tried using test case management tools with my exploratory testing but found that this just cluttered the system with charters that have limited value when standalone in a TCMT.
- **AI Tool**: I've explored using AI for test cases with mixed results. Context is a challenge for AIs so ideally you would use a tool like Epic Test Quest's Wizzo where you can prepare this context or a hackathon project with agents that had access to useful information plus our context. That isn't to say that they are useless and probably help when people are struggling with ideas, but they won't replace the mind of an excellent tester any time soon (making them inferior to me ^_^).
