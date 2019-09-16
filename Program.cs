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
        static string RepeatChar(string character, int reps)
        {
            string result = "";

            for (int i = 0; i < reps; i++)
            {
                result += character;
            }
            return result;
        }

        static string IndentString(string message, int indent)
        {
            string result = "";

            result += RepeatChar(" ", indent);
            result += message;

            return result;
        }

        static string CenterString(string message, int bannerWidth)
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

        static int ReadInt(string input)
        {
            int choice;

            while (!int.TryParse(input, out choice))
            {
                WriteLine("Invalid input.\nPlease choose a number.");
                input = ReadLine();
            }
            return choice;
        }

        static void GenerateHeader()
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
        static void DisplayDirections()
        {
            // generate output
            WriteLine();
            WriteLine("This program will determine how many rolls needed to wallpaper a room.");
            WriteLine("You will be asked to enter the length in feet, width in feet,");
            WriteLine("height in feet, and roll coverage in feet.");
            WriteLine();
        }

        static double CalculateRolls(double length, double width, double height, double rollCoverage)
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

        static void Main(string[] args)
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
            Write("Enter length (feet): ");
            input = ReadLine();
            length = ReadInt(input);
            WriteLine();
            Write("Enter width (feet): ");
            input = ReadLine();
            width = ReadInt(input);
            WriteLine();
            Write("Enter height (feet): ");
            input = ReadLine();
            height = ReadInt(input);
            WriteLine();
            Write("Enter roll coverage (square feet): ");
            input = ReadLine();
            rollCoverage = ReadInt(input);
            WriteLine();

            // Number Of Rolls output
            numOfRolls = Math.Ceiling(CalculateRolls(length, width, height, rollCoverage));

            // output using percentage format specifier
            WriteLine("The number of rolls needed are >> {0}", numOfRolls);

            ReadLine();
        }
    }
}
