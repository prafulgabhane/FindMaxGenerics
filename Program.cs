using FindMaxGenerics;

namespace FindMaxGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find the Max Num of 3 Variables Program");

            float X = 6.9F;
            float Y = 13.3F;
            float Z = 1.2F;

            float val = FindMax<float>.MaxFloatNumber(X, Y, Z);
            int X = 20;
            int Y = 40;
            int Z = 60;

            int val = FindMax<int>.MaxIntNumber(X, Y, Z);
            Console.WriteLine("The greater num is " + val);
        }
    }
}