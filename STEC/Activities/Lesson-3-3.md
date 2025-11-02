# Software Testing Essentials Certificate

## Module 3 Lesson 3: Testing heuristics, mnemonics and oracles in practice

### Mini Activity: Goldilocks

As I had a tab open for my favourite [brewery](https://fiercebeer.com/) I decided to think of quantities to add to the cart:
- 0 beer (too few)
- 1 beer (just right)
- 4 beers (just right)
- 99999 beers (too many, arguably)

I then tested them and interestingly the 0 quantity was changed to a 1 whilst 99999 was accepted but errored when I added to the cart. Clearly they have no upper limit. Later upon further testing, if I entered a more sensible "too many" value (200 beers) then I got a message saying that it couldn't add that quantity.

### Activity: One, Zero, Many 

This was interesting as it focused on different types of data interactions and my immediate thought was scenarios where you provide an array of items to an API.
- Array with single item should be accepted
- Array with no items should be accepted but empty arrays can cause issues from my experience.
- Array with many items should also be accepted.

As a note, I would likely also want to test a variant of zero, which is nothing. i.e. don't provide the field.

### Activity: Mneumonics

Let's use the test case from my Fierce Beer experiment above. It gave me a generic "cart error" message.

- *Functional:* I'm not sure if they have any observability in place and there was no simple way for me to report it. The condition could have been detected & prevented earlier with better validation.
- *Appropriate:* Yes it was instant and to myself. Definitely not a false error.
- *Impact:* Not a major impact, however it was preventable via better validation.
- *Log:* Unknown
- *User Interface:* The error message was rubbish. Being a tester putting in extreme values and looking for the answer, I understood why but a more informative message could have been shown. I also found that there were two issues with the error reporting. It was also duplicating the message.
- *Recovery:* Not really relevant but I could then go and adjust the quantities (wasn't cleared) so that is all good.
- *Emotions:* Mild irritation?