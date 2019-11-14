using System;
class EntryPoint
{
    static void Main()
    {
    Console.Title = "Bubble Sort!";
    Console.WriteLine("BUBBLE SORT!");
    Console.WriteLine(new string('-', 40));
    //Not very useful when sorting large amounts of data, because it is too slow
    //Good for up to 100 elements and nested loops
    //Compares the index to the one next to it to see if it is greater or less than
    //If greater, switch them, if less, keep them

    //Then you do it again and again

    int[] numbers = { 5,7,3,4,6 };
   

    for (int i = 0; i < numbers.Length; i++)
        {
        for (int j = 0; j < numbers.Length - i - 1; j++)//You must put the - 1 or get an exception out of bounds. Without the 1...
            {
                if (numbers[j] > numbers[j + 1])//...this +1 is asking for 5 elements, when there are only 4 (in this example)
                    //If given any length of elements, it will ask for one more than what is given, so you must put the -1 to keep it
                    //Within the bounds. 
                    {
                    SwapValues(ref numbers[j], ref numbers[j + 1]);
                    }
                    Console.WriteLine(string.Join(", ", numbers));
            }
        }
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(string.Join(", ", numbers));
    }
    static void SwapValues(ref int valueOne, ref int valueTwo)
    {
        int temp = valueOne;
        valueOne = valueTwo;
        valueTwo = temp;
    }

}

