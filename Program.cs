using System;

namespace myApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                DoNothing();
                System.Console.WriteLine(Hello.HelloWorld);
            }
        }

        private static void DoNothing()
        {

        }
        public static void MyMethod() => JustMakeYourselfBetter();

        private static void JustMakeYourselfBetter()
        {
            throw new NotImplementedException();
        }
    }
}
