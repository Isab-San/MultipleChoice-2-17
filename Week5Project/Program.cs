using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Week5Project
{
    internal class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            //ProblemOne();
            //ProblemTwo();
            //ProblemFour();
        }

        static void ProblemOne()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
        }

        static void ProblemTwo()
        {
            /*
             Write a program and continuously ask the user to enter a number or "ok" to exit.
            Calculate the sum of all the previously entered numbers and display it on the console.
             */
            int n2 = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit.");
                var input = Console.ReadLine();

                if (input == "ok")
                    break;
                n2 += Convert.ToInt32(input);
                
            }
            Console.WriteLine("The sum of all previously entered numbers is: " + n2);
        }

        static void ProblemFour()
        {
            /*
             Write a program that picks a random number between 1 and 10.
            Give the user 4 chances to guess the number.
            If the user guesses the number, display “You won"; otherwise, display “You lost"
             */
            random = new Random();
            int n4 = random.Next(1, 10);
            int n42 = 0;

            for(int x = 1; x < 5; x++)
                
             {
                    Console.WriteLine("This is iteration " + x);
                    Console.WriteLine(n4);
                    Console.WriteLine("Please enter a number between 1 and 10.");
                    n42 = Convert.ToInt32(Console.ReadLine());

                    if (n42 == n4)
                    {
                        Console.WriteLine("You won!");
                        break;
                    }
                    else if (x == 4)
                    {
                        Console.WriteLine("You lost");
                    }
                
             }
                
            
        }

    }  
}