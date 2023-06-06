// ---------- LABORATORIO 03 - DEYNNI ALMAZAN ---------------------------------

/* 
    1. We have a list of integers where elements appear either once or twice. 
    Find the elements that appeared twice in O(n) time. 
    Example: {1, 2, 3, 4, 7, 9, 2, 4} returns '{2, 4}
*/

using System;
using System.Collections.Generic;

List<int> nums = new List<int> { 1, 2, 3, 4, 7, 9, 2, 4 };

//Using HashSet to find duplicates 
List<int> FindDuplicates(List<int> nums)
{
    List<int> duplicates = new List<int>();
    HashSet<int> set = new HashSet<int>();

    foreach (int num in nums)
    {
        if (!set.Add(num))
        {
            duplicates.Add(num);
        }
    }

    return duplicates;
}


List<int> listDuplicates = FindDuplicates(nums);

Console.WriteLine("Exercise #1");
Console.Write("The numbers that appeared twice in the provided array are: ");
Console.WriteLine(string.Join(", ", listDuplicates)); // Output: 2, 4

/*  
    2. We have two sorted int arrays which could be with different sizes. 
    We need to merge them in a third array while keeping this 
    result array sorted. Can you do that in O(n) time? Don't use any extra 
    structures like Sets or Dictionaries.
    Example: {{1, 2, 3, 4, 5}, {2, 5, 7, 9, 13}} returns {1, 2, 2, 3, 4, 5, 5, 7, 9, 13}
*/


List<int> MergeSortedArrays(List<int> arr1, List<int> arr2)
{
    List<int> merged = new List<int>();
    int i = 0;
    int j = 0;

    while (i < arr1.Count && j < arr2.Count)
    {
        if (arr1[i] <= arr2[j])
        {
            merged.Add(arr1[i]);
            i++;
        }
        else
        {
            merged.Add(arr2[j]);
            j++;
        }
    }

    while (i < arr1.Count)
    {
        merged.Add(arr1[i]);
        i++;
    }

    while (j < arr2.Count)
    {
        merged.Add(arr2[j]);
        j++;
    }

    return merged;
}


List<int> arr1 = new List<int> { 1, 2, 3, 4, 5 };
List<int> arr2 = new List<int> { 2, 5, 7, 9, 13 };
List<int> merged = MergeSortedArrays(arr1, arr2);

Console.WriteLine("\nExercise #2");
Console.Write("Sorted array that includes the two provided arrays: ");
Console.WriteLine(string.Join(", ", merged)); // Output: 1, 2, 2, 3, 4, 5, 5, 7, 9, 13



/*
   3. Given an integer, reverse the digits of that integer, e. g. input is 3415, output is 5143. 
    What is the time complexity of your solution?
*/

int num = 550;

string numString = num.ToString();
char[] numArray = numString.ToCharArray();

Array.Reverse(numArray);

string reversedString = new string(numArray);
int reversedNum = int.Parse(reversedString);

Console.WriteLine("\nExercise #3");
Console.WriteLine($"Reversed number: {reversedNum}");
Console.WriteLine("The time complexity is O(n), where n is the number of digits in the given integer.");
