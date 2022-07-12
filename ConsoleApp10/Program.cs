using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            int crystalCount;
            int crystalPrice = 15;

            Console.Write("Введите кол-во золота: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов вы хотите купить: ");
            crystalCount = Convert.ToInt32(Console.ReadLine());
            money -= crystalCount * crystalPrice;

            Console.WriteLine("У вас - " + money + " золота и " + crystalCount + " кристаллов.");
        }
    }
}
