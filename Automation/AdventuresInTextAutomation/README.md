# Portfolio

This is the personal profile for Richard Adams, a quality and testing specialist based in the UK.

## Automation

### Adventures In Text

A long, long time ago I made a game for Xbox 360 called "Adventures in Text". It was a co-op multiple choice text adventure.

Recently to give me something fun to test with, and maybe reboot, I've been remaking it with a variety of different ways to run the game.
This includes some tests against the game when running on my machine.

The repo is private at time of writing but I've got my code on [GitHub](https://github.com/DevelionUK/AdventuresInText/).
If you really want access then ping me.
It isn't intended as a demonstration of good quality.

#### K6 scripts

I've had a little bit of fun with K6, first hitting my app with a fair few virtual users providing random numbers. This surfaced a few interesting bugs in the web app! I then also decided that whilst not a sensible test, I could use "expects" to report on how often it is beating or losing the game. It managed to complete the game a lot quicker because I think I put in a rubbish ending if you gave certain answers in the first of the three sections of the game.
