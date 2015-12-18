using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        // ctor + tab * 2
        // upper case for public members
        // konstruktor to jedyna metoda, w której nie podajemy zwracanego typu
        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public List<float> getGrades()
        {
            return grades;
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            // użycie funkcji wbudowanych w listę
            stats.setAverageGrade(grades.Average());
            stats.setHighestGrade(grades.Max());
            stats.setLowestGrade(grades.Min());

            /*
            if (grades.Count() > 0)
            { 
                float sum = 0;
                foreach(float grade in grades)
                {
                    stats.setHighestGrade(Math.Max(grade, stats.getHighestGrade()));
                    stats.setLowestGrade(Math.Min(grade, stats.getLowestGrade()));
                    sum += grade;
                }

                stats.setAverage(sum / grades.Count());
            }
            else
            {
                // zerujemy tylko najniższą wartość, nie będzie już potrzebna do porównań
                // average i highestGrade są zerowane w konstruktorze
                stats.setLowestGrade(0);
            }
            */
            
            return stats;
        }

        public static float MinimumGrade = 0;
        public static float MaximumGrade = 100;

        // domyślnie private
        List<float> grades;
    }
}
