# PrimeSifting

#### Latest version date: 7/15/20

#### By Deryck Jackson and Micheal Hansen

## Description

Finds all prime numbers up to inputed number

## Specifications

1. **Behavior:** Program allows user to input a number.
    * **Input Example: 3**
    * **Output Example: none**

2. **Behavior:** Program generates a list of integers in the range of 2 to the chosen number
    * **Input Example: 10**
    * **Output Example: { 2, 3, 4, 5, 6, 7, 8, 9, 10 }**

3. **Behavior:** Program removes all multiples of the first item from the list
    * **Input Example: { 2, 3, 4, 5, 6, 7, 8, 9, 10 }**
    * **Output Example: { 2, 3, 5, 7, 9 }**

4. **Behavior:** Program proceeds to the next item remaining on the list, and repeats the above process
    * **Input Example: { 2, 3, 5, 7, 9 }**
    * **Output Example: { 2, 3, 5, 7 }**

5. **Behavior:** Program continues until it has iterated through all items, then outputs the results.
    * **Input Example: { 2, 3, 5, 7 }**
    * **Output Example: 2, 3, 5, 7**
   
## Setup and Installation

* Click the green clone button to download the repo your Computer
* Find the .zip file on your Computer
* Unzip the file
* Browse to the PrimeSifting.Solution directory
* To run the code, navigate into the Primes directory and compile the code: `dotnet run`
* To run the tests, you'll need the packages: navigate ino the Primes.Tests directory, and run `dotnet restore`. Then, the tests can be run with `dotnet test`

## Bugs

No bugs

## Tech used

* C#

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Deryck Jackson
