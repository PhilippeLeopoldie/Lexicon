namespace Delegater03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> func = IsLessThan;
            bool less = func(1, 2);
        }

        static bool IsLessThan(int a, int b)
        {
            return a < b;
        }
    }
}
