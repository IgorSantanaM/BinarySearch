using System;

public class BinarySearchTest
{
    public static void Main(string[] args)
    {
        int searchInt; // Search key
        int position;  // Location of search key in array

        // Create an array and output it
        BinaryArray searchArray = new BinaryArray(15);
        Console.WriteLine("The sorted array is:");
        Console.WriteLine(searchArray);

        // Prompt and input the first integer from user
        Console.Write("Please enter an integer value (-1 to quit): ");
        searchInt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // Repeatedly input an integer; -1 terminates the app
        while (searchInt != -1)
        {
            // Use binary search to try to find the integer
            position = searchArray.BinarySearch(searchInt);

            // Check if the integer was found
            if (position == -1)
            {
                Console.WriteLine($"The integer {searchInt} was not found.\n");
            }
            else
            {
                Console.WriteLine($"The integer {searchInt} was found in position {position}.\n");
            }

            // Prompt and input next integer from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
    }
}
