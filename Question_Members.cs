using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal static class Question_Members
    {
        public static void Create_Question(string Header, out Questions question)
        {
            string body;
            int mark;
            do
            {
                Console.WriteLine("Enter Body Of Question: ");
                body = Console.ReadLine();

            }
            while (String.IsNullOrEmpty(body));

            do
            {
                Console.Write("Please Enter Mark Of Question ");

            }
            while (!int.TryParse(Console.ReadLine(), out mark) || mark < 0);

            question = new Questions(Header, body, mark);


        }
        public static void MCQ_Question(int J, Questions[] question)
        {

            Create_Question("Choise the Answer", out Questions question1);
            Answers[] answers = new Answers[3];
            Console.WriteLine($"Set Choises Of Questions");
            for (int i = 0; i < answers.Length; i++)
            {
                Console.Write($"Enter Choise number({i + 1}): ");
                answers[i] = new Answers(i + 1, Console.ReadLine());
            }
            int Correct;
            do
            {
                Console.Write("Enter Correct Answer:  ");
            }
            while (!int.TryParse(Console.ReadLine(), out Correct) || Correct < 1 || Correct > 3);
            question[J] = new MCQ(Correct, answers, question1.Header_of_the_question, question1.Body_of_the_question, question1.Mark);
        }


        public static void ToF_Question(int J,Questions[] question)
        {
           int CorrectAns;
            Create_Question("Choise True Or False Answer\t1.For True\t||2.For False", out Questions question2);
            do
            {
                Console.Write("Enter Correct Answer\t1.For True\t||2.For False:  ");

            }
            while (!int.TryParse(Console.ReadLine(), out CorrectAns) || CorrectAns < 1 || CorrectAns > 2);

            question[J] = new TrueOrFalse(CorrectAns, question2.Header_of_the_question, question2.Body_of_the_question, question2.Mark);
        }
        public static void Display(Questions[] questions)
        {
            //List<int> AnswersOfTester = new List<int>();
           int [] AnswersOfTester = new int [questions.Length] ;
            int Grade = 0, TotalGrade = 0;
            for (int i=0;i<questions.Length; i++)
            {
                Console.WriteLine(questions[i].ToString());
                TotalGrade += questions[i].Mark;
                switch (questions[i].typeOfQuestion)
                {
                    case TypeOfQuestion.MCQ:
                       MCQ mCQ = questions[i] as MCQ;
                        Console.WriteLine("Enter Your Answer");
                        AnswersOfTester[i]=int.Parse(Console.ReadLine());
                       
                            if (AnswersOfTester[i] == questions[i].Correct_Answer)
                                Grade += questions[i].Mark;
                            Console.WriteLine("=============================================================");
                        
                        break;
                    case TypeOfQuestion.TrueOrFalse:
                        TrueOrFalse True_O_False = questions[i] as TrueOrFalse;
                        Console.WriteLine("Enter Your Answer");
                        AnswersOfTester[i]=int.Parse(Console.ReadLine());
                        if (AnswersOfTester[i] == questions[i].Correct_Answer)
                            Grade += questions[i].Mark;
                        Console.WriteLine("=============================================================");

                        break;


                }
            }
            Console.Clear();
            for (int i=0;i<questions.Length;i++)
            {
                switch (questions[i].typeOfQuestion)
                {
                    case TypeOfQuestion.MCQ:
                        MCQ mCQ = questions[i] as MCQ;
                        Console.WriteLine($"Q{i + 1})  {questions[i].Body_of_the_question}:\n Your Answer is : {mCQ.Answers[AnswersOfTester[i]-1].Answer_Text}\t ||  Right Answer:{mCQ.Answers[mCQ.Correct_Answer - 1].Answer_Text}");
                        Console.WriteLine("=============================================================");
                        break;
                    case TypeOfQuestion.TrueOrFalse:
                        TrueOrFalse True_O_False = questions[i] as TrueOrFalse;

                        //bool Answer = StudentAnswer[i] == 1 ? true : false;
                        //bool CorrectAnswer = TOF.CorrectAnswer == 1 ? true : false;
                        bool Answer, CorrectAnswer;
                        if (AnswersOfTester[i] == 1)
                            Answer = true;
                        else if (AnswersOfTester[i] == 2)
                            Answer = false;
                        else
                            throw new Exception();
                        if (True_O_False.Correct_Answer == 1)
                            CorrectAnswer = true;
                        else if (True_O_False.Correct_Answer == 2)
                            CorrectAnswer = false;
                        else
                            throw new Exception();


                        if (True_O_False is not null)
                            Console.WriteLine($"Q{i + 1}) {True_O_False.Body_of_the_question} \nYour Answer is : {AnswersOfTester[i]}) {Answer}  ||  Right Answer : {True_O_False.Correct_Answer}){CorrectAnswer}\n");
                        Console.WriteLine("=============================================================");
                        break;

                }
            }
            Console.WriteLine($"Your Grade is {Grade} from {TotalGrade}");
        }
    }
}
   

