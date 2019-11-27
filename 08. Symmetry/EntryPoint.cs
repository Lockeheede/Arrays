using System;

class EntryPoint
{
    static void Main()
    {
    ///Array symmetry works where you split an array down the middle
    ///And you match the mirror elements to see if they are equal
    ///This can be done with an odd number of indexes as well
    ///1 2 3 4 4 3 2 1
    ///1 2 3 4 3 2 1 <--Here you would just split it down the four

    int[] symmetryArray = { 1, 2, 3, 4, 3, 2, 1 };

    bool isSymmetrical = true;

        for (int i = 0; i < symmetryArray.Length / 2; i++)
        {
            if (symmetryArray[i] != symmetryArray[symmetryArray.Length - i - 1])
            {
                isSymmetrical = false;
                break;
            }
        }
            if (isSymmetrical == true)
            {
                Console.WriteLine("The array is symmetrical!");
            }
            else
            {
                Console.WriteLine("The array is not symmetrical!");
            }
    }
}


