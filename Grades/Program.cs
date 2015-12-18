using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // shift + f5 - przerwanie debugowania
            // f12 - dostęp do źródeł klasy (deklaracje) po najechaniu na nazwę
            // ctrl + f4 - zamknięcie taba

            // Windows\Assembly - miejsce przechowywania Global Assembly Cache (biblioteki dll-i i nie tylko, np. mscorelib.dll)
            // .NET ładuje assemblies tylko, gdy używamy klas stamtąd, można deklarować więcej bez wpływu na wydajność
            // View -> Object Browser lub 2-klik na wybranej referencji
            // mscorelib nie ma na liście, jest domyślnie dołączany do projektów; jest w Object Browser

            // klasa jest typem referencyjnym, w zmiennej przechowujemy adres w pamięci (wskaźnik)

            // trzeba dodać assembly reference
            /*
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is the grade book program.");
            */

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
            Console.WriteLine("Average: " + stats.getAverageGrade());
            Console.WriteLine("Highest grade: " + stats.getHighestGrade());
            Console.WriteLine("Lowest grade: " + stats.getLowestGrade());
        }
    }
}
