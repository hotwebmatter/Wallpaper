/**
 * ######################################################
 * ##    Programming Assignment #5                     ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: September 16 2019             ##
 * ##    Purpose: Use methods that return values.      ##
 * ######################################################
 */

using System;
using static System.Console;

namespace Wallpaper
{
    class Program
    {
        private static string RepeatChar(string character, int reps)
        {
            string result = "";

            for (int i = 0; i < reps; i++)
            {
                result += character;
            }
            return result;
        }

        private static string IndentString(string message, int indent)
        {
            string result = "";

            result += RepeatChar(" ", indent);
            result += message;

            return result;
        }

        private static string CenterString(string message, int bannerWidth)
        {
            string result = "";

            if (message.Length > bannerWidth)
            {
                return message;
            }
            else
            {
                result += RepeatChar(" ", (bannerWidth - message.Length) / 2);
                result += message;
            }
            return result;
        }

        private static double ReadDouble(string input)
        {
            // input validation method
            double choice;
            while (!double.TryParse(input, out choice))
            {
                WriteLine("Invalid input.\nPlease choose a floating-point number.");
                input = ReadLine();
            }
            return choice;
        }

        private static double ReadLength()
        {
            double result;
            string input;
            Write("Enter length (feet): ");
            input = ReadLine();
            result = ReadDouble(input);
            WriteLine();
            return result;
        }

        private static double ReadWidth()
        {
            double result;
            string input;
            Write("Enter width (feet): ");
            input = ReadLine();
            result = ReadDouble(input);
            WriteLine();
            return result;
        }
        private static double ReadHeight()
        {
            double result;
            string input;
            Write("Enter height (feet): ");
            input = ReadLine();
            result = ReadDouble(input);
            WriteLine();
            return result;
        }

        private static double ReadCoverage()
        {
            double result;
            string input;
            Write("Enter roll coverage (square feet): ");
            input = ReadLine();
            result = ReadDouble(input);
            WriteLine();
            return result;
        }
        private static void GenerateHeader()
        {
            const int BANNER_WIDTH = 54;
            const int INDENTATION = 8;
            const string NAME = "Matthew Obert";

            // generate output
            WriteLine(RepeatChar("*", BANNER_WIDTH));
            WriteLine(CenterString("Wallpaper", BANNER_WIDTH));
            WriteLine(IndentString("Calculate Single Rolls Needed", INDENTATION));
            Write(IndentString("Name: ", INDENTATION));
            WriteLine(NAME);
            Write(IndentString("Date: ", INDENTATION));
            WriteLine(DateTime.Today.ToShortDateString());
            WriteLine(RepeatChar("*", BANNER_WIDTH));
        }
        private static void DisplayDirections()
        {
            // generate output
            WriteLine();
            WriteLine("This program will determine how many rolls needed to wallpaper a room.");
            WriteLine("You will be asked to enter the length in feet, width in feet,");
            WriteLine("height in feet, and roll coverage in feet.");
            WriteLine();
        }

        private static double CalculateRolls(double length, double width, double height, double rollCoverage)
        {
            // initialize local variables
            double perimeter;
            double area;
            double numOfRolls;

            // calculate new total
            perimeter = (length + width) * 2;
            area = perimeter * height;
            numOfRolls = area / rollCoverage;

            return numOfRolls;
        }

        public static void Main(string[] args)
        {
            // declare variables
            double length;
            double width;
            double height;
            double rollCoverage;
            double numOfRolls;
            string input;

            // header output (void method)
            GenerateHeader();

            // directions output (void method)
            DisplayDirections();

            // variable assignment
            length = ReadLength();
            width = ReadWidth();
            height = ReadHeight();
            rollCoverage = ReadCoverage();

            // Calculate number of rolls
            numOfRolls = Math.Ceiling(CalculateRolls(length, width, height, rollCoverage));

            // output number of rolls
            WriteLine("The number of rolls needed are: {0}", numOfRolls);

            ReadLine();
        }
    }
}
