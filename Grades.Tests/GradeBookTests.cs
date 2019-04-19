using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeTracker book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(70);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeTracker book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(70);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(70, result.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeTracker book = new GradeBook();
            book.AddGrade(65);
            book.AddGrade(86.3f);
            book.AddGrade(87);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(79.43f, result.AverageGrade, 0.01f);
        }

    }
}
