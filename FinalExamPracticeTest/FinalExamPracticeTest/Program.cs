using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPracticeTest
{
    class Program
    {

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            //Console.Clear();
            Console.WriteLine("Choose one of the following options:");
            Console.WriteLine("1 - Integers");
            Console.WriteLine("2 - Students");
            Console.WriteLine("3 - Digits");
            Console.WriteLine("4 - ASCII");
            Console.WriteLine("5 - Spaces");
            Console.WriteLine("6 - Exit");
            Console.Write("\r\nChoose one of the following options:");

            switch (Console.ReadLine())
            {
                case "1":
                    Integer();
                    return true;
                case "2":
                    Studentgrade();
                    return true;
                case "3":
                    Digits();
                    return true;
                case "4":
                    Ascii();
                    return true;
                case "5":
                    Spaces();
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }

        private static void Integer()
        {
            Console.Clear();
            Console.WriteLine("Insert the first value: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the second value: ");
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the third value: ");
            int value3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numbers: " + " " + value1 + " " + value2 + " " + value3);
            Console.WriteLine(" ");

            if (value1 == value2 && value1 == value3)
            {
                Console.WriteLine("All numbers are the same");
            }
            else if (value1 > value2 && value1 > value3)
            {
                Console.WriteLine("The greatest number is:" + value1);
            }
            else if (value2 > value1 && value2 > value3)
            {
                Console.WriteLine("The greatest number is:" + value2);
            }
            else
            {
                Console.WriteLine("The greatest number is:" + value3);
            }
            Console.ReadKey();
            Console.Clear();

        }

        private static void Studentgrade()
        {
            Console.Clear();
            Console.WriteLine("Insert a value for quiz score: ");
            float value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a value for mid-term score: ");
            float value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a value for final score: ");
            float value3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Scores: " + " Quiz: " + value1 + " Mid-Term: " + value2 + " Final: " + value3);

            float average = (value1 + value2 + value3) / 3;

            if (average >= 90)
            {
                Console.WriteLine("Final Score:" + average + " Grade A");
            }
            else if (average >= 70)
            {
                Console.WriteLine("Final Score:" + average + " Grade B");
            }
            else if (average >= 50)
            {
                Console.WriteLine("Final Score:" + average + " Grade C");
            }
            else
            {
                Console.WriteLine("Final Score:" + average + " Grade F");
            }
            Console.ReadKey();
            Console.Clear();
        }

        private static void Digits()
        {
            Console.Clear();
            Console.WriteLine("Insert a value: ");
            string value1 = Console.ReadLine();
            Console.WriteLine(value1 + " Has a total of: " + value1.Length + "digits");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Ascii()
        {
            for (int i = 1; i < 122; i++)
            {
                Console.Write(" " + i + " = " + (char)i);

                if (i % 10 == 0)
                {
                    Console.WriteLine(" ");
                }

            }
        }

        private static void Spaces()
        {
            Console.Clear();
            Console.WriteLine("Insert a value: ");
            string value1 = Console.ReadLine();
            var count = value1.Count(t => t == ' ');
            Console.WriteLine("Count: " + count);
            Console.ReadKey();
            Console.Clear();
        }
    }
}