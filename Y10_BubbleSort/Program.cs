namespace Y10_BubbleSort
{
    internal class Program
    {
        static void Starter()
        {
            int[] ages = { 12, 16, 14, 15 };
            int search_key = 16;
            foreach (int age in ages) 
            {
                if (age == search_key)
                {
                    Console.WriteLine($"Search key found at index {Array.IndexOf(ages, age)}");
                }
            }
        }
        static void OptimisedBubbleSort(int[] array) //this uses a swapped flag to allow early exit, and after each loop of the array, it decreases the length by 1, as the last element will have been sorted
        {
            int length = array.Length;
            while (length > 1)
            {
                int last_swap = 0;
                for (int i = 0; i < length-2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Starter();
        }
    }
}
