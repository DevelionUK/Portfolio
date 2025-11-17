# Software Testing Essentials Certificate

## Module 6 Lesson 5: Put risk techniques to the test!

### Activity

For this I have to use all of the 6 techniques with a suggested application. I've picked a video streaming service. As this is quite in depth and I've done similar, I won't spend more than 30 mins on the exercise.

#### SWOT analysis

This feels strange for just "a video streaming service" where I don't know it. Identifying 2 category.

##### Strengths

- Established user patterns.
- Limited dependencies on third parties (aside from content).

##### Weaknesses

- Heavy performance demands for streaming.
- Wide range of devices need to be supported.

##### Opportunities

- Introducing new types of content (shorts, live videos etc).
- Potential to be the best in class, at least for UX.

##### Threats

- Increasing competition.
- Lapses in performance could lead to loss of users.

#### Risk matrix

Identifying 2 per main quadrants (not doing 3x3).

##### High impact, high likelihood:

- Performance / scalability issues impacting performance
- Users impacted by their own poor connections

##### High impact, low likelihood:

- Security breach
- Authentication system failures

##### Low impact, high likelihood:

- Incorrect categorisation of videos
- Older clients being used

##### Low impact, low likelihood:

- Users trying to consume content as it is removed
- Push notification service not working

#### Scenario analysis

- What if the user loses network connection but has downloaded videos. Can they watch them?
- What if an older version of the app is used?
- What if there is a spike in usage when a new season finale is released?
- What if two people are using the same account & profile to view videos?

#### Risk Storming

To complete this I used 3 random Test Sphere "Quality Attribute" cards then came up with a risk for each.

- Clarity (Usability): My immediate thought here is based upon my parents using a 32" TV without their glasses on. Will the text be readable across the room?
- Data (Functionality): What if the data became corrupted? Is there redundancy in the storage?
- Security and Permissions (Reliability): The obvious one is hackers but with permissions, what about children? What protections and permissions limit their activity and what can they easily access?

##### Nightmare headlines game

- "Mateflix offline for millions of users"
- "Video preview spoils twist in Game of Moans"
- "Buffering issues lead to users cancelling subscriptions"
