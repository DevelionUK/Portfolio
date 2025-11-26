# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 5 Lesson 4: Testing metrics

### Personal Reflections
 
There was nothing in the course requiring this but the discussion between Lisa and Kat was fascinating.

#### Bug Metrics

One of my biggest face palm moments when I was moved to a different organisation was their metrics.

The project has been in an awful state for years after quality was largely abandoned but now it really needed releasing but wasn't shippable. The answer for this was metrics on bugs fixed vs raised, weighted by severity. The scores of teams throughout the organisation were on a dashboard and they would be quizzed in sprint reviews.

This didn't increase the quality of the product. Instead teams fudged the severities or just didn't raise bugs (either ignoring it, or fixing without an associated ticket). It led to more bug ping pong as batting a bug to another team was better than it staying in your backlog.

One of the first actions I did when taking on a quality section of our sprint review was to drop these metrics. My team fully supported it, so I gave my reasons (rather bluntly) and offered that people could reach out to me for information on a dashboard if they want.

I really don't like focusing on bug counts. If you get better at testing or focus on a new quality attribute then you're likely to find new bugs. It also assumes that all the bugs in the software are within Jira/Bugzilla etc.

#### 2025 Metrics Initiative

In mid-2025 I was tasked with getting quality metrics. There was no objective around what I was to gather so I asked around. No one cared. Other than "I want metrics". I suspect because they wanted to prove that quality wasn't a major problem (it REALLY was) so I'd drop having initiatives. (at the time the effort being spent by teams on quality was highly contentious)

I decided to focus in on something to measure value, excellence and correctness. However that was still super woolly so I spent some time digging into metrics. Coincidently there was a DORA session on metrics and the lean coffee gave me some insights. I needed to sell a story and the narrative that I decided to tell was that being bogged down with bugs is slowing us down. For value I looked at user story points vs defect count pulled into sprints to represent how much effort is on value. I represented excellence by highlighting accepted quality issues. Finally for correctness it was a pretty standard bug metric (eww, I know).

When this was done I shared it in a Sprint Review and asked for feedback. Interestingly I managed to get buy in to collaborate with one person on moving this further forward but the person who demanded the metrics, not a word. Sadly I never got to see the project further but my takeaways was that metrics for the sake of it is pointless. However having a story to tell does bring its merits. It needs to be tied in with a legitimate goal.
