using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public String Description
        {
            get
            {
                string Result;
                switch (LetterGrade){
                    case "A":
                        Result = "Excellent";
                        break;
                    case "B":
                        Result = "Good";
                        break;
                    case "C":
                        Result = "Average";
                        break;
                    default:
                        Result = "Failing";
                        break;
                }
                return Result;
            }
        }

        public string LetterGrade
        {
            get{
                string Result;
                if (AverageGrade >= 90) Result = "A";
                else if (AverageGrade >= 80) Result = "B";
                else if (AverageGrade >= 70) Result = "C";
                else if (AverageGrade >= 60) Result = "D";
                else if (AverageGrade >= 50) Result = "E";
                else Result = "F";
                return Result;
            }
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
