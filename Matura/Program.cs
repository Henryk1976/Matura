using System;

namespace Matura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz wynik z matematyki"); //x
            Console.WriteLine("Wpisz wynik z chemii");  //y
            Console.WriteLine("Wpisz wynik z fizyki");  //z

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();



            int ax = int.Parse(x);
            int ay = int.Parse(y);
            int az = int.Parse(z);

            if (ax > 70 && ay > 45 && az > 55 || ax+ay+az > 180 || ax + ay > 150 || ax + az > 150)
            { Console.WriteLine("Kandydat dopuszczony do rekrutacji"); }
            else { Console.WriteLine("Ucz się dalej"); }


        }
    }
}
