# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 8 Lesson 6: Spotting the testability of the requirements

### Activity: Evaluating requirement testability

> "The user should be able to reset their password easily." 

Straight off the bat we have two issues with vague working:
- Should
- Easily

Whilst this lesson is focused on testability, the means of resetting is really open and vague here. An easy way would be to just allow you to straight set a new password, or set back to a "default" but that is hardly secure! This maybe ties in to the Problem part of 10 P's of Testability.

I'd need to clarify exactly how passwords are being reset and the services involved. Most likely something like email.

This leads me to the first big testability challenge. Having your own email server where you can replicate errors and adverse behaviour isn't going to be straightforward. This ties in with Controllability of CODS. What automated test coverage can we provide so that we don't have to do full E2E testing of the solution?

I'd also be looking to understand our users and what "easily" looks like for them. Do we need to consider accessibility here? Do I need to consider usability challenges around using email services? Are these mobile or web users?

Another area to explore would be how we are doing observability for this. How will I be able to track and identify when requests fail?
