using System;
class EntryPoint
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int[] fourthArray = array;
        //This references the array, it does not get its own values

        int[] secondArray = (int[])array.Clone();
        //Do this to get every value from the target array
        //Which can be edited without changing it

        int[] thirdArray = new int[array.Length];
        Array.Copy(array, thirdArray, 4);
        ///Do this to copy exact values from the source
        ///Array and put it into a target array
        ///However, in order to get every value, you must put the total index

        array[2] = 10;
        //Changes the value of the first and fourth (reference)
        secondArray[2] = 12;

        CopyArray(array, out int [] fifthArray);

        Console.WriteLine(array[2]);
        Console.WriteLine(fourthArray[2]);
        Console.WriteLine(secondArray[2]);
        Console.WriteLine(thirdArray[2]);
        Console.WriteLine(fifthArray[2]);
    }

    static void CopyArray(int[] sourceArray, out int[] targetArray)
    {
        targetArray = new int[sourceArray.Length];

        for (int i = 0; i < sourceArray.Length; i++)
        {
            targetArray[i] = sourceArray[i];
        }
    }
}
