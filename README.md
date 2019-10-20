# Wallpaper
Fifth assignment to be submitted via Blackboard.

Actually assigned by professor, not just based on exercise in textbook.

## Objectives
Demonstrate usage of value-returning methods and void methods.

Note that the methods use their own (redundant) local variables for values.
Refactoring the Wallpaper class to get and set values of private data members
is beyond the scope of the current assignment. "Just the methods, ma'am."

I've refactored some void methods from earlier assignments to return values,
including RepeatChar() and CenterString(), along with the new IndentString().

Note also that I initially abstracted out the input validation into a single
reusable ReadDouble() method, but then created separate methods to set values of
length, width, height, and coverage (to better match the problem specification.)

These methods still call the ReadDouble() input validation method, but they are
more closely related to mutators for private data members, which I judged to be
part of the point of this exercise.

## Example output
```
******************************************************
                      Wallpaper
        Calculate Single Rolls Needed
        Name: Matthew Obert
        Date: 9/16/2019
******************************************************

This program will determine how many rolls needed to wallpaper a room.
You will be asked to enter the length in feet, width in feet,
height in feet, and roll coverage in feet.

Enter length (feet): 20

Enter width (feet): 27

Enter height (feet): 10

Enter roll coverage (square feet): 100

The number of rolls needed are: 10
```
