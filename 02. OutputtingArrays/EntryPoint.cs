using System;
    class EntryPoint
    {
        static void Main()
        {
        /*string[] beverages = { "coffee", "cola", "eggnog", "water", "juice" };

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
        ///there are low temps, medium temps, high temps and out of range temps
        */
        int[] temperatures = new int[40];
        Random rng = new Random();

        int[] lowRangeTemp = new int[temperatures.Length];
        int[] mediumRangeTemp = new int[temperatures.Length];
        int[] highRangeTemp = new int[temperatures.Length];
        int[] outOfRangeTemp = new int[temperatures.Length];

        int lowTempIndex = 0;
        int mediumTempIndex = 0;
        int highTempIndex = 0;
        int outOfRangeTempIndex = 0;
        int lowTempCursorPosition = 2;
        int mediumTempCursorPosition = 2;
        int highTempCursorPosition = 2;
        int outOfRangeCursorPosition = 2;

        Console.Write("Temperature Range\n");
        Console.WriteLine(new string('-', 75));
        Console.Write("50 to 65 \n\n" +
            "65 to 80  \n\n" +
            "60 to 110 \n\n" +
            "Out of Range \n\n");
        Console.WriteLine(new string('-', 75));

        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = rng.Next(0, 110);
        }

        for (int i = 0; i < temperatures.Length; i++)
        {
           
            if (temperatures[i] >= 50 && temperatures[i] <= 65)
            {
                ///The setcursorposition method can place a cursor where you want
                ///On the console. That's how the ranges can be placed up top,
                ///But the details for the if loops can be placed inbetween them
                Console.SetCursorPosition(lowTempCursorPosition, 3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{temperatures[i]}");
                lowRangeTemp[lowTempIndex] = temperatures[i];
                lowTempIndex++;
                lowTempCursorPosition += 3;
                Console.ResetColor();
            }
            else if (temperatures[i] >= 65 && temperatures[i] <= 80)
            {
                Console.SetCursorPosition(mediumTempCursorPosition, 5);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{temperatures[i]}");
                mediumRangeTemp[mediumTempIndex] = temperatures[i];
                mediumTempIndex++;
                mediumTempCursorPosition += 3;
                Console.ResetColor();
            }
            else if (temperatures[i] >= 80 && temperatures[i] <= 110)
            {
                Console.SetCursorPosition(highTempCursorPosition, 7);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{temperatures[i]}");
                highRangeTemp[highTempIndex] = temperatures[i];
                highTempIndex++;
                if(temperatures[i] >= 100)
                {
                    highTempCursorPosition += 4;
                }
                else if(temperatures[i] < 100)
                {
                    highTempCursorPosition += 3;
                }
                Console.ResetColor();
            }
            else if (temperatures[i] > 110 || temperatures[i] < 50)
            {
                Console.SetCursorPosition(outOfRangeCursorPosition, 9);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{temperatures[i]}");
                outOfRangeTemp[outOfRangeTempIndex] = temperatures[i];
                outOfRangeTempIndex++;
                if (temperatures[i] >= 100)
                {
                   outOfRangeCursorPosition += 4;
                }
                else if (temperatures[i] > 10)
                {
                    outOfRangeCursorPosition += 3;
                }
                else if (temperatures[i] < 10)
                {
                    outOfRangeCursorPosition += 2;
                }
                Console.ResetColor();
            }
            //Resets console position.
            Console.SetCursorPosition(0, 11);
        }
      
        }
    }
