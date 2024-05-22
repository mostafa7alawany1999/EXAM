using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Answers
    {
        public int Answer_Id { get; set; }
        public string Answer_Text { get; set; }
        public Answers()
        {
            
        }
        public Answers(int Answer_Id, string Answer_Text)
        {
            this.Answer_Id = Answer_Id;
            this.Answer_Text = Answer_Text;
        }
        public override string ToString()
        {
            return $"{Answer_Id}) {Answer_Text}";
        }
    }
}
