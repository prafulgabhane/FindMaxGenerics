using FindMaxGenerics;

namespace FindMaxGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****** Welcome to Find the Max Num of 3 Variables Program ******");

            FindMaximum<int> obj = new FindMaximum<int>(69, 53, 92);
            obj.MaxMethod();

        }
    }
}