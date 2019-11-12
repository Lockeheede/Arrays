using System;
    class EntryPoint
    {
        static void Main()
        {
        string[] wuTang = { "ghostface", "methodman", "rza", "gza", "raekwon", "odb" };

        //Using the reverse method takes the elements and changes the order
        //Array.Reverse(wuTang);
        //You can also start at an index and go for a specific length
        //Array.Reverse(wuTang, 1, 3); //means you start at methodman and end at raekwon

        Array.Reverse(wuTang);

        foreach (var item in wuTang)
        {
            Console.WriteLine(item);
        }
        }

    static void Reverse(string[] array, int index, int length)
    {
        string temp = string.Empty;

        for (int i = index; i < length / 2; i++)
        {
            temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }
    }

