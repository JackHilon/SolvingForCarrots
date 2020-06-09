using System;
using System.Text.RegularExpressions;

namespace SolvingForCarrots
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DivideLine();

            var myLine = Console.ReadLine();
            var myArray = StringLineToIntArray(myLine);

            // number of contestants in the contest
            // N >= 1
            var N = myArray[0];
           

            // number of huffle-puff problems solved in total
            // = (the number of carrots that will be handed out during the contest)
            // P <= 1000
            var P = myArray[1]; 


            //In this contest, you also earn a carrot for each difficult problem you solve, 
            //or huffle-puff problems as we prefer to call them. 
            var result = Carrot(N, P);
            Console.WriteLine(result);
            
        }

        private static int Carrot(int a, int b)
        {
            a = Math.Abs(a); // number of contestants
            b = Math.Abs(b); // number of solved problems (number of carrots) 

            if (a == 0)
                a++;

            b = b % 1000;

            // description for each contestant
            string description = " ";
            for (int i = 1; i <= a; i++)
            {
                description = Console.ReadLine();
            }

            return b; // number of carrots
        }

        private static int[] StringLineToIntArray(string line)
        {
            var str = line.Split(' ');
            int[] res = new int[2] { 0, 0 };


            int h = 0;
            int g = 0;
            try
            {
                h = int.Parse(str[0]);
                g = int.Parse(str[1]);
            }
            catch(FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                Console.WriteLine("Format error !!!!");
                line = Console.ReadLine();
                res = StringLineToIntArray(line);
                return res;
            }
            catch(IndexOutOfRangeException ex2)
            {
                Console.WriteLine(ex2.Message); 
                Console.WriteLine("Enter two items (not one) !!!!");
                line = Console.ReadLine();
                res = StringLineToIntArray(line);
                return res;
            }

            res[0] = h;
            res[1] = g;
            return res;
        }

        private static void DivideLine()
        {
            Console.WriteLine(" ");
            Console.WriteLine("================");
            Console.WriteLine(" ");
        }
    }
}