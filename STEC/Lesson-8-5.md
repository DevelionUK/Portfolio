# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 8 Lesson 5: When requirements don’t look like requirements

### Activity: Discovering Hidden Requirements

**Explicit Requirements:**

- Users can add items to their cart.
- Users can remove items from their cart.
- Total price reflects the current contents in the cart.
- User can to proceed to checkout.

**Implicit Requirements:**

- User can add more than one of the same item.
- User can see a list of items in the cart.
- User can individually remove items.
  - An option to "empty cart" would achieve removing items but do not believe this to be the intent.
- The checkout workflow contains the price and items specified in the cart
- The checkout workflow can be completed, although this may not be implemented.
- Accessibility
- Performance
- Responsive design
- Cart cleared upon completing checkout
- Cart should be persistent across using multiple tabs

**Tacit Requirements:**

- The state of the checkout workflow.
- Branding and style
- Currency supported
- Session timeout behaviour
- Security design

**Summary:**

The requirements here are really, really vague and in no way ready for development to start. Whilst I can identify what *must* be the behaviour, I'm having to assume a lot of behaviours around how the cart works and how it integrates into the workflow.

Questions I would have include:
- Clarifying whether remove items needs to be one by one or is empty cart OK?
- Asking about how quantities are provided and whether you can enter 
- Asking whether we're stock checking at this point.
- Asking about upper limits on items.
- What is the state of the checkout workflow? If it has been completed already (seems unlikely without a cart!) then we'd want to test how it integrates. If it doesn't exist, what is the expected behaviour when you proceed to this point?

These would lead to more questions to better clarify the behaviour.

(I could add more but I'm hungry for lunch :P)
