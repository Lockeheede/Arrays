using System;
class EntryPoint
{
    static void Main()
    {
        //Arrays are a collection of values
        //They can have their own data types
        //Such as int, string, char, etc

        //The length of the array is its number of
        //Elements - 1. Every array has an index
        //Of numbers that start at 0

        //You can initalize an array 2 different ways

        //This first way is by stating the number of
        //Indeces. You have to define each element seperately
        double[] temperatures = new double[4];
        //temperatures[0] = 98.6;
        //temperatures[1] = 70.0;
        //temperatures[2] = 85.0;
        //temperatures[3] = 83.3;
        //Adding a 5th element will not give you an error,
        //unless you run the code where it will tell you
        //the element is outside the bounds of the
        //array

        //The second way, you must define each element at initalization
        //Within some curly brackets
        int[] numbers = { 0, 2, 4, 6, 8 };
        int[] challenge = new int[10];

        //You can also use for loops to populate your arrays
        //Take the first temperature example
        Random rng = new Random();
        double minRange = 60.0;
        double maxRange = 99.9;

        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = minRange + (maxRange - minRange) * rng.NextDouble();
            ///The code above uses the random number generator (rng) to generate a random
            ///Double. Since nextdouble is between 0.0 and 1.0, you use the minRange
            ///Maxrange difference equation to get the number higher than those

            ///Using the for loop keeps the array inside the bounds of its index

            ///You can also read from the console to populate your arrays
            ///Make sure to convert because ReadLine() is for strings

            //Console.Write($"Enter a temperature for index {i}: ");
            //temperatures[i] = Convert.ToDouble(Console.ReadLine());

            //Remember, when doing this, if you put the incorrect format you will get 
            //An error
            Console.WriteLine(temperatures[i]);
        }

        ///Challenge, populate an array using foreach

        /*foreach(var item in numbers)
        {
            Console.WriteLine(item);
        }
        You actually cannot populate with foreach loops
        This loop is for output only
        */


    }
}

