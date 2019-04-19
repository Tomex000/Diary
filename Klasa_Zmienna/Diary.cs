using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_Zmienna
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        //zmienne
        List<float> ratings;// = new List<float>();

        //Metody
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public DiaryStatistic CoputeStatistic()
        {
            DiaryStatistic stats = new DiaryStatistic();

            float suma = 0f;
            foreach (var item in ratings)
            {
                suma += item;
            }
            stats.AverageGrade = suma / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();
            return stats;
        }

        

        public float GetMax()
        {
            return ratings.Max();
        }

        public float GetMin()
        {
            return ratings.Min();
        }
    }
}
