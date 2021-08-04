using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolKrista
{
    class LogikModel
    {

        public DateTime dateTime = DateTime.Now;
       
        private long timeToUp;
        private long timeToFlore;
        private long timeToTith;
        private long countTith = 0;
        private double speadBreaking;
        private long tempToStartBreaking;
        private long tempToFinish;
        private long minetVentBeforStart = 0;
        private long breaking = 5 * 60;

        public void start()
        {
            Console.Clear();
            bool flag = true;
            while (flag)
            {
                getDataFromConsole();

                calculations();

                Console.Write("Желаете запустить программу заново?(yes/no/changData):\n>> ");
                string res = Console.ReadLine();
                
                switch (res)
                {
                    case "yes":
                        Console.Clear();
                        break;
                    case "no":
                        flag = false;
                        Console.Clear();
                        break;
                    case "changData":
                        //Дописать выбор смены данных
                        break;

                }
                

            }
        }


        private void calculations()
        {
            minetVentBeforStart += timeToTith * countTith + timeToUp + timeToFlore;
            Console.WriteLine($"Начоло перелома {dateTime.AddMinutes(Convert.ToDouble(minetVentBeforStart))} ");
            minetVentBeforStart += breaking;
            Console.WriteLine($"Конец перелома {dateTime.AddMinutes(Convert.ToDouble(minetVentBeforStart))}");
            minetVentBeforStart += Convert.ToInt64((tempToStartBreaking - tempToFinish) / (speadBreaking / (24 * 60)));
            Console.WriteLine($"Время извлечения {dateTime.AddMinutes(Convert.ToDouble(minetVentBeforStart))} \n");

        }

        private void getDataFromConsole()
        {
            Console.WriteLine("Введите за какое время нагреваем до гомогенизации:");
            timeToUp = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Введите время выдержки на плато:");
            timeToFlore = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Введите количество зубов:");
            countTith = Convert.ToInt64(Console.ReadLine());
            if (countTith != 0)
            {
                Console.WriteLine("Введите время нижнего плато зуба:");
                timeToTith = Convert.ToInt64(Console.ReadLine()) + 40;
                Console.WriteLine("Введите время верхнего плато зуба:");
                timeToTith += Convert.ToInt64(Console.ReadLine());
            }

            Console.WriteLine("Введите скорость падения температуры:");
            speadBreaking = Convert.ToDouble(Console.ReadLine());
            if (speadBreaking == 0) speadBreaking = 1;

            Console.WriteLine("Введите температуру начала падения:");
            tempToStartBreaking = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Введите температуру извлечения:");
            tempToFinish = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("The end! \n");
        }
    }
}
