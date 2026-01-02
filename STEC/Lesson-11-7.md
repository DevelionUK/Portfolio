# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 11 Lesson 7: Reporting your testing

### Activity: Good vs. bad bug reports

A good bug report contains a clear description of the issue that you are reporting (pictures and videos help!) as well. Ideally this would also highlight the actual impact on a customer (are they blocked? Is it core workflow?).

The steps to reproduce the bug and (if known) the expected outcome are essential. This should come with any preconditions required for setup. Personally I don't like bugs that are heavy in detail on setup or using the software as this distracts from the steps that are relevant to the bug itself.

The steps should also include sample test data. In the examples in the activity, both have weaknesses in their description of using the coupon. One refers to "the coupon" but it isn't clear if it must be a specific coupon. The second example isn't perfect either:

> 1. Navigate to checkout page
> 2. Enter SUMMER20 into the coupon field
> 3. Click “Apply”

I would be asking whether the bug is specific to the code SUMMER20 or would any valid code cause the issue? From reading the bug I don't think it is specific to that code. My improved steps would be:

> 1. With at least one item in your basket, navigate to checkout page
> 2. Enter a valid code (e.g. SUMMER20) into the coupon field
> 3. Click “Apply”

Version information is essential and sometimes platform/browser, reproduction rate and last known working version can be valuable information. Context is relevant here. For some bugs I can assume 100% reproduction (e.g. improper validation) so I don't want to have several lines of screen space dedicated to that. I do however want to know when an issue was a "one off" or otherwise might not be reproducible every time. Similarly I've handled bugs where preconditions are thoroughly detailed with versions of all components and services involved for a typo in the log message.

Logs, network captures and other supporting data should be included if relevant (if in doubt, include it). One thing to add here is that I love it when a comment includes details on timings or other relevant information to search for in the logs. Having an 800 line long log file covering 12 hours and no indication on when the issue occurred it very frustrating!

The final thing is that I've worked with bug templates that included lots and lots of different fields. People ended up only filling in some fields and the boiler plate, complete with descriptions on how to fill in the fields, was left in place. This meant that my full monitor was filled with a bug description yet there was only a couple of lines that were actually meaningful to me. This hurt my head and I've often missed useful information that was buried under lines of junk.
