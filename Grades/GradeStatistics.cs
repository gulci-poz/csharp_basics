using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            averageGrade = 0;
            highestGrade = 0;
            // najwyższa wartość pod kątem pierwszego porównania
            // pierwsza porównywana wartość wskoczy na lowestGrade
            lowestGrade = float.MaxValue;
        }

        float averageGrade;
        float highestGrade;
        float lowestGrade;

        public float getAverageGrade()
        {
            return averageGrade;
        }

        public float getHighestGrade()
        {
            return highestGrade;
        }

        public float getLowestGrade()
        {
            return lowestGrade;
        }

        public void setAverageGrade(float average)
        {
            averageGrade = average;
        }

        public void setHighestGrade(float highest)
        {
            highestGrade = highest;
        }

        public void setLowestGrade(float lowest)
        {
            lowestGrade = lowest;
        }
    }
}
