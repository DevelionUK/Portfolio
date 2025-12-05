# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 8 Lesson 4: How to find testing opportunities in requirements

### Activity: Finding testing opportunities in a requirement

"Username should be an email"

Immediate questions on this:

1. Should... does this mean must?
2. Are there any limitations on size in the system, such as DB field?
3. Is this to be validated server side or client side (or both?)

Also to be I would clarify that this must mean a valid email address. Surely you are providing an actual email ("Hi, How are you...") and it seems implicit that the email should be valid.


**Rewritten requirement:**

The username must be a valid email address of up to 128 characters in length.

**Test Scenario**

Invalid email provided:
- <blank>
- a.b
- a@b
- @a.b
- a.@b.c
- a@b.c.
- a..b@c.d
- a%b@c.d
- a@b!c.d
- a@b@c
- a@b.c@d.e
- 129.characters.long.email.address.is.actually.pretty.long.but.i.am.glad.that.notepad.plus.plus.shows.me.counts@the.test.site.com

**Further Test Ideas**
- Valid emails with different capitalisation
- White space around the email
- XSS injection if the username is displayed on page
- Usernames that are already taken
- Using REST client to send invalid email addresses direct to the server
