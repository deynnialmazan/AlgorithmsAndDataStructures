// ---------- LABORATORIO 02 - DEYNNI ALMAZAN ---------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*1. A program that produces an array of all of the characters that appear 
 * more than once in a string.For example, the string “Programmatic Python”
 * would result in the array ['p','r','o','a','m','t']. */

string inputString = "Programmatic Python";

char[] GetRepeatedCharacters(string input)
{
    HashSet<char> uniqueCharacters = new HashSet<char>(); //HashSet create a collection of unique data
    HashSet<char> repeatedCharacters = new HashSet<char>();

    for (int i = 0; i < input.Length; i++)
    {
        char c = char.ToLower(input[i]);

        if (!uniqueCharacters.Contains(c))
        {
            uniqueCharacters.Add(c);
        }
        else if (!repeatedCharacters.Contains(c))
        {
            repeatedCharacters.Add(c);
        }
    }

    return repeatedCharacters.ToArray();
}

Console.WriteLine("Exercise #1");
Console.Write("Repeated characters: [ ");
char[] repeatedCharacters = GetRepeatedCharacters(inputString);
Console.Write(string.Join(", ", repeatedCharacters));
Console.Write(" ]");


/* 2. A program returns an array of strings that are unique words found in the argument.
 * For example, the string “To be or not to be” returns ["to","be","or","not"].*/


string inputString2 = "To be or not to be";
string[] GetUniqueWords(string input)
{
    List<string> words = new List<string>();
    StringBuilder currentWord = new StringBuilder();

    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];

        if (char.IsLetter(c))
        {
            currentWord.Append(c);
        }
        else if (currentWord.Length > 0)
        {
            words.Add(currentWord.ToString());
            currentWord.Clear();
        }
    }

    if (currentWord.Length > 0)
    {
        words.Add(currentWord.ToString());
    }

    return words.Distinct().ToArray();
}

string[] uniqueWords = GetUniqueWords(inputString2.ToLower());

Console.WriteLine("");
Console.WriteLine("\nExercise #2");
Console.Write("Unique words: [ ");
Console.Write(string.Join(", ", uniqueWords));
Console.Write(" ]");

//3. A program that reverses a provided string 

string inputString3 = "Reversed string!";
StringBuilder ReverseString(string input)
{
    StringBuilder reversedString = new StringBuilder();

    for (int i = input.Length - 1; i >= 0; i--)
    {
        reversedString.Append(input[i]);
    }

    return reversedString;
}

StringBuilder reversedString = ReverseString(inputString3);

Console.WriteLine("");
Console.WriteLine("\nExercise #3");
Console.WriteLine("Reversed string: " + reversedString);

/* 4. A program that finds the longest unbroken word in a string and prints it.
 * For example, the string "Tiptoe through the tulips" would print "through".
 * If there are multiple words tied for greatest length, print the last one */

string inputString4 = "Tiptoe through the tulips";
string FindLongestWord(string input)
{
    string[] words = input.Split(new char[] { ' ' });
    string longestWord = "";

    for (int i = 0; i < words.Length; i++)
    {
        string word = words[i];

        if (word.Length >= longestWord.Length)
        {
            longestWord = word;
        }
    }

    return longestWord;
}

string longestWord = FindLongestWord(inputString4);

Console.WriteLine("");
Console.WriteLine("\nExercise #3");
Console.WriteLine("Longest unbroken word: " + longestWord);

/*
 * Research and employ the StringBuilder class and explain its advantages or disadvantages over Strings.
 * 
 * ADVANTAGES:
 * 1. Mutable: We can modify its content without creating a new object each time. This is particularly useful 
 * when you need to perform multiple concatenations or modifications to a string.
 * 2. More efficient when dealing with large amounts of string concatenation.
 * 3. `StringBuilder` provides methods such as `Append` and `Insert` that allow you to efficiently add or insert 
 * content into the existing string without creating intermediate strings. This can be beneficial when building strings 
 * dynamically or when performing string manipulations.
 * 
 * DISADVANTAGES:
 * 1. Not Suitable for All String Operations. For simple scenarios involving a small number of string manipulations,
 * `string` class can be more concise and easier to read.
 * 2. Using `StringBuilder` involves method chaining and calls to specific methods like `Append` and `Insert`. 
 * This can make the code slightly more complex compared to simple string concatenation using the `+` operator.
 * 
 */