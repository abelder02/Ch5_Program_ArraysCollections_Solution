using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTasksDLL
{
    public class CT
    {
        public static string date = Convert.ToString(DateTime.Now);

        public static int LengthOfTopLine;

        public static void Header(out int x, string title, string purpose)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(100, 50);
            string topLine = "Author: Andrew Belder            "
            + "Title: " + title + "            Date: " + date;
            Console.Write(topLine);
            Console.WriteLine("\n\nPurpose: {0}", purpose);
            int LengthOfInput = topLine.Length;
            x = LengthOfInput;
            CreateHFLine(LengthOfInput);
         }
              
        public static void CreateHFLine(int x)
        {
            Console.WriteLine("");
            for (int i = 0; i < x; i++)
            {
                Color("white");
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }

        public static void CreateBorderLine(string x)
        {
            int y = x.Length;
            Console.WriteLine("");
            for (int i = 0; i < y; i++)
            {
                Color("white");
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }

        public static void Footer()
        {
            Console.ForegroundColor = ConsoleColor.White;
            CreateHFLine(LengthOfTopLine); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please press <ENTER> twice "
                + "to exit program...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nGoodbye!");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Read();
        }

        public static void AnyKeyToContinue()
        {
            Console.Write("Please Hit Any Key to Continue...\t");
            Console.ReadKey();
            Console.WriteLine("");
        }

        public static int AskUserForInt(string x)
        {
            Console.Write("\nPlease enter {0} ", x);
            Color("Green");
            var input = Console.ReadLine();
            var inputType = input.GetTypeCode();
            Color("");
            int convertInput = Convert.ToInt32(input);
            return convertInput;
                       
            
        }

        public static string AskUserForString(string x)
        {
            Console.Write("\nPlease enter {0} ", x);
            Color("Green");
            string input = Console.ReadLine();
            Color("");
            return input;
        }

        public static double AskUserForDouble(string x)
        {
            Console.Write("\nPlease enter {0} ", x);
            Color("Green");
            string input = Console.ReadLine();
            Color("");
            double convertInput = Convert.ToDouble(input);
            return convertInput;
        }

        public static DateTime AskUserForDateTime(string x)
        {
            Console.Write("\nPlease enter {0} ", x);
            Color("Green");
            string input = Console.ReadLine();
            Color("");
            DateTime convertInput = Convert.ToDateTime(input);
            return convertInput;
        }

        public static void Color(string x)
        {
            string y = x.ToLower();
            switch (y)
            {
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "dark yellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "dark blue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
            }
        }

        public static string capitalizeMethod(string x)
        {
            //wrongInput(x);
            return x.First().ToString().ToUpper() + x.Substring(1);
        }

        //public static void wrongInput(string x)
        //{
        //    if (String.IsNullOrEmpty(x))
        //        throw new ;
        //}

        public static void HeaderOld(string title, string purpose)
        {
            Console.ForegroundColor = ConsoleColor.Green;//changes color
            Console.SetWindowSize(100, 50); //Changes the Console Size
            Console.Write("Author: Andrew Belder");//NEED TO INSERT INFO
            Console.Write("\t\tTitle: {0}", title);
            Console.WriteLine("\t\tDate: {0}", DateTime.Now); //NEED TO INSERT INFO
            Console.WriteLine("\nPurpose: {0}", purpose);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n*********************************************"
                + "*****************************************************\n\n");
        }

    }


}
