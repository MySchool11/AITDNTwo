﻿using System;
// using System.Speech.Synthesis;

/*
 * In order to use the speech synthesis, follow these steps
 * 1)   Uncomment all the code that has been commented out
 *      between using System.Speech.Synthesis; and // voice.speak("Goodbye");
 *      also comment out the using System.Speech.Synthesis; declaration at the start of the program.
 * 2)   Right click on the project name (AITDNTwo) in the Solution Explorer
 * 3)   Select "Add Reference" from the menu
 * 4)   Type "speech" into the search box
 * 5)   Check the box next to "System.Speech"
 */

namespace AITDNTwo
{
    public class Program
    {

        /// <summary>
        /// A program which creates an instance of a gradebook and populates it with some results
        /// The solution also has a unit test project added to it (right click on solution --> add --> new project --> test --> unit test project (.NET framework)
        /// Then in the test project add a reference to (using) this project (AITDNTwo) so the tests can access the code
        /// </summary>
        /// <author>
        /// Samuel Bancroft (c) 2017
        /// </author>
        /// <code>
        /// Made up of two projects
        /// AIDTNTwo containing three main files
        /// GradeBooks.cs => A class declaration
        /// GradeStatistics.cs => A class declaration
        /// Program.cs = > the main file
        /// Grades.Tests containing two main files
        /// TypeTests.cs => A collection of Unit Tests
        /// GradeBookTests.cs => A collection of Unit Tests
        /// </code>

        private static void Main()
        {
            // var voice = new SpeechSynthesizer();

            // voice.Speak("Hello, this is a grade book program");

            var book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            var stats = book.ComputeStatistics();
            const string nameOfGradeBook = nameof(book);

            Console.WriteLine("The average grade from the gradebook named " + nameOfGradeBook + " is " + stats.AverageGrade);
            //// voice.Speak("The average grade from the grade book named " + nameOfGradeBook + " is " + stats.AverageGrade);
            Console.WriteLine("The highest grade from the gradebook named  " + nameOfGradeBook + " is " + stats.HighestGrade);
            //// voice.Speak("The highest grade from the grade book named  " + nameOfGradeBook + " is " + stats.HighestGrade);
            Console.WriteLine("The lowest grade from the gradebook named " + nameOfGradeBook + " is " + stats.LowestGrade);
            // voice.Speak("The lowest grade from the grade book named " + nameOfGradeBook + " is " + stats.LowestGrade);

            // voice.Speak("Goodbye");
        }
    }
}
