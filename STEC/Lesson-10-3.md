# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 10 Lesson 3: Let's explore it!

### Activity: Run an exploratory testing session and share your findings!

#### Mission 1

##### Mission Statement

Explore the Bill Pay with a new account to discover what the feature provides

[Timebox 10mins]

##### Findings Summary

- Feature is limited
- Two minor defects found with messaging. One is a poor error message (internal error) and the other is a confirmation with no clarity on how to perform the suggested actions. Entered as:
  - [Bug 1234] I'm not actually entering bugs
  - [Bug 1235] Definitely not 2 of them
- Proposed new charters are:
  - Accessibility
  - Validation
  - Security API testing including invalid requests and around authentication

##### Notes

**Initial impressions:**

- I found this via the Site Map
- Clicking Bill Pay without being logged in resulted in an error: An internal error has occurred and has been logged.
- Provided the following details:
  - First Name:	Richard
  - Last Name: Adams
  - Address: 123 Fake Street
  - City: Fake City
  - State: Solid
  - Zip Code: 111111
  - Phone #: 07971111111
  - SSN: 123456789
  - Username: RichA
  - Password: Test1234
- Once logged in, there is a link for Bill Pay.
- Bill Payment Service has a form requesting the following information:
  - Payee Name:
  - Address:
  - City:
  - State:
  - Zip Code:
  - Phone #:
  - Account #:
  - Verify Account #:
  - Amount: $
  - From account #: (this is a drop down)
- All fields are mandatory (checked by submitting blank form) bit this seems like quite a lot, at least compared to using similar services myself.
- Your balance isn't displayed, meaning that you need to look elsewhere to see if you have the funds.
- Submitting the form will say the bill was successfully paid

**Issue**

- Hit a CloudFlare issue and subsequently seemed to lose my session. Was no longer logged in and couldn't find my account.
- Upon submitting you are told "See Account Activity for more details". There is no such page directly accessible and requires a bit of a search.

#### Mission 2

##### Mission Statement

Explore the Bill Pay with invalid or incorrect details to discover what the feature provides

[Timebox 20mins]

##### Findings Summary

There is almost no validation on these pages. Some of these are lower priority, such as how phone numbers or ZIP codes aren't validated as legit, but five critical issues were found:

- Can exceed your current balance.
- Can make payments even when available funds is $0 and balance is $0 or negative.
- Negative quantities can be provided, leading to an increase in the customer's funds.
- Can provide amount with incorrect number of decimal places, which appeared to break the user's account and leave them unable to perform any operations.

Also despite requiring information on the person you are paying, these details aren't displayed anyway or used to validate the request. Unless they are adding value some other way, they should be removed.

##### Notes

- A lot of information is required but when entering incorrect details for Bob the Builder, it still went through. It isn't available in the Activity page either.
- Providing 'a' for each field was accepted for payee name, address, city, state, zip code(!) and phone number (!!!). These are not valid values.
- Account #, Verify Account # and Amount $ must be numeric but allow free text input. Why not numeric fields?
- Able to pay in excess of what the customer has in their account.
- Able to make payments when the balance is negative and available funds is $0.
- Able to pay a bill with a negative amount of money.
- Entering a very high positive or negative value resulted in an internal server error. No cap on what you can input
- The validation on account numbers being the same does work
- Submitting an account number with a decimal, such as 123.04 resulted in an internal error
- Decimals accepted for payment... even if it is merely $0.01
- Submitted payment of 1.23456 and it was accepted.
- Account at this point was now broken. All pages involving finances were displaying an internal error.

Date	Transaction	Debit (-)	Credit (+)
12-18-2025	Bill Payment to Bob the Builder	$123.00	
12-18-2025	Bill Payment to Bob the Builder	$123.00	
12-18-2025	Bill Payment to Bob the Puilder	$1.00	
12-18-2025	Bill Payment to a	$11111111111.00	
12-18-2025	Bill Payment to Bob the Builder	$1.00	
12-18-2025	Bill Payment to Bob the Builder	-$400000.00	
12-18-2025	Bill Payment to Bob the Builder	-$11111111111.00	
12-18-2025	Bill Payment to Bob the Builder	$0.01	

(note that I couldn't include the final transaction as the page won't load any more)
