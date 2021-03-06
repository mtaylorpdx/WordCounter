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
|If user inputs nothing, there is an error message|" "|"Please enter a valid word"|
|If user inputs a number, there is an error message|"Sna1l"|"Please enter a valid word"|
|If user inputs more than one word, there is an error message|"Snail swarm"|"Please enter a valid word"|
|User inputs a list of words that is set as a string|"A snail with a pail is a pail snail"|"a snail with a pail is a snail pail"|
|Program takes string and removes punctuation| "A snail, a pail, a pail snail"|"as snail a pail a pail snail"|
|Program takes list of words and splits it into a string array|"snail pail"|["snail", "pail"]|
|Program compares each string in string array to the original input word and counts the number of matches|"snail", "snail with a pail is a pail snail"|2|

## Setup/Installation Requirements

* Open Terminal
* Type ``$ git clone https://github.com/mtaylorpdx/WordCounter``
* To run tests:
  * Navigate to WordCounter.Tests folder
  * Type ``$ dotnet test``
* To run program:
  * Navigate to WordCounter folder
  * Type ``$ dotnet run``

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