﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMax();
            //float min = diary.GiveMin();

            for (; ;)
            {
                Console.WriteLine("Podaj ocene : ");
                float rating;
                bool result = float.TryParse((Console.ReadLine()),out rating);
               
                if (result)
                {
                    if (rating < 1 || rating > 10)
                    {
                        Console.WriteLine("Nie poprawna liczba");
                        Console.WriteLine("srednia twoich ocen to " + diary.CalculateAverage());
                        Console.WriteLine("Najwyzsza ocena to " + diary.GiveMax());
                        Console.WriteLine("Najnizsza ocena " + diary.GiveMin());
                        Console.ReadKey();
                    }
                    else
                    {
                        diary.AddRating(rating);
                    }
                }
            }
            
        }
    }
}
