using System;

namespace ConsoleApp5
{
    class Program
    {
        static String MyValue = "moro";
        static void Main(string[] args)
        {
            MyValue.CompareTo(args == null ? args[0] : null);
            (args == null ? args[0] : null).CompareTo(MyValue);
        }
    }
}
