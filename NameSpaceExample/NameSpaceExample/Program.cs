
System.Console.WriteLine("Hello, World!");
NPO.Output.WriteLine();
Console.WriteLine(NPO.Output.ave(3, 8));
ABC.Output.WriteLine();

namespace NPO
{
    class Output
    {
        public static void WriteLine()
        {
            Console.WriteLine("WriteLine method in NPO namespace");
        }

        public static double ave(int a, int b)
        {
            return (a + b) / 2.0;
        }
    }

}

namespace ABC
{
    class Output
    {
        public static void WriteLine()
        {
            Console.WriteLine("WriteLine method in ABC namespace");
        }
    }

}




