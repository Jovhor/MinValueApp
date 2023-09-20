using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = int.MaxValue;

            Console.WriteLine("Minimum Value \n");

            Console.WriteLine("Приложение для определения наименьшего члена введенной Вами последовательности.");
            Console.WriteLine("Назови последовательность, а я тебе скажу, какое самое маленькое в ней число.\n");
            Console.WriteLine("Начнем с длины последовательности. Впиши длину.\n");
            int seqLenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Давай, впиши первое число:");

            for (int i = 0; i < seqLenght; i++)
            {
                int userNumber = int.Parse(Console.ReadLine());
                if (userNumber - minValue < 0)
                {
                    minValue = userNumber;
                }
                Console.WriteLine($"Наименьшее число в последовательности: {minValue}");
            }

            Console.ReadKey();
        }
    }
}
