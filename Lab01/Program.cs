// prompt user for integer n, which serves as array length of word list
int n = 0;

while (n <= 0)
{
    // Form validation
    Console.WriteLine("Please enter integer value greater than zero.");
    n = Int32.Parse(Console.ReadLine()); //Parse is not type safe
}

string[] words = new string[n]; // get console entered amount
//I add the question mark after string to ensure that it has a value, its not empty

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter word {i + 1}");
    string newWord = Console.ReadLine();

    if (newWord.Length > 0 && !newWord.Contains(' '))
    {
        words[i] = newWord.ToLower();
    }
    else
    {
        Console.WriteLine("Sorry but you must enter at least one character.");
        i--;
    }
}

char charToCount = ' ';

while (!Char.IsLetter(charToCount))
{
    Console.WriteLine("Please, enter a character to count.");
    charToCount = Char.ToLower(Console.ReadKey().KeyChar);
}


//keyInfo shows all information/methods about an object
ConsoleKeyInfo keyInfo = Console.ReadKey();


Console.WriteLine($"\nYou entered the character '{charToCount}'");

// get a count of how many times this character appears in all of the words

int charCount = 0;
int totalCount = 0;

foreach (string word in words)
{
    char[] chars = word.ToCharArray();// passs the array word in a char array

    foreach (char c in chars) //check if each character is the same character entered by the user
    {
        if (Char.ToLower(c) == Char.ToLower(charToCount))
        {
            charCount++;
        }
        totalCount++;
    }
}


//print the number of occurrences of that character within all of the strings provided.
if ((charCount * 100) / totalCount > 25)
{
    Console.WriteLine($"The letter {charToCount} appears {charCount} times in the array. " +
        $"This letter makes up more than 25% of the total number of characters.");
}
else
{
    Console.WriteLine($"The letter {charToCount} appears {charCount} times in the array. " +
         $"This letter makes up less than 25% of the total number of characters.");
}
