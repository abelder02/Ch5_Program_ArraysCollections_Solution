using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTasksDLL;

namespace Ch5_Program_ArraysCollections
{
    class Ch5_Program_ArraysCollections
    {
        static void Main(string[] args)
        {
            CT.Header(out CT.LengthOfTopLine, "Arrays & Collections",
                "to figure out Chapter 7");
            //THis change
            List<int> Numbers = new List<int>();

            bool flag = true;
            do
            {
                Numbers.Add(AskUserForInt("a number", ref flag));
            }
            while (flag);

            Numbers.Remove(-911);
            double average = Numbers.Average();
            int max = Numbers.Max();
            int min = Numbers.Min();
            
            //FIND AND ADD CLEAR METHOD HERE
            CT.Color("magenta");
            Console.WriteLine("The average of the numbers is {0},"
                +"\nwhile the minimum value is {1} and the maximum value is {2}.",
                average, min, max);

            CT.Footer();
        }

        public static int AskUserForInt(string x, ref bool flag)
        {
            Console.Write("\nPlease enter {0} ", x);
            CT.Color("Green");
            var input = Console.ReadLine();
            for (int i = 0; i < 1; i++)
            {

                try
                {
                    int.Parse(input);
                }
                catch (FormatException)
                {
                    CT.Color("red");
                    Console.WriteLine("\nYOU GOOBER ---> FOLLOW DIRECTIONS");
                    CT.Color("white");
                    Console.Write("\nPlease enter {0} ", x);
                    CT.Color("green");
                    input = Console.ReadLine();
                    i--;
                }
            }
            int convertInput = Convert.ToInt32(input);
            if (convertInput == -911)
                flag = false;
            else
            { 
                CT.Color("red");
                Console.Write("\nTo exit please enter \"-911\"");
            }
            CT.Color("WHITE");
            return convertInput;
        }
    }
}
