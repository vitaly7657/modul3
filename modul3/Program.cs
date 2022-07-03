using System;

namespace modul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("задание 1");
            int anyNumber;
            Console.WriteLine("Введите целое число: ");
            anyNumber = int.Parse(Console.ReadLine());
            if (anyNumber % 2 == 0)
            {
                Console.WriteLine("Данное число является чётным");
            }
            else
            {
                Console.WriteLine("Данное число является нечётным");
            }
            Console.ReadKey();
            Console.Clear();

            //задание 2
            Console.WriteLine("задание 2");
            int numberOfCards;
            int summ = 0;
            int nominalInt;
            Console.WriteLine("Приветствую Вас в игре 21,\nпожалуйста введите количество карт на руках: ");
            numberOfCards = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfCards; i++)
            {
                Console.WriteLine($"Введите номинал {i} карты");
                string nominal = Console.ReadLine();
                if ((nominal == "J") || (nominal == "Q") || (nominal == "K") || (nominal == "T"))
                {
                    nominalInt = 10;
                }
                else
                {
                    nominalInt = Convert.ToInt32(nominal);
                }

                switch (1)
                {
                    case 1:
                        summ += nominalInt;
                        break;
                }
            }

            Console.WriteLine($"Сумма значений всех карт = {summ}");
            Console.ReadKey();
            Console.Clear();

            //задание 3
            Console.WriteLine("задание 3");
            int simpleNumber;
            bool flag = false;
            Console.WriteLine("Введите целое число: ");
            simpleNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= simpleNumber - 1; i++) //по заданию нужно начинать с 1, нов таком случае всегда будет остаток ноль
            {                
                if (simpleNumber % i == 0)
                {
                    Console.Write("Число не простое");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.Write("Число простое");
            }

            Console.ReadKey();            
        }
    }
}
