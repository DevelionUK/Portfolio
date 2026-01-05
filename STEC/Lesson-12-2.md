# Software Testing Essentials Certificate

[STEC Home](README.md)

## Module 12 Lesson 2: What testing evidence to collect

### Activity: Mapping testing evidence to scenarios

#### Scenario 1: UI Glitch in a Web Application

First we should provide a video and/or screenshot. A screenshot is quicker to look at but a video can better demonstrate most issues, including demonstrating reproduction. In this specific scenario where re-sizing the browser causes the issue, I'd have a screenshot to show the issue quickly then a video to demonstrate behaviour.

I would also look to include browser versions as it is possible that behaviour will vary between browser versions.

#### Scenario 2: Intermittent API Failure

Log files from the server application will be important here, including noting important times to help the reader narrow down on the error. Any observability tooling in place could provide a nice addition.

I would also be looking to provide a network trace so that we can see the specific requests sent to the server and the responses. A Har file might be enough without requiring Wireshark.

Finally version information and environment. In particular with this being intermittent, the more I can share on reproducing with different clients & server instances, the better.

As a note, for this issue I'd look to reproduce with just a tool like Postman/Bruno, which if successful I could provide these details to assist reproduction. Even better is if we can then script it to try a thousand times and see the pattern in failures.

#### Scenario 3: Slow Performance in a Web App

Environment will be important here as that may be the cause. I've seen plenty performance related issues where the root of the problem was that the load was simply too much for the small VM or a laptop running Visual Studio, Chrome and other resource intensive applications.

Har files and a Lighthouse report on performance would be really useful here and if it suggests that the backend is the issue then I'd be looking at telemetry for the server. This could be as simple as perfmon logs or maybe grafana. Wireshark may be useful if there's likelihood that the server is talking to different systems that could be introducing the delay.

Log files can also be useful. What was going on at the time? For example if you see log spam of attempting to reach a database or an unexpected gap in log times, this could be useful information. For example if the server has retrieved the data from the DB and then there's a 500ms gap before it has manipulated the data to return, this highlights an issue.
