# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 9 Lesson 4: How heuristics influence your test design

### Activity 2: Design test cases using heuristics

For this I opened to used the demo site [PHPTravels](https://phptravels.com/demo/) and the accessibility heuristic to create three test cases.

**Form can be completed with keyboard input only**
1. Access the page.
2. Press tab key until you are in the first field in the form.
3. Provide valid values for each field and use the tab key to progress to the next element.
4. Once all fields are filled in, tab/shift-tab to the Submit button and press Enter to submit.
- Form can be submitted with just keyboard control.
- Optional additional testing of repeating but with invalid details in the form.

**Tab control available throughout the page
1. Access the page.
2. Press tab key to move through each field on the page. 
- No fields / interactable elements are missed.
- The order is left to right & top to bottom.
- It should always be clear which field you have selected
- Optional testing of using Shift+Tab to reverse through the page.

**Alt text provided for all images**
0. Optional step zero of screenshotting page
1. Use a tool such as "Images ON / OFF" to disable all images on the page.
2. Scroll through the page. 
- Missing images have alternate text.
- All text is suitably readable.
- All elements can be interacted with.

**Accessibility score of 80% or higher
1. Run Lighthouse accessibility test. Consult (some link to a wiki) for steps.
- Page meets the minimum requirement of 80%.

#### Notes

I included that last one to highlight how advanced techniques are better captured outside of the test case. If Chrome Developer Tools changes its UI then suddenly we have loads of test cases with incorrect steps. Instead pointing the tester to more support should they require it.

I have also tried to avoid any needless details like what the content of the page is or what valid/invalid details are and this is because there should be existing test cases covering this. I think it is important that a test case covers one thing and the steps are specific to testing what you are interested in. Being an accessibility test, we're not interested in whether the validation is correct so I avoid any additional details here.
