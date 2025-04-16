namespace ConsoleApp5
{

    class Program
    {
        public static void Main(string[] args)
        {
            I_Take_A_Delegate(HelloWorldMethod);
            /* När vi anropar metoden "I_Take_A_Delegate" tilldelar vi dess
             * Action parameter "a" metoden HelloWorldMethod. Detta är i
             * grunden samma sak som att tilldela en variabel av typen
             * Action metoden HelloWorldMethod. Exempelvis: */
            //Action a = HelloWorldMethod;
        }

        static void I_Take_A_Delegate(Action a)
        {
            Console.WriteLine("Time to call the method in parameter 'a'");
            a();
        }

        static void HelloWorldMethod()
        {
            Console.WriteLine("Hello Academy!");
        }
    }


    //class Program
    //{
    //    public static void Main(string[] args)
    //    { /* Tilldela variabeln foo av typen Func<string, int> * metoden ReturnStringLength. */

    //        Func<string, int> foo = ReturnStringLength;
    //        Console.Write("Mata in en sträng: ");
    //        string s = Console.ReadLine();

    //        // Anropa metoden som variabeln foo tilldelats.
    //        int i = foo(s);
    //        Console.WriteLine($"Strängens längd = {i}");
    //    }
    //    static int ReturnStringLength(string msg)
    //    {
    //        return msg.Length;
    //    }
    //}
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        // Tilldela variabeln a av typen Action<string> metoden MyParameterAction.
    //        Action<string> a = MyParameterAction;

    //        // Anropa metoden som variabeln a tilldelats.
    //        a("Lexicon Rules!");
    //    }

    //    static void MyParameterAction(string s)
    //    {
    //        Console.WriteLine(s);
    //    }
    //}

    //class Program
    //{
    //    static void MyMethod()
    //    {
    //        Console.WriteLine("Hello World!");
    //    }

    //    public static void Main(string[] args)
    //    {
    //        // Tilldela variabeln a av typen Action metoden MyMethod.
    //        Action a = MyMethod;

    //        // Anropa metoden som variabeln a tilldelats.
    //        a();
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //SimpleDataTypeSort();
    //        ComplexDataTypeSort();
    //    }

    //    private static void SimpleDataTypeSort()
    //    {
    //        List<string> strings = ["Lexicon", "C#", "Delegater", "Extension Methods", "LINQ"];

    //        foreach (var item in strings)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        strings.Sort();

    //        Console.WriteLine("-------------------------------");
    //        foreach (var item in strings)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    private static void ComplexDataTypeSort()
    //    {
    //        List<Person> people =
    //        [
    //            new Person() { Age = 62, Height = 183 },
    //            new Person() { Age = 26, Height = 192 },
    //            new Person() { Age = 49, Height = 172 },
    //            new Person() { Age = 87, Height = 151 },
    //            new Person() { Age = 19, Height = 168 },
    //        ];

    //        foreach (var person in people)
    //            Console.WriteLine(person);

    //        people.Sort(Compare);

    //        Console.WriteLine("-------------------------------");

    //        foreach (var person in people)
    //            Console.WriteLine(person);

    //        int Compare(Person p1, Person p2)
    //        {
    //            if (p1.Height > p2.Height)
    //                return 1;
    //            else if (p1.Height < p2.Height)
    //                return -1;
    //            else
    //                return 0;
    //        }
    //    }
    //}
}
