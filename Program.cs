using FindMaxGenerics;

namespace FindMaxGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find the Max Num of 3 Variables Program");

            int X = 20;
            int Y = 40;
            int Z = 60;

            int val = FindMax<int>.MaxIntNumber(X, Y, Z);
            Console.WriteLine("The greater num is " + val);
        }
    }
}