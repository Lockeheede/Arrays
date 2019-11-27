using System;
using System.Collections.Generic;
    class EntryPoint
    {
        static void Main()
        {
        List<int> thisList = new List<int>();
        ///Different than arrays. For instance, you don't
        ///Define the indeces. And, if you use thisList[8] = 7; 
        ///You WON'T get an error until AFTER the code is run

        ///Instead you use:
        thisList.Add(69);//which adds a single element with the value of 69

        ///You can remove specific elements with:
        thisList.Remove(69);


        thisList.Add(2);
        thisList.Add(4);
        thisList.Add(6);
        thisList.Add(8);

        //Or a specific index with:
        thisList.RemoveAt(0);

        Console.WriteLine(thisList[0]);

        //You can use .count to count the arrays
        Console.WriteLine(thisList.Count);

        //Lists do not have a specific, fixed size like an array
        //Use Lists when you are unsure of how many indeces you'll be using in the array
        }
    }

