# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 8 Lesson 3: Clarifying requirements and identifying ambiguity

### Activity: Analysing and clarifying ambiguous requirements

"Users should receive notifications quickly"


- Users
  - All users? Even those with notifications disabled?
  - How many users are we talking?
  - Are there any users that don't get notified?
- should
  - SHOULD!!!
  - I should have completed the activity on lesson 2 but it felt redundant with my experience, so I didn't. This doesn't fail anything.
  - I should not drink alcohol on a quiet evening in, but I still could. I must not drink alcohol when driving.
  - Given should isn't "must", what about when the system doesn't do this?
- receive
  - What is required on the user's end to receive the message?
  - What is involved beyond ourselves? e.g. Firebase
  - Does it count if they've got their phone on DND / bedtime mode?
  - Are we only interested in them receiving the message? What about the time to send?
- notifications
  - What type of notifications? Push notifications or SMS?
  - What is the maximum content size in notifications?
  - Is there a a standard data size?
  - Are there any types of notifications that are more expensive / slower to send & receive?
- quickly
  - This is very vague!
  - Seconds, minutes or hours? Is days OK? If I received a push notification 5 hours after it was sent, that is still "quick" compared to sending me a letter in the post.

Having worked through this, I'm picking up "users" "receive" "quickly" and am now wanting to know whether all users should receive it quickly simultaneously? For example you could send one at a time and take 6 hours to notify all your customers of an upcoming deal. Or you may want a notification for a government emergency alert to be received by everyone within seconds of deciding to click "Send".

I've been involved in the requirements stage for many years now (11 years within software) and understand the value and importance of asking these questions early. I've seen where requirements haven't been clarified and the impact on the business when things are implemented correctly as understood by the team but not as desired by the business.

In this case the key risks are that we may target a different scenario/environment to what is intended. For example I may over focus on the users receiving the notification when the intention was actually on the speed that notifications are sent by the service. I may also think that the results are "pretty quick" but they don't meet what is needed. Another risk is that we over-engineer the system by targetting unnecessary times to send & receive notifications in seconds when minutes or hours was fine.
