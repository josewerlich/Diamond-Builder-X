using System.Diagnostics.Metrics;

namespace Diamond_Builder_X
{
    internal class Program
    {
        //Version 3: Print the top half and the bottom half
        static void Main(string[] args)
        {
            int number = 0;


            while (true)
            {
                Console.WriteLine("************************************");
                Console.WriteLine("********* Diamond Creator **********");
                Console.WriteLine("************************************");

                Console.WriteLine();

                Console.Write("Type the size of the diamond you want to create: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 != 0)
                {
                    //cut diamond in a half 
                    int diamondHalfSize = number / 2;


                    //top half
                    for (int counter = 0; counter < diamondHalfSize; counter++)
                    {
                        Console.Write(new string(' ', diamondHalfSize - counter));
                        Console.WriteLine(new string('*', counter * 2 + 1));
                    }
                    
                    //center line
                    Console.WriteLine(new string('*', number));
                    
             
                    //bottom half
                    for (int counter = diamondHalfSize -1; counter >= 0; counter--)
                    {
                        Console.Write(new string(' ', diamondHalfSize - counter));
                        Console.WriteLine(new string('*', counter * 2 + 1));
                    }
                }

                else
                {
                    Console.WriteLine("Please type a odd number. Press Enter to restart");
                    

                }
                Console.ReadLine();
            }

            
            


        }

    }
}
