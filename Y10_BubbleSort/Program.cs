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
        static void OptimisedBubbleSort(int[] array) 
        //this uses a swapped flag to allow early exit, and after each loop of the array, it decreases the length by 1, as the last element will have been sorted
        {
            int length = array.Length;
            while (length > 1)
            {
                int last_swap = 0;
                for (int i = 0; i < length-2; i++) //don't need to go all the way to the last element in the array because that will automatically be sorted with everything else
                {
                    if (array[i] > array[i + 1]) //if the term on the left is bigger than on the right (not sorted)
                    {
                        int temp = array[i];
                        array[i] = array[i + 1]; //set the current element to the one to the right
                        array[i + 1] = temp;
                        last_swap = i + 1;
                    }
                }
                length = last_swap;
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 2,7,6,12,16,19,32,1};
            OptimisedBubbleSort(array);
        }
    }
}
