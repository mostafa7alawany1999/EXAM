using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class TrueOrFalse: Questions
    {
        //public int Correct_Answer {  get; set; }
       
        public TrueOrFalse(int Correct_Answer, string Header_of_the_question, string Body_of_the_question, int Mark) : 
            base( Header_of_the_question,  Body_of_the_question,  Mark, TypeOfQuestion.TrueOrFalse)
        {
            this.Correct_Answer = Correct_Answer;
        }
        public override string ToString()
        {
            return $"{Header_of_the_question}\n{Body_of_the_question}      \t({Mark})Marks";
        }
    }
}
