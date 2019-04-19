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
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades = new float[5];
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UpperCaseString()
        {
            String name = "barti";
            name = name.ToUpper();

            Assert.AreEqual("BARTI", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2019, 4, 14);
            date = date.AddDays(2);
            Assert.AreEqual(date.Day, 16);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 96;

            IncrementNumber(x);
            Assert.AreEqual(96, x);
        }

        private void IncrementNumber(int x)
        {
            x += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeTracker book1 = new GradeTracker();
            GradeTracker book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        private void GiveBookAName(GradeTracker book)
        {
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            String name1 = "barti";
            String name2 = "Barti";

            bool result = String.Equals(name1, name2, StringComparison.CurrentCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVaraiblesHoldsAValues()
        {
            int x1 = 10;
            int x2 = x1;

            x1 = 20;
            Assert.AreNotEqual(x1, x2);

        }

        [TestMethod]
        public void GradeBookVaraiblesHoldsAReference()
        {
            GradeTracker book1 = new GradeTracker();
            GradeTracker book2 = book1;

            book1 = new GradeTracker();
            book1.Name = "Barti gradebook";
            Assert.AreNotEqual(book1.Name, book2.Name);
        }
    }
}
