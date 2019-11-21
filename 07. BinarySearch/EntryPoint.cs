using System;
//Practice this to find the index of an ordered array
    class EntryPoint
    {
        static void Main()
        {
        /*int[] array = { 1, 2, 3, 4, 7, 10, 100, 150, 300 };
        ///Start with the middle element, this is called the pivot
        ///Compare it with the number you are looking for
        ///Pivot is 7, if you are looking for 2
        ///Is it greater or less than what you are looking for?
        ///If the pivot is greater, everything to the left is less than the pivot
        ///If is is less (100) then you take the right side
        ///With 2, 2 becomes the new pivot
        ///You keep dividing the array into halves until you find what you are looking for

        ///You must make a while loop in order to determine whether the middle is the number you are looking for
        int lookingFor = 1;
        int start = 0;
        int end = array.Length - 1;
        int middle = (start + end) / 2;

        ///The while loop is based on a boolean, so you must create one
        bool isFound = false;

        while (!isFound)
        {
            if(array[middle] == lookingFor)
            {
                isFound = true;
            }
            else if(array[middle] > lookingFor)
            {
                end = middle - 1;
            }
            else if(array[middle] < lookingFor)
            {
                start = middle + 1;
            }
            middle = (end + start) / 2;
            Console.WriteLine($"Start: {start}, end: {end}, middle: {middle}");
        }

        Console.WriteLine($"The number {lookingFor} was found at index {middle}!");*/



        Console.WriteLine("Type BinarySearch in order to do a random array test!");
        string entry = Console.ReadLine();
        Console.WriteLine("Also enter a number between 50 and 150");
        int entry2 = Convert.ToInt32(Console.ReadLine());
        if (entry == "BinarySearch" && entry2 > 50 && entry2 < 150)
        {
            BinarySearch(entry2);
        }
        else
        {
            Console.WriteLine("Nah...");
            return;
        }

        }


    static void BinarySearch(int entry2)
    {
        //Using a random number generator (rng), you can create an array of 1000 elements 
        Random rng = new Random();
        int[] array2 = new int[1000];

        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = rng.Next(50, 150);
        }
        Array.Sort(array2); //Remember to sort a random array, a binarysearch Algorithm needs to be in order.

        int lookingFor = entry2;
        int start = 0;
        int end = array2.Length - 1;
        int middle = (start + end) / 2;

        ///The while loop is based on a boolean, so you must create one
        bool isFound = false;

        while (!isFound)
        {
            if (array2[middle] == lookingFor)
            {
                isFound = true;
            }
            else if (array2[middle] > lookingFor)
            {
                end = middle - 1;
            }
            else if (array2[middle] < lookingFor)
            {
                start = middle + 1;
            }
            middle = (end + start) / 2;
            Console.WriteLine($"Start: {start}, end: {end}, middle: {middle}");
        }

        Console.WriteLine($"The number {lookingFor} was found at index {middle}!");
    }
}


