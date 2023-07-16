internal class Program
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
 
        // Method statement 

        /*  static int cube(int num)
    {
        int result = num * num * num;
        return result;
    }*/


        /* bool isMale = true;
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
         }*/


        /* Console.WriteLine(GetMax(20, 10, 40));*/


        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a Operator: ");
        string op = Console.ReadLine();

        Console.Write("Enter a number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (op == "+")
        {
            Console.WriteLine(num1 + num2);
        }
        else if (op == "-")
        {
            Console.WriteLine(num1 - num2);
        }
        else if (op == "*")
        {
            Console.WriteLine(num1 * num2);
        }
        else if (op == "/")
        {
            Console.WriteLine(num1 / num2);
        }else
        {
            Console.WriteLine("Invalid operator.");
        }



    }

    /*static int GetMax(int num1, int num2, int num3)
    {
        int result;
        if(num1 >= num2 && num1 >= num3)
        {
            result = num1;
        }else if (num2 >= num1 && num2 >= num3)
        {
            result = num2;
        }else
        {
            result = num3;
        }
        return result;
    }*/



}

