using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Diamond_Builder_X
{
    internal class Program
    {
        //Version 4: Refactoring the code and adding an option to create a new or close the program
        static void Main(string[] args)
        {

            while (true)
            {
                ShowMenu();

                int number = NumberInput();

                if (number % 2 != 0)
                {
                    //cut diamond in a half 
                    int diamondHalfSize = number / 2;


                    //top half
                    ShowTopHalfDiamond(diamondHalfSize);

                    //center line
                    ShowTheCenterLineDiamond(number);

                    //bottom half
                    ShowBottomHalfDiamond(diamondHalfSize);
                }

                else
                {
                    Console.WriteLine("Please type a odd number. Press Enter to restart");
                }
                
                string continueOption = MenuDisplayContinue();

                if (continueOption != "Y")
                    break;

            }


        }
        static void ShowMenu()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("********* Diamond Creator **********");
            Console.WriteLine("************************************");

            Console.WriteLine();
        }
        static int NumberInput()
        {
            Console.Write("Type the size of the diamond you want to create: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        static void ShowTopHalfDiamond(int diamondHalfSize)
        {
            for (int counter = 0; counter < diamondHalfSize; counter++)
            {
                Console.Write(new string(' ', diamondHalfSize - counter));
                Console.WriteLine(new string('X', counter * 2 + 1));
            }
        }

        static void ShowTheCenterLineDiamond(int number)
        {
            Console.WriteLine(new string('X', number));
        }

        static void ShowBottomHalfDiamond(int diamondHalfSize)
        {
            for (int counter = diamondHalfSize - 1; counter >= 0; counter--)
            {
                Console.Write(new string(' ', diamondHalfSize - counter));
                Console.WriteLine(new string('X', counter * 2 + 1));
            }
        }

        static string MenuDisplayContinue()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Do you want to create a new diamond? (Y/N) ");

            string continueOption = Console.ReadLine()!.ToUpper();

            return continueOption;
        }
    }
}
