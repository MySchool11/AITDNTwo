using System;
using AITDNTwo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x); // This is because a value of x was passed into number, number was then changed not x which remained the same. By value is the default way of handling variables passed to methods in c#
        }

        [TestMethod]
        public void ValueTypesPassByRef()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47, x); // Because x was passed byref to IncrementNumber where the reference was changed so changing x everywhere
        }

        private void IncrementNumber(int number)
        {
            number += 1;         
        }

        private void IncrementNumber(ref int number) // overload for by ref method as byref calls must state ref on the call and the method to avoid ambiguity
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A Grade book", book1.Name); // These are equal becasue at the call of the method there are three pointers to the same object (book1, book2 and the book parameter of the GiveBookAName method, changing one, changes all (they are references, not values)
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A Grade book";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string nameOne = "Sam";
            string nameTwo = "sam";

            bool result = string.Equals(nameOne, nameTwo, StringComparison.OrdinalIgnoreCase); // the StringComparison operator is an enum and has serveral varients to use, this one ignores the case of the compared strings
            Assert.IsTrue(result);
        }

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
