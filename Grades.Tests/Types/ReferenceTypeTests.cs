using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AITDNTwo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void IntVAriablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;                    // Copies value of x1 to x2

            x1 = 4;                         // Because ints are value types, changing x1 will not change x2
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            var g1 = new GradeBook();
            var g2 = g1;                  // Copies pointer for G1 to G2 as Object types are ByReg (reference types) so hold a pointer to the data, not the data themselves
            g1.Name = "Test Grade Book";
            Assert.AreEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void VariablesDoNotHoldACopy()
        {
            var g1 = new GradeBook();
            var g2 = new GradeBook();
            Assert.AreNotEqual(g1, g2); // Test asserts they are not equal, proving they are not copies of the GradeBook object, or they would be the same
        }

        [TestMethod]
        public void VariablesDoNotHoldACopy2()
        {
            var g1 = new GradeBook();
            var g2 = g1;
            g1.Name = "Test grade book";
            Assert.IsTrue(g1.Name == "Test grade book"); 
            Assert.IsTrue(g2.Name == "Test grade book"); // Tests asserts the Name property of both g1 and g2 are the same
            g1 = new GradeBook();
            Assert.IsTrue(g2.Name == "Test grade book");
            Assert.IsFalse(g1.Name == "Test grade book"); // Tests now assert that the Name property is now different as it now holds a pointer to a new object hence we now have two GradeBook objects so the variable is not a copy of the object but a reference to it
        }
    }
}
