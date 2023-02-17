namespace ConsoleApp2
{
    internal class EmptyArrayFiller
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i]+= i;
            }
            Console.WriteLine(arr[3]);
        }
    }
}