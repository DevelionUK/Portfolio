# Software Testing Essentials Certificate

## Module 5 Lesson 2: Question oracles and artefacts to uncover risks

### Bling-R-US Notes

Not an activity but as Lena did, immediately I started taking notes. I then realised Lena was sharing the same notes but continued as I find that handy.


Scenario:
- Small company (low throughput capabilities)
- Existing customers are largely companies buying for staff / clients / give aways etc
- Variable sales rate
- Desire for international sales
- Seasonal sales (xmas, graduation etc)
- Spec is agreed already
- Dev is WIP already and only just considering testing with new hire
- Limited time availability for the client (need to make assumptions)

Specs:
- GDPR & privacy
- High quality images for profiles (of jewelry I think?)
- "Reasonable number" is vague.
- Order artefacts should be invoice (for customer) and work order (for company)
- Visually nice & user friendly
- Performance
  - 5-10 orders a  day
  - ~200 a day around seasonal sales
  - Aim to scale up 10x in 2 years
- Contact page
- Able to add new items and support exclusivity
- Wasn't sure on exactly what was the payment process (different payment options is nice to have, but what is MVP?)
- Pricing excludes VAT (25%) -> Target market is companies?
- Discounts available including an every 5th item free
  - 5th, 10th & 15th... ? OR only 5th
  - Cheapest?
- Shipping is per item or free if above a limit
- Engraved text 0-10 chars free and above costs more
  - Nothing on limits?

### Activity: What are three key questions to uncover risks in this project?

** Q1: What has been the testing processes so far? **

With development already in progress we are late to the game. To help understand the risks associated I would want to learn about the existing testing. I doubt nothing has been tested at all... just not by a tester.

Here's what I wrote on the Club:

> A big risk is how we’re joining the project late in the day. As well as modelling the system & focusing on areas that concern us, I think it is also useful to understand what the process has been for development. My opening question (with many follow ups) would be around how we’ve been testing already. Have the devs been writing unit or E2E tests? Have they been testing their own work? What areas have better coverage already?

** Q2: How is data being managed? **

With GDPR being an important part of the requirements, understanding how we're managing data will be important for testing for it. Additionally this will open ideas around security testing and functional testing by considering the data requirements and flows. Depending upon the answer, it may open the door for risk storming or threat modelling around this area.

** Q3: What is the cloud solution and its scalability? **

Performance is obviously a concern for the customer. However the numbers aren't huge therefore I'd be curious about how they are managing scaling.

** Feedback after using the site **

Upon using the website I got answers to a few of the questions bouncing about in my head. The UX was pretty rubbish with a lack of validation until you hit submit and with character count being important, there's no feedback as you type your message.
 
I found a few defects with a very quick test:
- Adding quantity of 0 said "NaN items" were added to my card. It was listed in the basket.
- Using a "Valid thru" of the current month was rejected. Can't I order if I have a few days on my card?
- Able to place a blank order