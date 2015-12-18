using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    // testc + tab * 2
    // testm + tab * 2
    // klasa testowa musi być publiczna
    // ctrl + r, a - uruchomienie wszystkich testów

    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            // dodajemy referencję do projektu Grades
            // ustawiamy dostęp public (zamiast domyślnego internal) do klasy GradeBook i GradeStatistics
            // dodajemy using Grades; 

            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.getHighestGrade());
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.getLowestGrade());
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            // możemy użyć oczekiwanej wartości double, mimo, że otrzymujemy średnią w float
            // ostatni parametr to dopuszczalna różnica (delta)
            Assert.AreEqual(85.16, result.getAverageGrade(), 0.01);
        }
    }
}
