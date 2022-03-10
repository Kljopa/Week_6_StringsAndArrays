using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees-ja perekonnanime
            //programm kontrollib andmete pikust
            //programm kuvab kumb nendes on pikem, kes ees-või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string secondName = Console.ReadLine();                 

            if (firstName.Length < secondName.Length)
            {
                Console.WriteLine("Perekonnanime on pikem");
            }
            else if (firstName.Length > secondName.Length)
            {
                Console.WriteLine("Eesnimi on pikem");
            }
            else 
            {
                Console.WriteLine("Eesnimi ja perekonnanime on ühe pikkusega");
            }
        }
    }
}
