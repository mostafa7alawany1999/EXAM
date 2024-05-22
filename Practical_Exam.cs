using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Practical_Exam : Exam
    {
        Questions[] questions {  get; set; }
        public Practical_Exam(int Time_of_exam,int Number_of_Questions):base(Time_of_exam, Number_of_Questions)
        {
            questions = new Questions[Number_of_Questions];
        }
        public override void Create_Exam()
        {
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Please Enter Question Number: {i+1} (MCQ)");
                Question_Members.MCQ_Question(i, questions);
                Console.Clear();
            }
        }

        public override void Show_Exam()
        {
            Question_Members.Display(questions);
        }
    }
}
