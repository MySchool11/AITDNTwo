using Microsoft.VisualStudio.TestTools.UnitTesting;     // Adds reference to the UnitTesting namespace so the functions can be accessed
using AITDNTwo;                                         // Adds a reference to the project being tested so the code can be accessed by the tests. This also needs to be added in the project references by right clicking on the references section and choosing AITDNTwo there

namespace Grades.Tests
{
    [TestClass] // In unit test classes the class must be started with [TestClass] reference
    public class GradeBookTests
    {
        [TestMethod] // The same applies for methods in a test class
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
