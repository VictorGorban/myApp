using System;

namespace myApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 5; j++)
            {
                DoNothing();
                System.Console.WriteLine(Hello.HelloGuys);
            }
            int i = 0;




            while (i < 4)
            {
                i++;
                DoNothing();
            }
        }

        public static void MyMethod3() => JustMakeYourselfBetter();
        
        public static void MyMethod() => JustMakeYourselfBetter();

        private static void JustMakeYourselfBetter()
        {
            DoNothing();
            
        }
    }
}
