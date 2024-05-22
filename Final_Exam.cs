using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Final_Exam : Exam
    {
        Questions[] questions { get; set; }
     
        public Final_Exam(int Time_of_exam, int Number_of_Questions) : base(Time_of_exam, Number_of_Questions)
        {
            questions = new Questions[Number_of_Questions];
        }
        public override void Create_Exam()
        {
            int choise;

                for (int i = 0; i < questions.Length; i++)
            {
                do
                {
                    Console.WriteLine("Please Enter Type Of Questions:   1.MCQ\t || 2.TrueOrFalse ");

                }
            while (!int.TryParse(Console.ReadLine(), out choise));
                switch (choise)
                {
                    case 1:
                       
                            Console.WriteLine($"Please Enter Question Number({i + 1})   (MCQ)");
                            Question_Members.MCQ_Question(i, questions);
                            Console.Clear();
               
                        break;
                    case 2:
                        
                            Console.WriteLine($"Please Enter Question Number({i + 1})   (True || False)");
                            Question_Members.ToF_Question(i, questions);
                            Console.Clear();
                        
                        break;
                }
            }
            
        }

        public override void Show_Exam()
        {
            Question_Members.Display(questions);
            //List<int> AnswersOfTester = new List<int>();
            //int Grade = 0, TotalGrade = 0;
            //for (int i = 0; i < questions.Length; i++)
            //{
            //    Console.WriteLine(questions[i].ToString());
            //    int answer = int.Parse(Console.ReadLine());
            //    AnswersOfTester.Add(answer);
            //    TotalGrade += questions[i].Mark;
            //    if (answer == questions[i].Correct_Answer)
            //        Grade += questions[i].Mark;

            //}
            //Console.Clear();
            //for (int i = 0; i < questions.Length; i++)
            //{

            //    Console.WriteLine("Your Answers");
            //    Console.WriteLine($"Q{i + 1}) {questions[i]}: {AnswersOfTester[i]}");
            //}
            //Console.WriteLine($"Your Grade is {Grade} from {TotalGrade}");
            //Console.WriteLine(questions[0]);

           
        }
    }
}
