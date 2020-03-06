# _Word Counter_

#### _Epicodus C# Week 2 solo project, 3/6/2020_

#### By _Matt Taylor_

## Description

_This application project is an exercise in C# testing using the console and MSTest. The program checks how frequently a user input word appears in a given string, returning full word matches only._

## Behavior Driven Development
| Behavior | Input | Output |
|----|----|-----|
|User inputs a word that is set as a string|"snail"|"snail"|
|User input word is set to all lowercase|"SnAil"|"snail"|
|If user inputs nothing, there is an error message|" "|"No word input. Please try again."|
|If user inputs a number, there is an error message|"Sna1l"|"Word must contain letters only. Please try again."|
|If user inputs more than one word, there is an error message|"Snail swarm"|"Please enter only one word. Try again."|
|User inputs a list of words that is set as a string, with all previous tests applying|"A snail with a pail is a pail snail"|"
a snail with a pail is a snail pail"|
|Program takes list of words and splits it into a string array|"snail pail"|["snail", "pail"]|
|Program compares each string in string array to the original input word and counts the number of matches|"snail", "snail with a pail is a pail snail"|2|

## Setup/Installation Requirements

* Open Terminal
* Type ``$ git clone https://github.com/mtaylorpdx/WordCounter``
* Navigate to WordCounter.Tests folder
* Type ``$ dotnet test``

## Support and contact details

Email [@Matt Taylor](mailto:me@email.com)

## Technologies Used

* Git
* C#
* .NET Core
* MSTest

### License

*Licensed under the MIT License*

Copyright (c) 2020 **_Matt Taylor_**