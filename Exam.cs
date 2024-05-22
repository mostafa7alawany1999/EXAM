using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal abstract class Exam
    {
        public int Time_of_exam { get; set; }
        public int Number_of_Questions { get; set; }
        public abstract void Create_Exam();
        public abstract void Show_Exam();
        public Exam()
        {
            
        }
        public Exam(int Time_of_exam, int Number_of_Questions)
        {
            this.Time_of_exam = Time_of_exam;
            this.Number_of_Questions = Number_of_Questions;
        }
    }
}
