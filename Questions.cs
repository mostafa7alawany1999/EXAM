using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public enum TypeOfQuestion
    {
        MCQ =1,
        TrueOrFalse
    }
    internal class Questions
    {
        public string Header_of_the_question { get; set; }
        public string Body_of_the_question { get; set; }
        public int Mark {  get; set; }
        public int Correct_Answer { get; set; }
        public TypeOfQuestion typeOfQuestion { get; set; }
        public Questions()
        {
            
        }
        

        public Questions(string Header_of_the_question, string Body_of_the_question, int Mark)
        {
            this.Header_of_the_question = Header_of_the_question;
            this.Body_of_the_question = Body_of_the_question;
            this.Mark = Mark;
        }
        public Questions(string Header_of_the_question, string Body_of_the_question, int Mark,TypeOfQuestion typeOfQuestion):
            this(Header_of_the_question,Body_of_the_question,Mark)
        {
            this.typeOfQuestion = typeOfQuestion;
            
        }

    }
}
