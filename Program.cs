﻿internal class Program
{
    private static void Main(string[] args)
    {
        /* Console.Write("Enter a number: ");
         double num1 = Convert.ToDouble(Console.ReadLine());
         Console.Write("Enter your another Number: ");
         double num2 = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine(num1 + num2);
         Console.WriteLine(num1 - num2);
         Console.WriteLine(num1 / num2);
         Console.WriteLine(num1 % num2);*/


        // Build A MAD Libs Game.

        /*string color, pluralNoun, celebrity;

        Console.Write("Enter a color: ");
        color = Console.ReadLine();

        Console.Write("Enter a Celebrity: ");
        celebrity = Console.ReadLine();

        Console.Write("Enter A PluralNoun: ");
        pluralNoun = Console.ReadLine();

        Console.WriteLine("Roses are " + " " + color);
        Console.WriteLine("I love Celebrity" + " " + celebrity);
        Console.WriteLine(pluralNoun + " " + "are blue.");*/


        // Return Statement 

        /* int cubedNumber = cube(5);
         Console.WriteLine(cubedNumber);
 */
        // Method statement 

        /*  static int cube(int num)
    {
        int result = num * num * num;
        return result;
    }*/


        bool isMale = true;
        bool isTall = false;

        if (isMale && isTall)
        {
            Console.WriteLine("You are a Tall male. ");
        }else if (isMale && !isTall) {
            Console.WriteLine("You are short male. ");
        }else if (!isMale && isTall)
        {
            Console.WriteLine("You are not male but you are Tall. ");
        }
        else
        {
            Console.WriteLine("You are not male not  a Tall. ");
        }






    }
}

