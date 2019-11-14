using System;
class EntryPoint
{
    static void Main()
        {
        Console.Title = "Selection Sort";
        Console.WriteLine("Selection Sort!");
        Console.WriteLine(new string('-', 40));
        ///Selection arrays take the array and divide it into 2 parts
        ///Sorted and Unsorted parts
        ///You take the smallest element and swap it with the first element
        ///The smallest is now sorted, you continue this until the sorted
        ///Part has all the smallest elements in it, and unsorted is empty

        int[] numbers = { 3, 4, 100, 5, 1, -1 };
        int smallestIndex = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            smallestIndex = i;

            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[smallestIndex] > numbers[j])
                {
                    smallestIndex = j;
                }
                
            }
            Console.WriteLine(string.Join(", ", numbers));
            SwapNumbers(ref numbers[i], ref numbers[smallestIndex]);
        

        }
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(string.Join(", ", numbers));
        }

    static void SwapNumbers(ref int valueOne, ref int valueTwo)
    {
        int temp = valueOne;
        valueOne = valueTwo;
        valueTwo = temp;
    }
}


