using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // shift + f5 - przerwanie debugowania

            // klasa jest typem referencyjnym, w zmiennej przechowujemy adres w pamięci (wskaźnik)

            GradeBook book = new GradeBook();
            book.AddGrade(95);
            book.AddGrade(50.1f);

            GradeBook book2 = book;
            book.AddGrade(75);
            book.AddGrade(33.3f);

            Console.WriteLine("Minimum grade: " + GradeBook.MinimumGrade);
            Console.WriteLine("Maximum grade: " + GradeBook.MaximumGrade);

            List<float> currentGrades = book.getGrades();
            Console.WriteLine("Last grade added: " + currentGrades.ElementAt(currentGrades.Count() - 1));

            GradeStatistics stats = book.ComputeStatistics();

            // cw + tab * 2
            Console.WriteLine("Average: " + stats.getAverage());
            Console.WriteLine("Highest grade: " + stats.getHighestGrade());
            Console.WriteLine("Lowest grade: " + stats.getLowestGrade());
        }
    }
}
