using System;
    class EntryPoint
    {
        static void Main()
        {
        string[] beverages = { "coffee", "cola", "eggnog", "water", "juice" };

        Console.WriteLine("The available beverages are:");
        for (int i = 0; i < beverages.Length; i++)
        {
            Console.WriteLine($"   {beverages[i]}");
        }

        Console.WriteLine(new string('-', 40));

        //you can use foreach to output
        //You don't need to name the var item each time
        //Try the singular version of the name of the array
        foreach (var beverage in beverages)
        {
            Console.WriteLine($"   {beverage}");
        }
        //foreach are usually easier for output, with no modificiations to the array

        Console.WriteLine(new string('-', 40));

        //you can also use a join method
        //This method puts whatever you would like in the string
        //Followed by the array
        //You can use a space, or even a comma
        string joinedArray = string.Join(" ", beverages);

        Console.WriteLine(joinedArray);

        Console.WriteLine(new string('-', 40));

        ///Use a string array of at least 40 elements
        ///Make a temperature, and then make it where
        ///there are low temps, high temps and out of range temps

        string[] temperatures = new string[40];
        Random rng = new Random();

        double minRange = 50.0;
        double maxRange = 105.0;

        string[] lowRangeTemp = new string[40];
        string[] highRangeTemp = new string[40];
        string[] outOfRangeTemp = new string[40];

        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = (minRange + (maxRange - minRange) * rng.NextDouble());

        }
        }
    }
