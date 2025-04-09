namespace Diamond_Builder_X
{
    internal class Program
    {
        //Version 1: Menu creation and user input validation to accept only odd numbers.
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
                diamondSize = Console.Read();

                if (diamondSize % 2 != 0)
                {
                    
                    Console.WriteLine("The number is odd, press Enter to continue");
                    Console.ReadLine();
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
