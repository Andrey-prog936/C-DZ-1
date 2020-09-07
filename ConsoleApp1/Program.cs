using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter symbols: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');
            Console.WriteLine("Quantity of spaces: " + spaceCount);
            /////////////////
            Console.Read();//
            /////////////////
            Console.Write("Введите номер билета:  ");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();
            if (ch.Length == 6)
            {
                int leftNumber = 0;
                int rightNumber = 0;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += ticketNumber[i];
                    }

                    else rightNumber += ticketNumber[i];
                }

                if (leftNumber == rightNumber)
                {
                    Console.WriteLine("У вас счастливый билет: {0} = {1}", leftNumber, rightNumber);
                }

                else Console.WriteLine("У вас не счастливый билет: {0} != {1}", leftNumber, rightNumber);
            }

            else Console.WriteLine("Число введено не правильно!");
            /////////////////
            Console.Read();//
            /////////////////
            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число В: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (a <= b)
            {
                for (int i = 0; i < a; i++)
                {
                    Console.Write("{0}", a);
                }
                Console.WriteLine();
                a++;
            }
            /////////////////
            Console.Read();//
            /////////////////
            Console.Write("Введите число: ");
            int abc = int.Parse(Console.ReadLine());
            int reverse = int.Parse(new string(abc.ToString().Reverse().ToArray()));
            Console.Write("Обратное число: " + reverse + "\n");
        }
    }
}