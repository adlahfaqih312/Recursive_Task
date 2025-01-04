namespace Recursive_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void SumOfNumbers(int n)
            {
                int sum = 0;
                for (int i = 0; i <= n; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine($"total sum is : {sum}");
            }
            Console.WriteLine("Enter the number you want : ");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                SumOfNumbers(num);
                break;
            }

        }
    }
}
