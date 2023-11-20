# Number Guessing Game
This document provides an overview and explanation of a simple Number Guessing Game implemented in C#. The game allows users to choose between two modes:

* User Guess Mode: The player thinks of a number, and the program attempts to guess it.
* Computer Guess Mode: The program thinks of a number, player attempts to guess it

## Details

* **Tools:** Visual Studio Professional 2022
* **Technology:** Asp.net 6.0
* **Testing framework:** NUnit

## Prerequisites
* visual studio 2022
* You can either clone the repository or download the zip file and then extract its contents into a directory.
* Navigate to the directory and access the "GuessNumberGame.sln" file.





###  How to build the code

Rebuid the solution in visual studio to restore missing nuget package. Make sure its in "Release" mode. 

	Right click the solution -> Rebuild the solution


###  How to Play

Open the PowerShell -> Go to project's folder : \GuessingGame\GuessNumberGame\bin\Release\net6.0

run exe by typing: .\GuessNumberGame.exe and play game mode 1

repeat the step by running command ".\GuessNumberGame.exe" and play game mode 2


### How to run tests

Open the solution into Visual Studio and open the test explorer from view menu.

Click on "Run all Tests in view" button menu


## File structure
```
├── ./
├── GuessNumberGame [1]
├── GuessNumberGame.Test [2]

``` 

* [1] GuessNumberGame -  is a console application designed to play a game.
* [2] GuessNumberGame.Test - TDD application logic using NUnit.

### Code Structure

*1. IPlayerGuessNumberGame Interface : This interface defines the contract for the user guessing game. It includes methods for initiating and playing the game.

*2. IComputerGuessNumberGame Interface: This interface outlines the contract for the computer guessing game. It specifies methods for initiating and playing the computer-based game.

*3. PlayerGuessNumberGame Class: This class implements the IPlayerGuessNumberGame interface and represents the user guessing game. The game prompts the user to think of a number within a specified range and then attempts to guess the number through user interactions.

*4. ComputerGuessNumberGame Class: This class implements the IComputerGuessNumberGame interface and represents the computer guessing game. The game generates a random number within the specified range and prompts the user to guess the number.

*5. Program Class: The Program class contains the Main method, serving as the entry point for the application. It prompts the user to choose a game mode and initiates the corresponding game instance.

Input Validation

The program validates user input to ensure it is an integer and corresponds to a valid game mode (1 or 2) and vaild guess number between the range. It prompts the user until a valid input is provided.

