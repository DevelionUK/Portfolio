# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 9 Lesson 3: A toolkit of test design techniques and fundamentals

### Activity: Applying test design techniques to testing scenarios

#### Scenario 1: User Registration Form

For this I'd be looking at Boundary Value Analysis with a decision / truth table. Although in truth my documentation in advance would be a little light as I'd call out that I'd test lengths, characters and omitting fields but would likely then build up the table as I test rather than doing everything in advance. I don't need detailed test cases to know how to test a requirement like:
> Username: Must be 6–15 alphanumeric characters

### Scenario 2: Online Shopping Workflow

Exploratory testing where I'm focused on using different inputs and error guessing would be important here. I'd usually want to prepare a list of ideas to consider throughout my testing, such as item quantities, discounts and going back and forth.

I'll also want a few clear workflows / use cases to tests to ensure that discounts are applied, handing going back and forth etc.

### Scenario 3: Video Player State Transitions

This already is a bunch of tests to execute. I'd probably prefer it written as a table with "initial state", "action", "new state" then rattle through it. More than this though I'd be interested in putting more design effort into considering very quick clicks, latency/packet loss and also right/middle click etc.
