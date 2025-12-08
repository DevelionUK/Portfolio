Feature: Injection Theory

This feature is for a small activity where learners provide a noun and verb to create sentences

    Rule: The movie title should contain the words provided by the user

        Scenario: Client provides any two words
            Given the client has just accessed the Injection Theory page
            When the movie name is generated with the noun "Tester" and verb "Tests"
            Then the title contains the words "Tester" and "Tests"

        Scenario Outline: Client provides multiple words for the values
            Given the client has just accessed the Injection Theory page
            When the movie name is generated with the noun <noun> and verb <verb>
            Then the title contains the words <noun> and <verb>

            Examples:
              | noun                | verb                 |
              | "Multiple words"    | "Lots of letters"    |
              | "Words, I say" | "Punctuation is OK." |

        Scenario: Client provides the hint solution
            Given the client has just accessed the Injection Theory page
            When the movie name is generated with the hint values
            Then the title is "The Day of the Dead was a really good film. I enjoyed this and Dawn of the Dead."

    Rule: The hint should not be visible when you first view the page

        Scenario: Hint is hidden when you view the page
            Given the client has just accessed the Injection Theory page
            When they try to read the hint
            Then the hint is not visible

    Rule: Invalid titles result in no movie name

        Scenario Outline: No movie shown for invalid title numbers
            Given the client has just accessed the Injection Theory page
            When the provide invalid title <title>
            Then no movie name is generated

            Examples:
              | title                     |
              | "11"                      |
              | "1; DROP TABLE Movies;--" |
              | "0"                       |
              | "1.5"                     |
