using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class MCQ:Questions
    {
        //public int Correct_Answer { get; set; }
        public Answers[] Answers{ get; set; }
        
        public MCQ(int Correct_Answer, Answers[] Answers,string Header_of_the_question, string Body_of_the_question, int Mark) 
            : base(Header_of_the_question, Body_of_the_question, Mark, TypeOfQuestion.MCQ)
        {
            this.Correct_Answer = Correct_Answer;
            this.Answers = Answers;
            
        }
        public override string ToString()
        {
            return $"{Header_of_the_question}\n{Body_of_the_question}\t\t\t({Mark})Marks\n{Answers[0]}\t\t{Answers[1]}\t\t{Answers[2]}";
        }
    }
}
