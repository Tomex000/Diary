using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_Zmienna
{
    class Program
    {
        static void GiveName(Diary diary)
        {
            diary = new Diary();
            diary.Name = "Dziennik";
        }
        static void IncrementNum(ref int numbe)
        {
            numbe +=1;
        }
        static void Main(string[] args)
        {
            //Diary diary = new Diary();
            //diary.AddRating(3.5f);
            //diary.AddRating(5);


            //DiaryStatistic stats = diary.CoputeStatistic();

            //Console.WriteLine("srednia ocen: "+ stats.AverageGrade);
            //Console.WriteLine("max ocena: "+ stats.MaxGrade);
            //Console.WriteLine("min ocena: "+ stats.MinGrade);
            //Console.ReadKey();

            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(d1);
            Console.WriteLine(d2.Name);


            int x1 = 4;
            IncrementNum(ref x1);
            Console.WriteLine(x1);


            string name1 = "mmmm";
            string name2 = "MMMM";
            bool areEqual = name1.Equals(name2,StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);

            Console.ReadKey();
        }
    }
}
