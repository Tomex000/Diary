using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            Console.ReadKey();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            float avg = diary.CalcAverage();
            float max = diary.GetMax();
            float min = diary.GetMin();

            for (;  ; )
            {
                Console.WriteLine("Podaj liczbe");

                float rating = float.Parse(Console.ReadLine());
               
                //warunek wyjscia z petli
                if (rating == 11)
                {
                    break;
                }

                diary.AddRating(rating);
            }
            Console.WriteLine("srednia ocen to " + diary.CalcAverage());
            Console.WriteLine("MAX:" + diary.GetMax());
            Console.WriteLine("MIN:" + diary.GetMin());
            Console.ReadKey();
        }
    }
}
