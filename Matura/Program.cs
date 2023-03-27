using Microsoft.VisualBasic;
using System;

namespace Matura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz wynik z matematyki"); //x
            string x = Console.ReadLine();

            Console.WriteLine("Wpisz wynik z chemii");  //y
            string y = Console.ReadLine();



            Console.WriteLine("Wpisz wynik z fizyki");
            string z = Console.ReadLine();



            int ax = int.Parse(x);
            int ay = int.Parse(y);
            int az = int.Parse(z);

            if (ax > 70 && ay > 45 && az > 55 || ax + ay + az > 180 || ax + ay > 150 || ax + az > 150)
            { Console.WriteLine("Kandydat dopuszczony do rekrutacji"); }
            else { Console.WriteLine("Ucz się dalej"); }


        }
    }
}
