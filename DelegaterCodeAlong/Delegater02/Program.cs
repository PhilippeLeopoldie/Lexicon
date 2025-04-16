namespace Delegater02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int? n = null;
            //Nullable<int> m = null;

            Action<string, bool> action = PrintIt;
            action("Håkan", true);
        }

        static void PrintIt(string message, bool capitalLetters)
        {
            if(capitalLetters)
                Console.WriteLine(message.ToUpper());
            else
                Console.WriteLine(message.ToLower());
        }
    }
}
