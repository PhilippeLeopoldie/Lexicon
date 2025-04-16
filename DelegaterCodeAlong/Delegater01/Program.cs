namespace Delegater01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action carAction = Accelerate;
            carAction();
            carAction = Decelerate;
            carAction();
        }

        static void Accelerate()
        {
            Console.WriteLine("Swish...");
        }

        static void Decelerate()
        {
            Console.WriteLine("Sqeeeeee!");
        }
    }
}
