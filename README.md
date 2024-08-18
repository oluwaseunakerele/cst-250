# cst-250
Milestone 1
## Design Overview
The console application is created to establish and control a dynamic game board, shown as a grid of cells. Each cell on the board can be in one of two states: "live" or "not live," which affects the progress of the game. The Board class sets up this grid and adjusts the difficulty level, which determines how many "live" cells are present. Tasks include arranging live neighbors and determining active neighbors for each cell, which are crucial for following game rules and interactions. The Program class manages the overall flow, dealing with user inputs and showing the current state of the board, offering a simple yet engaging user experience that showcases fundamental concepts in object-oriented programming and system design

## UML
![image](https://github.com/user-attachments/assets/f521e472-4edc-4694-b6a8-d54f218ec735)

## Computer Specs
Device name	DESKTOP-GJUO7TV
Processor	Intel(R) Core(TM) i5-7300U CPU @ 2.60GHz   2.71 GHz
Installed RAM	16.0 GB (15.9 GB usable)
Device ID	118DCACA-ECC5-438F-AFB1-ADF4B3E5B638
Product ID	00330-50624-93673-AAOEM
System type	64-bit operating system, x64-based processor
Pen and touch	Touch support with 10 touch points
## Pragramming Covention
The programming Coventions for Milestone 1 programming include using PascalCase for class and method names (e.g., Cell, CalculateLiveNeighbors()), and camelCase for variables (e.g., gridSize, difficultyLevel). Indentation should be 4 spaces per level, and braces {} should follow the K&R style, with opening braces on the same line. The code should follow object-oriented principles, such as encapsulation and method modularity. XML comments should be used to describe methods, and try-catch blocks should handle potential errors for user inputs and calculations.
## Bug Report.
Title: Incorrect Live Neighbor Calculation in Grid

Date: August 17, 2024

Priority: High

Description: The method calculateLiveNeighbors() in the Board class does not correctly calculate the number of live neighbors for each cell. The issue arises when cells located on the edge or corners of the grid are processed. The calculation fails to handle boundary conditions, resulting in incorrect neighbor counts.

Steps to Reproduce:

Initialize a 3x3 board.
Place a live cell on the corner.
Observe that the live neighbor count is incorrect for adjacent cells.
Expected Result: Correct live neighbor count.

Actual Result: Incorrect neighbor count.

## Video Link.
https://www.loom.com/share/c3048bf51d42458d86dde1959b495bb8?sid=2395152e-8d4a-4c7b-8b38-3181c1d3fe8d







