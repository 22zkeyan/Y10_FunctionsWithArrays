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
            string[] names = { "Bartholomew", "Ebeneezer", "Pneumonoultramicroscopicsilicovolcanoconiosis", "William", "Cratchit" };
            List(names);
            int[] times_table = numbers(5);
            foreach (int i in times_table)
            {
                Console.WriteLine(i);
            }
        }
    }
}
