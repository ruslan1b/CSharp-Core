# SoftServe IT Academy C# Core OOP Course
 ### SoftServe IT Academy course :+1:

## Task 1:
 
Create Console Application project in VS.
In method Main() write code for solving next tasks:
Define integer variables a and b.Read values a and b from Console and calculate: a+b, a-b, a*b, a/b. Output obtained results.
Output question “How are you?“. Define string variable answer. Read the value answer and output: “You are (answer)". 
Read 3 variables of char type. Write message: “You enter (first char), (second char), (3 char)”
Enter 2 integer numbers. Check if they are both positive – use bool expretion 

## Task 2

Identify enum TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted).  Assign status “Pass” for the variable  test1Status and print the value of the variable console.
Determine RGB structure that represents the color with fields red, green, blue (type byte). Identify two variables of this type and enter their fields for white and black colors.
Create Console Application project in VS.
   In method Main() write code for solving next task:
 read number of HTTP Error (400, 401,402, ...) and write the name of this error (Declare enum HTTPError)
declare struct Dog with fields Name, Mark, Age. Declare variable myDog of Dog type and read values for it. Output myDos into console. (Declare method ToString in struct)

## Task 3

Input a and b are two integers. Calculate how many integers in the range [a..b] are divided by 3 without remainder.
Input a character string. Print each second character
Input the name of the drink (coffee, tea, juice, water). Print the name of the drink and its price.
Input a sequence of positive integers (to the first negative). Calculate the arithmetic average of the entered numbers.
Check whether the entered year is a leap.
Find the sum of digits of the entered integer number
Check whether the entered integer number contains only odd numbers

## Homework 1

Create Console Application project in VS. In method Main() write code for solving next tasks:
define integer variable a. Read the value of a from console and calculate area and perimetr of square with length a. Output obtained results.
define string variable name and integer value age. Output question "What is your name?";Read the value name and output next question: "How old are you,(name)?". Read age and write whole information  
Read double number r and calculate the length (l=2*pi*r), area (S=pi*r*r) and volume (4/3*pi*r*r*r) of a circle of given r 2. 

## Homework 3

- Read the text as a string value and calculate the counts of characters 'a', 'o', 'i', 'e' in this text.
- Ask user to enter the number of month. Read the value and write the amount of days in this month.
- Input 10 integer numbers. Calculate the sum of first 5 elements if they are positive or product of last   element in  the other case.

## Homework 4

 1. Create class Person.
    **Class Person should consists of**
    - two private fields: name and birthYear (the birthday year). As a type for this field you may use      DataTime type.)
    - two properties for access to these fields (only get)
    - default constructor and constructor with 2 parameters 
    - methods:
            - Age() - to calculate the age of person
            - Input() - to input information about person
            - ChangeName() - to change the name of person
            - ToString() 
            - Output() - to output information about person (call ToString())
            - operator== (equal by name)
  2. In the method Main() create 6 objects of Person type and input information about them.
    - Then calculate and write to console the name and Age of each person;
    - Change the name of persons, which Age is less then 16, to "Very Young".
    - Output information about all persons. 
    - Find and output information about Persons with the same names (use ==)


## Homework 10

1.  Create Console Application project.
      Use classes Shape, Circle, Square from your previous homework.
      Use Linq and string functions to complete next tasks:
      1) Create list of Shape and fill it with 6 different shapes(Circle and Square).
      2) Find and write into the file shapes with area from range[10, 100]
      3) Find and write into the file shapes which name contains letter 'a'
      4) Find and remove from the list all shapes with perimeter less then 5. Write resulted list into Console

2.  Create Console Application project.
      Prepare txt file with a lot of text inside(for example take you.cs file from previos homework)
      Read all lines of text from file into array of strings.
      Each array item contains one line from file.
      Complete next tasks:
      1) Count and write the number of symbols in every line.
      2) Find the longest and the shortest line.
      3) Find and write only lines, which consist of word "var"/
