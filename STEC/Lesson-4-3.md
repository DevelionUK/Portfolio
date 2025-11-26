# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 4 Lesson 3: Testing input fields: Intuitive approach to uncovering issues

### Activity 1: Intuitive approach to uncovering issues

| Potential Issue | Why it may be a problem | Potential outcome |
| --------------- | ----------------------- | ----------------- |
| Entering a value that isn't an email  | The system may not provide validation | Lack of guidance to user |
| Using single or double quotes | Potential SQL injection vulnerability | An error message or potentially perform a SQL injection attack |
| Have a really long email or password | Limit on entry less than actual values | User unable to log in |
| Blank fields | Users should be prevented from doing this but is it allowed? | Poor UX - get an error instead of prevented. Users able to log in as other people |
| Incorrect password | Is the login correctly checking the password field? | Users able to log in as other people |
| Password visibility in page | Security vulnerability to show password on screen | User has their password stolen |
| Password not encrypted | Security vulnerability | User has their password stolen |
| Using minimum length email & password | Is validation different to actual values | User unable to log in |

I may have misunderstood this and just wrote ideas!

### Activity 2: Intuitive approach to uncovering issues

| Technique/Heuristic | How you will apply it |
| ------------------- | --------------------- |
| Data formatting tests | Use the Big List of Naughty Strings and some of my own ideas from Activity 1 to test the different validation |
| Boundary testing | Look at minimum and maximum values as per DB and test around those boundaries. |
| Accessibility  | Test the tab order and use Lighthouse to analyse the accessibility of the page. |
| Follow the data  | Use Chrome Dev Tools to inspect what is sent to the server. |
| Bypass the UI  | Use Chrome Dev Tools to modify what UI requires or use Postman to send direct requests to the server. |

### Activity 3: Perform testing

Rather than filling out the form, here's just some interesting notes.

This was discovered through the sign up page (OOS but needed to perform testing):
- Accepted basic "Test1234" password
- Minimum password is 6 characters.
- 100 char password accepted: 0123456789112345678921234567893123456789412345678951234567896123456789712345678981234567899123456789

Notes from testing login form:
- SQL injection failed (as expected)
- Incorrect password rejected (as expected)
- Getting back to the login form was really hard!
- Good accessibility score! 96%
- Validation looks to be by javascript on submit.
- If you submit an invalid email, fix it but get password wrong, the invalid format message remains on screen.
- Max chars for password is 17932 (odd...)
- Email length was huge. 103k+ characters resulted in a network error but ~101k seemed fine.
- Once logged in, your token is stored in local storage
- Seeing the cart got me distracted. I ordered a $29 shirt for $2. Go me.

### Activity 4: Reflection

Interestingly I had quite a lot of ideas on paper here but as I didn't setup the test accounts to login (and didn't feel comfortable setting up loads), I didn't touch upon a chunk of my plan. Also some of it would have been mitigated by conversations with the developer.

I definitely prefer the intuitive testing approach but there's merits in including both. I probably would have wanted to identify slightly less up front but get stuck into it more in time.
