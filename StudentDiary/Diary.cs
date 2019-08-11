using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        List<float> ratings = new List<float>();

        public void AddRating( float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float var1 = 0, avg = 0;
            foreach (var rating in ratings)
            {
                var1 += rating;
            }
            avg = var1 / ratings.Count();

            return avg;
        }
        public float GiveMax()
        {
            return ratings.Max();
        }
        public float GiveMin()
        {
            return ratings.Min();
        }
    }
}
