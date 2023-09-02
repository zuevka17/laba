namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размер: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[size];

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine($"{i}: ");
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}