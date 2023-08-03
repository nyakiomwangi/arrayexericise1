// create a simple program that inputs and prints array elements using a loop
//step 1 ask for user input

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array");
        int size = Convert.ToInt32(Console.ReadLine());
        //create the array
        int arr[] = new int[size];


        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());


        }
        Console.WriteLine("\n Elements in the array are:");
    }
}

// class Program
{
    static void Main(string[] args)
    {
        //C# program to print all negative elements in array
        /* Input array size */
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        /* Input elements in array */
        Console.WriteLine("Enter {0} elements in the array", size);
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        /*Print all negative elements of array*/
        Console.Write("\nAll negative elements in array are : ");
        for (int i = 0; i < size; i++)
        {
            /* If current array element is negative */
            if (arr[i] < 0)
            {
                Console.Write("{0}\t", arr[i]);
            }
        }
        Console.ReadLine();
    }
}