//------------------------- LAB 4  - DEYNNI ALMAZAN -----------------------------------------------

using System;
using System.Collections.Generic;

/*
    1. List<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter a List of Lists of Integers.
    It returns a new list with each element representing the maximum number found in the corresponding 
    original list. 
    For example, { {1, 5, 3}, {9, 7, 3, -2}, {2, 1, 2} } returns {5, 9, 2}. Output the results with a message
    like: “List 1 has a maximum of 5. List 2 has a maximum of 9. List 3 has a maximum of 2.”
*/

List<int> MaxNumbersInLists(List<List<int>> listOfLists)
{
    List<int> maxNumbers = new List<int>();

    //Iterating over each list and finds the maximum number in each one.

    for (int i = 0; i < listOfLists.Count; i++)
    {
        int max = int.MinValue;//assign the smaller possible value for int

        foreach (int number in listOfLists[i])
        {
            if (number > max)
            {
                max = number;
            }
        }
        maxNumbers.Add(max);
    }

    return maxNumbers;
}

//Creating a List of all List numbers
List<List<int>> listOfLists = new List<List<int>>()
   {
    new List<int>() { 1, 5, 3 },
    new List<int>() { 9, 7, 3, -2 },
    new List<int>() { 2, 1, 2 }
   };

//Using the function MaxNumbersInList:
List<int> maxNumbers = MaxNumbersInLists(listOfLists);
Console.WriteLine("Exercise #1");

//Printing max numbers of each list
for (int i = 0; i < maxNumbers.Count; i++)
{
    Console.WriteLine($"List {i + 1} has a maximum of {maxNumbers[i]}.");
}

//The time complexity of the MaxNumbersInLists function is O(N*M), where N is the number of lists
//in the listOfLists and M is the average number of elements in each list.


/*
    2. String HighestGrade(List<List<int>>) accepts a list of number grades among students in different
    courses (where each list represents a single course), between 0 and 100. It returns the highest 
    grade among all students in all courses.
    For example: { {85,92, 67, 94, 94}, {50, 60, 57, 95}, {95} } returns "The highest grade is 95. 
    This grade was found in class(es) {index}".
*/


string HighestGrade(List<List<int>> listOfCourses)
{
    int highestGrade = int.MinValue;

    //Variable to sabe the indices of the highest grade:
    List<int> coursesWithHighestGrade = new List<int>();

    //It iterates over each course to find the highest grade
    for (int i = 0; i < listOfCourses.Count; i++)
    {
        //It iterates over each grade within the course
        foreach (int grade in listOfCourses[i])
        {
            if (grade > highestGrade)
            {
                highestGrade = grade; //Storing new highest grade
                coursesWithHighestGrade.Clear(); //Deleting previous indice saved
                coursesWithHighestGrade.Add(i + 1); //Saving indice of the new highest grade found
            }
            //}
            else if (grade == highestGrade)
            {
                coursesWithHighestGrade.Add(i + 1);
            }
        }
    }

    string courseIndices = string.Join(", ", coursesWithHighestGrade);
    return $"The highest grade is {highestGrade}. This grade was found in class(es) {courseIndices}.";
}

List<List<int>> listOfCourses = new List<List<int>>()
    {
        new List<int>() { 85, 92, 67, 94, 94 },
        new List<int>() { 50, 60, 57, 95 },
        new List<int>() { 95 }
    };

string result = HighestGrade(listOfCourses);

Console.WriteLine($"\nExercise #2 \n{result}");
//The time complexity of the HighestGrade function is O(N*M), where N is the number of courses in the
//listOfCourses and M is the average number of grades in each course.


/*
    3. List<int> OrderByLooping (List<int>) orders a list of integers, from least to greatest, using only 
    basic control statements (ie. if/else, for/while).
     For example, argument {6, -2, 5, 3} returns {-2, 3, 5, 6}.
*/

List<int> OrderByLooping(List<int> numbers)
{
    bool swapped = false;
    int n = numbers.Count;

    do
    {
        swapped = false;

        for (int i = 0; i < n - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                int temp = numbers[i];
                numbers[i] = numbers[i + 1];
                numbers[i + 1] = temp;
                swapped = true;
            }
        }

        n--;
    } while (swapped);

    return numbers;
}

List<int> numbers = new List<int>() { 6, -2, 5, 3 };

List<int> orderedNumbers = OrderByLooping(numbers);

Console.WriteLine("\nExercise #3");
Console.WriteLine(string.Join(", ", orderedNumbers));


//The time complexity of the OrderByLooping function is O(N^2), where N is the number
//of elements in the numbers list.

//Source used to help finding the complexity: https://www.geeksforgeeks.org/understanding-time-complexity-simple-examples/


/* 
    BONUS: Do some research into bubble sorting. refactor OrderByLooping method to use it

    The bubble sort algorithm is simple to implement as it involves comparing adjacent elements and swapping 
    them when they are in the wrong order.This algorithm is not suitable for large data sets as its average 
    and worst-case time complexity is quite high.

    Sources:
    https://www.geeksforgeeks.org/bubble-sort/
    https://code-maze.com/csharp-bubble-sort/

*/


