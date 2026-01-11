# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 14 Lesson 4: What to do when testing blocks progress

### Activity: Create an action plan: Your checklist for unblocking testing

#### Existing quality issues

This is an issue that has blocked testing in the past and has even led to the idea of testing being the blocker when we're unable to test due to a defect.

This is something that I would escalate up and ensure that there is sufficient visibility that we are blocked, not blocking. I would also advocate for, if possible, a short term fix that can unblock other testing that wouldn't be invalidated when a new build arrives. I'd start this by sounding out the developer(s) involved to see what they think about the feasability before taking to senior leadership.

#### Lacking resources for testing

Testing can often become blocked when there are specific test environment needs. In the past I've typically encountered this when needing access to specific devices but they are currently in use or I'm otherwise unable to obtrain them at the time.

To help with this we would create ways of taking ownership of devices. Wikis were a popular choice of tool as well as spreadsheets. My suggestion was to also update the names of the devices so that when they showed up on the network, it was clear who owner them.

I would also make sure that it was clear when specific devices were to be required within testing and ensure that sourcing them was the first thing that was done, not at the time of requiring them.

#### Tests with long lead time (including setup)

I picked this as it is something that has bitten me in the past. I still recall a test case that had taken me 6 hours to reach the final step as it involved a number of slow but deliberate operations. The final step was to force a disk failure and wait for the unit's disk array to rebuild. This could take days and it meant completing the testing was blocked.

What I did is advise the person responsible for releases that this was going to impact our schedule but proposed that we don't wait on this completing before moving to our next activities. As expected, the test eventually passed.

I took two actions on this.

First I split out the rebuild step into its own test case and secondly on both test cases I called out the expected durations in the descriptions and also the names. Whilst our test case management software did have an expected duration field, we rarely used it and it wasn't one of the columns typically visible in reports (as most values were zero).
