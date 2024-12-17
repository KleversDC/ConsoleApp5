using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            //    Console.WriteLine("Enter a number between 1 and 100:");
            //    int number = int.Parse(Console.ReadLine());

            //    if (number < 1 || number > 100)
            //    {
            //        Console.WriteLine("Error: Number out of range.");
            //    }
            //    else if (number % 3 == 0 && number % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }
            //    else if (number % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (number % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number);
            //    }
            //2
            //Console.WriteLine("Enter the number:");
            //double value = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the percentage:");
            //double percentage = double.Parse(Console.ReadLine());

            //double result = value * (percentage / 100);
            //Console.WriteLine($"{percentage}% of {value} is {result}");
            //3
            //Console.WriteLine("Enter four digits:");
            //int di1 = int.Parse(Console.ReadLine());
            //int di2 = int.Parse(Console.ReadLine());
            //int di3 = int.Parse(Console.ReadLine());
            //int di4 = int.Parse(Console.ReadLine());

            //int number = int.Parse($"{di1}{di2}{di3}{di4}");
            //Console.WriteLine($"The formed number is: {number}");
            //4
            //Console.WriteLine("Enter a six-digit number:");
            //string number = Console.ReadLine();

            //if (number.Length != 6 || !int.TryParse(number, out _))
            //{
            //    Console.WriteLine("Error: Not a six-digit number.");
            //    return;
            //}

            //Console.WriteLine("Enter the positions to swap (1 to 6):");
            //int pos1 = int.Parse(Console.ReadLine()) - 1;
            //int pos2 = int.Parse(Console.ReadLine()) - 1;

            //if (pos1 < 0 || pos1 > 5 || pos2 < 0 || pos2 > 5)
            //{
            //    Console.WriteLine("Error: Invalid positions.");
            //    return;
            //}

            //char[] digits = number.ToCharArray();
            //(digits[pos1], digits[pos2]) = (digits[pos2], digits[pos1]);

            //string swappedNumber = new string(digits);
            //Console.WriteLine($"The swapped number is: {swappedNumber}");

            //6
            //Console.WriteLine("Enter the temperature:");
            //double temperature = double.Parse(Console.ReadLine());

            //Console.WriteLine("Choose conversion: 1 for Fahrenheit to Celsius, 2 for Celsius to Fahrenheit:");
            //int choice = int.Parse(Console.ReadLine());

            //if (choice == 1)
            //{
            //    double celsius = (temperature - 32) * 5 / 9;
            //    Console.WriteLine($"Temperature in Celsius: {celsius}");
            //}
            //else if (choice == 2)
            //{
            //    double fahrenheit = (temperature * 9 / 5) + 32;
            //    Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid choice.");
            //}
            //7
            //Console.WriteLine("Enter the first number:");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int end = int.Parse(Console.ReadLine());

            //if (start > end)
            //{
            //    (start, end) = (end, start);
            //}

            //Console.WriteLine("Even numbers in the range:");
            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.WriteLine();
//5
            //Console.WriteLine("Enter a date (dd.MM.yyyy):");
            //DateTime date;

            //if (!DateTime.TryParse(Console.ReadLine(), out date))
            //{
            //    Console.WriteLine("Error: Invalid date.");
            //}
            //else
            //{
            //    string season;

            //    if (date.Month == 12 || date.Month == 1 || date.Month == 2)
            //    {
            //        season = "Winter";
            //    }
            //    else if (date.Month >= 3 && date.Month <= 5)
            //    {
            //        season = "Spring";
            //    }
            //    else if (date.Month >= 6 && date.Month <= 8)
            //    {
            //        season = "Summer";
            //    }
            //    else
            //    {
            //        season = "Autumn";
            //    }

            //    Console.WriteLine($"{season} {date.DayOfWeek}");
            //}

        }
    }
}

