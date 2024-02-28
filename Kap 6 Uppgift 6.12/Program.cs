using System;
using System.Collections.Generic;
namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            //-------------------------------------------

            Console.WriteLine("Hur hög ska triangeln vara?");
            int height = ReadInt();
            SkrivTriangel(height);

        }

        static int ReadInt()
        {
            int integer;
            Console.WriteLine("Skriv in ett heltal:");

            while (int.TryParse(Console.ReadLine(), out integer) == false)
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return integer;
        }

        static void SkrivTriangel(int height)
        {
            //i = radnumret
            for (int i = 1; i <= height; i++)
            {
                //Mellanslagen
                for(int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }
                //Stjärnorna
                //Stjärnorna följer ett mönster, där antal stjärnorna på varje rad = radens nummer*2 - 1
                for (int j = 0; j < 2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
/*Skapa ett program som innehåller en metod som kan rita en triangel där användaren
får bestämma triangelns höjd. Triangeln ska se ut så här om höjden är 3:
  *
 ***
*****
Om höjden är 4 ska den istället se ut så här:
   *
  ***
 *****
*******/