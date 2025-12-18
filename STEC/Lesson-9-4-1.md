# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 9 Lesson 4: How heuristics influence your test design

### Activity 1: Use heuristics to improve test cases

This is an interesting activity as I suspect how I would write test cases isn’t considered “good” but over time I’ve found that less can be more.

I like to focus on behaviours not specifics of the UI as this requires less maintenance and focuses a manual test case on what matters most - the behaviour. I would assume that I’m writing this with the expectation of repeating it a bunch so do I want to be hyper-specific in what I write and therefore maintain? Or do I want to make sure it is clear what is the behaviour that we’re testing?

This is with the caveat that to test new / untested functionality, I’d be doing more charter based testing.

#### Poor test case 1

> - **Test case:** Login functionality
> - **Steps:** Enter valid credentials and click "Login."
> - **Expected Result:** The user should be logged in successfully.

There's a few issues here. First "Valid" is unclear and an example would be useful. Also the test case says "Login functionality" when it covers such a small part of it.

Personally I would rewrite it to be:

- **Test case:** Login with valid email
- **Precondition:** User created with known username and password
- **Steps:** Enter correct credentials for user and click "Login."
- **Expected Result:** The user should be logged in successfully.

Or maybe even:

**Scenario:** Login with valid credentials
- Given user account TestUser exists
- When correct credentials for TestUser are provided
- Then the user is logged into the account TestUser

Unless there is some complicated technique, I wouldn't want more detail on the steps. However what could be useful is more clear cut examples of logins, for example a few different usernames (or emails?) and passwords with different complexity.

We should then have a range of other test scenarios, largely around constraints testing, with a few examples, such as:
- Incorrect password
- Incorrect username
- Invalid username
- Invalid password
- Blank username or password (or both)
- Using the Input Method heuristic - copy & paste or password managers being interesting examples
- Trying to use the login form when already logged in

Invalid could of course mean character lengths, incorrectly formatted emails etc. More context would be useful. Incorrect means that they are valid but don't match what is in the system.

#### Poor test case 2

> - **Test case:** Checkout process
> - **Steps:** The user adds an item to the cart and checks out.
> - **Expected Result:** The checkout works correctly, and the order is processed smoothly.

This is really vague and needs to split into several different tests. There's a lot to consider such as:
- Just a single product or a mix of products?
- Quantities of each product, possibly considering if applicable (Goldilocks)
- Variances of how to pay plus shipping details
- Being signed in & not (yet) signed in
- Multiple tabs
- Going back & forth through the flow

We may need slightly more detailed tests but that would be context driven. I would assume that this is a key workflow and online checkouts aren't exactly an abnormal workflow therefore we have the oracle of how we know checkouts to work. I would be reluctant to spell out every click but we would want clarity over whether you're doing the workflow for a small order, large order, one that has special delivery or coupons etc. Basically better scope on the test.

It is worth noting that I'd be looking for exploratory charters here rather than lots of similar/nuanced test cases. An improved one for the happy path and any key alternate paths then use a charter to capture what I'm unlikely to be manually retesting.

#### Poor test case 3

> - **Test case:** Profile update
> - **Steps:**
>    - Log in.
>    - Navigate to Profile Settings.
>    - Change email address.
>    - Change password.
>    - Click Save.
> - **Expected Result:** The user’s email and password are updated in the system.

I would be looking to clarify that we're after valid details here, perhaps with examples. Plus of course there is likely to be a bunch more test cases to consider with validation (including already existing emails?).
