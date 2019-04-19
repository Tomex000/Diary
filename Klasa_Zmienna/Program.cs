using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_Zmienna
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3.5f);
            diary.AddRating(5);

            
            DiaryStatistic stats = diary.CoputeStatistic();

            Console.WriteLine("srednia ocen: "+ stats.AverageGrade);
            Console.WriteLine("max ocena: "+ stats.MaxGrade);
            Console.WriteLine("min ocena: "+ stats.MinGrade);
            Console.ReadKey();
        }
    }
}
