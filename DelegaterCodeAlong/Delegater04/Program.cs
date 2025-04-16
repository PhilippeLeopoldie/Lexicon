namespace Delegater04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeMethod("lexicon", ShoutOrWisper);
        }

        private static bool ShoutOrWisper()
        {
            Console.Write("Vill du skrika?: ");
            return Console.ReadKey(true).Key == ConsoleKey.J;
        }

        static void SomeMethod(string msg, Func<bool> f)
        {
            if(f())
                Console.WriteLine(msg.ToUpper());
            else
                Console.WriteLine(msg.ToLower());
        }
    }
}
