using System.Diagnostics.Metrics;

namespace Diamond_Builder_X
{
    internal class Program
    {
        //Version 2: Print the middle line of the diamond based on the user input
        static void Main(string[] args)
        {
            int diamondSize = 0;


            while (true)
            {
                Console.WriteLine("************************************");
                Console.WriteLine("********* Diamond Creator **********");
                Console.WriteLine("************************************");

                Console.WriteLine();

                Console.Write("Type the size of the diamond you want to create: ");
                diamondSize = Convert.ToInt32(Console.ReadLine());

                if (diamondSize % 2 != 0)
                {
                    char[] diamondMiddleLine = new char[diamondSize];

                    for (int counter = 0; counter < diamondSize; counter++ )
                    {
                        diamondMiddleLine[counter] = 'X';
                    }
                    Console.WriteLine(new string (diamondMiddleLine)); 
                }

                else
                {
                    Console.WriteLine("Please type a odd number. Press Enter to restart");
                    Console.ReadLine();

                }
                Console.ReadLine();
            }


            


        }

    }
}
