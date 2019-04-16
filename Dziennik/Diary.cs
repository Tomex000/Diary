using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
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

        public float CalcAverage()
        {
            float suma = 0, srednia = 0;
            foreach (var item in ratings)
            {
                suma += item;
            }
            srednia = suma / ratings.Count();

            return srednia;
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
