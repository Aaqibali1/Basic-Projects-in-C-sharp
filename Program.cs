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


        /* Console.Write("Enter a number: ");
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
         }*/


        // Console.WriteLine(GetDay(0));


        /*
                int index = 1;
                while(index <= 5)
                {
                    Console.WriteLine(index);
                    index++;
                }*/

        // Building a Guessing Game


        /* string secretWord = "Aaqib Ali";
         string guess = " ";

         while (guess != secretWord)
         {
             Console.Write("Enter guess: ");
             guess = Console.ReadLine();

         }
         Console.WriteLine("You Win! ");*/

        //More Advance Guessinng Game

        /* string secretWord = "Aaqib Ali the Coder";
         string guess = " ";
         int guessCount = 0;
         int guessLimit = 5;
         bool outOfGuesses = false;

         while (guess !=secretWord && !outOfGuesses)
         {
             if (guessCount < guessLimit)
             {
                 Console.Write("Enter a guess: ");
                 guess = Console.ReadLine();
                 guessCount++;
             }else
             {
                 outOfGuesses = true;

             }
         }
         if (outOfGuesses)
         {
             Console.WriteLine("You Lose! ");
         }else
         {
             Console.WriteLine("You Win! ");
         }*/


        /// For Loop program


        /*int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
         
        for(int i= 0; i < luckyNumbers.Length; i++)
        {
            Console.WriteLine(luckyNumbers[i]);
        }*/


        //Console.WriteLine(GetPow(3, 3));



        int[,] numberGrid =
        {
            {1, 2 },
            {3, 4},
            {5, 6 },
        };

        Console.WriteLine(numberGrid[2, 1]);

        Console.ReadLine();



    }

   /* static int GetPow(int baseNum, int powNum)
    {
        int result = 1;
         
        for(int i = 0; i < powNum; i++)
        {
            result = result * powNum;
        }


        return result;
    }*/

    /*static string GetDay(int DayNum)
    {
        string dayName;

        switch (DayNum)
        {
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Mnday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            default:
                dayName = "Invalid Day Number.";
                break;
        }

        return dayName;
    }*/
 
       
         


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

