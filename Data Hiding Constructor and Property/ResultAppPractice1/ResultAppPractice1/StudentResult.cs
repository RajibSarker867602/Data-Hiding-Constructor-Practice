using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultAppPractice1
{
    class StudentResult
    {
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Math { get; set; }

        public int GetAverage()
        {
            return (Physics + Chemistry + Math) / 3;
        }
        public string GetGrade()
        {
            string grade = "";
            int average = GetAverage();
            if (average >= 80)
            {
                grade= "A+";
            }
            else if (average >= 70)
            {
                grade = "B+";
            }
            else if (average >= 60)
            {
                grade = "C+";
            }
            else if (average >= 50)
            {
                grade = "D+";
            }
            else if (average < 50)
            {
                grade = "F";
            }
            return grade;
        }
    }
}
