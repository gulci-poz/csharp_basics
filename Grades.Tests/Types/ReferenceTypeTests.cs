using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        // struct tworzy value types
        // reprezentuje pojedynczą wartość (np.dzień tygodnia)
        // coś małego
        // w innych przypadkach tworzymy klasy
        /*
        public Struct DateTime
        {
            // kod struktury
        }
        */

        // enum tworzy value type
        // enum służy do reprezentowania stałych (symboli)
        // magical numbers zamieniane są na symbole
        /*
        public enum PayrollType
        {
            Contractor = 1,
            Salaried,
            Executive,
            Hourly
        }
        */


        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Gulci";
            string name2 = "gulci";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            // value types są szybsze i potrzebują mniej pamięci, są immutable
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook gb1 = new GradeBook();
            GradeBook gb2 = gb1;

            gb1.Name = "Gulci's Grade Book";
            Assert.AreEqual(gb1.Name, gb2.Name);
        }

        [TestMethod]
        public void GradeBookVariableAddressChanges()
        {
            GradeBook gb1 = new GradeBook();
            GradeBook gb2 = gb1;

            gb1.Name = "Gulci's Grade Book";

            // gb1 wskazuje na inny adres w pamięci
            // gb2 cały czas wskazuje na poprzedni adres
            gb1 = new GradeBook();
            gb1.Name = "Gulci's New Grade Book";
            Assert.AreNotEqual(gb1.Name, gb2.Name);
        }
    }
}
