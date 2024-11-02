using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] temperatures = new int[5];
        int minTemp = -30;
        int maxTemp = 130;
        double sum = 0;
        bool gettingWarmer = true;
        bool gettingCooler = true;

        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.WriteLine($"Enter temperature {i + 1} (range {minTemp} to {maxTemp}):");
            temperatures[i] = GetValidTemperature(minTemp, maxTemp);

            sum += temperatures[i];

            if (i > 0)
            {
                if (temperatures[i] <= temperatures[i - 1])
                {
                    gettingWarmer = false;
                }
                if (temperatures[i] >= temperatures[i - 1])
                {
                    gettingCooler = false;
                }
            }
        }

        if (gettingWarmer)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (gettingCooler)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It’s a mixed bag");
        }

        Console.WriteLine("n5-day Temperature: [" + string.Join(", ", temperatures) + "]");
        Console.WriteLine($"Average Temperature is {sum / temperatures.Length} degrees");
    }

    static int GetValidTemperature(int minTemp, int maxTemp)
    {
        int temp;
        while (true)
        {
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp >= minTemp && temp <= maxTemp)
            {
                return temp;
            }
            else
            {
                Console.WriteLine($"Invalid input. Please enter a temperature between {minTemp} and {maxTemp}.");
            }
        }
    }
}
