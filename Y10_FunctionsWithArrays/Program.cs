namespace Y10_FunctionsWithArrays
{
    internal class Program
    {
        static void List(string[] names) //parameter for names as a 1d array
        {
            for (int i = 0; i < names.GetLength(0); i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        static void ListNums(int[] nums) //parameter for names as a 1d array
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        static void List2DNums(int[,] nums) //parameter for names as a 1d array
        {
            for (int i = 0; i < nums.GetLength(0); i++) //.GetLength(0) tells you how many arrays there are in the 2d array
            {
                for (int j = 0; j < nums.GetLength(1); j++) //GetLength(1) tells you many elements there are in one array
                {
                    Console.WriteLine(nums[i, j]);
                }
            }
        }
        static void ListNamesWithBreaks(string[,] names)
        {
            for (int i = 0; i < names.GetLength(0); i++) //.GetLength(0) tells you how many arrays there are in the 2d array
            {
                for (int j = 0; j < names.GetLength(1); j++) //GetLength(1) tells you many elements there are in one array
                {
                    Console.Write($"{names[i, j]}, ");
                }
                Console.WriteLine("\n");
            }
        }
        static int[] numbers(int a) //returns an array of integers
        {
            int[] nums = new int[5];
            for (int i = 1; i <= nums.Length; i++)
            {
                nums[i-1] = a * i;
            }
            return nums;
        }
        static void Main(string[] args)
        {
            string[] names = { "Bartholomew", "Ebeneezer", "Pneumonoultramicroscopicsilicovolcanoconiosis", "William", "Cratchit", "Charles", "Niels", "Ernest", "Dalton", "Thompson" };
            List(names);
            int[] times_table = numbers(5);
            int[] numberss = { 1, 2, 3, 4, 5, 6, 7, 8 };
            ListNums(numberss);
            foreach (int i in times_table)
            {
                Console.WriteLine(i);
            }
            string[,] twoDnames = { { "Dave", "Tim", "Lucy" }, { "Jane", "Steve", "Alan" }, { "Julie", "Amy", "Jim" } };
            ListNamesWithBreaks(twoDnames);
            int[,] twoDnums = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            List2DNums(twoDnums);
        }
    }
}
