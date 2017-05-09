using Microsoft.VisualStudio.TestTools.UnitTesting;
using AITDNTwo;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculatesHighestGrade()
        {
            var book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);
            var result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }
        [TestMethod]
        public void CalculatesLowestGrade()
        {
            var book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);
            var result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }
        [TestMethod]
        public void CalculatesAverageGrade()
        {
            var book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);
            var result = book.ComputeStatistics();
            Assert.AreEqual(50, result.AverageGrade);
        }
    }
}
