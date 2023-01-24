/*
Author:Pubuduni Karalliyadde
Date: 1/19/2023
Decription: C# Console Application to calculate letter grades
*/

using System;

namespace ConditionalStatements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a numeric grade: ");

        try
        {
            decimal grade = decimal.Parse(Console.ReadLine());

            string letter;

            if (grade >= 90)
            {
                letter = "A";
                Console.WriteLine("Your expected grade for ISM 4300 is A");
            }

            else if (grade >= 80 && grade < 90)
            {
                letter = "B";
            }
        }
        catch
        {
            Console.WriteLine("Enter a numeric value");
        }

        try
        {
            decimal grade = decimal.Parse(Console.ReadLine());

            string letter;

            if (grade < 80 && grade >= 70)
            {
                letter = "C";
                Console.WriteLine("Your expected grade for ISM 4300 is C");
            }

            else if (grade < 70 && grade >=60)
            {
                letter = "D";
                Console.WriteLine("Your expected grade for ISM 4300 is D");
            }
        }
        catch
        {
            Console.WriteLine("Enter a numeric value");
        }
        try

        { decimal grade = decimal.Parse(Console.ReadLine());

            string letter;

            if (grade < 60)

                letter = "F";
            Console.WriteLine("Your expected grade for ISM 4300 is F");
        }
        catch
        { }
        }
    }
