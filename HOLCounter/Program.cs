using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tahte lauses "Hello World!"

            Console.WriteLine("Hello World!");
            string helloWorld = "Hello World!".ToLower();
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {
                    hCounter++;
                }
                if (helloWorld[i] == 'o')
                {
                    oCounter++;
                }
                if (helloWorld[i] == 'l')
                {
                    lCounter++;
                }
               
            }
            Console.WriteLine($"Lauses 'Hello World!' on: \n{hCounter} 'h', \n{oCounter} 'o', \n{lCounter} 'l' tähte");
        }
    }
}
