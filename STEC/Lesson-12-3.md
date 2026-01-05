# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 12 Lesson 3: Essentials guide to test documentation

### Activity: What test artefacts do you use, and why?
Where or when did (or would) you use it
Why was it (would it be) useful (or not)
Who did it (would it) help you communicate with

#### Regression testing

I've found that regression testing and its reports are useful when you want to manually test at the end of a release to ensure that key functionality is still working. Whilst ideally automated, there can be value in a human touch when you have complex systems connected together. A regression testing report can give that confidence boost that you've not broken something.

A really useful example was when we introduced a change relating to HTTPS certificates for third party embedded devices. When my testing was completed we had a report that highlights what worked, what didn't work and where I found inconsistent behaviour depending upon the device/certificate. This was shared with team leads and allowed us to prioritise what needed fixing/investigating first. Further to this, with the full report and my notes available, plus a condensed report, it also shared that a risky feature was largely working.

However generally I get very little benefit from regression testing reports. I am just interested in known what defects there are or on occassion, being able to see how much time we're wasting/spending on regression testing.

#### Plan (Test)

I would provide some form of plan for all testing that I've conducted and often this would be shared with one or more developers from the team implementing the feature/story.

Usually I find the act of planning more useful than the document itself, although it can be a really good starting point for a conversation on coverage with colleagues.
