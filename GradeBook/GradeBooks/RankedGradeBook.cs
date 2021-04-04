using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            char grade = 'F';

            if (Students.Count > 5)
            {
                int place = Students.Count;
                foreach(var student in Students)
                {
                    if (averageGrade > student.AverageGrade)
                        place--;
                }
                double d = place / Students.Count;
                if(d < 0.2)
                {
                    grade = 'A';
                }
                else if(d < 0.4)
                {
                    grade = 'B';
                }
                else if (d < 0.6)
                {
                    grade = 'C';
                }
                else if (d < 0.8)
                {
                    grade = 'D';
                }
            }
            return grade;

        }
    }
}
