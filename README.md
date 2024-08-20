# LeetCodeChallenges
## INTRODUCTION
This repository contains my solutions to the Computer Science challenge, every file contains the solution of a challenge, this solutions work in the LeetCode enviroment that they were developed in, if manual test were to be made additional code is required, my LeetCode user is: https://leetcode.com/u/CamiloVelezP/

## 1.0 CHALLENGES
In this section i will explain every challenge individually, my solution and some important data of the solution, so let's begin.

## 1.1 Merge Two 2D Arrays by Summing Values
The code for this challenge was made using python, this challenge asked to merge two 2D arrays into a final one that has all the unique ids of both initial arrays, also if a identical id was to be found in both arrays, the numerical value of them had to be added up and then add this result and it's id to the final array, also this final array had to be sorted ascendently by id, so, for this challenge i had to look up how to create an array with unique id's, some research pointed to a "hash map", a JAVA data structure that only allows unique keys, since i was using python i searched for a similar structure, and then saw that dictionaries work in a very similar way, so my code uses a loop to convert one array to a dictionary and iterates in every item of the other cheking a condition, if the item's id is not in the dictionary then it appends the item, if it is then it adds the item's value to the current value in the dictionary, when this iterations are complete i use the .items() method to make the dictionary a list again and then, use the sorted(...) built-in function to sort the result.
The time complexity for this code is O(N * Log(N)) as it uses a sorting function that normally has this complexity, as for the space complexity is O(N) as the code requires a dict with N elements, using leet code i got a 41ms for the runtime and 11.80MB of Memory usage.

## 1.2 Path with Maximum Gold
The code for this solution was created using C#, the task for this challenge was to return the maximum ammount of gold that can be collected in a grid that represents a mine, some cells in the grid (represented by a 2D array) contain an ammount of gold represented by a number or 0 if it doesn't have gold, the gold on a cell will be collected if it is visited turning its value to 0, the posible moves are only vertical and horizontal, the path can start or stop anywhere and cells with a 0 or already visited should not be visited, so for this solution it was advised to use recursion to search all posible paths, so a base case and a recursivity had to be defined, the recursivity was made using the function "check path" that accepted a row, column and a sumatory this function is first called when we iterate over every non-zero cell of the grid, then after adding the cell's gold to the summatory it will set its value in the original grid to 0 (don't worry, we'll restore the value later on) and search for other paths using the "check path" function adding or substracting 1 to its row or collumn, the base case was achived when the function is used in a cell that has zero gold or when row or col are no longer on the grid then returning the summatory as it is, the values of these paths are stored in an array and the maximum value of them is then returned, and dont forget to return the gold that we took from a cell to the original value, since we iterate on all the grid we need to find the maximum value of gold staring on any node so we do that using the Math.Max() function comparing the last maximum obtained gold starting in a cell with the maximum obtained gold obtained in te current cell.
The time complexity in this one is O(4^n) since it has 4 recursive calls, and the space complexity is O(N) since it has an array with fixed size but it is created on some recursive calls, leetcode gives a 525ms runtime and 122.64MB of storage memory.

## 1.3 Longest Valid Parentheses
This code was created using JavaScript, in this challenge i was given a string containing only "(" or ")" characters, so the task was to find the ammount of the longest substring of valid parenthesis, as an explanation, if i was given  "(()", i had to return 2 as for the "()" at the end, or if i was given ")()())" i had to return 4 as for the "()()" part, so my first idea was to loop through the entire string looking for a "(" and a ")" that were together but this efectively only returned count of times that "()" was on the string but some strings contained forms like this "(())" this will result in 4 as there is a valid parentheses inside a valid parentheses, so i changed the approach and used a stack to save all the "(" and if a ")" entered and the top of the stack was a "(" add 1 to the count to multiply this total times 2 to get all valid parentheses, else i reseted the count, and compare with the max values if i have found any, this solved the last problem but on some strings like this "()(()" it will fail because it will return 4 as the count will not reset for the parenthesis on the 3rd position, so to fix this every time i pushed a value to the stack i also added the id of that value on the string, so after looping the string all i will have on the stack is the "(" or ")" that do not belong in a valid sequence, using this identifiers i could know how many positions belonged in a valid secuence and returned the max of them.
This algorithm has a time complexity of O(N) since there is a pair of non nested loops and a space complexity of O(N) since i use an array to store the parentheses, leetcode gives a runtime of 63ms and a storage usage of 53.23MB.

