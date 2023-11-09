using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8.Homework2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите метраж помещения (в м2):");
            double squareMeterage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество проживающих людей:");
            int residentsCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите сезон (1 - лето, 2 - осень/зима):");
            int season = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Есть ли льготы? (1 - да, 0 - нет):");
            int hasBenefits = Convert.ToInt32(Console.ReadLine());

            double heatingRate = 1.5;  // тариф на отопление за 1 м2
            double waterRate = 2.0;    // тариф на воду за 1 чел
            double gasRate = 1.8;      // тариф на газ за 1 чел
            double repairRate = 1.0;   // тариф на текущий ремонт за 1 м2

            // Учет сезонности
            if (season == 2)  // осень/зима
            {
                heatingRate *= 1.2;  // отопление дороже в холодный сезон
            }

            // Расчет начислено
            double heatingCost = squareMeterage * heatingRate;
            double waterCost = residentsCount * waterRate;
            double gasCost = residentsCount * gasRate;
            double repairCost = squareMeterage * repairRate;

            // Расчет льгот
            double totalCost = heatingCost + waterCost + gasCost + repairCost;
            double discount = 0.0;

            if (hasBenefits == 1)
            {
                Console.WriteLine("Выберите льготу (1 - ветеран труда, 2 - ветеран войны):");
                int benefitType = Convert.ToInt32(Console.ReadLine());

                switch (benefitType)
                {
                    case 1:
                        discount = totalCost * 0.3;  // ветеран труда - 30%
                        break;
                    case 2:
                        discount = totalCost * 0.5;  // ветеран войны - 50%
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор льготы.");
                        break;
                }
            }
            // Вывод таблицы
            Console.WriteLine("\nВид платежа\t\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine($"Отопление\t\t{heatingCost:C}\t\t0%\t\t\t{heatingCost:C}");
            Console.WriteLine($"Вода\t\t\t{waterCost:C}\t\t0%\t\t\t{waterCost:C}");
            Console.WriteLine($"Газ\t\t\t{gasCost:C}\t\t0%\t\t\t{gasCost:C}");
            Console.WriteLine($"Ремонт\t\t\t{repairCost:C}\t\t0%\t\t\t{repairCost:C}");
            Console.WriteLine($"Итого\t{totalCost:C}");
            Console.WriteLine($"Льготная скидка\t{discount:C}");
            Console.WriteLine($"Итого со скидкой\t{totalCost - discount:C}");
        }
    }

}
