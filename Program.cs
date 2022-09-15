using System;
using System.ComponentModel;

namespace Selection_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double favnum = 2;

            Console.WriteLine("what is my favorite number?");
            Double number = Convert.ToDouble(Console.ReadLine());
            while (number > 2 || number < 2 || number == 2)
            {


                if (number == 2)
                {
                    Console.WriteLine("got it");

                }
                else if (number > 2)
                {
                    Console.WriteLine("Too high");
                    Console.WriteLine("Try Again! What is my favorite number?");
                }
                else
                {
                    Console.WriteLine("Too low");
                    Console.WriteLine("Try again! what is my favorite number?");
                }
                number = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("What is your favorite project?");
            string fproject = Console.ReadLine();
            switch (fproject.ToLower())
            {
                case "english":
                    Console.WriteLine("English ok good");
                break;
                case "spanish":
                       Console.WriteLine("spanish ok fine");
                    break;
                case "mathematics":
                    Console.WriteLine("mathematics sure! try again to guess mine");
                    break;
                case "science":
                    Console.WriteLine("SCIENCE V.GOOD");
                    break;
                case "history":
                    Console.WriteLine("history is fine subject");
                    break;

                default:    
                    Console.WriteLine("it is not mine though");
                    break ;
            }







        }
    }
}
