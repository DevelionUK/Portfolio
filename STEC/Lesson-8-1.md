# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 8 Lesson 1: What are requirements, and why we should care?

### Activity: Define and analyse requirements

Requirements are an agreement on the how the software is expected to behave. As well as explaining what a feature should do and how it should work, requirements can cover other areas like error handling behaviour and performance needs.

They are important in software development as they provide a shared understanding between the product team and development team on what the expected behaviours are, allowing the development team to implement the feature as desired by the product team and for the testers to verify that the behaviour is as expected, solves the original problem and doesn't have any unexpected gaps - or at least surface what those gaps are.

Whilst the activity suggests using one of a generic real world example, I can provide my own real world examples. Whilst working in a team creating software to integrate with third party systems we were only ever given a one line description. There was no guidance on performance, the third party system or exactly how it should behave. This has caused a few notable issues. One of these was from a typo with terminology where there is no shared domain language. We ended up not adding the support that the customer had actually wanted, which caused customers to be unhappy and a further project was required over a year later. If we had been able to engage and get clearer requirements from the beginning to ensure a shared understanding, we would have implemented the correct behaviour from the start.

The second example was that we never had any guidance from the business teams on non-functional requirements therefore we determined our own based upon similar projects. One project was delivered late trying to achieve the performance and load capabilities we expected. However a few years later we learnt the usage was a tenth of what we targeted. Being able to agree non-functional requirements is also important to ensure that we aren't spending unnecessary time to achieve performance that will never be required.
