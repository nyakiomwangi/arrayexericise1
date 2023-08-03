// create a simple program that inputs and prints array elements using a loop ..project1 
//step 1 ask for user input

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array");
        int size = Convert.ToInt32(Console.ReadLine());

        // Create the array
        int[] arr = new int[size];
        Console.WriteLine("Enter {0} elements in the array", size);
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\n Elements in the array are:");

        for (int i = 0; i < size; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.ReadLine();
    }
}

