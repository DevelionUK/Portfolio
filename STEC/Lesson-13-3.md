# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 13 Lesson 3: What happens after a fix?

### Activity: What would you do after the fix?

#### My approach

First I'd be reading the fix description and maybe the PR to understand the impact of the change and testing done by the developer.

Then if the issue was new to me, I'd want to reproduce it on an earlier version of the software if possible. I'd then repeat that testing to verify the fix. The next step would be regression testing of affected areas. This would likely take an exploratory approach rather than executing a bunch of test cases and the case would be based on what I've uncovered in that earlier investigation, my own feelings of risks (based upon experience) and automated test coverage.

Having an automated check for this in the future could be useful but not manual. Instead I would hope there's a manual worflow test that covers coupons meaning that we should be able to catch it again.

#### Test task

- Reproduce original issue
- Deploy version with fix and verify the fix
  - Use a mix of coupons
  - Logged on and not logged on
- Regression testing:
  - Refresh behaviour
  - Updating basket quantities
  - Completing the workflow with coupons
  - Modifying coupons applied to basket
