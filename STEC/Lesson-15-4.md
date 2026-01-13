# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 15 Lesson 4: Debt busters! (Activity)

Based upon the described scenario, the first observation around performance loading the page is defect in the application itself that needs to be raised. It may be testing debt that things like this haven't been considered due to a lack of knowledge on testing practices. This is likely to be a complex issue but first I'd look to create a testing spike to investigate and get real numbers on performance in this area and others. If it is specific to this area then I'd use Lighthouse or other tooling to see if there's an obvious root cause. Then I'd be looking for specifications on expected performance before raising the defect and advocating for it to be fixed.

The second observation around frequent bugs does suggest that the code has technical debt that is impacting the developers' ability to deliver correct & functional software. I'd probably look to do a couple of [meaningful RCAs](https://www.r-adams.co.uk/resources/meaningful-rcas/) with the team to understand what exactly is hurting us here and then raise tech debt tickets if applicable.

The observation around utils.py may suggest that there is technical/testing debt in documentation (depending on whether the file is in prod or test code). One thing that I would say straight away is that people will join and leave companies therefore having functions that nobody remembers writing is perfectly normal. The implication of the observation to me was that they aren't understood and this would be tech debt. An initial avenue to explore would be looking at the change history to understand when and why these functions were written.

Finally the issue about the lack of automated tests is clear testing debt. I would propose entering a tech debt item but before addressing I'd want to understand the frequency of changes here and whether we're concerned about changes on our end or the payment gateway. Writing automated tests isn't free therefore there needs to be a reason and value in adding them.
