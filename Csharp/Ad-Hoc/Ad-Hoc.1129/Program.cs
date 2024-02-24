using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
                break;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int[] values = Array.ConvertAll(input, int.Parse);

                char result = ProcessQuestion(values);
                Console.WriteLine(result);
            }
        }
    }

    static char ProcessQuestion(int[] values)
    {
        int blackCount = 0;
        int whiteCount = 0;

        for (int j = 0; j < values.Length; j++)
        {
            if (values[j] <= 127)
                blackCount++;
            else
                whiteCount++;
        }

        if (blackCount == 1 && whiteCount == 4)
        {
            for (int j = 0; j < values.Length; j++)
            {
                if (values[j] <= 127)
                    return GetOption(j);
            }
        }

        return '*';
    }

    static char GetOption(int index)
    {
        return (char)('A' + index);
    }
}