using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace Day5
{


    internal class Program
    {
        static void Main(string[] args)
        {

            //problem 1 
            //try
            //{
            //    Console.Write("Enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.Write("Enter second number: ");
            //    int num2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Result: {num1 / num2}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete.");
            //}
            //Purpose of finally: Ensures code in the block executes whether an exception


            //2. Positive Integers Validation


            //            static void TestDefensiveCode()
            //            {
            //                int x, y;
            //                do
            //                {
            //                    Console.Write("Enter a positive integer for X: ");
            //                } while (!int.TryParse(Console.ReadLine(), out x) || x <= 0);

            //                do
            //                {
            //                    Console.Write("Enter a positive integer for Y (greater than 1): ");
            //                } while (!int.TryParse(Console.ReadLine(), out y) || y <= 1);

            //                Console.WriteLine($"You entered: X = {x}, Y = {y}");
            //            }
            //            TestDefensiveCode();

            //            Why int.TryParse improves robustness:
            //It prevents exceptions by verifying input validity without throwing an error, avoiding program crashes.


            //3.Nullable Integer

            //int? nullableInt = null;
            //int value = nullableInt ?? -1; // Default value if null
            //Console.WriteLine($"Value: {value}");

            //if (nullableInt.HasValue)
            //{
            //    Console.WriteLine($"HasValue: {nullableInt.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("Nullable integer is null.");
            //}

            //Exception for accessing Value on null: InvalidOperationException.

            //4.Array Bounds Handling

            //int[] array = new int[5];

            //try
            //{
            //    Console.WriteLine(array[10]); // Accessing out-of-bounds index
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Error: Index out of bounds.");
            //}

            //5.Multi - Dimensional Array Sum

            //int[,] array = new int[3, 3];
            //Console.WriteLine("Enter values for a 3x3 array:");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter value for [{i},{j}]: ");
            //        array[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    int rowSum = 0, colSum = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        rowSum += array[i, j];
            //        colSum += array[j, i];
            //    }

            //    Console.WriteLine($"Sum of row {i}: {rowSum}");
            //    Console.WriteLine($"Sum of column {i}: {colSum}");


            //Usage of GetLength: Retrieves size along specified dimensions.

            //6.Jagged Array


            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2];
            //jaggedArray[1] = new int[3];
            //jaggedArray[2] = new int[4];

            //Console.WriteLine("Enter values for the jagged array:");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"Enter value for row {i}, column {j}: ");
            //        jaggedArray[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Jagged Array Values:");
            //foreach (var row in jaggedArray)
            //{
            //    Console.WriteLine(string.Join(", ", row));


            //Memory difference: Jagged arrays use separate memory blocks for each row.

            //2.Print Numbers in a Range
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{number} x {i} = {number * i}");
            //}

            //3.List Even Numbers

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.Write(i + (i < number - 1 ? ", " : "\n"));
            //}

            //4.Exponentiation

            // Console.Write("Enter the base: ");
            //int baseNum = int.Parse(Console.ReadLine());
            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = (int)Math.Pow(baseNum, exponent);
            //Console.WriteLine($"Result: {result}");

            //5.Reverse a String

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);

            //Console.WriteLine($"Reversed: {new string(charArray)}");










        }
    }
}
