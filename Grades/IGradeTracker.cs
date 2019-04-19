using System.Collections;
using System.IO;

namespace Grades
{
    internal interface IGradeTracker : IEnumerator
    {
        string Name { get; set; }

        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter destination);
        void AddGrade(float grade);
        IEnumerator GetEnumerator();
    }
}