using System;
using System.Collections.Generic;

namespace AITDNTwo
{
    public class GradeBook
    {
        private readonly List<float> _grades;

        public GradeBook() // Constructor
        {
            _grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            _grades.Add(grade);
        }

        // Using a reference to another class to form a member that can be accessed
        // An instance of GradeStatistics (ComputeStatistics()) is now accessible
        // as GradeBook.ComputeStatistics
        // Instantiated by calling ComputeStatistics stats = new GradeBook.ComputeStatistics
        public GradeStatistics ComputeStatistics()
        {
            var stats = new GradeStatistics();

            float sum = 0;
            foreach (var grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / _grades.Count;
            return stats;
        }
    }
}
