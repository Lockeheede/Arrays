using System;
using System.Collections.Generic;
using System.Linq;

///Remember, hold CTRL + . to get suggestions and namespaces
///Also, hold CTRL + K + C to comment out entire blocks of code

class EntryPoint
    {
        static void Main()
        {
        List<int> someNumbersInARange = new List<int> { 1, 2, 3, 4, 5 };
        ///This makes your list but also adds numbers right afterwards
        int[] arrayOfNumbers = { 1, 2, 3, 4, 5 };
        //This is similar
        List<int> listOfNumbers = arrayOfNumbers.ToList();//Use Ctrl + . to find the namespace for ToList()

        someNumbersInARange.AddRange(arrayOfNumbers);
        //This adds and concatenates the array to the end of the list

        //foreach (var item in someNumbersInARange)
        //{
        //    Console.WriteLine(item);
        //}

     
        string[] vegetables = {"cucumber", "romaine", "tomatoes" };
        string[] fruit = { "banana", "orange", "watermellon" };
        string[] meat = { "beef", "chicken", "fish" };

        List<string> food = ConcatenatedStrings(new List<string[]>() { vegetables, fruit, meat });

        foreach (var item in food)
        {
            Console.WriteLine(item);
        }
        }

        //To make a method that returns a list with list arguements
        static List<string> ConcatenatedStrings (List<string[]> listOfArrays)
        {
        List<string> concatenatedList = new List<string>();

        foreach (var stringArray in listOfArrays)
        {
            concatenatedList.AddRange(stringArray);
        }
        return concatenatedList;
        }
    }

