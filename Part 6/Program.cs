using System;

namespace Part_6
{
    class Program
    {
        


        static void Main(string[] args)
        {
            int min;
            int max;
            int userNumber;
            double score;
            int passes = 0 ;
            int fail = 0;
            int odd;
            Random gen = new Random();
            int maxRand;
            int minRand;
            int rand;
            int oddTotal = 0;
            

            
            Console.WriteLine("Enter a minimum number: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum number: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number between both: ");
            userNumber = Convert.ToInt32(Console.ReadLine());
            while (min >= userNumber || max <= userNumber)
            {
                Console.WriteLine("Enter a number between min and max");
                userNumber = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Number is between min and max");
            

            Console.WriteLine("Enter test scores %'s to see how many people passed. press any button to countinue");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Enter a score %");
                score = Convert.ToInt32(Console.ReadLine());
                {
                    if (score >= 70)
                    {
                        passes = passes + 1;
                        Console.WriteLine($"There are {passes} students that have passed so far and there are {fail} students that have failed so far");
                        Console.WriteLine("Press escape to stop entering scores");
                    }
                    else
                    {
                        fail = fail + 1;
                        Console.WriteLine($"There are {passes} students that have passed so far and there are {fail} students that have failed so far");
                        Console.WriteLine("Press escape to stop entering scores press any other button to countinue");
                    }
                }
            }
            Console.WriteLine("Enter a number to get a the sum of the odd numbers between 1 and the number: ");
            odd = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= odd; i += 2)
            {
                oddTotal = oddTotal + i;
                Console.WriteLine(oddTotal);
            }
            

            Console.WriteLine("Enter a minimum number");
            minRand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum number");
            maxRand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"25 random numbeers between the minimum and maximum numbers are: ");
            for (int i = 1; i <= 25; i++)
            {
                rand = gen.Next(minRand, maxRand);
                Console.WriteLine(rand);
            }
           
        }
    }
}
