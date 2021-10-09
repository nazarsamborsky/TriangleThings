using System;

namespace TriangleThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle cisloJedna = new Triangle(6); //rovnostranný trojúhelník
            cisloJedna.A = 0; // strana nemuze byt mensi nez 0
            Console.WriteLine(cisloJedna.A + " je délka strany A");
            Console.WriteLine(cisloJedna.B + " je délka strany B");
            Console.WriteLine(cisloJedna.C + " je délka strany C");
            Console.WriteLine(cisloJedna.GetOutline() + " je obvod");
            Console.WriteLine(cisloJedna.GetArea() + " je obsah");
            Console.WriteLine("Trojuhelnik " + cisloJedna.IsExisting() + " existovat");
            Console.WriteLine("Trojuhelnik " + Triangle.CanExist(6, 1, 4) + " existovat"); // static CanExsist
            Console.WriteLine(cisloJedna.GetAlpha() + " je uhel alfa");
            Console.WriteLine(cisloJedna.GetBeta() + " je uhel beta");
            Console.WriteLine(cisloJedna.GetGamma() + " je uhel gamma");
            Console.WriteLine();


            Triangle cisloDva = new Triangle(3, 4, 5);
            Console.WriteLine(cisloDva.A + " je délka strany A");
            Console.WriteLine(cisloDva.B + " je délka strany B");
            Console.WriteLine(cisloDva.C + " je délka strany C");
            Console.WriteLine(cisloDva.GetOutline() + " je obvod");
            Console.WriteLine(cisloDva.GetArea() + " je obsah");
            Console.WriteLine("Trojuhelnik " + cisloDva.IsExisting() + " existovat");
            Console.WriteLine(cisloDva.GetAlpha() + " je uhel alfa");
            Console.WriteLine(cisloDva.GetBeta() + " je uhel beta");
            Console.WriteLine(cisloDva.GetGamma() + " je uhel gamma");
            Console.WriteLine();
            cisloDva.SetSides(4, 8, 7);
            // strany po zmeneni
            Console.WriteLine(cisloDva.A + " je délka strany A");
            Console.WriteLine(cisloDva.B + " je délka strany B");
            Console.WriteLine(cisloDva.C + " je délka strany C");

        }
    }
}
