using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            ApplicationLicense applicationLicense = new ApplicationLicense();

            Console.WriteLine("Щоб отримати розширений доступ до програми потрібен активації." + "\nПродовжити?(y/n)");

            if (Console.ReadLine() == "y")
            {
            Console.WriteLine("Введіть ключ активації продукту:");
            string key = Console.ReadLine();
                if (key == applicationLicense.TrialKey)
                {
                    Console.WriteLine("Продукт успішно активовано.");
                    applicationLicense.AllowTrial();
                    return;
                }
                if (key == applicationLicense.ProKey)
                {
                    Console.WriteLine("Продукт успішно активовано.");
                    applicationLicense.AllowPro();
                    return;
                }
                else
                {
                    Console.WriteLine("Помилка! Хибний ключ активаціі.");
                    Console.WriteLine("Сбій активації продукту.");
                    applicationLicense.AllowCommon();

                }
            }
            else
            {
                applicationLicense.AllowCommon();
            }

            Console.ReadLine();
        }
    }
}
