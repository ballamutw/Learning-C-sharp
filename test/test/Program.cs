namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Fibonachi(int n)
            {
                if (n == 0 || n == 1) return n;

                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }

            int fib4 = Fibonachi(128);

        }
    }
}
