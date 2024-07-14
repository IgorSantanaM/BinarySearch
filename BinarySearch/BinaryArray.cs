public class BinaryArray
{
    private int[] data; // Array of values
    private static Random generator = new Random();

    // Create array of given size and fill with random integers
    public BinaryArray(int size)
    {
        data = new int[size]; // Create space for array

        // Fill array with random ints in range 10-99
        for (int i = 0; i < size; ++i)
            data[i] = generator.Next(10, 100);

        Array.Sort(data); // Sort the array
    }

    // Method to output certain values in the array
    public string RemainingElements(int low, int high)
    {
        string temporary = string.Empty;

        // Output elements left in array
        for (int i = low; i <= high; ++i)
            temporary += data[i] + " ";

        return temporary + "\n";
    }

    // Perform a binary search on the data
    public int BinarySearch(int searchElement)
    {
        int low = 0; // Low end of the search area
        int high = data.Length - 1; // High end of the search area
        int location = -1; // Return value; -1 if not found

        while (low <= high && location == -1)
        {
            int middle = (low + high) / 2; // Calculate the middle element

            // Display remaining elements of array
            Console.Write(RemainingElements(low, high));
            // Output spaces for alignment
            for (int i = 0; i < middle; ++i)
                Console.Write(" ");
            Console.WriteLine("*"); // Indicate current middle

            // If the element is found at the middle
            if (searchElement == data[middle])
                location = middle; // Location is the current middle
            else if (searchElement < data[middle])
                high = middle - 1; // Eliminate the higher half
            else
                low = middle + 1; // Eliminate the lower half
        }

        return location; // Return location of search key
    }

    // Method to output values in array
    public override string ToString()
    {
        return RemainingElements(0, data.Length - 1);
    }
}